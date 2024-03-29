﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using team.BlueApi.Models;

namespace team.BlueApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly WordsContext _context;
        public TextController(WordsContext ctx)
        {
            _context = ctx;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Words>>> Get()
        {
            return await _context.Words.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ReceivedWords receivedWords)
        {
            // Ignore case and remove nonletter characters
            string recWordsCleaned = new(receivedWords.Text.ToLower().Where(c => !char.IsPunctuation(c)).ToArray());

            List<string>? distinctWords = recWordsCleaned.Split(" ", StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

            // Remove already persisted words from list
            distinctWords.RemoveAll(s => _context.Words.Any(entity => entity.Text == s));

            // Add the remaining strings as Word objects
            await _context.Words.AddRangeAsync(distinctWords.Select(word => new Words() { Text = word }));
            await _context.SaveChangesAsync();

            // Get watchlist words
            List<string> watchlist = _context.Watchlist.Select(q => q.WatchedWord!.ToLower()).ToList();

            // Compare the two lists with intersect
            List<string> result = distinctWords.Intersect(watchlist).ToList();


            return Ok(new ResponseWords()
            {
                DistinctUniqueWords = distinctWords.Count,
                WatchlistWords = result.Select(q => new WatchlistWord() { WatchedWord = q }).ToList()
            });
        }
    }
}

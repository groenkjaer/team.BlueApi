# team.BlueApi
## Minitest opgave fra team.blue opsætning
Projektet er en asp.net core Web Api som modtager en tekst, og svarer med hvor mange unikke distinkt ord fra teksten som er blevet gemt i programmets database, samt hvor mange af de indsendte ord er på programmet "watchlist".

Projektet burde selv oprette en database (WordsDB) i localdb når man først antaster et api endpoint, hvis det ikke virker korrekt så foreligger der en backup fil i mappen DatabaseBackup.

Det er muligt at ændre hvilken connectionstring programmet anvender i appsettings.json

## Eksempel curl
```
curl -X POST "http://localhost:5086/api/Text" -H "accept: application/json" -H "Content-Type: application/json" -d "{ \"text\": \"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec et placerat est, nec laoreet erat. Ut et leo arcu. Vivamus dictum neque a blandit luctus. Ut finibus a nulla efficitur tristique. Phasellus commodo vel metus ac. \"}"
```

#### Tidsforbrug er ~4½ time

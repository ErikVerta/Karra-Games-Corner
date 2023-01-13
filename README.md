# Kärra-Games-Corner

# Way of Working

## OBS! Det första man ska göra i projektet:

- Clone repo

## Sen utgår vi från nedan.

När du har valt en task följ denna guide!

1. Hämta alla nya ändringar genom en pull request från developement. Kommando: git pull origin development

2. Skapa en ny branch med task id; Kommando: git checkout -b {branchName} Ex. git checkout -b Task-34
   [Förtydligande av branchName =>(Task-{taskens id-nummer}) Ex. Task-34]

3. Sen löser man tasken och sparar lokalt.

4. Skriv in följande kommandon: <br>
   git add . <br>
   git commit (klicka på I, se till så att det står insert längst ner. Skriv in headern här: ab#{taskId} ex. ab#97) tryck enter. Nu beskriver du ditt jobb. tryck enter.
   tryck escape - tryck kolon (:) - skriv in wq - tryck enter. <br>
   git push -u origin {branchName} ( OBS! Detta görs bara första gången man pushar sin branch till github) <br>
   git push(Annars körs detta)

5. OBS! Endast när man helt klar med tasken; Pull request görs via Github.com på den arbetade branchen. <br>
   Klicka på bransches - välj branchen som du har jobbat med <br>
   Klicka på Pull-request <br>
   OBS!!! Ändra Base: från Main till development i vilken branch man pullar till. <br>
   Klicka på create pull request.

6. Skriv i discord att du är klar med din task och gjort en pull request

7. Annan utvecklare kollar genom pull-requesten och gör följade: <br>
   Godkänner enligt DoD på Task. <br>
   OBS! Ifall icke-godkänd Task => Godkännaren ger feedback.
   Ifall feedback är otillräcklig så kontaktar man godkännaren. <br>
   Tar bort branchen. <br>
   Gillar discordinlägget (DoD).

8. OBS! När pull-request är godkänd -> Taskägaren sätter tasken som klar på Azure boards.


9. Branchskaparen tar bort branchen lokalt. Använd följande kommandon: <br>
git checkout development <br>
git branch -d {branchName}; Ex. git branch -d Task-34


using SpaProject;

Main main = new();
//1. Olvassa be a furdoadat.txt fájl tartalmát!
main.FirstTask();

//2. Írja a képernyőre, hogy az első és az utolsó vendég mikor lépett ki az öltözőből!
main.SecondTask();

//3. Határozza meg és írja ki a képernyőre, hogy hány olyan fürdővendég volt, aki az öltözőn
//kívül csak egy részlegen járt és azt a részleget csak egyszer használta! 
main.ThirdTask();

//4. Határozza meg, hogy melyik vendég töltötte a legtöbb időt a fürdőben! A vendég
//azonosítóját és a fürdőben tartózkodás idejét írja ki a képernyőre! A fürdőben a legtöbb
//időt töltő vendégek közül elegendő egy vendég adatait megjelenítenie. 
main.FourthTask();

//5. Készítsen statisztikát, hogy 06:00:00-08:59:59 óra között, 09:00:00-15:59:59 óra között
//és 16:00:00 - 19:59:59 óra között hány vendég érkezett a fürdőbe! Az eredményt írja ki
//a képernyőre a mintán látható formában! 
main.FifthTask();

//6.Készítsen egy listát a szauna részlegen járt vendégekről és az általuk ott töltött időről!
//A vendég azonosítóját és a részlegen eltöltött időt a szauna.txt fájlba írja ki!
//A fájlban egy sorban a vendég azonosítója és szóközzel elválasztva a részlegen eltöltött
//idő szerepeljen óra:perc: másodperc formában!Ügyeljen arra, hogy egy vendég a szauna
//részlegben a nap folyamán többször is járhatott!  (megjegyzés: adatbázisba mentést használtam txt helyett!)
main.SixthTask();

//7. Készítsen egy listát, amelyben megadja, hogy az egyes részlegeket hányan használták!
//Az eredményt a minta szerint írja ki a képernyőre! Ha egy vendég egy részlegen
//többször is járt a nap folyamán, azt a statisztikában csak egynek számolja! 
main.SeventhTask();
Console.ReadKey();

SpaProject felépítése

////Program.cs
A legfelsőbb réteg, itt példányosítom a Main class-t!

////Main.cs 
Itt helyezkednek el az egyes feladatok amiket a program megvalósít!

////ReadFromFile és a ReadNoAgain class
ugyanazt az interfacet kapta mind a kettő (IRead), az egyik lementi az adatbázisba a txt tartalmát a másik nem(újbóli futtatáskor nem volna jó ha plussz adatokat mentene le ugyanabból a txt-ből)

////SaveSauna és interfaceje
adatbázisba menti a kiértékelt statisztikai adatokat

///////Data
itt található az adatbázishoz kapcsolódó osztályok és az IocContainer

//////Factories
Itt hozzuk létre az objecteket az adatbázishoz

//////Migrations
EF által generált class

//////Models
Itt vannak az üzleti modellek, egyéb struktúrák és a BaseClass

//////Repositories
Ez a réteg elválasztja az adatbázist a felsőbb rétegektől, csak itt dolgozunk az adatbázissal (mentés, lekérdezés stb)

/////Tests Project
Tesztelhető methódusok


A program a furdoadat.txt file-t is tartalmazza


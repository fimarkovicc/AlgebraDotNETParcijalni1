# PARCIJALNI ISPIT – C# i .NET Framework: osnovno korištenje
1. Kreirajte projekt tipa Class Library pod nazivom Ispit.Model koji će sadržavati glavne klase s rješenjima.
2. Kreirajte klasu Ucenik sa sljedećim svojstvima:
a. Ime (string),
b. Prezime (string),
c. DatumRodjenja (DateTime), d. Prosjek (double)
3. U klasi Ucenik kreirajte metode:
a. Starost() - izračunava se uz pomoć datuma rođenja i tekućeg datuma
b. IspisProsjeka() - određuje se uz pomoć brojčanog podatka spremljenog u svojstvu Prosjek
- nedovoljan (od 1 do 1.49),
- dovoljan (od 1.50 do 2.49),
- dobar (do 2.50 do 3.49),
- vrlo dobar (od 3.50 do 4.49),
- odličan (od 4.50 do 5)
4. Kreirajte projekt konzolne aplikacije pod nazivom Ispit.Konzola i u njega dodajte .dll datoteku projekta Ispit.Model.
5. U projektu Ispit.Konzola kreirajte sučelje za unos tri učenika s podacima imena, prezimena, datuma rođenja i prosjeka. Nakon unosa tri učenika svi podaci se ispisuju na ekranu programa.
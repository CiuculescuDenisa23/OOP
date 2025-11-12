Am aplicat în mod constant cei patru piloni principali ai OOP:

1. Încapsulare
Acesta este cel mai fundamental concept pe care îl folosesc.
Ce am făcut: Am grupat datele (câmpuri/proprietăți) împreună cu logica (metodele) care le manipulează, în interiorul unei clase.

Exemplu: Clasa Cinema este un exemplu perfect. Ea "încapsulează" listele de Utilizatori și Filme și expune metode publice sigure pentru a interacționa cu ele (de ex. AutentificaUtilizator, RealizeazaRezervare), în loc să permită accesul direct la liste. La fel, Aprozar gestionează intern lista de produse.

2. Moștenire
Am folosit moștenirea pentru a crea ierarhii logice și a elimina codul duplicat.
Ce am făcut: Am creat clase de bază care definesc atribute comune și apoi clase derivate (copil) care moștenesc aceste atribute, adăugând propria lor specializare.

Exemplu:
ZborLocal și ZborTransatlantic moștenesc ambele din Zboruri.
ProdusLaBucata și ProdusLaKg moștenesc din Produs.
PachetBasic, PachetAvansat și PachetPesteNoapte moștenesc din Pachet.

3. Polimorfism (prin Suprascriere)
Acesta este unul dintre cele mai puternice concepte pe care le-am demonstrat.
Ce am făcut: Am permis claselor derivate să furnizeze propria lor implementare specifică pentru o metodă care a fost definită în clasa de bază. Am folosit cuvintele cheie abstract și override.

Exemplu:
În proiectul Pachete, fiecare tip de pachet (PachetBasic, PachetAvansat etc.) are propria sa logică de override pentru metodele Cost() și TimpLivrare().
În proiectul Zboruri, ZborLocal și ZborTransatlantic suprascriu metoda CalculPret pentru a implementa formule de preț diferite.
4. Abstractizare
Am folosit clase abstracte pentru a defini "contracte" pe care clasele derivate trebuie să le respecte.
Ce am făcut: Am creat clase de bază (abstract class) care nu pot fi instanțiate direct, ci servesc doar ca un șablon. Am folosit metode abstracte (abstract method) pentru a forța clasele copil să implementeze o anumită funcționalitate.

Exemplu:
Pachet este o clasă abstractă care forțează toate pachetele să aibă o metodă Cost() și TimpLivrare().
Zboruri este abstractă și forțează implementarea CalculPret.
Produs este abstract și forțează implementarea ValidareCantitate.
Competențe Practice Demonstrate

Pe lângă conceptele OOP, proiectele mele arată că știu să:
Construiesc Aplicații Consolă: Toate proiectele mele sunt aplicații C# (.NET 8) funcționale, de tip consolă, cu un punct de intrare Main.
Gestionez Colecții de Date: Folosesc List<T> în mod extensiv pentru a gestiona grupuri de obiecte (ex. List<Rezervare>, List<Produs>, List<Utilizator>).
Creez Logică de Business: Implementez meniuri interactive (cu bucle while și switch), citesc date de la utilizator și execut logica aplicației (ex. calcularea costurilor, validarea stocurilor, rezervarea locurilor).
Gestionez Persistența Datelor (JSON): În proiectul Cinema, demonstrez o abilitate avansată de a salva starea aplicației (utilizatori, filme) în fișiere .json și a o reîncărca la pornire, folosind pachetul Newtonsoft.Json.
Implementez Sisteme de Roluri: Am creat un sistem de autentificare care face distincția între utilizatori normali și administratori, fiecare având meniuri și permisiuni diferite (Admin poate adăuga filme, Clientul poate doar rezerva).

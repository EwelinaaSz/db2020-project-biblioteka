#1. Dodawanie nowego czytelnika wraz z adresem. Z uwagi na budowê bazy najpierw dodawany jest adres u¿ytkownika, a potem jego klucz g³ówny (tabeli adres) jest przekazywany do zapytania tworz¹cego u¿ytkownika.
INSERT INTO adres( ulica, nr_domu, kod_pocztowy, miasto) VALUES ('ULICA', NR_DOMU, KOD_POCZTOWY, 'MIASTO')
INSERT INTO czytelnik( imie, nazwisko, nr_telefonu, e_mail, adres_id_fk) VALUES ('Jan', 'Kowalski', 123456789, 'jkowalski@gmail.com', (SELECT MAX(adres_id) FROM adres));


#2. Edycja danych czytelnika i jego adresu na podstawie numeru karty bibliotecznej.
UPDATE czytelnik, adres
SET imie = 'INPUT_IMIE', nazwisko = 'INPUT_NAZWISKO', nr_telefonu = INPUT_TELEFON, e_mail = 'INPUT_MAIL', adres.ulica = 'INPUT_ULICA', adres.nr_domu = INPUT_NR_DOMU, adres.kod_pocztowy = KOD_POCZTOWY, adres.miasto = 'MIASTO'
WHERE czytelnik.adres_id_fk = adres.adres_id AND czytelnik.nr_karta_biblioteczna = nr_karty

#3. Sprawdzenie ile wypo¿czeñ jest przypisanych do konta czytelnika.
SELECT COUNT(wypozyczenie.egzemplarz_id_fk) 
FROM wypozyczenie 
INNER JOIN czytelnik
ON wypozyczenie.czytelnk_id_fk = czytelnik.nr_karta_biblioteczna 
WHERE czytelnik.nr_karta_biblioteczna

#4. Usuwanie czytelnika i zwi¹zanego z nim adresu.
DELETE czytelnik, adres 
FROM czytelnik 
INNER JOIN adres 
ON czytelnik.adres_id_fk = adres.adres_id
WHERE czytelnik.nr_karta_biblioteczna = NR_KARTY

#5. Dodawanie ksi¹¿ki do bazy.
INSERT INTO ksiazka(ISBN, tytul, kategoria, wydawnictwo, data_wydania, liczba_stron)
VALUES (INPUT_ISBN, 'INPUT_TYTUL', 'INPUT_KATEGORIA', 'INPUT_WYDAWNICTWO', INPUT_DATA_WYDANIA, INPUT_LICZBA_STRON)


#6. Dodawanie autora do bazy.
INSERT INTO autor(imie, nazwisko, data_urodzenia, data_smierci)
VALUES ('INPUT_IMIE', 'INPUT_NAZWISKO', INPUT_DATA_URODZENIA, INPUT_DATA_SMIERCI)

#7. Dodawanie fizycznych egzemplarzy ksi¹¿ek (które bêdzie mo¿na wypo¿yczaæ).
INSERT INTO egzemplarz(ksiazka_id_fk, dostepny) 
VALUES(INPUT_ID_KSIAZKI, true)

#8. Sprawdzanie dostêpnoœci wolnych egzemplarzy danej ksi¹¿ki poprzez wybranie najmniejszego id wolnego egzemplarza (jeœli istnieje wolny egzemplarz).
SELECT egzemplarz.egzemplarz_id FROM egzemplarz 
INNER JOIN ksiazka
ON egzemplarz.ksiazka_id_fk = ksiazka.ISBN 
WHERE egzemplarz.dostepny = true AND ksiazka.ISBN = tytul_id
ORDER BY egzemplarz.egzemplarz_id
LIMIT 1

#9. Wypo¿yczanie egzemplarza ksi¹¿ki przez czytelnika.
INSERT INTO wypozyczenie(data_wypozyczenia, data_zwrotu, czytelnk_id_fk, egzemplarz_id_fk)
VALUES(DATA_WYPOZYCZENIA, DATA_ODDANIA, ID_CZYTELNIKA, ID_EGZEMPLARZ);

UPDATE egzemplarz SET dostepny = false 
WHERE egzemplarz.egzemplarz_id =ID_EGZEMPLARZ;


#10. Sprawdzawdzanie wszystkich wypozyczeñ lub ich wyszukiwanie po nazwisku lub numerze karty bibliotecznej czytelnika albo tytule wypo¿yczonej ksi¹¿ki. 
SELECT czytelnik.nr_karta_biblioteczna as 'Numer Karty Bibliotecznej', czytelnik.imie as 'Imie', czytelnik.nazwisko as 'Nazwisko', ksiazka.tytul as 'Tytu³', egzemplarz.egzemplarz_id, wypozyczenie.data_wypozyczenia as 'Data wypo¿yczenia', wypozyczenie.data_zwrotu as 'Data zwrotu'
FROM wypozyczenie 
INNER JOIN czytelnik 
ON czytelnik.nr_karta_biblioteczna = wypozyczenie.czytelnk_id_fk
INNER JOIN egzemplarz 
ON egzemplarz.egzemplarz_id = wypozyczenie.egzemplarz_id_fk
INNER JOIN ksiazka 
ON ksiazka.ISBN = egzemplarz.ksiazka_id_fk
WHERE czytelnik.nazwisko LIKE "%%" AND ksiazka.tytul LIKE "%%" AND czytelnik.nr_karta_biblioteczna = NR_KARTY_BIBLIOTECZNEJ

#11. Sprawdzanie wszystkich przetrzymañ lub ich wyszukiwanie po nazwisku lub numerze karty bibliotecznej czytelnika albo tytule wypo¿yczonej ksi¹¿ki.
SELECT czytelnik.nr_karta_biblioteczna as 'Numer Karty Bibliotecznej', czytelnik.imie as 'Imie', czytelnik.nazwisko as 'Nazwisko', ksiazka.tytul as 'Tytu³', egzemplarz.egzemplarz_id, wypozyczenie.data_wypozyczenia as 'Data wypo¿yczenia', wypozyczenie.data_zwrotu as 'Data zwrotu'
FROM wypozyczenie 
INNER JOIN czytelnik 
ON czytelnik.nr_karta_biblioteczna = wypozyczenie.czytelnk_id_fk
INNER JOIN egzemplarz 
ON egzemplarz.egzemplarz_id = wypozyczenie.egzemplarz_id_fk
INNER JOIN ksiazka 
ON ksiazka.ISBN = egzemplarz.ksiazka_id_fk
WHERE czytelnik.nazwisko LIKE "%%" AND ksiazka.tytul LIKE "%%" AND czytelnik.nr_karta_biblioteczna = NR_KARTY_BIBLIOTECZNEJ AND CURDATE() > wypozyczenie.data_zwrotu

#12. Zwrot wypo¿yczonych ksi¹¿ek.
DELETE FROM wypozyczenie
WHERE wypozyczenie.czytelnk_id_fk = ID_CZYTELNIKA AND wypozyczenie.egzemplarz_id_fk = ID_EGZEMPLARZ;

UPDATE egzemplarz SET dostepny = true WHERE egzemplarz.egzemplarz_id = ID_EGZEMPLARZ;

#13. Przeszukiwanie listy czytelników wzglêdem imienia lub nazwiska lub numeru karty blibliotecznej w porz¹dku alfabetycznym wg nazwisk.
SELECT czytelnik.nazwisko as 'Nazwisko', czytelnik.imie as 'Imie' czytelnik.nr_karta_biblioteczna as 'Numer Karty Bibliotecznej', czytelnik.nr_telefonu as 'Numer telefonu', czytelnik.e_mail as 'e-mail' , adres.ulica as 'Ulica', adres.nr_domu as 'Numer domu', adres.kod_pocztowy as 'Kod pocztowy', adres.miasto as 'Miasto', czytelnik.adres_id_fk 
FROM czytelnik
INNER JOIN adres 
ON czytelnik.adres_id_fk = adres.adres_id
WHERE czytelnik.nazwisko LIKE "%%" AND czytelnik.imie LIKE "%%" AND czytelnik.nr_karta_biblioteczna = NR_KARTY_BIBLIOTECZNEJ
ORDER BY czytelnik.nazwisko;

#14. Przeszukiwanie listy ksi¹¿ek po ich tytule lub kategorii lub nazwisku autora. Lista zawiera dodatkowo informacje o liczbie dostêpnych wolnych egzemplarzy danej ksi¹zki.
SELECT ksiazka.tytul as 'Tytu³', autor.nazwisko as 'Nazwisko', autor.imie as 'Imie', ksiazka.kategoria as 'Kategoria', ksiazka.wydawnictwo as 'Wydawnictwo', ksiazka.ISBN as 'Numer ISBN', ksiazka.data_wydania as 'Data wydania', ksiazka.liczba_stron as 'Liczba stron', COUNT(egzemplarz.egzemplarz_id) as 'Iloœæ dostêpnych egzemplarzy' 
FROM ksiazka 
INNER JOIN ksiazko_autor 
ON ksiazka.ISBN = ksiazko_autor.ksiazka_id_fk
INNER JOIN autor 
ON autor.autor_id = ksiazko_autor.autor_id_fk
LEFT JOIN egzemplarz 
ON egzemplarz.ksiazka_id_fk = ksiazka.ISBN AND egzemplarz.dostepny = true
WHERE ksiazka.tytul LIKE "%%" AND autor.nazwisko LIKE "%%" AND ksiazka.kategoria LIKE "%%" 
GROUP BY ksiazka.ISBN"
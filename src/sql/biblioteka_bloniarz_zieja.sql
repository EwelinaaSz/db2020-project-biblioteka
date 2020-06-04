-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 04 Cze 2020, 15:55
-- Wersja serwera: 10.4.11-MariaDB
-- Wersja PHP: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `biblioteka_bloniarz_zieja`
--
CREATE DATABASE IF NOT EXISTS `biblioteka_bloniarz_zieja` DEFAULT CHARACTER SET utf8 COLLATE utf8_polish_ci;
USE `biblioteka_bloniarz_zieja`;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `adres`
--

CREATE TABLE `adres` (
  `adres_id` int(11) NOT NULL,
  `ulica` varchar(30) COLLATE utf8mb4_polish_ci NOT NULL,
  `nr_domu` int(11) NOT NULL,
  `kod_pocztowy` int(11) NOT NULL,
  `miasto` varchar(30) COLLATE utf8mb4_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

--
-- Zrzut danych tabeli `adres`
--

INSERT INTO `adres` (`adres_id`, `ulica`, `nr_domu`, `kod_pocztowy`, `miasto`) VALUES
(12, 'Krakowska', 52, 30100, 'Jaslo'),
(14, 'Kielecka', 33, 12123, 'Zadip'),
(15, 'Śląska', 18, 23120, 'Katowice'),
(16, 'Śląskowa', 112, 99997, 'Wawka'),
(18, 'Kolejka', 67, 11321, 'Kolejka'),
(19, 'Yomatishi', 132, 60019, 'Pekin'),
(20, 'Warszawska', 7, 44122, 'Kielce');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `autor`
--

CREATE TABLE `autor` (
  `autor_id` int(11) NOT NULL,
  `imie` varchar(30) COLLATE utf8mb4_polish_ci NOT NULL,
  `nazwisko` varchar(30) COLLATE utf8mb4_polish_ci NOT NULL,
  `data_urodzenia` date NOT NULL,
  `data_smierci` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

--
-- Zrzut danych tabeli `autor`
--

INSERT INTO `autor` (`autor_id`, `imie`, `nazwisko`, `data_urodzenia`, `data_smierci`) VALUES
(19, 'Henryk', 'Sienkiewicz', '1846-05-05', '0000-00-00'),
(20, 'Adam', 'Mickiewicz', '0000-00-00', '0000-00-00'),
(21, 'Juliusz', 'Słowacki', '1809-09-04', '1849-04-03'),
(22, 'Andrzej', 'Sapkowski', '0000-00-00', NULL),
(23, 'Peter', 'Brett', '1973-02-08', NULL),
(24, 'Jacek', 'Piekara', '0000-00-00', NULL);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `czytelnik`
--

CREATE TABLE `czytelnik` (
  `nr_karta_biblioteczna` int(11) NOT NULL,
  `imie` varchar(30) COLLATE utf8mb4_polish_ci NOT NULL,
  `nazwisko` varchar(30) COLLATE utf8mb4_polish_ci NOT NULL,
  `nr_telefonu` int(20) NOT NULL,
  `e_mail` varchar(30) COLLATE utf8mb4_polish_ci NOT NULL,
  `adres_id_fk` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

--
-- Zrzut danych tabeli `czytelnik`
--

INSERT INTO `czytelnik` (`nr_karta_biblioteczna`, `imie`, `nazwisko`, `nr_telefonu`, `e_mail`, `adres_id_fk`) VALUES
(10, 'Patryk', 'Zieja', 504123444, 'pzieja@student.com', 12),
(12, 'Kamil', 'Zadrogi', 555444333, 'kdrogi@student.com', 14),
(13, 'Wojciech', 'Dyrda', 321456753, 'wdyrda@gmail.com', 15),
(14, 'Karina', 'Wróbel', 112244222, 'karwro@doktor.com', 16),
(16, 'Patryk', 'Błoniarz', 122133566, 'pbloniarz@student.com', 18),
(17, 'Urszula', 'Lewandowski', 997112609, 'Cykoria@o2.pl', 19),
(18, 'Bartłomiej', 'Zieja', 445334112, 'bartzieja@hotmail.com', 20);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `egzemplarz`
--

CREATE TABLE `egzemplarz` (
  `egzemplarz_id` int(11) NOT NULL,
  `ksiazka_id_fk` bigint(20) NOT NULL,
  `dostepny` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

--
-- Zrzut danych tabeli `egzemplarz`
--

INSERT INTO `egzemplarz` (`egzemplarz_id`, `ksiazka_id_fk`, `dostepny`) VALUES
(15, 1111111111111, 1),
(16, 1111111111222, 1),
(17, 1111111111333, 0),
(18, 1111111222111, 1),
(19, 1111111222222, 1),
(20, 1111111333111, 0),
(21, 1111111333222, 1),
(22, 1111222111111, 1),
(23, 1111222111222, 0),
(24, 1222222111111, 1),
(25, 3222222111111, 0),
(26, 1111111111333, 1),
(27, 1111111111333, 1),
(28, 1111111111222, 1),
(29, 1111111111111, 1),
(30, 1222222111111, 1),
(31, 1111222111111, 1),
(32, 1111111222111, 1),
(33, 1111111111111, 1),
(34, 1111111222222, 1),
(35, 1111111111111, 1),
(36, 1111222111222, 1),
(37, 1111111111111, 1),
(38, 1111222111222, 1),
(39, 1111222111222, 1),
(40, 1111111333111, 0),
(41, 3222222111111, 1),
(42, 1111111333222, 1),
(44, 1231231231234, 1),
(49, 1231231231234, 1),
(50, 1231231231234, 1),
(51, 1231231231234, 1),
(52, 5677655432123, 0),
(53, 4445553337654, 0),
(54, 4445553337654, 1),
(55, 1111111111222, 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ksiazka`
--

CREATE TABLE `ksiazka` (
  `ISBN` bigint(20) NOT NULL,
  `tytul` varchar(30) COLLATE utf8mb4_polish_ci NOT NULL,
  `kategoria` varchar(30) COLLATE utf8mb4_polish_ci NOT NULL,
  `wydawnictwo` varchar(30) COLLATE utf8mb4_polish_ci NOT NULL,
  `data_wydania` date NOT NULL,
  `liczba_stron` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

--
-- Zrzut danych tabeli `ksiazka`
--

INSERT INTO `ksiazka` (`ISBN`, `tytul`, `kategoria`, `wydawnictwo`, `data_wydania`, `liczba_stron`) VALUES
(1111111111111, 'Malowany Człowiek', 'fantastyka', 'Fabryka Słów', '2012-06-11', 350),
(1111111111222, 'Pustynna Włócznia', 'fantastyka', 'Fabryka Słów', '2013-06-11', 320),
(1111111111333, 'Wojna w Blasku Dnia', 'fantastyka', 'Fabryka Słów', '2014-06-11', 420),
(1111111222111, 'Dziady', 'poezja', 'Insignis', '1999-11-01', 200),
(1111111222222, 'Pan Tadeusz', 'poezja', 'Insignis', '1999-11-01', 200),
(1111111333111, 'Balladyna', 'inne', 'Insignis', '1994-03-02', 150),
(1111111333222, 'Ballady i Romanse', 'romans', 'Insignis', '1994-03-02', 122),
(1111222111111, 'Sezon Burz', 'fantastyka', 'Super Nowa', '2014-01-04', 300),
(1111222111222, 'Pani Jeziora', 'fantastyka', 'Super Nowa', '2010-01-04', 500),
(1222222111111, 'Krzyżacy', 'fantastyka', 'Greg', '1980-03-01', 600),
(1231231231234, 'Ja inkwizytor: Dotyk Zła', 'fantastyka', 'Inko', '2020-06-03', 122),
(3222222111111, 'Quo Vadis', 'fantastyka', 'Greg', '1980-06-11', 250),
(4445553337654, 'Ani słowa prawdy', 'komedia', 'Inko', '2011-11-11', 245),
(5677655432123, 'Ja inkwizytor: Miecz na czarow', 'inne', 'Inko', '2020-06-04', 122);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ksiazko_autor`
--

CREATE TABLE `ksiazko_autor` (
  `autor_id_fk` int(11) NOT NULL,
  `ksiazka_id_fk` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

--
-- Zrzut danych tabeli `ksiazko_autor`
--

INSERT INTO `ksiazko_autor` (`autor_id_fk`, `ksiazka_id_fk`) VALUES
(23, 1111111111111),
(23, 1111111111222),
(23, 1111111111333),
(20, 1111111222111),
(20, 1111111222222),
(21, 1111111333111),
(21, 1111111333222),
(22, 1111222111111),
(22, 1111222111222),
(19, 1222222111111),
(19, 3222222111111),
(24, 1231231231234),
(24, 5677655432123),
(24, 4445553337654);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `wypozyczenie`
--

CREATE TABLE `wypozyczenie` (
  `data_wypozyczenia` date NOT NULL,
  `data_zwrotu` date NOT NULL,
  `czytelnk_id_fk` int(11) NOT NULL,
  `egzemplarz_id_fk` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_polish_ci;

--
-- Zrzut danych tabeli `wypozyczenie`
--

INSERT INTO `wypozyczenie` (`data_wypozyczenia`, `data_zwrotu`, `czytelnk_id_fk`, `egzemplarz_id_fk`) VALUES
('2020-06-03', '2020-07-03', 13, 20),
('2020-06-03', '2020-07-03', 12, 40),
('2020-06-03', '2020-07-03', 10, 17),
('2020-06-03', '2020-07-03', 13, 25),
('2020-06-03', '2020-03-03', 12, 23),
('2020-06-04', '2020-07-04', 12, 52),
('2020-06-04', '2020-07-04', 14, 53);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `adres`
--
ALTER TABLE `adres`
  ADD PRIMARY KEY (`adres_id`);

--
-- Indeksy dla tabeli `autor`
--
ALTER TABLE `autor`
  ADD PRIMARY KEY (`autor_id`);

--
-- Indeksy dla tabeli `czytelnik`
--
ALTER TABLE `czytelnik`
  ADD PRIMARY KEY (`nr_karta_biblioteczna`),
  ADD KEY `adres_id_fk` (`adres_id_fk`);

--
-- Indeksy dla tabeli `egzemplarz`
--
ALTER TABLE `egzemplarz`
  ADD PRIMARY KEY (`egzemplarz_id`),
  ADD KEY `ksiazka_id_fk` (`ksiazka_id_fk`);

--
-- Indeksy dla tabeli `ksiazka`
--
ALTER TABLE `ksiazka`
  ADD PRIMARY KEY (`ISBN`);

--
-- Indeksy dla tabeli `ksiazko_autor`
--
ALTER TABLE `ksiazko_autor`
  ADD KEY `autor_id_fk` (`autor_id_fk`),
  ADD KEY `ksiazka_id_fk` (`ksiazka_id_fk`);

--
-- Indeksy dla tabeli `wypozyczenie`
--
ALTER TABLE `wypozyczenie`
  ADD KEY `czytelnk_id_fk` (`czytelnk_id_fk`),
  ADD KEY `egzemplarz_id_fk` (`egzemplarz_id_fk`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `adres`
--
ALTER TABLE `adres`
  MODIFY `adres_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT dla tabeli `autor`
--
ALTER TABLE `autor`
  MODIFY `autor_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT dla tabeli `czytelnik`
--
ALTER TABLE `czytelnik`
  MODIFY `nr_karta_biblioteczna` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT dla tabeli `egzemplarz`
--
ALTER TABLE `egzemplarz`
  MODIFY `egzemplarz_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `czytelnik`
--
ALTER TABLE `czytelnik`
  ADD CONSTRAINT `czytelnik_ibfk_1` FOREIGN KEY (`adres_id_fk`) REFERENCES `adres` (`adres_id`);

--
-- Ograniczenia dla tabeli `egzemplarz`
--
ALTER TABLE `egzemplarz`
  ADD CONSTRAINT `egzemplarz_ibfk_1` FOREIGN KEY (`ksiazka_id_fk`) REFERENCES `ksiazka` (`ISBN`);

--
-- Ograniczenia dla tabeli `ksiazko_autor`
--
ALTER TABLE `ksiazko_autor`
  ADD CONSTRAINT `ksiazko_autor_ibfk_1` FOREIGN KEY (`autor_id_fk`) REFERENCES `autor` (`autor_id`),
  ADD CONSTRAINT `ksiazko_autor_ibfk_2` FOREIGN KEY (`ksiazka_id_fk`) REFERENCES `ksiazka` (`ISBN`);

--
-- Ograniczenia dla tabeli `wypozyczenie`
--
ALTER TABLE `wypozyczenie`
  ADD CONSTRAINT `wypozyczenie_ibfk_1` FOREIGN KEY (`czytelnk_id_fk`) REFERENCES `czytelnik` (`nr_karta_biblioteczna`),
  ADD CONSTRAINT `wypozyczenie_ibfk_2` FOREIGN KEY (`egzemplarz_id_fk`) REFERENCES `egzemplarz` (`egzemplarz_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Mar 09, 2023 at 05:06 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `users`
--

-- --------------------------------------------------------

--
-- Table structure for table `userlog`
--

CREATE TABLE `userlog` (
  `id` int(100) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(32) NOT NULL,
  `privilege` varchar(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `userlog`
--

INSERT INTO `userlog` (`id`, `login`, `pass`, `privilege`) VALUES
(57, 'petrovss', '1234567', 'user'),
(48, 'admin', '1', 'admin'),
(56, 'novikvv', '12345', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `usersjournal`
--

CREATE TABLE `usersjournal` (
  `id` int(11) NOT NULL,
  `loginUser` varchar(100) NOT NULL,
  `topic` varchar(250) CHARACTER SET utf32 NOT NULL,
  `comment` text NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `usersjournal`
--

INSERT INTO `usersjournal` (`id`, `loginUser`, `topic`, `comment`, `date`) VALUES
(39, 'novikvv', 'замена картриджа в 15 кабинете принтера 2540', 'замена прошла успешна', '2021-11-14'),
(40, 'novikvv', 'создание резервной копии на ПК ws-sas1 sd', 'резервная копия была скопирована на сетевой диск \\\\192.168.1.1\\путь ds sdf sd', '2021-11-01'),
(41, 'petrovss', 'отчистка ненужных строк конфига на комутаторе cisco 2950ол', 'были убраны следующие строки\n..................................\n..................................\n..................................\n..................................\n..................................\n..................................\n..................................', '2021-08-04'),
(42, 'petrovss', 'сброс пароля пользователю Пушкин Владислав Петрович', 'пользователь забыл свой пароль после отпуска сбросил на 1234567', '2021-11-03'),
(54, 'novikvv', 'Выполениние ТО на стойках регистрации 1-7', 'Выполениние ТО на стойках регистрации 1-7', '2022-04-08'),
(55, 'novikvv', 'Замена картриджа', 'При установке картриджа необходимо было зажать клавишы OK + STOP так как картридж не оригинальный.', '2022-04-08');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `userlog`
--
ALTER TABLE `userlog`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `usersjournal`
--
ALTER TABLE `usersjournal`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `userlog`
--
ALTER TABLE `userlog`
  MODIFY `id` int(100) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=65;

--
-- AUTO_INCREMENT for table `usersjournal`
--
ALTER TABLE `usersjournal`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

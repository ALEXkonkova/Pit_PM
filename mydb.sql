-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Фев 14 2021 г., 17:44
-- Версия сервера: 5.7.24
-- Версия PHP: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `mydb`
--

-- --------------------------------------------------------

--
-- Структура таблицы `actions`
--

CREATE TABLE `actions` (
  `idactions` int(11) NOT NULL,
  `cost` int(6) NOT NULL,
  `user_iduser` int(11) NOT NULL,
  `orders_idorders` int(11) NOT NULL,
  `name` text NOT NULL,
  `date_on` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `date_off` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `actions`
--

INSERT INTO `actions` (`idactions`, `cost`, `user_iduser`, `orders_idorders`, `name`, `date_on`, `date_off`) VALUES
(3, 0, 1, 3, 'Диагностика', '2021-01-21 15:27:13', NULL),
(4, 4500, 1, 4, 'Замена дисплея', '2021-01-23 13:57:11', NULL),
(5, 500, 1, 3, 'Чистка', '2021-01-23 16:46:06', NULL),
(6, 3500, 1, 3, 'Замена аккумулятора', '2021-01-23 17:48:37', NULL),
(7, 1000, 3, 5, 'Диагностика после залития', '2021-01-27 16:40:03', NULL),
(8, 3500, 3, 5, 'Заамена аккумулятора', '2021-01-27 16:40:44', NULL),
(9, 5000, 3, 5, 'Замена дисплея', '2021-01-27 16:40:54', NULL),
(10, 0, 1, 6, 'Диагностика', '2021-01-29 11:26:39', NULL),
(11, 4500, 1, 7, 'Замена аккумулятора', '2021-01-29 11:29:21', NULL),
(12, 300, 1, 7, 'Чистка', '2021-02-13 10:23:12', NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `devices`
--

CREATE TABLE `devices` (
  `imei` varchar(15) NOT NULL,
  `brand` varchar(10) DEFAULT NULL,
  `model` varchar(30) NOT NULL,
  `type` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `devices`
--

INSERT INTO `devices` (`imei`, `brand`, `model`, `type`) VALUES
('12476589123', 'Samsung', 'Galaxy S6', NULL),
('170364128412', 'Apple', 'iphone x', NULL),
('19547201236', 'Apple', 'Iphone 7 plus', NULL),
('19547234109', 'Asus', 'Zenfone lite 5+', NULL),
('514034941242', 'apple', 'macbook air 12 2015', NULL),
('67018942031', 'Xiaomi', 'Note 9 s', NULL),
('97031521971', 'Samsung', 'Galaxy 10A', NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `orders`
--

CREATE TABLE `orders` (
  `idorders` int(11) NOT NULL,
  `reason` text NOT NULL,
  `state` text NOT NULL,
  `flooded` int(1) NOT NULL,
  `comment` text,
  `devices_imei` varchar(15) NOT NULL,
  `сlients_phone` char(11) NOT NULL,
  `users_idusers` int(11) NOT NULL,
  `data_off` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `orders`
--

INSERT INTO `orders` (`idorders`, `reason`, `state`, `flooded`, `comment`, `devices_imei`, `сlients_phone`, `users_idusers`, `data_off`) VALUES
(3, 'Не слышно собеседника', 'Идеальное', 0, '', '19547201236', '79052804743', 1, NULL),
(4, 'Разбит экран', 'Разит экран и скол вверхней части телефона', 0, '00', '19547234109', '79062804743', 1, NULL),
(5, 'Не работает', 'Отвратительное', 1, '', '67018942031', '79062752627', 3, NULL),
(6, 'Незаряжается', 'Отличное', 0, '', '12476589123', '79052474411', 1, NULL),
(7, 'Замена аккумулятора', 'Есть скол снизу на углу', 0, '', '170364128412', '79042752214', 1, NULL),
(8, 'Залитие', 'Есть потертости на задней крышке', 1, '', '97031521971', '79052476584', 3, NULL),
(9, 'Диагностика По', 'Идеальное', 0, '', '514034941242', '79000171100', 1, NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `status`
--

CREATE TABLE `status` (
  `idstatus` int(11) NOT NULL,
  `status` char(23) NOT NULL DEFAULT 'Принят',
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `orders_idorders` int(11) NOT NULL,
  `users_idusers` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `status`
--

INSERT INTO `status` (`idstatus`, `status`, `date`, `orders_idorders`, `users_idusers`) VALUES
(3, 'Принят', '2021-01-21 15:26:51', 3, 1),
(4, 'Принят', '2021-01-23 13:56:58', 4, 1),
(5, 'Изменён', '2021-01-23 17:47:59', 3, 1),
(6, 'Изменён', '2021-01-23 17:48:42', 3, 1),
(11, 'Согласован', '2021-01-24 15:47:18', 3, 1),
(12, 'Принят', '2021-01-27 16:39:46', 5, 3),
(13, 'Изменён', '2021-01-27 16:40:55', 5, 3),
(14, 'Согласован', '2021-01-27 16:40:59', 5, 3),
(15, 'Готово', '2021-01-27 16:41:01', 5, 3),
(16, 'Выдан', '2021-01-27 16:41:03', 5, 3),
(17, 'Принят', '2021-01-29 11:26:22', 6, 1),
(18, 'Принят', '2021-01-29 11:28:54', 7, 1),
(19, 'Принят', '2021-02-13 10:20:51', 8, 3),
(20, 'Готово', '2021-02-13 10:22:49', 7, 1),
(21, 'Изменён', '2021-02-13 10:48:34', 7, 1),
(22, 'Согласован', '2021-02-13 10:49:03', 7, 1),
(23, 'Готово', '2021-02-14 15:00:29', 7, 1),
(24, 'Принят', '2021-02-14 20:19:17', 9, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `idusers` int(11) NOT NULL,
  `name` varchar(16) NOT NULL,
  `surname` varchar(16) NOT NULL,
  `patronymic` varchar(20) DEFAULT NULL,
  `right1` int(45) NOT NULL,
  `login` text NOT NULL,
  `pass` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`idusers`, `name`, `surname`, `patronymic`, `right1`, `login`, `pass`) VALUES
(1, 'Александр', 'Фомичев', NULL, 1, 'admin', '1234'),
(2, 'Александра', 'Конькова', '', 1, 'Alex', '1234'),
(3, 'Орешников', 'Егор', '', 0, 'iq', '0000'),
(4, 'Шелен', 'Дмитрий', 'Викторович', 0, 'login', '1234'),
(5, '', '', '', 0, '', '');

-- --------------------------------------------------------

--
-- Структура таблицы `сlients`
--

CREATE TABLE `сlients` (
  `phone` char(11) NOT NULL,
  `name` varchar(11) NOT NULL,
  `gender` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `сlients`
--

INSERT INTO `сlients` (`phone`, `name`, `gender`) VALUES
('79000171100', 'Алёна', NULL),
('79042752214', 'Екатерина', NULL),
('79052474411', 'Андрей', NULL),
('79052476584', 'Дмитрий', NULL),
('79052804743', 'Александр', NULL),
('79062752627', 'Мария', NULL),
('79062804743', 'Марина', NULL);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `actions`
--
ALTER TABLE `actions`
  ADD PRIMARY KEY (`idactions`,`user_iduser`,`orders_idorders`),
  ADD KEY `service_idservice` (`user_iduser`),
  ADD KEY `orders_idorders` (`orders_idorders`);

--
-- Индексы таблицы `devices`
--
ALTER TABLE `devices`
  ADD PRIMARY KEY (`imei`);

--
-- Индексы таблицы `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`idorders`,`devices_imei`,`сlients_phone`,`users_idusers`),
  ADD KEY `users_idusers` (`users_idusers`),
  ADD KEY `devices_imei` (`devices_imei`),
  ADD KEY `сlients_phone` (`сlients_phone`);

--
-- Индексы таблицы `status`
--
ALTER TABLE `status`
  ADD PRIMARY KEY (`idstatus`,`orders_idorders`,`users_idusers`),
  ADD KEY `users_idusers` (`users_idusers`),
  ADD KEY `orders_idorders` (`orders_idorders`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`idusers`);

--
-- Индексы таблицы `сlients`
--
ALTER TABLE `сlients`
  ADD PRIMARY KEY (`phone`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `actions`
--
ALTER TABLE `actions`
  MODIFY `idactions` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT для таблицы `orders`
--
ALTER TABLE `orders`
  MODIFY `idorders` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `status`
--
ALTER TABLE `status`
  MODIFY `idstatus` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `idusers` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `actions`
--
ALTER TABLE `actions`
  ADD CONSTRAINT `actions_ibfk_1` FOREIGN KEY (`user_iduser`) REFERENCES `users` (`idusers`),
  ADD CONSTRAINT `actions_ibfk_3` FOREIGN KEY (`orders_idorders`) REFERENCES `orders` (`idorders`);

--
-- Ограничения внешнего ключа таблицы `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`users_idusers`) REFERENCES `users` (`idusers`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`devices_imei`) REFERENCES `devices` (`imei`),
  ADD CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`сlients_phone`) REFERENCES `сlients` (`phone`);

--
-- Ограничения внешнего ключа таблицы `status`
--
ALTER TABLE `status`
  ADD CONSTRAINT `status_ibfk_1` FOREIGN KEY (`users_idusers`) REFERENCES `users` (`idusers`),
  ADD CONSTRAINT `status_ibfk_2` FOREIGN KEY (`orders_idorders`) REFERENCES `orders` (`idorders`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Апр 06 2017 г., 12:58
-- Версия сервера: 5.5.53
-- Версия PHP: 7.1.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `train`
--

-- --------------------------------------------------------

--
-- Структура таблицы `race`
--

CREATE TABLE `race` (
  `id` int(11) NOT NULL,
  `destination` text NOT NULL,
  `vagon` text NOT NULL,
  `time` text NOT NULL,
  `seat_1` tinyint(1) NOT NULL DEFAULT '0',
  `seat_2` tinyint(1) NOT NULL DEFAULT '0',
  `seat_3` tinyint(1) NOT NULL DEFAULT '0',
  `seat_4` tinyint(1) NOT NULL DEFAULT '0',
  `seat_5` tinyint(1) NOT NULL DEFAULT '0',
  `seat_6` tinyint(1) NOT NULL DEFAULT '0',
  `seat_7` tinyint(1) NOT NULL DEFAULT '0',
  `seat_8` tinyint(1) NOT NULL DEFAULT '0',
  `seat_9` tinyint(1) NOT NULL DEFAULT '0',
  `seat_10` tinyint(1) NOT NULL DEFAULT '0',
  `seat_11` tinyint(1) NOT NULL DEFAULT '0',
  `seat_12` tinyint(1) NOT NULL DEFAULT '0',
  `seat_13` tinyint(1) NOT NULL DEFAULT '0',
  `seat_14` tinyint(1) NOT NULL DEFAULT '0',
  `seat_15` tinyint(1) NOT NULL DEFAULT '0',
  `seat_16` tinyint(1) NOT NULL DEFAULT '0',
  `seat_17` tinyint(1) NOT NULL DEFAULT '0',
  `seat_18` tinyint(1) NOT NULL DEFAULT '0',
  `seat_19` tinyint(1) NOT NULL DEFAULT '0',
  `seat_20` tinyint(1) NOT NULL DEFAULT '0',
  `seat_21` tinyint(1) NOT NULL DEFAULT '0',
  `seat_22` tinyint(1) NOT NULL DEFAULT '0',
  `seat_23` tinyint(1) NOT NULL DEFAULT '0',
  `seat_24` tinyint(1) NOT NULL DEFAULT '0',
  `seat_25` tinyint(1) NOT NULL DEFAULT '0',
  `seat_26` tinyint(1) NOT NULL DEFAULT '0',
  `seat_27` tinyint(1) NOT NULL DEFAULT '0',
  `seat_28` tinyint(1) NOT NULL DEFAULT '0',
  `seat_29` tinyint(1) NOT NULL DEFAULT '0',
  `seat_30` tinyint(1) NOT NULL DEFAULT '0',
  `seat_31` tinyint(1) NOT NULL DEFAULT '0',
  `seat_32` tinyint(1) NOT NULL DEFAULT '0',
  `seat_33` tinyint(1) NOT NULL DEFAULT '0',
  `seat_34` tinyint(1) NOT NULL DEFAULT '0',
  `seat_35` tinyint(1) NOT NULL DEFAULT '0',
  `seat_36` tinyint(1) NOT NULL DEFAULT '0',
  `seat_37` tinyint(1) NOT NULL DEFAULT '0',
  `seat_38` tinyint(1) NOT NULL DEFAULT '0',
  `seat_39` tinyint(1) NOT NULL DEFAULT '0',
  `seat_40` tinyint(1) NOT NULL DEFAULT '0',
  `seat_41` tinyint(1) NOT NULL DEFAULT '0',
  `seat_42` tinyint(1) NOT NULL DEFAULT '0',
  `seat_43` tinyint(1) NOT NULL DEFAULT '0',
  `seat_44` tinyint(1) NOT NULL DEFAULT '0',
  `seat_45` tinyint(1) NOT NULL DEFAULT '0',
  `seat_46` tinyint(1) NOT NULL DEFAULT '0',
  `seat_47` tinyint(1) NOT NULL DEFAULT '0',
  `seat_48` tinyint(1) NOT NULL DEFAULT '0',
  `seat_49` tinyint(1) NOT NULL DEFAULT '0',
  `seat_50` tinyint(1) NOT NULL DEFAULT '0',
  `seat_51` tinyint(1) NOT NULL DEFAULT '0',
  `seat_52` tinyint(1) NOT NULL DEFAULT '0',
  `seat_53` tinyint(1) NOT NULL DEFAULT '0',
  `seat_54` tinyint(1) NOT NULL DEFAULT '0',
  `seat_55` tinyint(1) NOT NULL DEFAULT '0',
  `seat_56` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `race`
--

INSERT INTO `race` (`id`, `destination`, `vagon`, `time`, `seat_1`, `seat_2`, `seat_3`, `seat_4`, `seat_5`, `seat_6`, `seat_7`, `seat_8`, `seat_9`, `seat_10`, `seat_11`, `seat_12`, `seat_13`, `seat_14`, `seat_15`, `seat_16`, `seat_17`, `seat_18`, `seat_19`, `seat_20`, `seat_21`, `seat_22`, `seat_23`, `seat_24`, `seat_25`, `seat_26`, `seat_27`, `seat_28`, `seat_29`, `seat_30`, `seat_31`, `seat_32`, `seat_33`, `seat_34`, `seat_35`, `seat_36`, `seat_37`, `seat_38`, `seat_39`, `seat_40`, `seat_41`, `seat_42`, `seat_43`, `seat_44`, `seat_45`, `seat_46`, `seat_47`, `seat_48`, `seat_49`, `seat_50`, `seat_51`, `seat_52`, `seat_53`, `seat_54`, `seat_55`, `seat_56`) VALUES
(1, 'lviv', '12', '13.40', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1),
(2, 'iavano-frankivsk kolomiya', '5', '12.00', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `race`
--
ALTER TABLE `race`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `race`
--
ALTER TABLE `race`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

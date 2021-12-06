DROP DATABASE IF EXISTS clinicon;

-- Comentario: Porfavor Deletar o banco antes de utilizado para poder atualizar o codigo por completo!


/*
-- INICIO Nota --

Quando for adicionar items e codigo por aqui,
Por favor Selecione e execute somente a parte que voce adicionou!!! 
Caso contrario podera perder dados que foi adicionado pelo app ou phpmyadmin!

-- FIM Nota --
*/

-- ------------------------------------------ --

CREATE DATABASE clinicon;

USE clinicon;

CREATE TABLE IF NOT EXISTS `admins` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) CHARACTER SET utf8 NOT NULL,
  `email` varchar(255) CHARACTER SET utf8 NOT NULL,
  `senha` TEXT CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `messages` (
  `msg_id` int(11) NOT NULL AUTO_INCREMENT,
  `incoming_msg_id` int(255) NOT NULL,
  `outgoing_msg_id` int(255) NOT NULL,
  `msg` varchar(1000) NOT NULL,
  PRIMARY KEY (`msg_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int(255) NOT NULL AUTO_INCREMENT,
  `unique_id` int(255) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `nome_social` varchar(255) NOT NULL DEFAULT '-',
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `cpf` varchar(255) NOT NULL,
  `data_de_nascimento` varchar(255) NOT NULL,
  `sexo` varchar(255) NOT NULL,
  `pais` varchar(255) NOT NULL,
  `estado` varchar(255) NOT NULL,
  `cidade` varchar(255) NOT NULL,
  `logradouro` varchar(255) NOT NULL,
  `img` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;


-- Adicionanco dados --


-- Administradores (admins)
INSERT INTO `admins` (`id`, `nome`, `email`, `senha`) VALUES
(4, 'Administrador', 'email', 'senha'),
(11, 'Admin', 'admin', 'admin');


-- Mensagens (msg / messages)
INSERT INTO `messages` (`msg_id`, `incoming_msg_id`, `outgoing_msg_id`, `msg`) VALUES
(1, 2, 3, 'mensagem teste'),
(2, 3, 4, 'mensag test 2'),
(4, 3, 4, 'mensag test 3'),
(6, 26, 19, '12787!!'),
(10, 26, 19, '12787!');


-- Usuarios (users)
INSERT INTO `users` (`user_id`, `unique_id`, `fname`, `lname`, `nome_social`, `email`, `password`, `cpf`, `data_de_nascimento`, `sexo`, `pais`, `estado`, `cidade`, `logradouro`, `img`, `status`) VALUES
(10, 1, 'nome', 'sobrenome', '', 'email@gmail.com', 'senha', '123.123.123-23', '30/05/1956', 'Masculino', 'Brasil', 'MG', 'Sabara', 'Rua lima', 'img.png', 'offline'),
(11, 1, 'dsdfsf', '32e2ed', '', 'ashdoiasd', 'passowrd', '123.123.123-23', '30/05/1956', 'Masculino', 'Brasil', 'MG', 'Sabara', 'Rua lima', 'img.png', 'offline');



















-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 03-Dez-2020 às 19:04
-- Versão do servidor: 10.4.16-MariaDB
-- versão do PHP: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `destinocerto`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `atendimento`
--

CREATE TABLE `atendimento` (
  `id_atendimento` int(11) NOT NULL,
  `nome` varchar(200) NOT NULL,
  `email` varchar(200) NOT NULL,
  `duvida` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `atendimento`
--

INSERT INTO `atendimento` (`id_atendimento`, `nome`, `email`, `duvida`) VALUES
(1, 'Rodrigo', 'rodrigo@hotmail.com', 'Parcelamento de pacotes');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pacotes`
--

CREATE TABLE `pacotes` (
  `id_pacotes` int(11) NOT NULL,
  `nome` varchar(200) NOT NULL,
  `origem` varchar(200) NOT NULL,
  `destino` varchar(200) NOT NULL,
  `saida` varchar(50) NOT NULL,
  `retorno` varchar(50) NOT NULL,
  `preco` double(9,2) NOT NULL,
  `id_usuarios` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pacotes`
--

INSERT INTO `pacotes` (`id_pacotes`, `nome`, `origem`, `destino`, `saida`, `retorno`, `preco`, `id_usuarios`) VALUES
(1, 'Natal', 'Recife', 'Rio Grande do Norte', '02/12/2020', '10/12/2020', 550.00, 1),
(2, 'João Pessoa', 'São Paulo', 'Paraíba', '05/01/2021', '10/01/2021', 620.00, 1),
(4, 'Gramado', 'Recife', 'Rio Grande do Sul', '20/05/2021', '25/05/2021', 720.00, 1),
(5, 'Noronha', 'Recife', 'Fernando de Noronha', '22/04/2021', '28/04/2021', 800.00, 1),
(6, 'Salvador', 'Rio de Janeiro', 'Bahia', '17/03/2021', '22/03/2021', 430.00, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuarios` int(11) NOT NULL,
  `nome` varchar(200) NOT NULL,
  `login` varchar(100) NOT NULL,
  `data_nascimento` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `conta` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id_usuarios`, `nome`, `login`, `data_nascimento`, `senha`, `conta`) VALUES
(1, 'Rafael', 'rafael-vaz', '17/01/1995', '1701', 'administrador'),
(2, 'Miguel', 'miguel-pereira', '05/11/1998', '1802', 'administrador'),
(3, 'Paulo', 'paulo-carvalho', '25/06/1997', '1358', 'colaborador'),
(4, 'Gustavo', 'gustavo-ferreira', '18/07/1992', '1587', 'colaborador'),
(5, 'Rodrigo', 'rodrigo-silva', '08/03/1996', '3601', 'usuario'),
(6, 'Lucas', 'lucas-freitas', '15/01/1995', '2201', 'usuario');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `atendimento`
--
ALTER TABLE `atendimento`
  ADD PRIMARY KEY (`id_atendimento`);

--
-- Índices para tabela `pacotes`
--
ALTER TABLE `pacotes`
  ADD PRIMARY KEY (`id_pacotes`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuarios`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `atendimento`
--
ALTER TABLE `atendimento`
  MODIFY `id_atendimento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `pacotes`
--
ALTER TABLE `pacotes`
  MODIFY `id_pacotes` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuarios` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

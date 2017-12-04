-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 04-Dez-2017 às 18:25
-- Versão do servidor: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `trabalholp2`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `carro`
--

CREATE TABLE `carro` (
  `nome` varchar(64) NOT NULL,
  `modelo` varchar(64) NOT NULL,
  `precoBase` double NOT NULL,
  `id` int(11) NOT NULL,
  `Removido` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `carro`
--

INSERT INTO `carro` (`nome`, `modelo`, `precoBase`, `id`, `Removido`) VALUES
('Fiat Uno', '1987', 0, 8, 1),
('Gol', '2016', 0, 10, 1),
('Relampago marquinhos', 'meme 2002 a.C', 0, 11, 1),
('RR', '2018', 190000, 12, 0),
('F-TYPE', '2018', 300000, 13, 0),
('Hb20', '2017', 40000, 21, 0),
('Saveiro', 'Cross 2015', 52000, 23, 0),
('L200', 'HPE', 90000, 24, 0),
('GOL', 'MSI', 29000, 25, 0),
('Civic', '2018', 98000, 31, 0),
('Polo', '2018', 90000, 32, 0),
('Fox', 'MSI', 50000, 33, 0),
('Up!', '2018', 30000, 34, 0),
('GTR', 'nism0', 400000, 35, 0),
('Corolla', '2018', 90000, 36, 0),
('Golf', '2018', 70000, 37, 0),
('Tundra', '2002', 130000, 38, 0),
('azera', '2011', 120000, 39, 0),
('Uno', '1999', 3500, 41, 0),
('Strada', 'Working', 30000, 43, 0),
('Montana', 'Sport', 34000, 44, 0),
('Onix', 'LX 2014', 45000, 45, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `carromotor`
--

CREATE TABLE `carromotor` (
  `idcarro` int(11) NOT NULL,
  `idmotor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `carromotor`
--

INSERT INTO `carromotor` (`idcarro`, `idmotor`) VALUES
(8, 1),
(10, 4),
(10, 5),
(11, 1),
(11, 4),
(12, 1),
(13, 6),
(16, 6),
(17, 1),
(18, 1),
(19, 1),
(20, 1),
(21, 7),
(21, 8),
(23, 4),
(23, 5),
(24, 9),
(25, 1),
(25, 4),
(25, 5),
(27, 1),
(27, 7),
(31, 1),
(31, 16),
(32, 1),
(32, 5),
(32, 17),
(33, 4),
(33, 5),
(33, 17),
(34, 4),
(34, 5),
(34, 13),
(35, 11),
(36, 1),
(36, 7),
(36, 18),
(37, 1),
(37, 13),
(37, 14),
(38, 19),
(39, 20),
(41, 1),
(43, 21),
(44, 5),
(45, 4),
(45, 8);

-- --------------------------------------------------------

--
-- Estrutura da tabela `carroopcional`
--

CREATE TABLE `carroopcional` (
  `idcarro` int(11) NOT NULL,
  `idopcional` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `carroopcional`
--

INSERT INTO `carroopcional` (`idcarro`, `idopcional`) VALUES
(11, 1),
(11, 3),
(12, 3),
(13, 1),
(13, 2),
(13, 3),
(22, 1),
(23, 1),
(23, 2),
(23, 5),
(24, 2),
(24, 5),
(25, 1),
(25, 2),
(27, 2),
(27, 5),
(31, 2),
(31, 7),
(31, 10),
(31, 13),
(31, 14),
(32, 1),
(32, 2),
(32, 6),
(32, 7),
(33, 1),
(33, 2),
(34, 1),
(34, 10),
(34, 13),
(35, 1),
(35, 2),
(35, 5),
(35, 6),
(35, 7),
(35, 10),
(35, 11),
(35, 13),
(35, 14),
(36, 1),
(36, 2),
(37, 1),
(37, 2),
(37, 7),
(37, 10),
(37, 13),
(37, 14),
(38, 5),
(38, 10),
(38, 14),
(39, 1),
(39, 2),
(39, 6),
(39, 7),
(41, 10),
(43, 1),
(44, 1),
(44, 2),
(44, 11),
(45, 1),
(45, 2),
(45, 13),
(45, 14);

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id` int(11) NOT NULL,
  `nome` varchar(64) NOT NULL,
  `email` varchar(64) NOT NULL,
  `cpf` varchar(16) NOT NULL,
  `rg` varchar(16) NOT NULL,
  `datanasc` date NOT NULL,
  `ecivil` varchar(16) NOT NULL,
  `telefone` varchar(16) NOT NULL,
  `renda` double NOT NULL,
  `cep` varchar(16) NOT NULL,
  `rua` varchar(64) NOT NULL,
  `bairro` varchar(64) NOT NULL,
  `numero` varchar(8) NOT NULL,
  `complemento` varchar(8) NOT NULL,
  `nomeBanco` varchar(64) NOT NULL,
  `agencia` varchar(16) NOT NULL,
  `nconta` varchar(16) NOT NULL,
  `Removido` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id`, `nome`, `email`, `cpf`, `rg`, `datanasc`, `ecivil`, `telefone`, `renda`, `cep`, `rua`, `bairro`, `numero`, `complemento`, `nomeBanco`, `agencia`, `nconta`, `Removido`) VALUES
(1, 'Teste', 'vesss', '144,452,385-41', '1551', '1995-07-05', 'solteiro', '(16)5148-4846', 10321, '13560000', 'rrs', 'jdds', '12', '165', 'BB', '10', '16', 1),
(2, 'teste222', 'em', '151,564,654-56', '56.415.   -', '2016-02-10', 'ecv', '(19)6546-4615', 123478, '1356000', 'jjji', 'aaa', '342', '32', 'jlib', '1654', '1510', 1),
(3, 'Cliente p/ teste', 'teste@email.com', '111,111,111-11', '15615521', '1998-06-17', 'casado', '(16)8498-4851', 38272, '138379', 'Rua', 'bairro', '123', '34', 'BB', '15415', '3215', 0),
(4, 'João', 'jj@mail.com', '165,185,196-15', '23.544.234-2', '2014-06-10', 'solteiro', '(16)2968-5165', 13000, '134568000', 'jib', 'jober', '120', '00', 'santander', '18880', '2541516', 0),
(5, 'Billy jhonny the kid', 'billyjony@drrr.com', '222,222,222-22', '12.345.679-8', '2000-06-07', 'viuvo', '(16)5498-4981', 135690, '13000000', 'Avenida Raul Veiga 209', 'Centro', '890', '0', 'Santander', '2500', '13560-1', 0),
(6, 'Guilherme Diogo Ian Almeida', 'gguilhermediogoianalmeida@facebook.com', '430,049,748-60', '40.179.729-6', '2017-11-08', 'solteiro', '(12)2393-7582', 1300, '17240-970', 'Rua Marechal Deodoro 218', 'Centro', '218', '0', 'Banco do Brasil', '23561', '13584', 0),
(7, 'João Vitor', 'jvi@min.com', '056,948,654-15', '15.666.856-9', '2066-02-25', 'solteiro', '(16)9999-4986', 25000, '13569000', 'rua 9', 'centro', '4566', '0', 'agiota', '001', '00171', 0),
(8, 'Luna Eloá Carvalho', 'lunaeloacarvalho-97@aedu.com', '610,149,918-97', '28.149.413-7', '1990-06-20', 'solteira', '(16)9993-31922', 2100, '13573-206', 'Rua Professor Sebastião Gomes', 'Cidade Aracy', '506', '0', 'Banco do brasil', '125', '100', 0),
(9, 'Alícia Bárbara Heloisa Pereira', 'aliabeloisapereira-75@land.com.br', '104,965,328-98', '30.169.708-5', '2017-11-08', 'viuva', '(16)9966-4752', 3500, '13564-813', 'Travessa Cinco', 'Loteamento Aracê de Santo Antonio I', '803', '0', 'santander', '2700', '160', 0),
(10, 'Heitor Luiz Monteiro', 'heitorluizmonteiro_@wwlimpador.com.br', '789,436,628-58', '10.634.415-8', '2017-11-08', 'casado', '(16) 367-98528', 6500, '13574-560', 'Rua Porceno Marino', 'Jardim Gibertoni', '15', '12', 'Banco do brasil', '160', '11', 0),
(11, 'Luana Gabriela Carolina Rocha', 'luanagabriela@cotamtambores.com.br', '439,388,128-18', '11.321.574-5', '2017-11-08', 'Solteira', '(16) 992-65000', 12000, '13571-603', 'Rua Ivo Nildo Bellucci', 'Jardim de Cresci', '520', '121', 'Santander', '423', '348', 0),
(12, 'Bruno Bryan', 'brunobryanpinto_@suplementototal.com.br', '828,974,338-68', '46.718.096-9', '2017-11-08', 'casado', '(13)4918-91871', 1300, '13573-321', 'Rua 19', 'Conjunto Habitacional Planalto Verde', '344', '12', 'Banco do Brasil', '1880', '1350', 0),
(13, 'Natália Betina Oliveira', 'nat@contjulioroberto.com.br', '592,157,238-11', '30.565.716-1', '2017-11-08', 'viuva', '(16)9842-2564', 6500, '13562-420', 'Avenida Bruno Ruggiero Filho', 'Parque Santa Felícia Jardim', '972', '0', 'Santander', '1350', '1210', 0),
(14, 'Caroline Lorena Campos', 'carolinelorenacampos_@sunrise.com.br', '319,596,218-74', '43.706.287-9', '2017-11-08', 'casada', '(16)9891-51654', 8500, '13566-802', 'Travessa Três', 'Tibaia de São Fernando II', '956', '23', 'BB', '1350', '220', 0),
(15, 'Levi Ryan Castro', 'lleviryancastro@parkhotel.com.br', '671,828,258-80', '17.362.809-6', '2017-11-08', 'solteiro', '(16) 981-95347', 3200, '13571-270', 'Rua João Batista de Aguiar', 'Recreio São Judas Tadeu', '916', '0', 'bb', '234', '12', 0),
(16, 'Igor Rafael Costa', 'igorrafaelcosta_@uol.om.br', '123,456,789-12', '18.912.117-8', '2017-11-08', 'casado', '(16) 255-83928', 1350, '13563-520', 'Rua Dona Odete Ribas Arruda Botelho', 'Jardim São Carlos 5', '891', '0', 'santander', '132', '15', 0),
(17, 'Joaquim Matheus Gomes', 'joaquimmatheus-95@unicamp.br', '987,654,321-11', '50.112.865-7', '2017-11-08', 'solteiro', '(16) 985-23290', 6800, '13568-653', 'Rua Raul Rodrigues Martins', 'Residencial Parque Douradinho', '333', '0', 'banco', '16545', '41145', 0),
(18, 'Alice Marcela Camila Cardoso', 'alicemarcela@grupomozue.com.br', '159,753,842-61', '36.545.801-6', '2017-11-08', 'casada', '(16) 996-84225', 15000, '13562-341', 'Rua Angelo Passeri', 'Jardim Alvorada', '292', '0', 'Santander', '14142', '1233', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `id` int(11) NOT NULL,
  `nome` varchar(64) NOT NULL,
  `email` varchar(64) NOT NULL,
  `cpf` varchar(16) NOT NULL,
  `rg` varchar(16) NOT NULL,
  `datanasc` date NOT NULL,
  `ecivil` varchar(16) NOT NULL,
  `telefone` varchar(16) NOT NULL,
  `Salario` double NOT NULL,
  `cep` varchar(16) NOT NULL,
  `rua` varchar(64) NOT NULL,
  `bairro` varchar(64) NOT NULL,
  `numero` varchar(8) NOT NULL,
  `complemento` varchar(8) NOT NULL,
  `nomeBanco` varchar(64) NOT NULL,
  `agencia` varchar(16) NOT NULL,
  `nconta` varchar(16) NOT NULL,
  `salarioTotal` double NOT NULL,
  `Removido` int(11) NOT NULL,
  `Login` varchar(64) NOT NULL,
  `Senha` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`id`, `nome`, `email`, `cpf`, `rg`, `datanasc`, `ecivil`, `telefone`, `Salario`, `cep`, `rua`, `bairro`, `numero`, `complemento`, `nomeBanco`, `agencia`, `nconta`, `salarioTotal`, `Removido`, `Login`, `Senha`) VALUES
(1, 'Joao', 'jj@kkjkkj.com', '165,156,415-61', '165156', '1994-06-15', 'solteiro', '(16)5154-5185', 16515, '13546', 'rua kdoekf', 'Wololo', '16', '1', 'BB', '12055', '615', 0, 0, 'jhon1', 'jhon1'),
(2, 'Funcionario1', 'jj@kk.com', '156,156,156-16', '165152', '2004-06-08', 'casado', '(15)6541-4196', 1350, '134564', 'r23', 'bairro1', '312', '03', 'BB', '143', '23', 0, 1, 'funcionario', 'funcionario'),
(4, 'Funcionario teste', 'mail@testefunc.com', '222,222,222-22', '123412', '2017-05-30', 'solteiro', '(16)8949-1855', 2515, '1651655', 'rua', 'bairro', '132', '15', 'bb', '1234', '23', 0, 0, 'log', 'sen'),
(5, 'Danilo Tomás Ryan Ribeiro', 'danilotomiro@eletrovip.com', '210,525,468-38', '35.721.736-6', '2017-11-08', 'solteiro', '(16)9985-7159', 8500, '13565-384', 'Via de Acesso 12', 'Condomínio Residencial Village São Carlos l', '470', '22', 'santander', '165', '165', 0, 0, 'func2', 'pw2'),
(6, 'Heitor Nicolas Freitas', 'heitor@habby-appe.com.br', '241,555,158-90', '43.417.736-2', '2017-11-08', 'casado', '(16) 999-7471', 4444, '13568-842', 'Avenida Comendador Oscar Ferreira', 'Conjunto Habitacional Dom Constantino Amstalden', '490', '123', 'brasil', '1645', '444', 0, 0, '1115', '166'),
(7, 'Pietra Luna Luana Moura', 'pietralunaluana3@adherminer.com.br', '650,718,678-34', '15.020.514-4', '2017-11-08', 'casada', '(16)8918-9198', 3404, '13563-732Rua Ado', 'Rua Adolpho Orlandi', 'Jardim Santa Elisa', '715', '0', 'santander', '16548', '1515', 0, 0, 'jj', 'jj'),
(8, 'Letícia Luiza Souza', 'lletialuizasouza@mail.com', '548,679,338-30', '28.405.403-3', '2017-11-08', 'viuva', '(16)8491-8196', 2500, '13995-970', 'Rua Senador Abelardo César', 'Centro', '910', '0', 'santander', '1651', '1961', 0, 0, '33', '15'),
(9, 'Rayssa Alícia Larissa Ribeiro', 'ray@vigaconstrucao.com.br', '920,211,688-16', '35.718.935-8', '2017-11-08', 'casada', '(16)4919-9119', 9512, '13995-970', 'Rua Senador Abelardo Césa', 'Centro', '123', '0', 'bb', '123', '412', 0, 0, 'jk', 'kj'),
(10, 'Camila Isadora Monteiro', 'asd@afe.com', '165,065,061-65', '11.583.656-1', '2017-11-08', 'solteira', '(15)4341-4122', 3500, '1651819', '1', '2', '3', '4', '44', '16451', '165', 0, 0, 'nt', 'nt'),
(11, 'Antonio Diego Tomás Martins', 'antoniodiegotmartins_@schaeffler.com', '467,228,008-06', '13.823.883-2', '2017-11-08', 'Casado', '(19)8619-8418', 7489189, '15296', 'Rua Senador Abelardo César 99', 'Centro', '501', '0', 'Banco do Brasil', '1524', '123.487-6', 0, 0, 'ser123', 'joia'),
(12, 'Henry Bryan Mendes', 'henrybryanmendes_@spamgourmet.com', '848,036,838-16', '13.534.898-5', '2017-11-08', '', '(16)5489-1981', 1451, '13995-970', 'Rua Senador Abelardo César 99', 'cea', '296', '15', 'fae', '165', '124', 0, 0, 'ads', 'as'),
(13, 'Tomás Cauê Emanuel', 'tomascaueemanuelpinto_@fabianocosta.com.br', '545,905,668-34', '26.457.148-4', '2017-11-08', 'casad', '(12)4512-4122', 1245, '13995-970', 'Rua Senador Abelardo César 99', 'Centro', '543', '0', 'bb', '124', '412', 0, 0, 'fgsar', 'aerf'),
(14, 'Melissa Ana da Silva', 'melelissaasilva@emcinfo.com.br', '181,041,380-81', '39.125.412-1', '2017-11-08', 'set', '(12)4125-4125', 1566, '13995-970', 'Rua Senador Abelardo', 'Centro', '935', '0', 'bb', '125', '165', 0, 0, 'afghrt', 'vzsd'),
(15, 'Mariane Clara Nina Araújo', 'qwef_@seraobenedito.com.br', '123,456,789-11', '13.202.652-1', '2017-11-08', 'aa', '(12)4215-4125', 1502, '13995-970', 'Rua Senador Ab', 'Centro', '414', '0', 'bb', '16', '1564', 0, 0, 'gaeasc', 'evcc'),
(16, 'Ian Yuri Dias', 'iianyuridias@origamieventos.com.br', '465,125,318-09', '42.642.876-6', '2017-11-08', 'solt', '(19) 983-5300', 24254, '13995-970', 'Rua Senador Abelardo César 99', 'Centro', '423', '14', 'aefg', '134', '142', 0, 0, 'fasr', 'vsd'),
(17, 'Nicolas André Nascimento', 'nnicolasandrenascimento@lonax.net', '111,111,111-11', '1685145', '2017-11-08', 'afef', '(19) 998-3444', 2500, '4135', 'arrr', 'brrr', '16', '0', 'bb', '1561', '1651', 0, 0, 'gvaser', 'grsa52');

-- --------------------------------------------------------

--
-- Estrutura da tabela `motor`
--

CREATE TABLE `motor` (
  `id` int(11) NOT NULL,
  `nome` varchar(32) NOT NULL,
  `litragem` varchar(16) NOT NULL,
  `ano` varchar(4) NOT NULL,
  `cavalos` varchar(8) NOT NULL,
  `preco` double NOT NULL,
  `Removido` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `motor`
--

INSERT INTO `motor` (`id`, `nome`, `litragem`, `ano`, `cavalos`, `preco`, `Removido`) VALUES
(1, '2.0 MSI TURBO', '2.0', '2017', '220', 13000, 0),
(4, '1.0 mi', '1.0', '2015', '89', 2000, 0),
(5, '1.6 MPI', '1.6', '2017', '120', 26000, 0),
(6, 'TYPE BITURBO', '5.2', '2018', '350', 32000, 0),
(7, '1.0 3 cilindros', '1.0', '2017', '90', 0, 0),
(8, '1.6 hyundai', '1.6', '2017', '110', 4000, 0),
(9, '3.3 TURBO DIESEL', '3.3', '2013', '200', 0, 1),
(10, '1.0 Turbo', '1.0', '2017', '130', 10000, 0),
(11, 'nism0 biturbo', '3.5', '2016', '340', 120000, 0),
(12, '2.5 mpi', '2.5', '2015', '140', 25000, 0),
(13, '1.0 turbo MSI', '1.0', '2016', '140', 0, 0),
(14, 'turbo MSI', '1.4', '2017', '170', 10000, 0),
(15, '1.3 x', '1.3', '2015', '100', 0, 0),
(16, '1.8 honda', '1.8', '2017', '160', 0, 0),
(17, '1.8 volks', '160', '2017', '160', 3400, 0),
(18, '1.8 toyota', '1.8', '2017', '160', 0, 0),
(19, '5.2 Turbo', '5.2', '2002', '320', 0, 0),
(20, '3.3 v6', '3.3', '2011', '300', 0, 0),
(21, '1.4 working', '1.4', '2014', '110', 0, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `opcional`
--

CREATE TABLE `opcional` (
  `id` int(11) NOT NULL,
  `nome` varchar(64) NOT NULL,
  `itens` varchar(64) NOT NULL,
  `ano` varchar(8) NOT NULL,
  `preco` double NOT NULL,
  `Removido` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `opcional`
--

INSERT INTO `opcional` (`id`, `nome`, `itens`, `ano`, `preco`, `Removido`) VALUES
(1, 'Trend', 'Vidro e trava eletricos e direção hidraulica', '2010', 1242, 0),
(2, 'Tecnologico', 'multimidia, painel digital', '2016', 1845, 0),
(3, 'raio invocado', 'só um adesivo mesmo', '1965', 500, 1),
(5, 'Terra', 'santo antonio, suspencaoo alta', '2010', 2000, 0),
(6, 'Parking', 'camera de ré, sensor de ré, estacionamento automatico', '2019', 6000, 0),
(7, 'luxo', 'banco de couro, chave canivete', '2016', 4500, 0),
(8, 'vintage', 'leitor de fita', '1990', 80000, 0),
(10, 'segurança', 'alarme, rebatimento de retrovisor', '2016', 2300, 0),
(11, 'esforço zero', 'vidro eletrico, retrovisor eletrico', '2015', 3200, 0),
(12, 'Caminhoneiro', 'antena px', '2000', 1600, 0),
(13, 'tapete', 'tapete de carpete', '2017', 300, 0),
(14, 'botão', 'chave presencial, botão start stop', '2016', 4000, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `id` int(11) NOT NULL,
  `idCliente` int(11) NOT NULL,
  `idVendedor` int(11) NOT NULL,
  `idCarro` int(11) NOT NULL,
  `dataVenda` date NOT NULL,
  `desconto` double NOT NULL,
  `nParcelas` int(11) NOT NULL,
  `juros` double NOT NULL,
  `precoCarro` double NOT NULL,
  `precoTotal` double NOT NULL,
  `Entrada` double NOT NULL,
  `restante` double NOT NULL,
  `precoApagar` double NOT NULL,
  `valParcela` double NOT NULL,
  `Removido` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `venda`
--

INSERT INTO `venda` (`id`, `idCliente`, `idVendedor`, `idCarro`, `dataVenda`, `desconto`, `nParcelas`, `juros`, `precoCarro`, `precoTotal`, `Entrada`, `restante`, `precoApagar`, `valParcela`, `Removido`) VALUES
(3, 3, 4, 12, '2017-11-08', 12, 12, 1, 179080, 204792, 0, 0, 0, 0, 0),
(4, 3, 4, 11, '2017-11-08', 1, 12, 0, 14071, 14753, 0, 0, 0, 0, 0),
(5, 3, 4, 21, '2017-11-08', 1, 20, 0, 39600, 40810, 0, 0, 0, 0, 0),
(6, 3, 4, 24, '2017-11-08', 1, 15, 0, 90926, 93819, 0, 0, 0, 0, 0),
(7, 3, 4, 13, '2017-11-08', 16, 13, 0, 281473, 295662, 0, 0, 0, 0, 0),
(8, 3, 4, 23, '2017-11-08', 1, 16, 1, 54634, 90105, 0, 0, 0, 0, 0),
(9, 3, 4, 24, '2017-11-08', 2, 23, 0, 91686, 96008, 0, 56686, 61008, 2652, 0),
(10, 3, 4, 12, '2017-11-08', 1, 15, 0, 201058, 208259, 0, 188714, 195915, 13061, 0),
(11, 3, 4, 23, '2017-11-08', 2, 25, 3, 79465, 174501, 0, 79341, 174377, 6975, 0),
(12, 3, 4, 10, '2017-11-08', 1, 12, 3, 1980, 2921, 0, 1780, 2721, 226, 0),
(13, 3, 4, 12, '2017-11-08', 1, 12, 1, 201058, 240518, 0, 188058, 227518, 18959, 0),
(14, 3, 4, 21, '2017-11-08', 1, 13, 1, 39520, 47703, 0, 38320, 46503, 3577, 0),
(16, 3, 4, 12, '2017-11-08', 12, 3, 3, 179080, 184573, 0, 49080, 54573, 18191, 0),
(17, 3, 4, 11, '2017-11-08', 1, 20, 1, 14099, 17090, 0, 11099, 14090, 704, 0),
(18, 3, 4, 21, '2017-11-08', 10, 13, 3, 36000, 52699, 0, 33000, 49699, 3823, 0),
(19, 3, 4, 13, '2017-11-08', 12, 13, 6, 293252, 641003, 0, 293251, 641001, 49307, 0),
(20, 3, 4, 21, '2017-11-08', 3, 12, 1, 42680, 47655, 0, 29680, 34655, 2887, 0),
(21, 3, 4, 23, '2017-11-08', 1, 10, 3, 80276, 105184, 0, 67276, 92184, 9218, 0),
(22, 3, 4, 25, '2017-11-08', 0, 12, 2, 30629, 30629, 0, 25629, 25629, 2135, 0),
(23, 16, 15, 44, '2017-11-08', 0, 12, 3, 53892, 53892, 0, 21892, 21892, 1824, 0),
(24, 18, 17, 32, '2017-11-08', 0, 16, 3, 81916, 81916, 0, 68916, 68916, 4307, 0),
(25, 18, 15, 38, '2017-11-08', 0, 13, 3, 125840, 125840, 0, 65840, 65840, 5064, 0),
(26, 18, 17, 34, '2017-11-08', 0, 16, 3, 33139, 33139, 0, 30917, 30917, 1932, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendamotor`
--

CREATE TABLE `vendamotor` (
  `idvenda` int(11) NOT NULL,
  `idmotor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `vendamotor`
--

INSERT INTO `vendamotor` (`idvenda`, `idmotor`) VALUES
(5, 7),
(6, 9),
(7, 6),
(8, 4),
(9, 9),
(10, 1),
(11, 5),
(12, 4),
(13, 1),
(14, 7),
(16, 1),
(17, 1),
(18, 7),
(19, 6),
(20, 8),
(21, 5),
(22, 4),
(23, 5),
(25, 19),
(26, 13);

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendaopcionais`
--

CREATE TABLE `vendaopcionais` (
  `idvenda` int(11) NOT NULL,
  `idopcional` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `vendaopcionais`
--

INSERT INTO `vendaopcionais` (`idvenda`, `idopcional`) VALUES
(8, 1),
(9, 2),
(9, 5),
(10, 3),
(11, 1),
(11, 2),
(13, 3),
(16, 3),
(17, 1),
(19, 1),
(21, 1),
(21, 2),
(22, 1),
(23, 1),
(24, 1),
(24, 2),
(26, 1),
(26, 10);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `carro`
--
ALTER TABLE `carro`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `carromotor`
--
ALTER TABLE `carromotor`
  ADD PRIMARY KEY (`idcarro`,`idmotor`);

--
-- Indexes for table `carroopcional`
--
ALTER TABLE `carroopcional`
  ADD PRIMARY KEY (`idcarro`,`idopcional`);

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `motor`
--
ALTER TABLE `motor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `opcional`
--
ALTER TABLE `opcional`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `vendamotor`
--
ALTER TABLE `vendamotor`
  ADD KEY `id_fk_motor` (`idmotor`),
  ADD KEY `id_fk_venda` (`idvenda`);

--
-- Indexes for table `vendaopcionais`
--
ALTER TABLE `vendaopcionais`
  ADD KEY `id_fk_vendaop` (`idvenda`),
  ADD KEY `id_fk_vendao` (`idopcional`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `carro`
--
ALTER TABLE `carro`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `motor`
--
ALTER TABLE `motor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `opcional`
--
ALTER TABLE `opcional`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `venda`
--
ALTER TABLE `venda`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `vendamotor`
--
ALTER TABLE `vendamotor`
  ADD CONSTRAINT `id_fk_motor` FOREIGN KEY (`idmotor`) REFERENCES `motor` (`id`),
  ADD CONSTRAINT `id_fk_venda` FOREIGN KEY (`idvenda`) REFERENCES `venda` (`id`);

--
-- Limitadores para a tabela `vendaopcionais`
--
ALTER TABLE `vendaopcionais`
  ADD CONSTRAINT `id_fk_vendao` FOREIGN KEY (`idopcional`) REFERENCES `opcional` (`id`),
  ADD CONSTRAINT `id_fk_vendaop` FOREIGN KEY (`idvenda`) REFERENCES `venda` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

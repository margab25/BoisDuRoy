-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : sam. 24 juin 2023 à 14:48
-- Version du serveur : 10.4.24-MariaDB
-- Version de PHP : 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bois`
--

-- --------------------------------------------------------

--
-- Structure de la table `demande`
--

CREATE TABLE `demande` (
  `id_demande` int(11) NOT NULL,
  `nb_rtt` decimal(4,2) DEFAULT NULL,
  `nb_cp` decimal(4,2) DEFAULT NULL,
  `date_debut` date NOT NULL,
  `date_fin` date NOT NULL,
  `date_envoi` date NOT NULL,
  `motif_refus` text DEFAULT NULL,
  `id_statut` int(11) NOT NULL,
  `matricule_emp` char(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `demande`
--

INSERT INTO `demande` (`id_demande`, `nb_rtt`, `nb_cp`, `date_debut`, `date_fin`, `date_envoi`, `motif_refus`, `id_statut`, `matricule_emp`) VALUES
(1, '0.50', '0.00', '2023-02-02', '2023-02-02', '2023-01-06', NULL, 2, 'E4231'),
(2, '0.50', '0.00', '2023-03-27', '2023-03-27', '2023-01-21', NULL, 3, 'E4233'),
(3, '1.00', '0.00', '2023-02-06', '2023-02-06', '2023-01-15', 'csc', 1, 'E4234'),
(4, '0.50', '0.00', '2023-02-04', '2023-02-04', '2023-01-12', NULL, 2, 'E4238'),
(5, '0.50', '0.00', '2023-02-20', '2023-02-20', '2023-01-01', NULL, 2, 'E4235'),
(6, '1.00', '0.00', '2023-07-17', '2023-07-17', '2023-01-16', 'papa apap', 1, 'E4235'),
(7, '1.00', '0.00', '2023-07-31', '2023-07-31', '2023-01-26', NULL, 3, 'E4235'),
(8, '1.00', '0.00', '2023-09-12', '2023-09-12', '2023-01-19', NULL, 3, 'E4232'),
(9, '1.00', '0.00', '2023-09-30', '2023-09-30', '2023-01-04', NULL, 2, 'E4232'),
(10, '0.00', '3.00', '2023-02-02', '2023-02-04', '2023-01-15', 'cs', 1, 'E4230'),
(11, '0.00', '5.00', '2023-03-20', '2023-03-24', '2023-01-17', NULL, 3, 'E4233'),
(12, '0.00', '5.00', '2023-02-06', '2023-02-10', '2023-01-25', NULL, 3, 'E4236'),
(13, '0.00', '0.50', '2023-02-04', '2023-02-04', '2023-01-26', NULL, 3, 'E4238'),
(14, '0.00', '3.50', '2023-02-20', '2023-02-23', '2023-01-22', NULL, 3, 'E4238'),
(15, '0.00', '5.00', '2023-07-17', '2023-07-21', '2023-01-11', NULL, 2, 'E4234'),
(16, '0.00', '5.00', '2023-07-24', '2023-07-28', '2023-01-10', NULL, 2, 'E4234'),
(17, '0.00', '5.00', '2023-07-24', '2023-07-28', '2023-01-02', NULL, 2, 'E4232'),
(18, '0.00', '5.00', '2023-07-31', '2023-08-04', '2023-01-30', NULL, 3, 'E4232'),
(19, '24.50', '0.50', '2023-05-11', '2023-05-03', '2023-05-07', NULL, 1, 'E4233'),
(23, '0.00', '20.00', '2023-05-25', '2023-05-18', '2023-05-07', NULL, 1, 'E4233'),
(24, '0.00', '20.00', '2023-05-25', '2023-05-18', '2023-05-07', NULL, 1, 'E4233'),
(28, '0.00', '0.50', '2023-05-01', '2023-05-01', '2023-05-07', NULL, 1, 'E4233'),
(29, '0.00', '2.00', '2023-05-01', '2023-05-03', '2023-05-07', NULL, 1, 'E4233'),
(30, '0.00', '2.00', '2023-05-03', '2023-05-05', '2023-05-07', NULL, 1, 'E4233'),
(31, '0.00', '2.00', '2023-05-11', '2023-05-13', '2023-05-07', NULL, 3, 'E4233');

-- --------------------------------------------------------

--
-- Structure de la table `employe`
--

CREATE TABLE `employe` (
  `matricule_emp` char(5) NOT NULL,
  `mail_emp` varchar(50) NOT NULL,
  `tel_emp` char(5) NOT NULL,
  `num_secu_emp` char(16) NOT NULL,
  `date_emb_emp` date NOT NULL,
  `date_naiss_emp` date NOT NULL,
  `mdp_emp` varchar(255) NOT NULL,
  `nom_emp` varchar(50) NOT NULL,
  `prenom_emp` varchar(50) NOT NULL,
  `id_fonction` int(11) NOT NULL,
  `id_service` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `employe`
--

INSERT INTO `employe` (`matricule_emp`, `mail_emp`, `tel_emp`, `num_secu_emp`, `date_emb_emp`, `date_naiss_emp`, `mdp_emp`, `nom_emp`, `prenom_emp`, `id_fonction`, `id_service`) VALUES
('E4230', 'MDupont@broy.com', '21230', '1801149491883 25', '2005-11-13', '1980-11-12', '*8CB2919E204A412AFDA2883ABF4B5149D0DD0A8D', 'Dupont', 'Martin', 1, 1),
('E4231', 'KDubois@broy.com', '21231', '2870449491932 72', '2010-04-15', '1987-04-05', '', 'Dubois', 'Karine', 2, 2),
('E4232', 'MSimon@broy.com', '21232', '1900949491602 11', '2012-08-15', '1990-09-04', '*D1B32BCD7211FB1B9872AEA8411D784063D1494D', 'Simon', 'Marcel', 1, 1),
('E4233', 'CCuistot@broy.com', '21233', '2721249491420 08', '2001-01-15', '1972-12-05', '*700EE6DC628C436D1379856AC64D8B97D9876359', 'Cuistot', 'Corine', 3, 3),
('E4234', 'JMarquerie@broy.com', '21234', '1981249491332 54', '2020-12-01', '1998-12-02', '*4ED24F061520719054D6C146DC62F52CF484F3B2', 'Marquerie', 'Jean', 1, 1),
('E4235', 'JFrémond@broy.com', '21235', '2890949491138 52', '2005-09-02', '1989-09-02', '*3EF9E27109B910BBF8223205CE3A177F3994E71B', 'Frémond', 'Julie', 4, 4),
('E4236', 'MBreger@broy.com', '21236', '2861149491870 06', '2000-05-12', '1986-11-12', '*DE0709AEB91DA52B7625DD08496873CF1C24601F', 'Breger', 'Mathilde', 1, 1),
('E4237', 'CMonsard@broy.com', '21237', '2000149491101 56', '2022-01-12', '2000-01-12', '*AE1AE1D27F03925B3002043ADB04336B6FAC0DFF', 'Monsard', 'Camille', 5, 5),
('E4238', 'TLiothard@broy.com', '21238', '1020549491006 12', '2019-06-02', '2002-05-29', '*A55CD691341E8148552AEC373246801AB9417213', 'Liohthard', 'Thibault', 6, 6),
('E4239', 'KGrasset@broy.com', '21239', '1011249491666 63', '2020-12-12', '2001-07-06', '*6E326187604C68BE929F0D41D7C05E92379F2200', 'Grasset', 'Kevin', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `etat`
--

CREATE TABLE `etat` (
  `id_etat_conge` int(11) NOT NULL,
  `annee_conge` date NOT NULL,
  `cp_acquis` decimal(4,2) DEFAULT NULL,
  `cp_restant` decimal(4,2) DEFAULT NULL,
  `rtt_acquis` decimal(4,2) DEFAULT NULL,
  `rtt_restant` decimal(4,2) DEFAULT NULL,
  `matricule_emp` char(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `etat`
--

INSERT INTO `etat` (`id_etat_conge`, `annee_conge`, `cp_acquis`, `cp_restant`, `rtt_acquis`, `rtt_restant`, `matricule_emp`) VALUES
(1, '2023-01-01', '25.00', '22.00', '1.00', '1.00', 'E4230'),
(2, '2023-01-01', '25.00', '25.00', '2.00', '1.50', 'E4231'),
(3, '2023-01-01', '25.00', '10.00', '3.00', '0.00', 'E4232'),
(4, '2023-01-01', '25.00', '20.00', '1.00', '0.50', 'E4233'),
(5, '2023-01-01', '25.00', '5.00', '1.00', '0.00', 'E4234'),
(6, '2023-01-01', '25.00', '25.00', '5.00', '2.50', 'E4235'),
(7, '2023-01-01', '25.00', '20.00', '1.00', '1.00', 'E4236'),
(8, '2023-01-01', '0.00', '0.00', '5.00', '5.00', 'E4237'),
(9, '2023-01-01', '25.00', '21.00', '8.00', '7.50', 'E4238'),
(10, '2023-01-01', '25.00', '25.00', '1.00', '1.00', 'E4239');

-- --------------------------------------------------------

--
-- Structure de la table `fonction`
--

CREATE TABLE `fonction` (
  `id_fonction` int(11) NOT NULL,
  `nom_fonction` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `fonction`
--

INSERT INTO `fonction` (`id_fonction`, `nom_fonction`) VALUES
(1, 'Menuisier'),
(2, 'Agent de maintenance'),
(3, 'Agent de traitement'),
(4, 'Controleur qualité'),
(5, 'Directrice des ressources humaines'),
(6, 'Responsable informatique');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

CREATE TABLE `service` (
  `id_service` int(11) NOT NULL,
  `nom_service` varchar(50) NOT NULL,
  `responsable_service` char(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`id_service`, `nom_service`, `responsable_service`) VALUES
(1, 'Production', 'E4232'),
(2, 'Entretien', 'E4237'),
(3, 'Expédition', 'E4237'),
(4, 'Qualité', 'E4237'),
(5, 'RH', 'E4237'),
(6, 'DSI', 'E4237');

-- --------------------------------------------------------

--
-- Structure de la table `statut`
--

CREATE TABLE `statut` (
  `id_statut` int(11) NOT NULL,
  `nom_statut` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `statut`
--

INSERT INTO `statut` (`id_statut`, `nom_statut`) VALUES
(1, 'Refusé'),
(2, 'Validé'),
(3, 'En cours');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `demande`
--
ALTER TABLE `demande`
  ADD PRIMARY KEY (`id_demande`),
  ADD KEY `id_statut` (`id_statut`),
  ADD KEY `matricule_emp` (`matricule_emp`);

--
-- Index pour la table `employe`
--
ALTER TABLE `employe`
  ADD PRIMARY KEY (`matricule_emp`),
  ADD KEY `id_fonction` (`id_fonction`),
  ADD KEY `id_service` (`id_service`);

--
-- Index pour la table `etat`
--
ALTER TABLE `etat`
  ADD PRIMARY KEY (`id_etat_conge`),
  ADD KEY `matricule_emp` (`matricule_emp`);

--
-- Index pour la table `fonction`
--
ALTER TABLE `fonction`
  ADD PRIMARY KEY (`id_fonction`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`id_service`);

--
-- Index pour la table `statut`
--
ALTER TABLE `statut`
  ADD PRIMARY KEY (`id_statut`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `demande`
--
ALTER TABLE `demande`
  MODIFY `id_demande` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT pour la table `etat`
--
ALTER TABLE `etat`
  MODIFY `id_etat_conge` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `fonction`
--
ALTER TABLE `fonction`
  MODIFY `id_fonction` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `service`
--
ALTER TABLE `service`
  MODIFY `id_service` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `statut`
--
ALTER TABLE `statut`
  MODIFY `id_statut` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `demande`
--
ALTER TABLE `demande`
  ADD CONSTRAINT `demande_ibfk_1` FOREIGN KEY (`id_statut`) REFERENCES `statut` (`id_statut`),
  ADD CONSTRAINT `demande_ibfk_2` FOREIGN KEY (`matricule_emp`) REFERENCES `employe` (`matricule_emp`);

--
-- Contraintes pour la table `employe`
--
ALTER TABLE `employe`
  ADD CONSTRAINT `employe_ibfk_1` FOREIGN KEY (`id_fonction`) REFERENCES `fonction` (`id_fonction`),
  ADD CONSTRAINT `employe_ibfk_2` FOREIGN KEY (`id_service`) REFERENCES `service` (`id_service`);

--
-- Contraintes pour la table `etat`
--
ALTER TABLE `etat`
  ADD CONSTRAINT `etat_ibfk_1` FOREIGN KEY (`matricule_emp`) REFERENCES `employe` (`matricule_emp`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

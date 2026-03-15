-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: quiz_game
-- ------------------------------------------------------
-- Server version	8.0.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `id_categoria` int NOT NULL AUTO_INCREMENT,
  `nombre_categoria` varchar(45) NOT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Historia'),(2,'Literatura'),(3,'Música'),(4,'Astronomía'),(5,'Tecnología');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partida`
--

DROP TABLE IF EXISTS `partida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partida` (
  `id_partida` int NOT NULL AUTO_INCREMENT,
  `id_categoria` int NOT NULL,
  `puntaje_final` int NOT NULL,
  `fecha` datetime DEFAULT NULL,
  PRIMARY KEY (`id_partida`),
  KEY `fk_categoria_idx` (`id_categoria`),
  CONSTRAINT `fk_categoria` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id_categoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partida`
--

LOCK TABLES `partida` WRITE;
/*!40000 ALTER TABLE `partida` DISABLE KEYS */;
/*!40000 ALTER TABLE `partida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partida_detalle`
--

DROP TABLE IF EXISTS `partida_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partida_detalle` (
  `id_detalle` int NOT NULL AUTO_INCREMENT,
  `id_partida` int NOT NULL,
  `id_pregunta` int NOT NULL,
  `fue_correcta` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_detalle`),
  KEY `id_partida` (`id_partida`),
  KEY `id_pregunta` (`id_pregunta`),
  CONSTRAINT `partida_detalle_ibfk_1` FOREIGN KEY (`id_partida`) REFERENCES `partida` (`id_partida`) ON DELETE CASCADE,
  CONSTRAINT `partida_detalle_ibfk_2` FOREIGN KEY (`id_pregunta`) REFERENCES `pregunta` (`id_pregunta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partida_detalle`
--

LOCK TABLES `partida_detalle` WRITE;
/*!40000 ALTER TABLE `partida_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `partida_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pregunta`
--

DROP TABLE IF EXISTS `pregunta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pregunta` (
  `id_pregunta` int NOT NULL AUTO_INCREMENT,
  `id_categoria` int NOT NULL,
  `texto_pregunta` varchar(455) DEFAULT NULL,
  `tipo_respuesta` enum('texto','imagen') NOT NULL,
  PRIMARY KEY (`id_pregunta`),
  KEY `fk_pregunta_categoria_idx` (`id_categoria`),
  CONSTRAINT `fk_pregunta_categoria` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pregunta`
--

LOCK TABLES `pregunta` WRITE;
/*!40000 ALTER TABLE `pregunta` DISABLE KEYS */;
INSERT INTO `pregunta` VALUES (1,1,'¿En qué año comenzó la Segunda Guerra Mundial?','texto'),(2,1,'¿Quién fue el primer presidente de México?','texto'),(3,1,'¿Qué cultura mesoamericana es famosa por sus calendarios avanzados?','texto'),(4,1,'¿Quién fue el primer hombre en pisar la luna en 1969?','texto'),(5,1,'¿En qué año descubrió América Cristóbal Colón?','texto'),(6,1,'¿Qué imagen muestra a Nelson Mandela?','imagen'),(7,1,'¿Qué imagen corresponde al sacerdote que dio el Grito de Independencia en 1810?','imagen'),(8,1,'¿Quién era el presidente de México en 2010?','imagen'),(9,1,'¿Quién fue el líder de Alemania durante la Segunda Guerra Mundial?','imagen'),(10,1,'¿Cuál de estas pirámides es la Pirámide del Sol?','imagen'),(11,2,NULL,'texto'),(12,2,NULL,'texto'),(13,2,NULL,'texto'),(14,2,NULL,'texto'),(15,2,NULL,'texto'),(16,2,NULL,'imagen'),(17,2,NULL,'imagen'),(18,2,NULL,'imagen'),(19,2,NULL,'imagen'),(20,2,NULL,'imagen'),(21,3,'¿Qué cantante es conocido como “El rey del pop”?','texto'),(22,3,'¿Qué banda británica interpretó la canción Bohemian Rhapsody?','texto'),(23,3,'¿Quién compuso La Quinta Sinfonía?','texto'),(24,3,'¿Qué cantante dominicano es conocido como El Rey de la Bachata?','texto'),(25,3,'¿Qué artista cantó Despacito?','texto'),(26,3,'¿Quién fue el artista principal del Super Bowl 2021?','imagen'),(27,3,'¿Cuál de estos instrumentos pertenece a la música clásica?','imagen'),(28,3,'¿Qué artista se hizo famoso con la canción La Bicicleta?','imagen'),(29,3,'¿Cuál portada corresponde al álbum El Último Tour Del Mundo?','imagen'),(30,3,'¿Quién cantó Waka Waka en el Mundial 2010?','imagen'),(31,4,'¿Cuál es el planeta más grande del sistema solar?','texto'),(32,4,'¿Cuál es el planeta más cercano al Sol?','texto'),(33,4,'¿Cuál es el planeta más lejano del Sol?','texto'),(34,4,'¿Cuál es el sexto planeta desde el Sol?','texto'),(35,4,'¿Cuál es el satélite natural de la Tierra?','texto'),(36,4,'¿Qué imagen corresponde al planeta más grande del sistema solar?','imagen'),(37,4,'¿Cuál de estas imágenes corresponde a la superficie de Mercurio?','imagen'),(38,4,'¿Qué imagen corresponde a nuestra galaxia?','imagen'),(39,4,'¿Qué imagen corresponde al tercer planeta desde el Sol?','imagen'),(40,4,'¿Cuál fase de la Luna se llama cuarto menguante?','imagen'),(41,5,'¿Qué significa RAM?','texto'),(42,5,'¿Quién fabrica las tarjetas gráficas Radeon?','texto'),(43,5,'¿Cuál fue la primera red social importante?','texto'),(44,5,'¿Qué lenguaje se usa para apps iOS?','texto'),(45,5,'¿Quién es el padre de la computación?','texto'),(46,5,'¿Cuál logo corresponde al segundo logo de Apple?','imagen'),(47,5,'¿Cuál empresa NO fabrica CPU?','imagen'),(48,5,'¿Quién es el CEO actual de Apple?','imagen'),(49,5,'¿Qué plataforma popularizó videos de 6 segundos?','imagen'),(50,5,'¿Quién fundó Nvidia?','imagen');
/*!40000 ALTER TABLE `pregunta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `respuesta`
--

DROP TABLE IF EXISTS `respuesta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `respuesta` (
  `id_respuesta` int NOT NULL AUTO_INCREMENT,
  `id_pregunta` int NOT NULL,
  `texto_respuesta` varchar(255) DEFAULT NULL,
  `ruta_imagen` varchar(255) DEFAULT NULL,
  `es_correcta` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_respuesta`),
  KEY `id_pregunta` (`id_pregunta`),
  CONSTRAINT `respuesta_ibfk_1` FOREIGN KEY (`id_pregunta`) REFERENCES `pregunta` (`id_pregunta`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=201 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `respuesta`
--

LOCK TABLES `respuesta` WRITE;
/*!40000 ALTER TABLE `respuesta` DISABLE KEYS */;
INSERT INTO `respuesta` VALUES (1,1,'1945',NULL,0),(2,1,'1935',NULL,0),(3,1,'1939',NULL,1),(4,1,'1941',NULL,0),(5,2,'Benito Juárez',NULL,0),(6,2,'Porfirio Díaz',NULL,0),(7,2,'Vicente Guerrero',NULL,0),(8,2,'Guadalupe Victoria',NULL,1),(9,3,'Azteca',NULL,0),(10,3,'Maya',NULL,1),(11,3,'Tolteca',NULL,0),(12,3,'Zapoteca',NULL,0),(13,4,'Yuri Gagarin',NULL,0),(14,4,'Buzz Aldrin',NULL,0),(15,4,'Neil Armstrong',NULL,1),(16,4,'Alan Shepard',NULL,0),(17,5,'1482',NULL,0),(18,5,'1492',NULL,1),(19,5,'1502',NULL,0),(20,5,'1495',NULL,0),(21,6,'',NULL,0),(22,6,'',NULL,0),(23,6,'',NULL,0),(24,6,'',NULL,0),(25,7,'',NULL,0),(26,7,'',NULL,0),(27,7,'',NULL,0),(28,7,'',NULL,0),(29,8,'',NULL,0),(30,8,'',NULL,0),(31,8,'',NULL,0),(32,8,'',NULL,0),(33,9,'',NULL,0),(34,9,'',NULL,0),(35,9,'',NULL,0),(36,9,'',NULL,0),(37,10,'',NULL,0),(38,10,'',NULL,0),(39,10,'',NULL,0),(40,10,'',NULL,0),(41,11,'',NULL,0),(42,11,'',NULL,0),(43,11,'',NULL,0),(44,11,'',NULL,0),(45,12,'',NULL,0),(46,12,'',NULL,0),(47,12,'',NULL,0),(48,12,'',NULL,0),(49,13,'',NULL,0),(50,13,'',NULL,0),(51,13,'',NULL,0),(52,13,'',NULL,0),(53,14,'',NULL,0),(54,14,'',NULL,0),(55,14,'',NULL,0),(56,14,'',NULL,0),(57,15,'',NULL,0),(58,15,'',NULL,0),(59,15,'',NULL,0),(60,15,'',NULL,0),(61,16,'',NULL,0),(62,16,'',NULL,0),(63,16,'',NULL,0),(64,16,'',NULL,0),(65,17,'',NULL,0),(66,17,'',NULL,0),(67,17,'',NULL,0),(68,17,'',NULL,0),(69,18,'',NULL,0),(70,18,'',NULL,0),(71,18,'',NULL,0),(72,18,'',NULL,0),(73,19,'',NULL,0),(74,19,'',NULL,0),(75,19,'',NULL,0),(76,19,'',NULL,0),(77,20,'',NULL,0),(78,20,'',NULL,0),(79,20,'',NULL,0),(80,20,'',NULL,0),(81,21,'Elvis Presley',NULL,0),(82,21,'Prince Royce',NULL,0),(83,21,'Michael Jackson',NULL,1),(84,21,'Justin Timberlake',NULL,0),(85,22,'The Beatles',NULL,0),(86,22,'Queen',NULL,1),(87,22,'The Who',NULL,0),(88,22,'Oasis',NULL,0),(89,23,'Wolfgang Amadeus Mozart',NULL,0),(90,23,'Johann Sebastian Bach',NULL,0),(91,23,'Ludwig van Beethoven',NULL,1),(92,23,'Franz Schubert',NULL,0),(93,24,'Eminem',NULL,1),(94,24,'50 Cent',NULL,0),(95,24,'Dr. Dre',NULL,0),(96,24,'Snoop Dogg',NULL,0),(97,25,'Prince Royce',NULL,0),(98,25,'Romeo Santos',NULL,1),(99,25,'Juan Luis Guerra',NULL,0),(100,25,'Frank Reyes',NULL,0),(101,26,'',NULL,0),(102,26,'',NULL,0),(103,26,'',NULL,0),(104,26,'',NULL,0),(105,27,'',NULL,0),(106,27,'',NULL,0),(107,27,'',NULL,0),(108,27,'',NULL,0),(109,28,'',NULL,0),(110,28,'',NULL,0),(111,28,'',NULL,0),(112,28,'',NULL,0),(113,29,'',NULL,0),(114,29,'',NULL,0),(115,29,'',NULL,0),(116,29,'',NULL,0),(117,30,'',NULL,0),(118,30,'',NULL,0),(119,30,'',NULL,0),(120,30,'',NULL,0),(121,31,'Saturno',NULL,0),(122,31,'Urano',NULL,0),(123,31,'Neptuno',NULL,0),(124,31,'Júpiter',NULL,1),(125,32,'Venus',NULL,0),(126,32,'Tierra',NULL,0),(127,32,'Mercurio',NULL,1),(128,32,'Marte',NULL,0),(129,33,'Neptuno',NULL,1),(130,33,'Saturno',NULL,0),(131,33,'Urano',NULL,0),(132,33,'Júpiter',NULL,0),(133,34,'Júpiter',NULL,0),(134,34,'Saturno',NULL,1),(135,34,'Urano',NULL,0),(136,34,'Neptuno',NULL,0),(137,35,'Andrómeda',NULL,0),(138,35,'La Luna',NULL,1),(139,35,'Sirio',NULL,0),(140,35,'Vía Láctea',NULL,0),(141,36,'',NULL,0),(142,36,'',NULL,0),(143,36,'',NULL,0),(144,36,'',NULL,0),(145,37,'',NULL,0),(146,37,'',NULL,0),(147,37,'',NULL,0),(148,37,'',NULL,0),(149,38,'',NULL,0),(150,38,'',NULL,0),(151,38,'',NULL,0),(152,38,'',NULL,0),(153,39,'',NULL,0),(154,39,'',NULL,0),(155,39,'',NULL,0),(156,39,'',NULL,0),(157,40,'',NULL,0),(158,40,'',NULL,0),(159,40,'',NULL,0),(160,40,'',NULL,0),(161,41,'Random Access Memory',NULL,1),(162,41,'Rapid Access Machine',NULL,0),(163,41,'Read Access Memory',NULL,0),(164,41,'Real Application Memory',NULL,0),(165,42,'Intel',NULL,0),(166,42,'Nvidia',NULL,0),(167,42,'AMD',NULL,1),(168,42,'Qualcomm',NULL,0),(169,43,'Facebook',NULL,0),(170,43,'MySpace',NULL,1),(171,43,'Twitter',NULL,0),(172,43,'LinkedIn',NULL,0),(173,44,'Python',NULL,0),(174,44,'Java',NULL,0),(175,44,'Swift',NULL,1),(176,44,'Ruby',NULL,0),(177,45,'Alan Turing',NULL,1),(178,45,'Bill Gates',NULL,0),(179,45,'Steve Jobs',NULL,0),(180,45,'Charles Babbage',NULL,0),(181,46,'',NULL,0),(182,46,'',NULL,0),(183,46,'',NULL,0),(184,46,'',NULL,0),(185,47,'',NULL,0),(186,47,'',NULL,0),(187,47,'',NULL,0),(188,47,'',NULL,0),(189,48,'',NULL,0),(190,48,'',NULL,0),(191,48,'',NULL,0),(192,48,'',NULL,0),(193,49,'',NULL,0),(194,49,'',NULL,0),(195,49,'',NULL,0),(196,49,'',NULL,0),(197,50,'',NULL,0),(198,50,'',NULL,0),(199,50,'',NULL,0),(200,50,'',NULL,0);
/*!40000 ALTER TABLE `respuesta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-03-14 17:35:26

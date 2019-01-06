-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: shop_dathao
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `loai_hang_hoa`
--

DROP TABLE IF EXISTS `loai_hang_hoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `loai_hang_hoa` (
  `idloai_hang_hoa` int(11) NOT NULL AUTO_INCREMENT,
  `ten_loai_hang_hoa` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idloai_hang_hoa`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loai_hang_hoa`
--

LOCK TABLES `loai_hang_hoa` WRITE;
/*!40000 ALTER TABLE `loai_hang_hoa` DISABLE KEYS */;
INSERT INTO `loai_hang_hoa` VALUES (1,'Meeveo'),(2,'Quire'),(3,'Youspan'),(4,'Viva'),(5,'Quimm'),(6,'Devshare'),(7,'Twitterwire'),(8,'Cogibox'),(9,'Quimm'),(10,'Thoughtbeat'),(11,'Mydeo'),(12,'Skimia'),(13,'Wikivu'),(14,'Gabtype'),(15,'Gigashots'),(16,'Feednation'),(17,'Browsedrive'),(18,'Oloo'),(19,'Jabberbean'),(20,'Zoomzone'),(21,'Twitterwire'),(22,'Kwideo'),(23,'Reallinks'),(24,'Tagchat'),(25,'Jaxworks'),(26,'Innotype'),(27,'Linkbridge'),(28,'Oozz'),(29,'Youfeed'),(30,'Jetpulse'),(31,'Realpoint'),(32,'Twimm'),(33,'Janyx'),(34,'Oyoyo'),(35,'Realcube'),(36,'Npath'),(37,'Fanoodle'),(38,'Lazz'),(39,'Kimia'),(40,'Rhybox'),(41,'Quaxo'),(42,'Einti'),(43,'Edgetag'),(44,'Plajo'),(45,'Buzzshare'),(46,'Ailane'),(47,'Avaveo'),(48,'Twitterbeat'),(49,'Kanoodle'),(50,'Jayo');
/*!40000 ALTER TABLE `loai_hang_hoa` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-06 21:43:57

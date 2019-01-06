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
-- Table structure for table `khach_hang`
--

DROP TABLE IF EXISTS `khach_hang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `khach_hang` (
  `idkhach_hang` int(11) NOT NULL,
  `ten_khach_hang` varchar(45) NOT NULL,
  `sdt` varchar(45) NOT NULL,
  `gioi_tinh` varchar(45) NOT NULL,
  `diem_tich_luy` int(11) NOT NULL DEFAULT '0',
  `cmnd` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idkhach_hang`),
  UNIQUE KEY `cmnd_UNIQUE` (`cmnd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khach_hang`
--

LOCK TABLES `khach_hang` WRITE;
/*!40000 ALTER TABLE `khach_hang` DISABLE KEYS */;
INSERT INTO `khach_hang` VALUES (0,'Khách lẻ','null','null',0,'null'),(2,'Idaline Leonida','19750312','Nữ',110,'951698075'),(3,'Amalita Tiery','19800821','Nam',499,'843933767'),(4,'Horatius Gianotti','19840802','Nam',278,'627481090'),(5,'Deni Klein','19800619','Nam',267,'453744424'),(6,'Cathrin Dietmar','19810907','Nam',417,'186828009'),(7,'Sam Hawtrey','19840131','Nữ',366,'355707508'),(8,'Netta Franckton','19800210','Nữ',422,'624021969'),(9,'Latashia Dyka','19760810','Nam',108,'640175420'),(10,'Nonie Swettenham','19761015','Nam',415,'775443500'),(11,'Elmore Jacquemy','19700314','Nam',423,'503654604'),(12,'Dennet Trembey','19840227','Nữ',261,'310277630'),(13,'Ynez Hastler','19760803','Nam',79,'438677525'),(14,'Hortense Klulisek','19780126','Nữ',19,'990959680'),(15,'Aloisia Jose','19700501','Nữ',27,'667219498'),(16,'Kaitlynn Fairbrace','19700919','Nam',122,'604718180'),(17,'Nertie McAllen','19830319','Nam',218,'901686586'),(18,'Neala Kimblen','19840824','Nam',183,'322940644'),(19,'Isidro Sedgebeer','19780618','Nữ',404,'890454400'),(20,'Berta Chiommienti','19830625','Nữ',272,'467757287'),(21,'Jacklin Anglim','19810817','Nam',436,'243434575'),(22,'Gay Anglin','19840405','Nam',267,'239023393'),(23,'Rosella Van Geffen','19750321','Nữ',210,'352910659'),(24,'Doreen Zambon','19751105','Nữ',82,'162472093'),(25,'Carey Stebbings','19831016','Nữ',169,'634372397'),(26,'Aloisia Rudman','19830105','Nam',74,'113065835'),(27,'Tiena Errichi','19810116','Nam',340,'770105962'),(28,'Tabatha Sellers','19790426','Nữ',40,'313431840'),(29,'Estrella Kebell','19810807','Nam',138,'723612176'),(30,'Spense Ionnidis','19830607','Nam',423,'302675561'),(31,'Wendall Menauteau','19830605','Nữ',215,'267482746'),(32,'Debbie Hassard','19710128','Nữ',332,'767356170'),(33,'Odele Morforth','19770702','Nữ',113,'434474239'),(34,'Wilma Fones','19740817','Nữ',353,'447188787'),(35,'Leland Katt','19750522','Nữ',26,'682220764'),(36,'Atlante Gori','19791021','Nam',97,'210744502'),(37,'Corette Cosgrive','19800622','Nữ',119,'304642509'),(38,'Isaac Woodcock','19840504','Nam',120,'938255775'),(39,'Allen Calton','19840917','Nam',129,'216458555'),(40,'Amalia Kirkpatrick','19801217','Nữ',426,'147295622'),(41,'Carlota Treacher','19700703','Nữ',160,'671556318'),(42,'Carline Salmond','19750916','Nữ',89,'688101926'),(43,'Harriett Bergstrand','19740426','Nữ',35,'442914806'),(44,'Anneliese De la Harpe','19731220','Nam',147,'753072671'),(45,'Cally Levesley','19831013','Nam',109,'499990774'),(46,'Hughie Hartmann','19791030','Nữ',413,'540328611'),(47,'Alejandra Hunter','19830125','Nam',448,'358513143'),(48,'Vanya Yalden','19801105','Nữ',48,'697523502'),(49,'Berta Corstorphine','19770526','Nữ',44,'686486974'),(50,'Dulcea Lesser','19730124','Nữ',439,'584180187'),(51,'Morissa Valerius','19770217','Nam',331,'142526191'),(52,'Goldarina Heatherington','19760102','Nam',90,'428744401'),(53,'Randa Danovich','19741027','Nam',286,'920070139'),(54,'Ingrim Stidever','19800205','Nam',304,'384774265'),(55,'Markos O\'Lagen','19800104','Nữ',84,'796730411'),(56,'Ulysses Pyffe','19780404','Nữ',320,'259467183'),(57,'Morrie MacInnes','19821213','Nữ',449,'117250669'),(58,'Eula Zanotti','19810408','Nữ',240,'141373281'),(59,'Ulrike Sapwell','19730528','Nam',349,'450366037'),(60,'Myrvyn Leyband','19760706','Nam',425,'413655457'),(61,'Dayna Gillbey','19700828','Nam',249,'306957223'),(62,'Cleon Dilrew','19701224','Nam',139,'373223369'),(63,'Quintina Rebillard','19740204','Nam',432,'272943482'),(64,'Vladimir Philippart','19710819','Nam',222,'794357281'),(65,'Hetti Leddy','19840428','Nữ',426,'892153116'),(66,'Brianna Truman','19810207','Nam',116,'419934497'),(67,'Hayley Russen','19710902','Nam',200,'525565256'),(68,'Delbert Ivanilov','19700419','Nữ',49,'157389051'),(69,'York Sherewood','19740403','Nam',324,'731783264'),(70,'Joeann Goult','19720711','Nữ',103,'658631050'),(71,'Wendall Gatherer','19740703','Nam',82,'218761473'),(72,'Neron Gemlbett','19710930','Nữ',113,'426458587'),(73,'Nolana Trevithick','19710212','Nữ',30,'193085062'),(74,'Ramsey Cheeld','19710430','Nữ',43,'222479552'),(75,'Emmerich Risso','19790602','Nam',366,'972449231'),(76,'Davita Connaughton','19840504','Nữ',30,'657273600'),(77,'Cathee Osmant','19720302','Nam',158,'655158752'),(78,'York Truter','19770709','Nữ',270,'952724025'),(79,'Isidor Teape','19700124','Nữ',280,'913502869'),(80,'Shoshanna Gierke','19790719','Nữ',171,'185168546'),(81,'Haily Raecroft','19841213','Nam',180,'692235771'),(82,'Giff Clunan','19730416','Nữ',96,'885287722'),(83,'Sonja Holdforth','19760227','Nam',417,'859544380'),(84,'Fenelia Iorizzi','19760830','Nam',416,'707650160'),(85,'Gaylene Soldan','19830405','Nữ',143,'278052915'),(86,'Fritz Cripin','19760324','Nữ',76,'607876047'),(87,'Theodora Adams','19780619','Nam',238,'170552078'),(88,'Shandee Gaw','19750106','Nữ',210,'650330595'),(89,'Quintin Rutter','19761121','Nữ',459,'294443512'),(90,'Hilarius Burgon','19721024','Nữ',316,'564969449'),(91,'Adora Knath','19830608','Nữ',283,'355543329'),(92,'Dre Casier','19770416','Nữ',188,'289033764'),(93,'Kettie Looney','19821230','Nam',242,'656793670'),(94,'Thelma Andrzej','19840519','Nam',187,'153513470'),(95,'Lucina Ewings','19841029','Nữ',430,'387879639'),(96,'Shana Birchenhead','19750826','Nam',335,'589415892'),(97,'Ida Pegg','19790718','Nam',382,'227662181'),(98,'Cristian Voice','19820308','Nam',414,'348481987'),(99,'Loretta Birtwhistle','19740906','Nam',13,'285644990'),(100,'Mariann Lightbourne','19780814','Nam',179,'551942052'),(101,'Brad Rounding','19700214','Nam',22,'677626866');
/*!40000 ALTER TABLE `khach_hang` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-06 21:44:00

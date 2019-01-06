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
-- Table structure for table `bang_cham_cong`
--

DROP TABLE IF EXISTS `bang_cham_cong`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `bang_cham_cong` (
  `idbang_cham_cong` int(11) NOT NULL AUTO_INCREMENT,
  `id_nhanvien` int(11) DEFAULT NULL,
  `so_gio` int(11) DEFAULT NULL,
  `ngay` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idbang_cham_cong`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bang_cham_cong`
--

LOCK TABLES `bang_cham_cong` WRITE;
/*!40000 ALTER TABLE `bang_cham_cong` DISABLE KEYS */;
INSERT INTO `bang_cham_cong` VALUES (8,1,11,'1/6/2019'),(9,1,12,'1/1/2019'),(10,1,12,'1/1/2019');
/*!40000 ALTER TABLE `bang_cham_cong` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bang_chuc_vu`
--

DROP TABLE IF EXISTS `bang_chuc_vu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `bang_chuc_vu` (
  `idbang_chuc_vu` int(11) NOT NULL,
  `chuc_vu` varchar(45) NOT NULL,
  PRIMARY KEY (`idbang_chuc_vu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bang_chuc_vu`
--

LOCK TABLES `bang_chuc_vu` WRITE;
/*!40000 ALTER TABLE `bang_chuc_vu` DISABLE KEYS */;
INSERT INTO `bang_chuc_vu` VALUES (1,'NHÂN VIÊN BÁN HÀNG'),(2,'THỦ KHO'),(3,'QUẢN LÍ');
/*!40000 ALTER TABLE `bang_chuc_vu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chi_tiet_hoa_don`
--

DROP TABLE IF EXISTS `chi_tiet_hoa_don`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `chi_tiet_hoa_don` (
  `idchi_tiet_hoa_don` int(11) NOT NULL AUTO_INCREMENT,
  `idhoa_don` varchar(45) DEFAULT NULL,
  `idhang_hoa` varchar(45) DEFAULT NULL,
  `so_luong` varchar(45) DEFAULT NULL,
  `thanh_tien` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idchi_tiet_hoa_don`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chi_tiet_hoa_don`
--

LOCK TABLES `chi_tiet_hoa_don` WRITE;
/*!40000 ALTER TABLE `chi_tiet_hoa_don` DISABLE KEYS */;
INSERT INTO `chi_tiet_hoa_don` VALUES (1,'1','00206550','2','343102'),(2,'1','04059791','1','251933'),(3,'1','226449393','3','429762'),(13,'22','002206550','1','171551'),(14,'22','035258211','1','496623'),(15,'23','002206550','4','686204'),(16,'23','00206550','5','857755'),(17,'23','035258211','200','99324600'),(18,'24','','',''),(19,'25','','','');
/*!40000 ALTER TABLE `chi_tiet_hoa_don` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chi_tiet_phieu_nhap`
--

DROP TABLE IF EXISTS `chi_tiet_phieu_nhap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `chi_tiet_phieu_nhap` (
  `idchi_tiet_phieu_nhap` int(11) NOT NULL AUTO_INCREMENT,
  `idphieu_nhap` int(11) NOT NULL,
  `idhang_hoa` varchar(45) NOT NULL,
  `so_luong` varchar(45) NOT NULL,
  `thanh_tien` varchar(45) NOT NULL,
  PRIMARY KEY (`idchi_tiet_phieu_nhap`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chi_tiet_phieu_nhap`
--

LOCK TABLES `chi_tiet_phieu_nhap` WRITE;
/*!40000 ALTER TABLE `chi_tiet_phieu_nhap` DISABLE KEYS */;
INSERT INTO `chi_tiet_phieu_nhap` VALUES (1,2,'00206550','1','171000'),(2,2,'00206550','1','171000'),(3,2,'03258211','1','496000'),(4,2,'035802527','1','123000'),(5,2,'045059791','1','251000'),(6,3,'00206550','1','171000'),(7,3,'03258211','2','992000'),(8,3,'04059791','3','753000');
/*!40000 ALTER TABLE `chi_tiet_phieu_nhap` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hang_hoa`
--

DROP TABLE IF EXISTS `hang_hoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `hang_hoa` (
  `id_hanghoa` int(11) NOT NULL AUTO_INCREMENT,
  `ten_hanghoa` varchar(200) NOT NULL,
  `so_luong` int(11) DEFAULT NULL,
  `gia_tien` int(11) DEFAULT NULL,
  `size` varchar(45) NOT NULL,
  `loai_hang_hoa` int(11) NOT NULL,
  `nha_cung_cap` int(11) NOT NULL,
  PRIMARY KEY (`id_hanghoa`)
) ENGINE=InnoDB AUTO_INCREMENT=203 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hang_hoa`
--

LOCK TABLES `hang_hoa` WRITE;
/*!40000 ALTER TABLE `hang_hoa` DISABLE KEYS */;
INSERT INTO `hang_hoa` VALUES (1,'Paperman',64,171000,'L',26,13),(2,'Paperman',64,171000,'M',2,7),(3,'Easy Riders',78,496000,'L',24,14),(4,'Easy Riders',78,496000,'M',20,10),(5,'Green Street Hooligans (a.k.a. Hooligans)',65,123000,'M',28,9),(6,'Green Street Hooligans (a.k.a. Hooligans)',65,123000,'L',33,13),(7,'Foolish Wives',81,251000,'L',29,19),(8,'The Fabulous Baron Munchausen',43,361000,'L',49,9),(9,'Ramona and Beezus',41,144000,'L',20,4),(10,'Romantics, The',26,217000,'L',28,12),(11,'A.K.',72,341000,'L',17,2),(12,'Night Falls on Manhattan',51,339000,'L',2,9),(13,'Crow: Salvation, The',44,480000,'L',36,1),(14,'Great Lie, The',29,455000,'L',43,6),(15,'Everybody\'s All-American',53,160000,'L',21,4),(16,'Shot in the Dark, A',37,185000,'L',19,16),(17,'Yes Men, The',19,451000,'L',36,7),(18,'Jarhead',64,132000,'L',7,9),(19,'Huhwihaji Anha (No Regret)',97,244000,'L',20,14),(20,'Bedazzled',40,170000,'L',31,4),(21,'This Boy\'s Life',42,244000,'L',31,8),(22,'Mrs. Doubtfire',31,143000,'L',29,17),(23,'Marmaduke',42,217000,'L',43,2),(24,'Alien Contamination',21,324000,'L',10,8),(25,'True Love',77,370000,'L',11,11),(26,'Leading Man, The',71,136000,'L',18,9),(27,'Smile',90,102000,'L',20,17),(28,'Tom & Thomas',99,468000,'L',24,19),(29,'Cloudland',14,234000,'L',27,6),(30,'Val Lewton:  The Man in the Shadows',84,391000,'L',8,3),(31,'Moebius',88,138000,'L',18,7),(32,'Tyler Perry\'s Daddy\'s Little Girls',30,198000,'L',10,15),(33,'Manchurian Candidate, The',37,215000,'L',44,15),(34,'Hit Squad',90,327000,'L',21,13),(35,'',50,282000,'L',4,11),(36,'Ride Beyond Vengeance',77,457000,'L',41,5),(37,'Sunchaser, The',50,284000,'L',45,2),(38,'Cousins',61,488000,'L',49,17),(39,'Middle Men',94,283000,'L',18,18),(40,'The Iron Commissioner',81,109000,'L',8,7),(41,'Cosmonaut (Cosmonauta)',49,117000,'L',35,2),(42,'Music and Lyrics',90,315000,'L',46,1),(43,'Black Eagle',34,315000,'L',9,2),(44,'In Their Skin',74,301000,'L',38,17),(45,'Foolish Wives',81,251000,'M',47,17),(46,'Cyberjack (Virtual Assassin)',16,240000,'L',4,15),(47,'Hot Dog... The Movie',36,434000,'L',34,1),(48,'Amadeus',27,365000,'L',22,9),(49,'Dynamite',62,454000,'L',23,7),(50,'Girl Next Door, The',64,396000,'L',12,4),(51,'Broken Windows',82,316000,'L',10,10),(52,'Boy of the Streets',86,475000,'L',3,7),(53,'',21,314000,'L',18,11),(54,'Avengers, The',73,252000,'L',40,12),(55,'Road to Wellville, The',79,101000,'L',16,7),(56,'The Fabulous Baron Munchausen',43,361000,'M',3,14),(57,'Hungry for Change',26,396000,'L',40,14),(58,'Black Sunday (La maschera del demonio)',75,309000,'L',38,3),(59,'George Lopez: America\'s Mexican',12,407000,'L',38,18),(60,'Watcher, The',92,374000,'L',39,4),(61,'Campaign, The',100,153000,'L',20,15),(62,'Ill Gotten Gains',33,471000,'L',35,5),(63,'Intimidation',64,305000,'L',13,18),(64,'',94,128000,'L',17,5),(65,'Faust',93,146000,'L',21,10),(66,'M*A*S*H (a.k.a. MASH)',41,110000,'L',23,5),(67,'Oblivion Island: Haruka and the Magic Mirror (Hottarake no shima - Haruka to maho no kagami)',23,413000,'L',47,1),(68,'Rage: Carrie 2, The',55,173000,'L',48,10),(69,'Pirate Movie, The',31,417000,'L',36,1),(70,'Good Night to Die, A',61,397000,'L',38,14),(71,'Ramona and Beezus',41,144000,'M',42,16),(72,'Ghost in the Machine (a.k.a. Deadly Terror)',11,417000,'L',48,9),(73,'Moliere',83,308000,'L',15,8),(74,'Burden of Dreams',89,384000,'L',4,18),(75,'12:08 East of Bucharest (A fost sau n-a fost?)',81,253000,'L',37,5),(76,'Nokas',24,150000,'L',4,5),(77,'Passion of Anna, The (Passion, En)',71,385000,'L',3,3),(78,'Blue Dahlia, The',32,383000,'L',44,13),(79,'Magnificent Ambersons, The',34,425000,'L',18,7),(80,'Corruptor, The',16,197000,'L',42,9),(81,'Dark Touch',43,185000,'L',43,15),(82,'They Came to Cordura',27,458000,'L',26,16),(83,'Citadel',74,234000,'L',49,13),(84,'The African',74,177000,'L',19,18),(85,'Island, The (a.k.a. Naked Island) (Hadaka no shima)',20,250000,'L',37,9),(86,'\'Human\' Factor, The (Human Factor, The)',64,181000,'L',28,1),(87,'Games of Love and Chance (L\'esquive)',27,234000,'M',21,14),(88,'Claymation Christmas Celebration, A',49,297000,'L',43,2),(89,'Rosewater',68,222000,'L',27,14),(90,'Four Lions',72,314000,'L',38,6),(91,'Haunted House',31,483000,'L',37,4),(92,'Killjoy Goes to Hell',90,480000,'L',28,15),(93,'King Creole',92,456000,'L',38,15),(94,'Born to Win',98,282000,'L',33,8),(95,'Secret Life of Zoey, The',64,137000,'L',22,12),(96,'Lost Missile, The',10,168000,'L',26,11),(97,'Prince of the Sun: The Great Adventure of Horus (Taiyou no ouji Horusu no daibouken)',54,191000,'L',18,15),(98,'Grudge 2, The',47,249000,'L',49,6),(99,'Lille Fridolf and I',57,241000,'L',16,10),(100,'Breakfast with Scot',36,438000,'L',34,10),(101,'Fatal Beauty',38,469000,'L',49,7),(102,'',72,174000,'L',43,3),(103,'Patton Oswalt: Finest Hour',10,189000,'L',12,8),(104,'Shattered',51,489000,'L',5,8),(105,'Big Shots',95,499000,'L',41,10),(106,'Dead Man\'s Burden',59,419000,'L',15,18),(107,'Romantics, The',26,217000,'M',8,7),(108,'Night Falls on Manhattan',51,339000,'M',7,18),(109,'A.K.',72,341000,'M',31,7),(110,'Crow: Salvation, The',44,480000,'M',38,1),(111,'Great Lie, The',29,455000,'M',31,2),(112,'Everybody\'s All-American',53,160000,'M',26,2),(113,'Yes Men, The',19,451000,'M',19,19),(114,'Shot in the Dark, A',37,185000,'M',22,14),(115,'Jarhead',64,132000,'M',4,10),(116,'Bedazzled',40,170000,'M',45,15),(117,'Huhwihaji Anha (No Regret)',97,244000,'M',33,7),(118,'This Boy\'s Life',42,244000,'M',6,16),(119,'Marmaduke',42,217000,'M',40,2),(120,'Mrs. Doubtfire',31,143000,'M',26,3),(121,'Alien Contamination',21,324000,'M',38,18),(122,'True Love',77,370000,'M',38,3),(123,'Leading Man, The',71,136000,'M',40,9),(124,'Smile',90,102000,'M',47,3),(125,'Tom & Thomas',99,468000,'M',30,9),(126,'Val Lewton:  The Man in the Shadows',84,391000,'M',48,4),(127,'Cloudland',14,234000,'M',48,1),(128,'Tyler Perry\'s Daddy\'s Little Girls',30,198000,'M',18,16),(129,'Moebius',88,138000,'M',44,19),(130,'Manchurian Candidate, The',37,215000,'M',40,12),(131,'Hit Squad',90,327000,'M',33,10),(132,'',50,282000,'M',20,4),(133,'Sunchaser, The',50,284000,'M',43,15),(134,'Ride Beyond Vengeance',77,457000,'M',47,1),(135,'Cousins',61,488000,'M',5,8),(136,'The Iron Commissioner',81,109000,'M',26,4),(137,'Middle Men',94,283000,'M',12,1),(138,'Cosmonaut (Cosmonauta)',49,117000,'M',1,12),(139,'Music and Lyrics',90,315000,'M',20,9),(140,'Black Eagle',34,315000,'M',19,16),(141,'In Their Skin',74,301000,'M',13,2),(142,'Cyberjack (Virtual Assassin)',16,240000,'M',29,13),(143,'Hot Dog... The Movie',36,434000,'M',33,3),(144,'Amadeus',27,365000,'M',14,11),(145,'Dynamite',62,454000,'M',18,11),(146,'Girl Next Door, The',64,396000,'M',43,15),(147,'Broken Windows',82,316000,'M',27,7),(148,'Boy of the Streets',86,475000,'M',16,7),(149,'',21,314000,'M',28,17),(150,'Road to Wellville, The',79,101000,'M',10,17),(151,'Avengers, The',73,252000,'M',4,10),(152,'Hungry for Change',26,396000,'M',20,12),(153,'Black Sunday (La maschera del demonio)',75,309000,'M',35,10),(154,'George Lopez: America\'s Mexican',12,407000,'M',19,13),(155,'Watcher, The',92,374000,'M',34,10),(156,'Ill Gotten Gains',33,471000,'M',8,14),(157,'Intimidation',64,305000,'M',12,19),(158,'Campaign, The',100,153000,'M',20,1),(159,'Faust',93,146000,'M',24,1),(160,'',94,128000,'M',34,10),(161,'M*A*S*H (a.k.a. MASH)',41,110000,'M',5,19),(162,'Oblivion Island: Haruka and the Magic Mirror (Hottarake no shima - Haruka to maho no kagami)',23,413000,'M',3,7),(163,'Good Night to Die, A',61,397000,'M',25,1),(164,'Rage: Carrie 2, The',55,173000,'M',34,3),(165,'Pirate Movie, The',31,417000,'M',33,11),(166,'Moliere',83,308000,'M',49,12),(167,'Ghost in the Machine (a.k.a. Deadly Terror)',11,417000,'M',41,7),(168,'Burden of Dreams',89,384000,'M',7,8),(169,'Nokas',24,150000,'M',13,19),(170,'12:08 East of Bucharest (A fost sau n-a fost?)',81,253000,'M',33,4),(171,'Passion of Anna, The (Passion, En)',71,385000,'M',15,5),(172,'Magnificent Ambersons, The',34,425000,'M',18,13),(173,'Blue Dahlia, The',32,383000,'M',8,16),(174,'Citadel',74,234000,'M',34,17),(175,'Dark Touch',43,185000,'M',6,2),(176,'They Came to Cordura',27,458000,'M',48,15),(177,'Corruptor, The',16,197000,'M',14,1),(178,'The African',74,177000,'M',49,13),(179,'Island, The (a.k.a. Naked Island) (Hadaka no shima)',20,250000,'M',37,4),(180,'\'Human\' Factor, The (Human Factor, The)',64,181000,'M',28,14),(181,'Claymation Christmas Celebration, A',49,297000,'M',5,1),(182,'Rosewater',68,222000,'M',1,4),(183,'Four Lions',72,314000,'M',34,2),(184,'Killjoy Goes to Hell',90,480000,'M',22,2),(185,'King Creole',92,456000,'M',48,16),(186,'Haunted House',31,483000,'M',44,8),(187,'Born to Win',98,282000,'M',7,13),(188,'Prince of the Sun: The Great Adventure of Horus (Taiyou no ouji Horusu no daibouken)',54,191000,'M',21,17),(189,'Lost Missile, The',10,168000,'M',5,7),(190,'Secret Life of Zoey, The',64,137000,'M',27,10),(191,'Grudge 2, The',47,249000,'M',11,7),(192,'Lille Fridolf and I',57,241000,'M',21,4),(193,'Breakfast with Scot',36,438000,'M',3,6),(194,'Fatal Beauty',38,469000,'M',1,16),(195,'',72,174000,'M',16,13),(196,'Patton Oswalt: Finest Hour',10,189000,'M',2,17),(197,'Shattered',51,489000,'M',41,14),(198,'Big Shots',95,499000,'M',31,8),(199,'Dead Man\'s Burden',59,419000,'M',31,8),(200,'Games of Love and Chance (L\'esquive)',27,234000,'L',49,9),(201,'3123',0,3123,'M',1,2),(202,'3123',0,3123,'M',1,2);
/*!40000 ALTER TABLE `hang_hoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hoa_don`
--

DROP TABLE IF EXISTS `hoa_don`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `hoa_don` (
  `idhoa_don` int(11) NOT NULL AUTO_INCREMENT,
  `idkhach_hang` varchar(45) DEFAULT NULL,
  `tong_tien` varchar(45) NOT NULL,
  `ngay_lap` datetime NOT NULL,
  `idnhan_vien` varchar(45) NOT NULL,
  `hinh_thuc_thanh_toan` int(11) NOT NULL,
  PRIMARY KEY (`idhoa_don`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hoa_don`
--

LOCK TABLES `hoa_don` WRITE;
/*!40000 ALTER TABLE `hoa_don` DISABLE KEYS */;
INSERT INTO `hoa_don` VALUES (1,'1','1024797','2018-01-01 12:00:00','1',1),(2,'2','0','2018-12-31 12:00:00','2',1),(3,'3','0','2018-12-31 12:00:00','3',1),(4,'0','0','2018-06-06 12:00:00','3',1),(22,'0','668174','2019-01-05 03:00:00','1',1),(23,'26','11476419','2019-01-04 12:00:00','1',1),(24,'0','0','2019-01-06 00:00:00','1',1),(25,'0','0','2019-01-06 00:00:00','1',1);
/*!40000 ALTER TABLE `hoa_don` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `loai_thanh_toan`
--

DROP TABLE IF EXISTS `loai_thanh_toan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `loai_thanh_toan` (
  `idloai_thanh_toan` int(11) NOT NULL,
  `key` int(11) NOT NULL,
  `loai_thanh_toan` varchar(45) NOT NULL,
  PRIMARY KEY (`idloai_thanh_toan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loai_thanh_toan`
--

LOCK TABLES `loai_thanh_toan` WRITE;
/*!40000 ALTER TABLE `loai_thanh_toan` DISABLE KEYS */;
INSERT INTO `loai_thanh_toan` VALUES (1,1,'Tiền mặt'),(2,2,'Ngân hàng'),(3,3,'Ví điện tử (MoMo)');
/*!40000 ALTER TABLE `loai_thanh_toan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nha_cung_cap`
--

DROP TABLE IF EXISTS `nha_cung_cap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `nha_cung_cap` (
  `idnha_cung_cap` int(11) NOT NULL AUTO_INCREMENT,
  `ten_nha_cung_cap` varchar(45) NOT NULL,
  PRIMARY KEY (`idnha_cung_cap`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nha_cung_cap`
--

LOCK TABLES `nha_cung_cap` WRITE;
/*!40000 ALTER TABLE `nha_cung_cap` DISABLE KEYS */;
INSERT INTO `nha_cung_cap` VALUES (1,'Prosacco LLC'),(2,'Walter, Hirthe and Sanford'),(3,'Ebert, Rolfson and Torp'),(4,'Heller, Mraz and Bode'),(5,'Kreiger-Tromp'),(6,'Metz, Prosacco and Effertz'),(7,'Torp LLC'),(8,'Fay Group'),(9,'Paucek LLC'),(10,'Beatty-Dickinson'),(11,'Wisozk-Hodkiewicz'),(12,'Bednar Group'),(13,'Pfannerstill LLC'),(14,'Bartell, Klein and Schulist'),(15,'Schuster-Mitchell'),(16,'Kreiger, Crist and MacGyver'),(17,'Leuschke, Zemlak and Cronin'),(18,'Shanahan Group'),(19,'O\'Connell and Sons'),(20,'Kiehn, Muller and Harvey');
/*!40000 ALTER TABLE `nha_cung_cap` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhan_vien`
--

DROP TABLE IF EXISTS `nhan_vien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `nhan_vien` (
  `id_nhanvien` int(11) NOT NULL AUTO_INCREMENT,
  `ten_nhanvien` varchar(45) NOT NULL,
  `ngay_sinh` varchar(45) NOT NULL,
  `gioi_tinh` varchar(5) NOT NULL,
  `dia_chia` varchar(45) NOT NULL,
  `ma_chuc_vu` int(11) NOT NULL,
  `mat_khau` varchar(100) NOT NULL,
  `ten_dang_nhap` varchar(45) NOT NULL,
  `tinh_trang` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_nhanvien`),
  KEY `chuc_vu_idx` (`ma_chuc_vu`),
  CONSTRAINT `chuc_vu` FOREIGN KEY (`ma_chuc_vu`) REFERENCES `bang_chuc_vu` (`idbang_chuc_vu`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhan_vien`
--

LOCK TABLES `nhan_vien` WRITE;
/*!40000 ALTER TABLE `nhan_vien` DISABLE KEYS */;
INSERT INTO `nhan_vien` VALUES (1,'LÊ XUÂN TIẾN','1/6/2019','NAM','KTX B',1,'tienlx97','tienlx97',0),(2,'HUỲNH MINH TÂN','1/6/2019','NAM','KTX A',1,'tanhm97','tanhm97',0),(3,'BÙI TRƯỜNG THỊNH','1/6/2019','NAM','KTX C',1,'thinhbt97','thinhbt97',0),(4,'HỨA VĨ TRUNG','1/6/2019','NAM','KTX D',2,'trunght97','trunght97',0),(13,'TIEN','1/10/2019','NỮ','ADASD',1,'AAAA','AAAA',0),(14,'TIEN','1/10/2019','NỮ','ADASD',1,'AAAA','AAAA',0),(15,'TIEN','1/10/2019','NỮ','ADASD',1,'AAAA','AAAA',0),(16,'TIEN','1/10/2019','NỮ','ADASD',1,'AAAA','AAAA',0),(17,'aadasasd','1/1/2019','NAM','asdasdasd',2,'asdasd','asdasdasd',0),(18,'1111111','1/1/2019','NAM','asdasdasd',2,'asdasd','asdasdasd',0),(19,'2222','1/7/2019','NỮ','2222',1,'222','222',0),(20,'zz','1/8/2019','NAM','zzzz',1,'zzz','zzz',0);
/*!40000 ALTER TABLE `nhan_vien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phieu_nhap`
--

DROP TABLE IF EXISTS `phieu_nhap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `phieu_nhap` (
  `idphieu_nhap` int(11) NOT NULL AUTO_INCREMENT,
  `idnhan_vien` int(11) NOT NULL,
  `ngay_nhap` datetime DEFAULT NULL,
  `so_luong` varchar(45) DEFAULT NULL,
  `tong_tien` varchar(45) DEFAULT NULL,
  `hinh_thuc_nhap` int(11) DEFAULT NULL,
  PRIMARY KEY (`idphieu_nhap`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieu_nhap`
--

LOCK TABLES `phieu_nhap` WRITE;
/*!40000 ALTER TABLE `phieu_nhap` DISABLE KEYS */;
INSERT INTO `phieu_nhap` VALUES (1,1,'2019-01-05 00:00:00','4','1041000',0),(2,1,'2019-01-05 00:00:00','4','1041000',0),(3,1,'2019-01-05 00:00:00','6','1916000',0);
/*!40000 ALTER TABLE `phieu_nhap` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tham_so`
--

DROP TABLE IF EXISTS `tham_so`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tham_so` (
  `soYeuCau` int(11) NOT NULL DEFAULT '0',
  `phan_tram` int(5) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tham_so`
--

LOCK TABLES `tham_so` WRITE;
/*!40000 ALTER TABLE `tham_so` DISABLE KEYS */;
INSERT INTO `tham_so` VALUES (10,10);
/*!40000 ALTER TABLE `tham_so` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yeu_cau`
--

DROP TABLE IF EXISTS `yeu_cau`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `yeu_cau` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_nv` varchar(45) NOT NULL,
  `noi_dung_query` varchar(100) NOT NULL,
  `tinh_trang` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yeu_cau`
--

LOCK TABLES `yeu_cau` WRITE;
/*!40000 ALTER TABLE `yeu_cau` DISABLE KEYS */;
INSERT INTO `yeu_cau` VALUES (8,'1','call ThemCong(\'1\',\'1/1/2019\', \'12\')',1),(9,'1','call ThemCong(\'1\',\'1/1/2019\', \'15\')',0);
/*!40000 ALTER TABLE `yeu_cau` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'shop_dathao'
--
/*!50003 DROP PROCEDURE IF EXISTS `BaoCaoDoanhThuTheoNgay` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `BaoCaoDoanhThuTheoNgay`(in mon INT, in ye INT)
BEGIN
	declare tongdoanhthu double;
    select sum(tong_tien) into tongdoanhthu
	from hoa_don where Month(ngay_lap)=mon and Year(ngay_lap)=ye;
    
   select Date(ngay_lap) as ngaylap, Count(idhoa_don) as sogiaodich,
   sum(tong_tien) as doanhthu, concat(TRUNCATE(sum(tong_tien)/tongdoanhthu*100,2),'%') as tyle
	from hoa_don where Month(ngay_lap)=mon and Year(ngay_lap)=ye
    group by Date(ngay_lap);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DangNhap` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DangNhap`(in _tendangnhap varchar(45),in _matkhau varchar(100))
BEGIN
	select nhan_vien.id_nhanvien, ten_nhanvien, ngay_sinh, gioi_tinh, dia_chia, ten_dang_nhap, bang_chuc_vu.chuc_vu as ma_chuc_vu
		from nhan_vien, bang_chuc_vu
		where ten_dang_nhap = _tendangnhap and mat_khau = _matkhau and nhan_vien.ma_chuc_vu = bang_chuc_vu.idbang_chuc_vu;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `KhoiTaoChiTietHoaDon` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `KhoiTaoChiTietHoaDon`(IN idhoadon VARCHAR(45),
in idhanghoa VARCHAR(45),in soluong VARCHAR(45),in thanhtien VARCHAR(45))
BEGIN
	INSERT INTO chi_tiet_hoa_don ( idhoa_don, idhang_hoa,so_luong,thanh_tien)
   VALUES
   ( idhoadon, idhanghoa,soluong,thanhtien );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `KhoiTaoChiTietPhieuNhap` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `KhoiTaoChiTietPhieuNhap`(IN idphieunhap VARCHAR(45),
in idhanghoa VARCHAR(45),in soluong VARCHAR(45),in thanhtien VARCHAR(45))
BEGIN
	INSERT INTO chi_tiet_phieu_nhap ( idphieu_nhap, idhang_hoa,so_luong,thanh_tien)
   VALUES
   ( idphieunhap, idhanghoa,soluong,thanhtien );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `KhoiTaoHoaDon` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `KhoiTaoHoaDon`(IN cmnd VARCHAR(45),IN tong_tien VARCHAR(45),
in ngay_lap VARCHAR(45),in idnhan_vien VARCHAR(45),in thanhtoan INT)
BEGIN
	Declare tempdate Date;
	Declare idkhachhang char(10);
    
   select NOW() into tempDate;
   
   if cmnd Like 'null' then
		Set idkhachhang = 0;
   else
	   select idkhach_hang into idkhachhang
		from khach_hang
		 where cmnd like cmnd
		Limit 1;
   end if;
    
    
	INSERT INTO hoa_don ( idkhach_hang, tong_tien,ngay_lap,idnhan_vien,hinh_thuc_thanh_toan )
   VALUES
   ( idkhachhang, tong_tien,tempdate,idnhan_vien,thanhtoan );
   select idhoa_don from hoa_don
   order by idhoa_don DESC limit 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `KhoiTaoPhieuNhap` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `KhoiTaoPhieuNhap`(IN Idnhan_vien VARCHAR(45),
in ngay_lap VARCHAR(45),in so_luong VARCHAR(45),IN tong_tien VARCHAR(45),in hinh_thuc_nhap INT)
BEGIN
	Declare tempdate Date;
    
   select NOW() into tempDate;
    
	INSERT INTO phieu_nhap (idnhan_vien,ngay_nhap,so_luong ,tong_tien,hinh_thuc_nhap)
   VALUES
   ( Idnhan_vien, tempDate,so_luong,tong_tien,hinh_thuc_nhap );
   select idphieu_nhap from phieu_nhap
   order by idphieu_nhap DESC limit 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LayBangChamCong` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `LayBangChamCong`(in id INT(11),in ngay varchar(20))
BEGIN
	select * 
    from bang_cham_cong 
    where bang_cham_cong.id_nhanvien = id and bang_cham_cong.ngay = ngay;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LayDanhSachHangHoa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `LayDanhSachHangHoa`()
BEGIN
	select * from hang_hoa ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LayDanhSachHoaDon` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `LayDanhSachHoaDon`()
BEGIN
	select idhoa_don,ten_khach_hang,tong_tien,ngay_lap,ten_nhanvien from hoa_don a
	,(select idkhach_hang,ten_khach_hang from khach_hang) b,nhan_vien c
	where a.idkhach_hang=b.idkhach_hang and a.idnhan_vien=c.id_nhanvien;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LayDanhSachKhacHang` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `LayDanhSachKhacHang`()
BEGIN
	select * from khach_hang where idkhach_hang > 0;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LayDanhSachKhachHang` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `LayDanhSachKhachHang`()
BEGIN
	select * from khach_hang where idkhach_hang > 0;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LayDanhSachLoaiHang` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `LayDanhSachLoaiHang`()
BEGIN
select * from loai_hang_hoa;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LayDanhSachNhaCungCap` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `LayDanhSachNhaCungCap`()
BEGIN
select *
    from nha_cung_cap;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LayKhachHangTheoCMND` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `LayKhachHangTheoCMND`(in _cmnd varchar(45))
BEGIN
select *
    from khach_hang
    where cmnd like _cmnd and idkhach_hang > 0;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ThemCong` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ThemCong`(in id INT(11),in ngay varchar(20),in soGio INT(11))
BEGIN
	insert into `bang_cham_cong` (`id_nhanvien`,`so_gio`,`ngay`) values(id,soGio,ngay);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ThemHangHoa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ThemHangHoa`(in Ten_hang_hoa VARCHAR(45)
,in Gia_tien INT, in  Size VARCHAR(45), in Loai_hang_hoa VARCHAR(45), in  Nha_cung_cap VARCHAR(45))
BEGIN
declare idloai int;
declare idnha int;

select idloai_hang_hoa into idloai from loai_hang_hoa
where ten_loai_hang_hoa like Loai_hang_hoa
limit 1;

select idnha_cung_cap into idnha from nha_cung_cap
where ten_nha_cung_cap like Nha_cung_cap
limit 1;

insert into hang_hoa (ten_hanghoa,so_luong,gia_tien,size,loai_hang_hoa,nha_cung_cap)
values 
(Ten_hang_hoa,0,Gia_tien,Size,idloai,idnha);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ThemNhanVien` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ThemNhanVien`(in tennv varchar(100),
in ngaysinh varchar(100),
in gioitinh varchar(100),
in diachi varchar(100),
in tenchucvu varchar(100),
in matkhau varchar(100),
in tendangnhap varchar(100))
BEGIN
   declare id_chucvu int(11);
   select idbang_chuc_vu into id_chucvu
   from bang_chuc_vu
   where bang_chuc_vu.chuc_vu like tenchucvu;
   
   INSERT INTO nhan_vien(`ten_nhanvien`,`ngay_sinh`,`gioi_tinh`,`dia_chia`,`ma_chuc_vu`,`mat_khau`,`ten_dang_nhap`,`tinh_trang`) 
   values( tennv, ngaysinh,gioitinh,diachi,id_chucvu,matkhau,tendangnhap,0);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ThemThamSo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ThemThamSo`(in id varchar(10))
BEGIN
	declare c int(2);
	   select count(*) into c
	   from tham_so
	   where id_nv = id;
	   IF c like 1 then
			INSERT INTO tham_so(`id_nv`) 
			values(id);
       END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ThucHienYeuCau` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ThucHienYeuCau`(in id varchar(45))
BEGIN
   declare q varchar(100);

   select noi_dung_query into q
   from yeu_cau
   where yeu_cau.id like id;
   
    SET @s = q;
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
    
    update yeu_cau
    set tinh_trang = 1
    where yeu_cau.id like id;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `TimKiemMaHangHoa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `TimKiemMaHangHoa`(in _mahanghoa varchar(45))
BEGIN
 select *
    from hang_hoa
    where id_hanghoa like CONCAT('%', _mahanghoa, '%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `TimKiemTenHangHoa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `TimKiemTenHangHoa`(in _tenhanghoa varchar(45))
BEGIN
 select *
    from hang_hoa
    where ten_hanghoa like CONCAT('%', _tenhanghoa, '%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `XoaYeuCau` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `XoaYeuCau`(in id varchar(45))
BEGIN
    update yeu_cau
    set tinh_trang = 2
    where yeu_cau.id like id;
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-07  2:08:32

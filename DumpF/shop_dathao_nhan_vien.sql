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
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhan_vien`
--

LOCK TABLES `nhan_vien` WRITE;
/*!40000 ALTER TABLE `nhan_vien` DISABLE KEYS */;
INSERT INTO `nhan_vien` VALUES (1,'LÊ XUÂN TIẾN','1/6/2019','NAM','KTX B',1,'tienlx97','tienlx97',0),(2,'HUỲNH MINH TÂN','1/6/2019','NAM','KTX A',1,'tanhm97','tanhm97',0),(3,'BÙI TRƯỜNG THỊNH','1/6/2019','NAM','KTX C',1,'thinhbt97','thinhbt97',0),(4,'HỨA VĨ TRUNG','1/6/2019','NAM','KTX D',2,'trunght97','trunght97',0),(13,'TIEN','1/10/2019','NỮ','ADASD',1,'AAAA','AAAA',0),(14,'TIEN','1/10/2019','NỮ','ADASD',1,'AAAA','AAAA',0),(15,'TIEN','1/10/2019','NỮ','ADASD',1,'AAAA','AAAA',0),(16,'TIEN','1/10/2019','NỮ','ADASD',1,'AAAA','AAAA',0),(17,'aadasasd','1/1/2019','NAM','asdasdasd',2,'asdasd','asdasdasd',0),(18,'1111111','1/1/2019','NAM','asdasdasd',2,'asdasd','asdasdasd',0),(19,'2222','1/7/2019','NỮ','2222',1,'222','222',0);
/*!40000 ALTER TABLE `nhan_vien` ENABLE KEYS */;
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

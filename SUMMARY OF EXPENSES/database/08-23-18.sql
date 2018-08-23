/*
 Navicat Premium Data Transfer

 Source Server         : mySql
 Source Server Type    : MySQL
 Source Server Version : 100134
 Source Host           : localhost:3306
 Source Schema         : dfcexpsum

 Target Server Type    : MySQL
 Target Server Version : 100134
 File Encoding         : 65001

 Date: 23/08/2018 11:11:13
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for tblsummaryexpenses
-- ----------------------------
DROP TABLE IF EXISTS `tblsummaryexpenses`;
CREATE TABLE `tblsummaryexpenses`  (
  `eID` int(11) NOT NULL AUTO_INCREMENT,
  `vID` int(11) NULL DEFAULT NULL,
  `expenseType` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `unit` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `qty` int(11) NULL DEFAULT NULL,
  `unitPrice` decimal(19, 4) NULL DEFAULT NULL,
  `totalPrice` decimal(19, 4) NULL DEFAULT NULL,
  `prevOdometer` int(11) NULL DEFAULT NULL,
  `currentOdometer` int(11) NULL DEFAULT NULL,
  `kml` decimal(19, 4) NULL DEFAULT NULL,
  `date` datetime(6) NULL DEFAULT NULL,
  `yearUsed` int(11) NULL DEFAULT NULL,
  `remarks` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`eID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 26 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tblsummaryexpenses
-- ----------------------------
INSERT INTO `tblsummaryexpenses` VALUES (24, 7, 'Salaries & Wages', '', 1, 3500.0000, 3500.0000, 0, 0, 0.0000, '2018-08-17 00:00:00.000000', 0, 'SALARY');
INSERT INTO `tblsummaryexpenses` VALUES (25, 7, 'Salaries & Wages', '', 1, 1500.0000, 1500.0000, 0, 0, 0.0000, '2018-08-23 00:00:00.000000', 0, 'PAYROLL');

-- ----------------------------
-- Table structure for tblsystemsettings
-- ----------------------------
DROP TABLE IF EXISTS `tblsystemsettings`;
CREATE TABLE `tblsystemsettings`  (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `settingsName` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `value` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tblsystemsettings
-- ----------------------------
INSERT INTO `tblsystemsettings` VALUES (1, 'LastUpdate', '08/23/2018');

-- ----------------------------
-- Table structure for tblvehicle
-- ----------------------------
DROP TABLE IF EXISTS `tblvehicle`;
CREATE TABLE `tblvehicle`  (
  `vID` int(11) NOT NULL AUTO_INCREMENT,
  `plateNo` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `vehicleModel` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `nameOfDriver` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`vID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 8 CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tblvehicle
-- ----------------------------
INSERT INTO `tblvehicle` VALUES (1, '2131231', 'GRANDIA', 'MARVIN BALADIANG');
INSERT INTO `tblvehicle` VALUES (2, '312312', 'FORTUNER', 'RODMAR DUMAGO');
INSERT INTO `tblvehicle` VALUES (3, '31231', 'HI ACE', 'ELVIRA DELA SERNA');
INSERT INTO `tblvehicle` VALUES (4, '213123', 'KIA', 'ADING ADING');
INSERT INTO `tblvehicle` VALUES (5, '123123', 'FOTON', 'RENZ RENZ');
INSERT INTO `tblvehicle` VALUES (6, '123123', 'ASDASD', 'ASDASD');
INSERT INTO `tblvehicle` VALUES (7, '30109', 'WINGVAN BLUE', 'RYAN ALFECHE');

SET FOREIGN_KEY_CHECKS = 1;

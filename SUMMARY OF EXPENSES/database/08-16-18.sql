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

 Date: 16/08/2018 14:44:25
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for tblsummaryexpenses
-- ----------------------------
DROP TABLE IF EXISTS `tblsummaryexpenses`;
CREATE TABLE `tblsummaryexpenses`  (
  `eID` int(11) NOT NULL,
  `vID` int(11) NULL DEFAULT NULL,
  `expenseType` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `unit` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `qty` int(11) NULL DEFAULT NULL,
  `unitPrice` decimal(19, 4) NULL DEFAULT NULL,
  `totalPrice` decimal(19, 4) NULL DEFAULT NULL,
  `prevOdometer` int(11) NULL DEFAULT NULL,
  `currentOdometer` int(11) NULL DEFAULT NULL,
  `kml` decimal(19, 4) NULL DEFAULT NULL,
  `date` datetime(0) NULL DEFAULT NULL,
  `yearUsed` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`eID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tblsummaryexpenses
-- ----------------------------
INSERT INTO `tblsummaryexpenses` VALUES (1, 4, 'Fuel', 'Liter', 5, 50.0000, 250.0000, 12000, 12300, 60.0000, '2018-08-10 00:00:00', NULL);
INSERT INTO `tblsummaryexpenses` VALUES (2, 5, 'Tire', 'PCS', 1, 1500.0000, 1500.0000, 0, 0, 0.0000, '2017-08-11 00:00:00', 1);
INSERT INTO `tblsummaryexpenses` VALUES (4, 5, 'Tire', 'PCS', 2, 1500.0000, 3000.0000, 0, 0, 0.0000, '2018-08-11 00:00:00', 0);
INSERT INTO `tblsummaryexpenses` VALUES (10, 5, 'Fuel', 'LITER', 5, 48.0000, 240.0000, 11280, 11500, 44.0000, '2018-08-11 00:00:00', 0);

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
INSERT INTO `tblsystemsettings` VALUES (1, 'LastUpdate', '08/14/2018');

-- ----------------------------
-- Table structure for tblvehicle
-- ----------------------------
DROP TABLE IF EXISTS `tblvehicle`;
CREATE TABLE `tblvehicle`  (
  `vID` int(11) NOT NULL,
  `plateNo` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `vehicleModel` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  `nameOfDriver` varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL,
  PRIMARY KEY (`vID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = latin1 COLLATE = latin1_swedish_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of tblvehicle
-- ----------------------------
INSERT INTO `tblvehicle` VALUES (1, '2131231', 'GRANDIA', 'MARVIN BALADIANG');
INSERT INTO `tblvehicle` VALUES (2, '312312', 'FORTUNER', 'RODMAR DUMAGO');
INSERT INTO `tblvehicle` VALUES (3, '31231', 'HI ACE', 'ELVIRA DELA SERNA');
INSERT INTO `tblvehicle` VALUES (4, '213123', 'KIA', 'ADING ADING');
INSERT INTO `tblvehicle` VALUES (5, '123123', 'FOTON', 'RENZ RENZ');

SET FOREIGN_KEY_CHECKS = 1;

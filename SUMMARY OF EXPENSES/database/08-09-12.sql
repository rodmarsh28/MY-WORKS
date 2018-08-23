/*
 Navicat Premium Data Transfer

 Source Server         : generalLedgerDB
 Source Server Type    : SQL Server
 Source Server Version : 10001600
 Source Host           : dfarm3:1433
 Source Catalog        : SummaryOfExpenses
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 10001600
 File Encoding         : 65001

 Date: 09/08/2018 16:39:20
*/


-- ----------------------------
-- Table structure for tblSummaryExpenses
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSummaryExpenses]') AND type IN ('U'))
	DROP TABLE [dbo].[tblSummaryExpenses]
GO

CREATE TABLE [dbo].[tblSummaryExpenses] (
  [eID] int  NOT NULL,
  [vID] int  NULL,
  [expenseType] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [unit] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [qty] int  NULL,
  [unitPrice] money  NULL,
  [totalPrice] money  NULL,
  [prevOdometer] int  NULL,
  [currentOdometer] int  NULL,
  [kml] int  NULL
)
GO

ALTER TABLE [dbo].[tblSummaryExpenses] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tblVehicle
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblVehicle]') AND type IN ('U'))
	DROP TABLE [dbo].[tblVehicle]
GO

CREATE TABLE [dbo].[tblVehicle] (
  [vID] int  NOT NULL,
  [plateNo] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [vehicleModel] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [nameOfDriver] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblVehicle] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Primary Key structure for table tblSummaryExpenses
-- ----------------------------
ALTER TABLE [dbo].[tblSummaryExpenses] ADD CONSTRAINT [PK__tblSumma__D9519B2503317E3D] PRIMARY KEY CLUSTERED ([eID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblVehicle
-- ----------------------------
ALTER TABLE [dbo].[tblVehicle] ADD CONSTRAINT [PK__tblVehic__DD9EAB757F60ED59] PRIMARY KEY CLUSTERED ([vID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


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

 Date: 11/08/2018 16:52:42
*/


-- ----------------------------
-- Table structure for tblSummaryExpenses
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSummaryExpenses]') AND type IN ('U'))
	DROP TABLE [dbo].[tblSummaryExpenses]
GO

CREATE TABLE [dbo].[tblSummaryExpenses] (
  [eID] int  IDENTITY(1,1) NOT NULL,
  [vID] int  NULL,
  [expenseType] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [unit] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [qty] int  NULL,
  [unitPrice] money  NULL,
  [totalPrice] money  NULL,
  [prevOdometer] int  NULL,
  [currentOdometer] int  NULL,
  [kml] money  NULL,
  [date] datetime2(7)  NULL,
  [yearUsed] int  NULL
)
GO

ALTER TABLE [dbo].[tblSummaryExpenses] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblSummaryExpenses
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblSummaryExpenses] ON
GO

INSERT INTO [dbo].[tblSummaryExpenses] ([eID], [vID], [expenseType], [unit], [qty], [unitPrice], [totalPrice], [prevOdometer], [currentOdometer], [kml], [date], [yearUsed]) VALUES (N'1', N'4', N'Fuel', N'Liter', N'5', N'50.0000', N'250.0000', N'12000', N'12300', N'60.0000', N'2018-08-10 00:00:00.0000000', NULL)
GO

INSERT INTO [dbo].[tblSummaryExpenses] ([eID], [vID], [expenseType], [unit], [qty], [unitPrice], [totalPrice], [prevOdometer], [currentOdometer], [kml], [date], [yearUsed]) VALUES (N'2', N'5', N'Tire', N'PCS', N'1', N'1500.0000', N'1500.0000', N'0', N'0', N'.0000', N'2017-08-11 00:00:00.0000000', N'1')
GO

INSERT INTO [dbo].[tblSummaryExpenses] ([eID], [vID], [expenseType], [unit], [qty], [unitPrice], [totalPrice], [prevOdometer], [currentOdometer], [kml], [date], [yearUsed]) VALUES (N'4', N'5', N'Tire', N'PCS', N'2', N'1500.0000', N'3000.0000', N'0', N'0', N'.0000', N'2018-08-11 00:00:00.0000000', N'0')
GO

INSERT INTO [dbo].[tblSummaryExpenses] ([eID], [vID], [expenseType], [unit], [qty], [unitPrice], [totalPrice], [prevOdometer], [currentOdometer], [kml], [date], [yearUsed]) VALUES (N'10', N'5', N'Fuel', N'LITER', N'5', N'48.0000', N'240.0000', N'11280', N'11500', N'44.0000', N'2018-08-11 00:00:00.0000000', N'0')
GO

SET IDENTITY_INSERT [dbo].[tblSummaryExpenses] OFF
GO


-- ----------------------------
-- Table structure for tblType
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblType]') AND type IN ('U'))
	DROP TABLE [dbo].[tblType]
GO

CREATE TABLE [dbo].[tblType] (
  [id] int  NOT NULL,
  [ExpensesType] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblType] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tblVehicle
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblVehicle]') AND type IN ('U'))
	DROP TABLE [dbo].[tblVehicle]
GO

CREATE TABLE [dbo].[tblVehicle] (
  [vID] int  IDENTITY(1,1) NOT NULL,
  [plateNo] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [vehicleModel] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [nameOfDriver] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblVehicle] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblVehicle
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblVehicle] ON
GO

INSERT INTO [dbo].[tblVehicle] ([vID], [plateNo], [vehicleModel], [nameOfDriver]) VALUES (N'1', N'2131231', N'GRANDIA', N'MARVIN BALADIANG')
GO

INSERT INTO [dbo].[tblVehicle] ([vID], [plateNo], [vehicleModel], [nameOfDriver]) VALUES (N'2', N'312312', N'FORTUNER', N'RODMAR DUMAGO')
GO

INSERT INTO [dbo].[tblVehicle] ([vID], [plateNo], [vehicleModel], [nameOfDriver]) VALUES (N'3', N'31231', N'HI ACE', N'ELVIRA DELA SERNA')
GO

INSERT INTO [dbo].[tblVehicle] ([vID], [plateNo], [vehicleModel], [nameOfDriver]) VALUES (N'4', N'213123', N'KIA', N'ADING ADING')
GO

INSERT INTO [dbo].[tblVehicle] ([vID], [plateNo], [vehicleModel], [nameOfDriver]) VALUES (N'5', N'123123', N'FOTON', N'RENZ RENZ')
GO

SET IDENTITY_INSERT [dbo].[tblVehicle] OFF
GO


-- ----------------------------
-- Primary Key structure for table tblSummaryExpenses
-- ----------------------------
ALTER TABLE [dbo].[tblSummaryExpenses] ADD CONSTRAINT [PK__tblSumma__D9519B2503317E3D] PRIMARY KEY CLUSTERED ([eID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblType
-- ----------------------------
ALTER TABLE [dbo].[tblType] ADD CONSTRAINT [PK__tblType__3213E83F0AD2A005] PRIMARY KEY CLUSTERED ([id])
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


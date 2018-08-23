/*
 Navicat Premium Data Transfer

 Source Server         : generalLedgerDB
 Source Server Type    : SQL Server
 Source Server Version : 10001600
 Source Host           : dfarm3:1433
 Source Catalog        : dfcpsMasterlistDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 10001600
 File Encoding         : 65001

 Date: 09/07/2018 10:43:41
*/


-- ----------------------------
-- Table structure for tblChildrenInfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblChildrenInfo]') AND type IN ('U'))
	DROP TABLE [dbo].[tblChildrenInfo]
GO

CREATE TABLE [dbo].[tblChildrenInfo] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [employeeID] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [lastname] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [firstname] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [middlename] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblChildrenInfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tblDesciplinaryAction
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDesciplinaryAction]') AND type IN ('U'))
	DROP TABLE [dbo].[tblDesciplinaryAction]
GO

CREATE TABLE [dbo].[tblDesciplinaryAction] (
  [descActionNo] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [date] datetime2(7)  NULL,
  [employeeID] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [typeofViolation] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [actionTaken] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [punishDateFrom] datetime2(7)  NULL,
  [punishDateTo] datetime2(7)  NULL,
  [detailsofincrement] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [preparedby] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblDesciplinaryAction] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tblEmployeesInfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblEmployeesInfo]') AND type IN ('U'))
	DROP TABLE [dbo].[tblEmployeesInfo]
GO

CREATE TABLE [dbo].[tblEmployeesInfo] (
  [employeeID] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [lastname] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [firstname] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [middlename] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [address] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [contactNo] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [homeNo] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [religion] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [gender] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [birthdate] datetime2(7)  NULL,
  [civilstatus] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [department] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [division] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [position] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [rate] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [grade] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [payMethod] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [dateHired] datetime2(7)  NULL,
  [workingStatus] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [field] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [sssNo] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [tinNo] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [piNo] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [phNo] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [allowBenefitsDeduction] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [remarks] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblEmployeesInfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tblLeave
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblLeave]') AND type IN ('U'))
	DROP TABLE [dbo].[tblLeave]
GO

CREATE TABLE [dbo].[tblLeave] (
  [leaveNo] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [dateFilled] datetime2(7)  NULL,
  [employeeID] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [leaveType] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [reason] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [dateFrom] datetime2(7)  NULL,
  [dateTo] datetime2(7)  NULL,
  [totalDays] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [withpay] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [remarks] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblLeave] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tblSpouseInfo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSpouseInfo]') AND type IN ('U'))
	DROP TABLE [dbo].[tblSpouseInfo]
GO

CREATE TABLE [dbo].[tblSpouseInfo] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [employeeID] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [lastname] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [firstname] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [middlename] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblSpouseInfo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Primary Key structure for table tblChildrenInfo
-- ----------------------------
ALTER TABLE [dbo].[tblChildrenInfo] ADD CONSTRAINT [PK__tblChild__3213E83F07020F21] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblDesciplinaryAction
-- ----------------------------
ALTER TABLE [dbo].[tblDesciplinaryAction] ADD CONSTRAINT [PK__tblDesci__8E560CD00EA330E9] PRIMARY KEY CLUSTERED ([descActionNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblEmployeesInfo
-- ----------------------------
ALTER TABLE [dbo].[tblEmployeesInfo] ADD CONSTRAINT [PK__tblEmplo__C134C9A17F60ED59] PRIMARY KEY CLUSTERED ([employeeID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblLeave
-- ----------------------------
ALTER TABLE [dbo].[tblLeave] ADD CONSTRAINT [PK__tblLeave__CB45E81B1273C1CD] PRIMARY KEY CLUSTERED ([leaveNo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblSpouseInfo
-- ----------------------------
ALTER TABLE [dbo].[tblSpouseInfo] ADD CONSTRAINT [PK__tblSpous__3213E83F03317E3D] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


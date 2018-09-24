/*
 Navicat Premium Data Transfer

 Source Server         : generalLedgerDB
 Source Server Type    : SQL Server
 Source Server Version : 10001600
 Source Host           : dfarm3:1433
 Source Catalog        : generalLedgerDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 10001600
 File Encoding         : 65001

 Date: 24/09/2018 16:55:32
*/


-- ----------------------------
-- Table structure for tblAccCategories
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblAccCategories]') AND type IN ('U'))
	DROP TABLE [dbo].[tblAccCategories]
GO

CREATE TABLE [dbo].[tblAccCategories] (
  [CATEGORYID] int  IDENTITY(1,1) NOT NULL,
  [TYPENO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [CATEGORY] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblAccCategories] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblAccCategories
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblAccCategories] ON
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'1', N'1', N'FINANCE & ACCOUNTING DIVISION')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'2', N'1', N'ENGINEERING & MAINTENANCE')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'3', N'1', N'WAREHOUSE & STOCKROOM')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'4', N'2', N'REVENUE / SALES')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'5', N'2', N'SALES RETURN & ALLOWANCE')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'6', N'2', N'OTHER INCOME')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'7', N'2', N'OTHER EXPENSES')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'8', N'3', N'ASSET ACCOUNTS')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'9', N'3', N'CURRENT ASSETS')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'10', N'3', N'INVENTORY')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'11', N'3', N'FIXED ASSETS')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'12', N'3', N'LIABILITIES')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'13', N'3', N'LONG TERM LIABILITIES')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'14', N'3', N'STOCKHOLDERS EQUITY')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'15', N'1', N'IT DIVISION')
GO

INSERT INTO [dbo].[tblAccCategories] ([CATEGORYID], [TYPENO], [CATEGORY]) VALUES (N'16', N'1', N'OPERATION ADMINISTRATION')
GO

SET IDENTITY_INSERT [dbo].[tblAccCategories] OFF
GO


-- ----------------------------
-- Table structure for tblAccountEntry
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblAccountEntry]') AND type IN ('U'))
	DROP TABLE [dbo].[tblAccountEntry]
GO

CREATE TABLE [dbo].[tblAccountEntry] (
  [ACCENTRYID] int  IDENTITY(1,1) NOT NULL,
  [CVNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ACCNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DEBIT] money  NULL,
  [CREDIT] money  NULL
)
GO

ALTER TABLE [dbo].[tblAccountEntry] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblAccountEntry
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblAccountEntry] ON
GO

INSERT INTO [dbo].[tblAccountEntry] ([ACCENTRYID], [CVNO], [ACCNO], [DEBIT], [CREDIT]) VALUES (N'11', N'CV-00001', N'110009', N'21500.0000', N'.0000')
GO

INSERT INTO [dbo].[tblAccountEntry] ([ACCENTRYID], [CVNO], [ACCNO], [DEBIT], [CREDIT]) VALUES (N'12', N'CV-00001', N'380001', N'.0000', N'21500.0000')
GO

INSERT INTO [dbo].[tblAccountEntry] ([ACCENTRYID], [CVNO], [ACCNO], [DEBIT], [CREDIT]) VALUES (N'13', N'CV-00002', N'1150001', N'21500.0000', N'.0000')
GO

INSERT INTO [dbo].[tblAccountEntry] ([ACCENTRYID], [CVNO], [ACCNO], [DEBIT], [CREDIT]) VALUES (N'14', N'CV-00002', N'380001', N'.0000', N'21500.0000')
GO

INSERT INTO [dbo].[tblAccountEntry] ([ACCENTRYID], [CVNO], [ACCNO], [DEBIT], [CREDIT]) VALUES (N'15', N'CV-00003', N'1150001', N'7180.5700', N'.0000')
GO

INSERT INTO [dbo].[tblAccountEntry] ([ACCENTRYID], [CVNO], [ACCNO], [DEBIT], [CREDIT]) VALUES (N'16', N'CV-00003', N'380001', N'.0000', N'7180.5700')
GO

INSERT INTO [dbo].[tblAccountEntry] ([ACCENTRYID], [CVNO], [ACCNO], [DEBIT], [CREDIT]) VALUES (N'17', N'CV-00004', N'1150001', N'26785.7100', N'.0000')
GO

INSERT INTO [dbo].[tblAccountEntry] ([ACCENTRYID], [CVNO], [ACCNO], [DEBIT], [CREDIT]) VALUES (N'18', N'CV-00004', N'380001', N'.0000', N'26785.7100')
GO

SET IDENTITY_INSERT [dbo].[tblAccountEntry] OFF
GO


-- ----------------------------
-- Table structure for tblCOA
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblCOA]') AND type IN ('U'))
	DROP TABLE [dbo].[tblCOA]
GO

CREATE TABLE [dbo].[tblCOA] (
  [ACCNO] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [CATEGORYID] int  NULL,
  [ACCOUNTNAME] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblCOA] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblCOA
-- ----------------------------
INSERT INTO [dbo].[tblCOA]  VALUES (N'110001', N'1', N'Advertisement & Promotions')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'110002', N'1', N'BAD DEBTS')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'110003', N'1', N'BANK CHARGES')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'110004', N'1', N'COMMUNICATIONS (TEL, CABLE, MOBILE & INTERNET)')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'110005', N'1', N'DEPRECIATION EXPENSE')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'110006', N'1', N'EMPLOYEES BENEFITS')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'110007', N'1', N'FOOD PROVISION')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'110008', N'1', N'FREIGHT & HANDLING')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'110009', N'1', N'OFFICE SUPPLIES')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'1150001', N'15', N'OFFICE SUPPLIES')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'1160001', N'16', N'ADVERTISEMENT & PROMOTIONS')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'120001', N'2', N'ADVERTISEMENT & PROMOTIONS')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'120002', N'2', N'BAD DEBTS')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'120003', N'2', N'BACKING INCENTIVES')
GO

INSERT INTO [dbo].[tblCOA]  VALUES (N'380001', N'8', N'CASH IN BANK - LBP')
GO


-- ----------------------------
-- Table structure for tblcoaType
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblcoaType]') AND type IN ('U'))
	DROP TABLE [dbo].[tblcoaType]
GO

CREATE TABLE [dbo].[tblcoaType] (
  [TYPENO] int  IDENTITY(1,1) NOT NULL,
  [ACCTYPE] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblcoaType] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblcoaType
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblcoaType] ON
GO

INSERT INTO [dbo].[tblcoaType] ([TYPENO], [ACCTYPE]) VALUES (N'1', N'EXPENSE ACCOUNTS')
GO

INSERT INTO [dbo].[tblcoaType] ([TYPENO], [ACCTYPE]) VALUES (N'2', N'REVENUE ACCOUNTS')
GO

INSERT INTO [dbo].[tblcoaType] ([TYPENO], [ACCTYPE]) VALUES (N'3', N'BALANCE SHEET ACCOUNTS')
GO

SET IDENTITY_INSERT [dbo].[tblcoaType] OFF
GO


-- ----------------------------
-- Table structure for tblCV
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblCV]') AND type IN ('U'))
	DROP TABLE [dbo].[tblCV]
GO

CREATE TABLE [dbo].[tblCV] (
  [CVNO] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [REQNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DATE] datetime2(7)  NULL,
  [TINNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PAYEE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ADDRESS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [BANKNAME] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [CHECKNO] int  NULL,
  [TOTALAMOUNT] money  NULL,
  [TOTALDEBIT] money  NULL,
  [TOTALCREDIT] money  NULL,
  [AMOUNTINWORDS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PREPAREDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [CHECKEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [APPROVEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [STATUS] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblCV] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblCV
-- ----------------------------
INSERT INTO [dbo].[tblCV]  VALUES (N'CV-00001', N'PO-00001', N'2018-06-01 00:00:00.0000000', N'1231232', N'COLUMBIA', N'J.CATHOLICO, G.S.C.', N'LBP', N'21313123', N'21500.0000', N'21500.0000', N'21500.0000', N'TWENTY ONE THOUSAND FIVE HUNDRED  PESOS', N'RODMAR A. DUMAGO', N'CLARA MAE LABRADOR', N'NEIL CACHUELA', N'ISSUED')
GO

INSERT INTO [dbo].[tblCV]  VALUES (N'CV-00002', N'RFP-00001', N'2018-06-13 00:00:00.0000000', N'', N'OCTAGON', N'J. CATOLICO, G.S.C.', N'LBP', N'12312312', N'21500.0000', N'21500.0000', N'21500.0000', N'TWENTY ONE THOUSAND FIVE HUNDRED  PESOS', N'RODMAR A. DUMAGO', N'CLARA MAE LABRADOR', N'NEIL CACHUELA', N'ISSUED')
GO

INSERT INTO [dbo].[tblCV]  VALUES (N'CV-00003', N'PO-00002', N'2018-09-24 00:00:00.0000000', N'', N'MICRO VALLEY', N'KCC, J.CATHOLICO, G.S.C.', N'LBP', N'122111', N'7180.5700', N'7180.5700', N'7180.5700', N'SEVEN THOUSAND ONE HUNDRED EIGHTY  PESOS AND FIFTY SEVEN CENTS', N'RODMAR A. DUMAGO', N'CLARA MAE LABRADOR', N'NEIL CACHUELA', N'ISSUED')
GO

INSERT INTO [dbo].[tblCV]  VALUES (N'CV-00004', N'PO-00003', N'2018-09-24 00:00:00.0000000', N'', N'MICRO VALLEY', N'ASDASDA', N'LBP', N'12312312', N'26785.7100', N'26785.7100', N'26785.7100', N'TWENTY SIX THOUSAND SEVEN HUNDRED EIGHTY FIVE PESOS AND SEVENTY ONE CENTS', N'RODMAR A. DUMAGO', N'CLARA MAE LABRADOR', N'NEIL CACHUELA', N'ISSUED')
GO


-- ----------------------------
-- Table structure for tblEmployee
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblEmployee]') AND type IN ('U'))
	DROP TABLE [dbo].[tblEmployee]
GO

CREATE TABLE [dbo].[tblEmployee] (
  [EMPID] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [NAME] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ADDRESS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [CONTACTNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [BIRTHDATE] datetime2(7)  NULL,
  [GENDER] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [CIVILSTATUS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [POSITION] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [RATE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PAYMETHOD] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DATEHIRED] datetime2(7)  NULL,
  [FIELD] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DEDUCT] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [SSSNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TINNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PAGIBIGNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PHILHEALTHNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [STATUS] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblEmployee] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblEmployee
-- ----------------------------
INSERT INTO [dbo].[tblEmployee]  VALUES (N'EMP-00001', N'ASDASD, ASDASD ASDASD.', N'ASDASD', N'ASDASD', N'2018-06-21 00:00:00.0000000', N'Male', N'Single', N'ASDASD', N'9100', N'Monthly', N'2018-06-21 00:00:00.0000000', N'Work Hours', N'Yes', N'123123', N'', N'', N'', N'Active')
GO

INSERT INTO [dbo].[tblEmployee]  VALUES (N'EMP-00002', N'DUMAGO, RODMAR A.', N'GREENVILLE CALUMPANG G.S.C.', N'09307579980', N'2018-06-19 00:00:00.0000000', N'Male', N'Single', N'PROGRAMMER', N'320', N'Daily', N'2017-10-01 00:00:00.0000000', N'Work Hours', N'Yes', N'12312312', N'1231231', N'12312312', N'1231231', N'Active')
GO


-- ----------------------------
-- Table structure for tblINVENTORY
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblINVENTORY]') AND type IN ('U'))
	DROP TABLE [dbo].[tblINVENTORY]
GO

CREATE TABLE [dbo].[tblINVENTORY] (
  [INVTYCODE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [MATERIALDESC] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TYPE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [UNIT] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [STOCKSONHAND] int  NULL
)
GO

ALTER TABLE [dbo].[tblINVENTORY] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblINVENTORY
-- ----------------------------
INSERT INTO [dbo].[tblINVENTORY]  VALUES (N'ITM-00001', N'HP PRINTER', N'HP PRINTER ALL IN ONE', N'SET', N'3')
GO

INSERT INTO [dbo].[tblINVENTORY]  VALUES (N'ITM-00002', N'EPSON PRINTER', N'Epson L360 All-in-One Ink Tank Printer', N'SET', N'5')
GO

INSERT INTO [dbo].[tblINVENTORY]  VALUES (N'ITM-00003', N'BROTHER PRINTER', N'Brother HL-L5100DN', N'SET', N'5')
GO

INSERT INTO [dbo].[tblINVENTORY]  VALUES (N'ITM-00004', N'BALLPEN', N'PANDA', N'BOX', N'3')
GO

INSERT INTO [dbo].[tblINVENTORY]  VALUES (N'ITM-00005', N'EPSON', N'IP2770', N'SET', N'3')
GO

INSERT INTO [dbo].[tblINVENTORY]  VALUES (N'ITM-00006', N'COMPUTER SET', N'HP', N'SET', N'1')
GO

INSERT INTO [dbo].[tblINVENTORY]  VALUES (N'ITM-00007', N'BALLPEN', N'UNI', N'BOX', N'4')
GO

INSERT INTO [dbo].[tblINVENTORY]  VALUES (N'ITM-00008', N'BONDPAPER', N'UNIX', N'BOX', N'4')
GO

INSERT INTO [dbo].[tblINVENTORY]  VALUES (N'ITM-00009', N'ACER COMPUTER', N'ACER', N'SET', N'1')
GO


-- ----------------------------
-- Table structure for tblMISDESC
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMISDESC]') AND type IN ('U'))
	DROP TABLE [dbo].[tblMISDESC]
GO

CREATE TABLE [dbo].[tblMISDESC] (
  [MISNO] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [DATE] datetime2(7)  NULL,
  [MWSREF] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [SECTION] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DEPARTMENT] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [REMARKS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ISSUEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [APPROVEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [RECEIVEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ISRECEIVED] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblMISDESC] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblMISDESC
-- ----------------------------
INSERT INTO [dbo].[tblMISDESC]  VALUES (N'MIS-00001', N'2018-05-22 00:00:00.0000000', N'MWS-00001', N'PROGRAMMER', N'IT', N'', N'RODMAR A. DUMAGO', N'ELVIE DELA SERNA', N'RODMAR DUMAGO', N'YES')
GO

INSERT INTO [dbo].[tblMISDESC]  VALUES (N'MIS-00002', N'2018-05-22 00:00:00.0000000', N'MWS-00002', N'PROGRAMMER', N'IT', N'', N'RODMAR A. DUMAGO', N'ELVIE DELA SERNA', N'MARVIN BALADIANG', N'NO')
GO

INSERT INTO [dbo].[tblMISDESC]  VALUES (N'MIS-00003', N'2018-06-04 00:00:00.0000000', N'MWS-00003', N'PROGRAMMER', N'IT', N'', N'RODMAR A. DUMAGO', N'ELVIE DELA SERNA', N'RODMAR DUMAGO', N'NO')
GO


-- ----------------------------
-- Table structure for tblMISITEM
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMISITEM]') AND type IN ('U'))
	DROP TABLE [dbo].[tblMISITEM]
GO

CREATE TABLE [dbo].[tblMISITEM] (
  [MISITEMID] int  IDENTITY(1,1) NOT NULL,
  [INVTYCODE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [MISNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [MATERIALDESC] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TYPE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ACCNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [UNIT] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [QTY] int  NULL
)
GO

ALTER TABLE [dbo].[tblMISITEM] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblMISITEM
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblMISITEM] ON
GO

INSERT INTO [dbo].[tblMISITEM] ([MISITEMID], [INVTYCODE], [MISNO], [MATERIALDESC], [TYPE], [ACCNO], [UNIT], [QTY]) VALUES (N'43', N'ITM-00001', N'MIS-00001', N'HP PRINTER', N'HP PRINTER ALL IN ONE', N'110009', N'SET', N'1')
GO

INSERT INTO [dbo].[tblMISITEM] ([MISITEMID], [INVTYCODE], [MISNO], [MATERIALDESC], [TYPE], [ACCNO], [UNIT], [QTY]) VALUES (N'44', N'ITM-00002', N'MIS-00002', N'EPSON PRINTER', N'Epson L360 All-in-One Ink Tank Printer', N'110009', N'SET', N'1')
GO

INSERT INTO [dbo].[tblMISITEM] ([MISITEMID], [INVTYCODE], [MISNO], [MATERIALDESC], [TYPE], [ACCNO], [UNIT], [QTY]) VALUES (N'45', N'ITM-00006', N'MIS-00003', N'COMPUTER SET', N'HP', N'1150001', N'SET', N'1')
GO

SET IDENTITY_INSERT [dbo].[tblMISITEM] OFF
GO


-- ----------------------------
-- Table structure for tblMRSDESC
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMRSDESC]') AND type IN ('U'))
	DROP TABLE [dbo].[tblMRSDESC]
GO

CREATE TABLE [dbo].[tblMRSDESC] (
  [MRSNO] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [DATE] datetime2(7)  NULL,
  [POREFNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DR] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [SUPPLIERNAME] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ADDRESS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [REMARKS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TOTALAMOUNT] money  NULL,
  [RECEIVEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DELIVEREDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ISVATEXCEMPTED] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblMRSDESC] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblMRSDESC
-- ----------------------------
INSERT INTO [dbo].[tblMRSDESC]  VALUES (N'MRS-00001', N'2018-09-24 00:00:00.0000000', N'PO-00004', N'12312', N'OCTAGON', N'SM GENSAN', N'', N'26000.0000', N'RENZ', N'', N'YES')
GO


-- ----------------------------
-- Table structure for tblMRSITEM
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMRSITEM]') AND type IN ('U'))
	DROP TABLE [dbo].[tblMRSITEM]
GO

CREATE TABLE [dbo].[tblMRSITEM] (
  [MRSITEMID] int  IDENTITY(1,1) NOT NULL,
  [MRSNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [INVTYCODE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [MATERIALDESC] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TYPE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [UNIT] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [QUANTITY] int  NULL
)
GO

ALTER TABLE [dbo].[tblMRSITEM] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblMRSITEM
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblMRSITEM] ON
GO

INSERT INTO [dbo].[tblMRSITEM] ([MRSITEMID], [MRSNO], [INVTYCODE], [MATERIALDESC], [TYPE], [UNIT], [QUANTITY]) VALUES (N'1', N'MRS-00001', N'ITM-00009', N'ACER COMPUTER', N'ACER', N'1', N'1')
GO

SET IDENTITY_INSERT [dbo].[tblMRSITEM] OFF
GO


-- ----------------------------
-- Table structure for tblMWSDESC
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMWSDESC]') AND type IN ('U'))
	DROP TABLE [dbo].[tblMWSDESC]
GO

CREATE TABLE [dbo].[tblMWSDESC] (
  [MWSDESCNO] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [DATE] datetime2(7)  NULL,
  [sTO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [SECTION] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DEPARTMENT] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [JUSTIFICATION] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PREPAREDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [APPROVEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ISISSUED] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblMWSDESC] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblMWSDESC
-- ----------------------------
INSERT INTO [dbo].[tblMWSDESC]  VALUES (N'MWS-00001', N'2018-05-22 00:00:00.0000000', N'WAREHOUSE', N'PROGRAMMER', N'IT', N'', N'RODMAR DUMAGO', N'ELVIE DELA SERNA', N'YES')
GO

INSERT INTO [dbo].[tblMWSDESC]  VALUES (N'MWS-00002', N'2018-05-22 00:00:00.0000000', N'WAREHOUSE', N'PROGRAMMER', N'IT', N'', N'MARVIN BALADIANG', N'ELVIE DELA SERNA', N'YES')
GO

INSERT INTO [dbo].[tblMWSDESC]  VALUES (N'MWS-00003', N'2018-06-04 00:00:00.0000000', N'WAREHOUSE', N'PROGRAMMER', N'IT', N'', N'RODMAR DUMAGO', N'ELVIE DELA SERNA', N'YES')
GO

INSERT INTO [dbo].[tblMWSDESC]  VALUES (N'MWS-00004', N'2018-09-24 00:00:00.0000000', N'RODMAR DUMAGO', N'MIS', N'IT', N'', N'RODMAR DUMAGO', N'NEIL CACHUELA', N'CANCELLED')
GO

INSERT INTO [dbo].[tblMWSDESC]  VALUES (N'MWS-00005', N'2018-09-24 00:00:00.0000000', N'WAREHOUSE', N'MIS', N'IT', N'', N'RODMAR DUMAGO', N'NEIL CACHUELA', N'NO')
GO


-- ----------------------------
-- Table structure for tblMWSITEM
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMWSITEM]') AND type IN ('U'))
	DROP TABLE [dbo].[tblMWSITEM]
GO

CREATE TABLE [dbo].[tblMWSITEM] (
  [MWSITEMID] int  IDENTITY(1,1) NOT NULL,
  [MWSDESCNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [MATERIALDESC] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [UNIT] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [QTY] int  NULL
)
GO

ALTER TABLE [dbo].[tblMWSITEM] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblMWSITEM
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblMWSITEM] ON
GO

INSERT INTO [dbo].[tblMWSITEM] ([MWSITEMID], [MWSDESCNO], [MATERIALDESC], [UNIT], [QTY]) VALUES (N'16', N'MWS-00001', N'HP PRINTER', N'SET', N'1')
GO

INSERT INTO [dbo].[tblMWSITEM] ([MWSITEMID], [MWSDESCNO], [MATERIALDESC], [UNIT], [QTY]) VALUES (N'17', N'MWS-00002', N'EPSON PRINTER', N'SET', N'1')
GO

INSERT INTO [dbo].[tblMWSITEM] ([MWSITEMID], [MWSDESCNO], [MATERIALDESC], [UNIT], [QTY]) VALUES (N'18', N'MWS-00003', N'COMPUTER DESKTOP', N'SET', N'1')
GO

INSERT INTO [dbo].[tblMWSITEM] ([MWSITEMID], [MWSDESCNO], [MATERIALDESC], [UNIT], [QTY]) VALUES (N'20', N'MWS-00004', N'ACER COMPUTER', N'PC', N'1')
GO

INSERT INTO [dbo].[tblMWSITEM] ([MWSITEMID], [MWSDESCNO], [MATERIALDESC], [UNIT], [QTY]) VALUES (N'21', N'MWS-00005', N'PROJECTOR', N'PC', N'1')
GO

SET IDENTITY_INSERT [dbo].[tblMWSITEM] OFF
GO


-- ----------------------------
-- Table structure for tblParticulars
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblParticulars]') AND type IN ('U'))
	DROP TABLE [dbo].[tblParticulars]
GO

CREATE TABLE [dbo].[tblParticulars] (
  [PARTID] int  IDENTITY(1,1) NOT NULL,
  [CVNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PARTICULARS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [AMOUNT] money  NULL
)
GO

ALTER TABLE [dbo].[tblParticulars] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblParticulars
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblParticulars] ON
GO

INSERT INTO [dbo].[tblParticulars] ([PARTID], [CVNO], [PARTICULARS], [AMOUNT]) VALUES (N'9', N'CV-00001', N'DESKTOP COMPUTER', N'21500.0000')
GO

INSERT INTO [dbo].[tblParticulars] ([PARTID], [CVNO], [PARTICULARS], [AMOUNT]) VALUES (N'10', N'CV-00002', N'PAYMENT FOR DESKTOP COMPUTER', N'21500.0000')
GO

INSERT INTO [dbo].[tblParticulars] ([PARTID], [CVNO], [PARTICULARS], [AMOUNT]) VALUES (N'11', N'CV-00003', N'OFFICE SUPPLIES', N'7180.5700')
GO

INSERT INTO [dbo].[tblParticulars] ([PARTID], [CVNO], [PARTICULARS], [AMOUNT]) VALUES (N'12', N'CV-00004', N'PURCHASE COMPUTER', N'26785.7100')
GO

SET IDENTITY_INSERT [dbo].[tblParticulars] OFF
GO


-- ----------------------------
-- Table structure for tblPayroll
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPayroll]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPayroll]
GO

CREATE TABLE [dbo].[tblPayroll] (
  [PAYROLLID] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [EMPID] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DATEFROM] datetime2(7)  NULL,
  [DATETO] datetime2(7)  NULL,
  [REGWORKDAYS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [SPECHOLIDAYS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [NONWORKHOLIDAYS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [LEAVEPAY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [OVERTIME] varchar(255) COLLATE Latin1_General_CI_AS DEFAULT NULL NULL,
  [LATEUNDERTIME] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TOTALDEDUCTIONS] money  NULL,
  [GROSSPAY] money  NULL,
  [NETPAY] money  NULL,
  [DATEGENERATE] datetime2(7)  NULL
)
GO

ALTER TABLE [dbo].[tblPayroll] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPayroll
-- ----------------------------
INSERT INTO [dbo].[tblPayroll]  VALUES (N'PR-00001', N'EMP-00002', N'2018-06-16 00:00:00.0000000', N'2018-06-30 00:00:00.0000000', N'12', N'1', N'1', N'0', N'2', N'15', N'373.5000', N'4336.0000', N'3962.5000', N'2018-06-27 00:00:00.0000000')
GO


-- ----------------------------
-- Table structure for tblPayrollCash
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPayrollCash]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPayrollCash]
GO

CREATE TABLE [dbo].[tblPayrollCash] (
  [ID] int  IDENTITY(1,1) NOT NULL,
  [PAYROLLID] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [REGWORKCASH] money  NULL,
  [SPECHOLIDAYCASH] money  NULL,
  [NONWORKHOLIDAYCASH] money  NULL,
  [LEAVEPAYCASH] money  NULL,
  [OVERTIMECASH] money  NULL
)
GO

ALTER TABLE [dbo].[tblPayrollCash] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPayrollCash
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblPayrollCash] ON
GO

INSERT INTO [dbo].[tblPayrollCash] ([ID], [PAYROLLID], [REGWORKCASH], [SPECHOLIDAYCASH], [NONWORKHOLIDAYCASH], [LEAVEPAYCASH], [OVERTIMECASH]) VALUES (N'15', N'PR-00001', N'3840.0000', N'320.0000', N'96.0000', N'.0000', N'80.0000')
GO

INSERT INTO [dbo].[tblPayrollCash] ([ID], [PAYROLLID], [REGWORKCASH], [SPECHOLIDAYCASH], [NONWORKHOLIDAYCASH], [LEAVEPAYCASH], [OVERTIMECASH]) VALUES (N'16', N'PR-00002', N'4550.0000', N'.0000', N'.0000', N'.0000', N'.0000')
GO

SET IDENTITY_INSERT [dbo].[tblPayrollCash] OFF
GO


-- ----------------------------
-- Table structure for tblPayrollDeductions
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPayrollDeductions]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPayrollDeductions]
GO

CREATE TABLE [dbo].[tblPayrollDeductions] (
  [ID] int  IDENTITY(1,1) NOT NULL,
  [PAYROLLID] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [LATEUNDERTIMECASH] money  NULL,
  [SSS] money  NULL,
  [PAGIBIG] money  NULL,
  [PHILHEALTH] money  NULL,
  [WHOLDINGTAX] money  NULL,
  [CASHADVANCE] money  NULL
)
GO

ALTER TABLE [dbo].[tblPayrollDeductions] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPayrollDeductions
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblPayrollDeductions] ON
GO

INSERT INTO [dbo].[tblPayrollDeductions] ([ID], [PAYROLLID], [LATEUNDERTIMECASH], [SSS], [PAGIBIG], [PHILHEALTH], [WHOLDINGTAX], [CASHADVANCE]) VALUES (N'4', N'PR-00001', N'10.0000', N'163.5000', N'100.0000', N'100.0000', N'.0000', N'.0000')
GO

INSERT INTO [dbo].[tblPayrollDeductions] ([ID], [PAYROLLID], [LATEUNDERTIMECASH], [SSS], [PAGIBIG], [PHILHEALTH], [WHOLDINGTAX], [CASHADVANCE]) VALUES (N'5', N'PR-00002', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000')
GO

SET IDENTITY_INSERT [dbo].[tblPayrollDeductions] OFF
GO


-- ----------------------------
-- Table structure for tblPCV
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPCV]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPCV]
GO

CREATE TABLE [dbo].[tblPCV] (
  [PCVNO] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [REFNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DATE] datetime2(7)  NULL,
  [PAYEE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [SECTION] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DEPARTMENT] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [ACCNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ISSUEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [RECEIVEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TOTALDEBIT] money  NULL,
  [TOTALAMOUNT] money  NULL,
  [STATUS] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblPCV] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tblPCVItems
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPCVItems]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPCVItems]
GO

CREATE TABLE [dbo].[tblPCVItems] (
  [PARTID] int  IDENTITY(1,1) NOT NULL,
  [PCVNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PARTICULARS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DEBIT] money  NULL,
  [AMOUNT] money  NULL
)
GO

ALTER TABLE [dbo].[tblPCVItems] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for tblPODESC
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPODESC]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPODESC]
GO

CREATE TABLE [dbo].[tblPODESC] (
  [PONO] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [DATE] datetime2(7)  NULL,
  [PRSREF] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [SUPPLIERNAME] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ADDRESS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [CONTACTPERSON] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [CONTACTNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PAYMENTTERM] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TOTALAMOUNT] money  NULL,
  [REMARKS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PREPAREDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [RECOMMENDEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [APPROVEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [POSTATUS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TAXEXCEMPTED] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblPODESC] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPODESC
-- ----------------------------
INSERT INTO [dbo].[tblPODESC]  VALUES (N'PO-00001', N'2018-05-22 00:00:00.0000000', N'PRS-00001', N'COLUMBIA', N'J.CATHOLICO GENERAL SANTOS CITY', N'MITO SAMPLE', N'221-32221', N'', N'21500.0000', N'', N'RODMAR A. DUMAGO', N'NIEL CACHUELA', N'JAMES C. DAMALERIO', N'WAITING FOR ITEMS RECEIVED', N'NO')
GO

INSERT INTO [dbo].[tblPODESC]  VALUES (N'PO-00002', N'2018-06-04 00:00:00.0000000', N'PRS-00002', N'MICRO VALLEY', N'3RD FLOOR KCC, G.S.C.', N'MITA SAMPLE', N'221-32212', N'CASH', N'7180.5714', N'', N'RODMAR A. DUMAGO', N'NEIL CACHUELA', N'JAMES C. DAMALERIO', N'WAITING FOR ITEMS RECEIVED', N'YES')
GO

INSERT INTO [dbo].[tblPODESC]  VALUES (N'PO-00003', N'2018-06-04 00:00:00.0000000', N'PRS-00003', N'MICRO VALLEY', N'KCC, G.S.C.', N'MITA SAMPLE', N'221-323213', N'CASH', N'26785.7143', N'', N'RODMAR A. DUMAGO', N'NEIL CACHUELA', N'JAMES C. DAMALERIO', N'WAITING FOR ITEMS RECEIVED', N'YES')
GO

INSERT INTO [dbo].[tblPODESC]  VALUES (N'PO-00004', N'2018-09-24 00:00:00.0000000', N'PRS-00004', N'OCTAGON', N'SM GENSAN', N'', N'', N'CASH', N'26785.7143', N'COMPUTER', N'RODMAR A. DUMAGO', N'RODMAR DUMAGO', N'NEIL CACHUELA', N'RECEIVED', N'YES')
GO


-- ----------------------------
-- Table structure for tblPOITEM
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPOITEM]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPOITEM]
GO

CREATE TABLE [dbo].[tblPOITEM] (
  [POITEMID] int  IDENTITY(1,1) NOT NULL,
  [PONO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ITEMDESC] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TYPE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [UNIT] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [UPRICE] money  NULL,
  [QTY] int  NULL,
  [AMOUNT] money  NULL,
  [LESSVAT] money  NULL
)
GO

ALTER TABLE [dbo].[tblPOITEM] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPOITEM
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblPOITEM] ON
GO

INSERT INTO [dbo].[tblPOITEM] ([POITEMID], [PONO], [ITEMDESC], [TYPE], [UNIT], [UPRICE], [QTY], [AMOUNT], [LESSVAT]) VALUES (N'39', N'PO-00001', N'COMPUTER SET', N'HP', N'SET', N'21500.0000', N'1', N'21500.0000', N'.0000')
GO

INSERT INTO [dbo].[tblPOITEM] ([POITEMID], [PONO], [ITEMDESC], [TYPE], [UNIT], [UPRICE], [QTY], [AMOUNT], [LESSVAT]) VALUES (N'40', N'PO-00002', N'EPSON', N'IP2770', N'SET', N'3500.0000', N'2', N'6250.0000', N'3125.0000')
GO

INSERT INTO [dbo].[tblPOITEM] ([POITEMID], [PONO], [ITEMDESC], [TYPE], [UNIT], [UPRICE], [QTY], [AMOUNT], [LESSVAT]) VALUES (N'41', N'PO-00002', N'BONDPAPER', N'AONE', N'REAM', N'521.1200', N'2', N'930.5714', N'465.2857')
GO

INSERT INTO [dbo].[tblPOITEM] ([POITEMID], [PONO], [ITEMDESC], [TYPE], [UNIT], [UPRICE], [QTY], [AMOUNT], [LESSVAT]) VALUES (N'42', N'PO-00003', N'COMPUTER DESKTOP', N'ACER', N'SET', N'30000.0000', N'1', N'26785.7143', N'26785.7143')
GO

INSERT INTO [dbo].[tblPOITEM] ([POITEMID], [PONO], [ITEMDESC], [TYPE], [UNIT], [UPRICE], [QTY], [AMOUNT], [LESSVAT]) VALUES (N'43', N'PO-00004', N'ACER COMPUTER', N'ACER', N'PC', N'30000.0000', N'1', N'26785.7143', N'26785.7143')
GO

SET IDENTITY_INSERT [dbo].[tblPOITEM] OFF
GO


-- ----------------------------
-- Table structure for tblPRSDESC
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPRSDESC]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPRSDESC]
GO

CREATE TABLE [dbo].[tblPRSDESC] (
  [PRSNO] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [DATE] datetime2(7)  NULL,
  [REMARKS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PREPAREDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [APPROVEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [REQSTATUS] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblPRSDESC] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPRSDESC
-- ----------------------------
INSERT INTO [dbo].[tblPRSDESC]  VALUES (N'PRS-00001', N'2018-05-22 00:00:00.0000000', N'', N'RODMAR A. DUMAGO', N'NIEL CACHUELA', N'APPROVED FOR PO')
GO

INSERT INTO [dbo].[tblPRSDESC]  VALUES (N'PRS-00002', N'2018-05-31 00:00:00.0000000', N'', N'MARK L. APORADOR', N'NEIL CACHUELA', N'APPROVED FOR PO')
GO

INSERT INTO [dbo].[tblPRSDESC]  VALUES (N'PRS-00003', N'2018-06-04 00:00:00.0000000', N'', N'RODMAR A. DUMAGO', N'', N'APPROVED FOR PO')
GO

INSERT INTO [dbo].[tblPRSDESC]  VALUES (N'PRS-00004', N'2018-09-24 00:00:00.0000000', N'COMPUTER', N'RODMAR A. DUMAGO', N'NEIL CACHUELA', N'APPROVED FOR PO')
GO

INSERT INTO [dbo].[tblPRSDESC]  VALUES (N'PRS-00005', N'2018-09-24 00:00:00.0000000', N'', N'RODMAR A. DUMAGO', N'NEIL CACHUELA', N'PENDING FOR PO')
GO


-- ----------------------------
-- Table structure for tblPRSITEM
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPRSITEM]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPRSITEM]
GO

CREATE TABLE [dbo].[tblPRSITEM] (
  [PRSITEMID] int  IDENTITY(1,1) NOT NULL,
  [PRSNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [INVTYCODE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ITEMDESC] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [TYPE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [UNIT] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [QTY] int  NULL,
  [STOCKSONHAND] int  NULL
)
GO

ALTER TABLE [dbo].[tblPRSITEM] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPRSITEM
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblPRSITEM] ON
GO

INSERT INTO [dbo].[tblPRSITEM] ([PRSITEMID], [PRSNO], [INVTYCODE], [ITEMDESC], [TYPE], [UNIT], [QTY], [STOCKSONHAND]) VALUES (N'32', N'PRS-00001', N'ITM-00006', N'COMPUTER SET', N'HP', N'SET', N'1', N'2')
GO

INSERT INTO [dbo].[tblPRSITEM] ([PRSITEMID], [PRSNO], [INVTYCODE], [ITEMDESC], [TYPE], [UNIT], [QTY], [STOCKSONHAND]) VALUES (N'33', N'PRS-00002', N'ITM-00005', N'EPSON', N'IP2770', N'SET', N'2', N'3')
GO

INSERT INTO [dbo].[tblPRSITEM] ([PRSITEMID], [PRSNO], [INVTYCODE], [ITEMDESC], [TYPE], [UNIT], [QTY], [STOCKSONHAND]) VALUES (N'34', N'PRS-00002', N'-', N'BONDPAPER', N'AONE', N'REAM', N'2', N'0')
GO

INSERT INTO [dbo].[tblPRSITEM] ([PRSITEMID], [PRSNO], [INVTYCODE], [ITEMDESC], [TYPE], [UNIT], [QTY], [STOCKSONHAND]) VALUES (N'35', N'PRS-00003', N'-', N'COMPUTER DESKTOP', N'ACER', N'SET', N'1', N'0')
GO

INSERT INTO [dbo].[tblPRSITEM] ([PRSITEMID], [PRSNO], [INVTYCODE], [ITEMDESC], [TYPE], [UNIT], [QTY], [STOCKSONHAND]) VALUES (N'36', N'PRS-00004', N'-', N'ACER COMPUTER', N'ACER', N'PC', N'1', N'0')
GO

INSERT INTO [dbo].[tblPRSITEM] ([PRSITEMID], [PRSNO], [INVTYCODE], [ITEMDESC], [TYPE], [UNIT], [QTY], [STOCKSONHAND]) VALUES (N'37', N'PRS-00005', N'ITM-00008', N'BONDPAPER', N'UNIX', N'BOX', N'1', N'4')
GO

SET IDENTITY_INSERT [dbo].[tblPRSITEM] OFF
GO


-- ----------------------------
-- Table structure for tblRFC
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblRFC]') AND type IN ('U'))
	DROP TABLE [dbo].[tblRFC]
GO

CREATE TABLE [dbo].[tblRFC] (
  [RFCNO] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [DATE] datetime2(7)  NULL,
  [xTO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [SECTION] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DEPARTMENT] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PAYEE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PURPOSE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [IDNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [AMOUNT] money  NULL,
  [REQUESTEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [APPROVEDBY] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [STATUS] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblRFC] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblRFC
-- ----------------------------
INSERT INTO [dbo].[tblRFC]  VALUES (N'RFC-00001', N'2018-06-13 00:00:00.0000000', N'ASDASS', N'ASDASDAS', N'ASDASDASD', N'DASDASDAS', N'ASDASDAS', N'ASDASDAS', N'3123123.0000', N'ASDASDAS', N'ASDASDAS', N'APPROVED')
GO

INSERT INTO [dbo].[tblRFC]  VALUES (N'RFC-00002', N'2018-09-24 00:00:00.0000000', N'PCF CUSTODIAN', N'MIS', N'IT', N'RODMAR DUMAGO', N'PURCHASE PC ACCESSORIES', N'', N'5000.0000', N'RODMAR DUMAGO', N'NEIL CACHUELA', N'APPROVED')
GO


-- ----------------------------
-- Table structure for tblRFP
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblRFP]') AND type IN ('U'))
	DROP TABLE [dbo].[tblRFP]
GO

CREATE TABLE [dbo].[tblRFP] (
  [RFPNO] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [DATE] datetime2(7)  NULL,
  [PAYEE] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [ADDRESS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PAYMENTFOR] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PREPAREDBY] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [CHECKEDBY] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [APPROVEDBY] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [TOTALDEBIT] money  NULL,
  [TOTALCREDIT] money  NULL,
  [STATUS] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblRFP] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblRFP
-- ----------------------------
INSERT INTO [dbo].[tblRFP]  VALUES (N'RFP-00001', N'2018-06-13 00:00:00.0000000', N'OCTAGON', N'J. CATOLICO, G.S.C.', N'FOR COMPUTERS', N'RODMAR A. DUMAGO', N'CLARA MAE LABRADOR', N'NEIL CACHUELA', N'21500.0000', N'.0000', N'CHECK / CASH ISSUED')
GO


-- ----------------------------
-- Table structure for tblRFPItems
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblRFPItems]') AND type IN ('U'))
	DROP TABLE [dbo].[tblRFPItems]
GO

CREATE TABLE [dbo].[tblRFPItems] (
  [PARTID] int  IDENTITY(1,1) NOT NULL,
  [RFPNO] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [PARTICULARS] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [DEBIT] money  NULL,
  [CREDIT] money  NULL
)
GO

ALTER TABLE [dbo].[tblRFPItems] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblRFPItems
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblRFPItems] ON
GO

INSERT INTO [dbo].[tblRFPItems] ([PARTID], [RFPNO], [PARTICULARS], [DEBIT], [CREDIT]) VALUES (N'13', N'RFP-00001', N'PAYMENT FOR DESKTOP COMPUTERS', N'21500.0000', N'.0000')
GO

SET IDENTITY_INSERT [dbo].[tblRFPItems] OFF
GO


-- ----------------------------
-- Table structure for tblUsers
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblUsers]') AND type IN ('U'))
	DROP TABLE [dbo].[tblUsers]
GO

CREATE TABLE [dbo].[tblUsers] (
  [userID] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [username] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [password] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [name] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [role] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [isActive] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblUsers] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblUsers
-- ----------------------------
INSERT INTO [dbo].[tblUsers]  VALUES (N'USR-00001', N'admin', N'1234', N'RODMAR A. DUMAGO', N'ADMIN', N'YES')
GO

INSERT INTO [dbo].[tblUsers]  VALUES (N'USR-00002', N'mark1', N'mark', N'MARK L. APORADOR', N'PURCHASER', N'YES')
GO


-- ----------------------------
-- Primary Key structure for table tblAccCategories
-- ----------------------------
ALTER TABLE [dbo].[tblAccCategories] ADD CONSTRAINT [PK__tblAccCa__A50F98966EF57B66] PRIMARY KEY CLUSTERED ([CATEGORYID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblAccountEntry
-- ----------------------------
ALTER TABLE [dbo].[tblAccountEntry] ADD CONSTRAINT [PK__tblAccou__6D2E14816754599E] PRIMARY KEY CLUSTERED ([ACCENTRYID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblCOA
-- ----------------------------
ALTER TABLE [dbo].[tblCOA] ADD CONSTRAINT [PK__tblCOA__FBD3D3A95AEE82B9] PRIMARY KEY CLUSTERED ([ACCNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblcoaType
-- ----------------------------
ALTER TABLE [dbo].[tblcoaType] ADD CONSTRAINT [PK__tblcoaGr__2F4118CB5165187F] PRIMARY KEY CLUSTERED ([TYPENO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblCV
-- ----------------------------
ALTER TABLE [dbo].[tblCV] ADD CONSTRAINT [PK__tblCV__A0A838495FB337D6] PRIMARY KEY CLUSTERED ([CVNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblEmployee
-- ----------------------------
ALTER TABLE [dbo].[tblEmployee] ADD CONSTRAINT [PK__tblEmplo__14CCD97D33D4B598] PRIMARY KEY CLUSTERED ([EMPID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblMISDESC
-- ----------------------------
ALTER TABLE [dbo].[tblMISDESC] ADD CONSTRAINT [PK__tblMISDE__6ABD73352F10007B] PRIMARY KEY CLUSTERED ([MISNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblMISITEM
-- ----------------------------
ALTER TABLE [dbo].[tblMISITEM] ADD CONSTRAINT [PK__tblMISIT__1869D81C3F466844] PRIMARY KEY CLUSTERED ([MISITEMID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblMRSDESC
-- ----------------------------
ALTER TABLE [dbo].[tblMRSDESC] ADD CONSTRAINT [PK__tblMRSDE__DE8569F131EC6D26] PRIMARY KEY CLUSTERED ([MRSNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblMRSITEM
-- ----------------------------
ALTER TABLE [dbo].[tblMRSITEM] ADD CONSTRAINT [PK__tblMRSIT__09CEBC691A14E395] PRIMARY KEY CLUSTERED ([MRSITEMID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblMWSDESC
-- ----------------------------
ALTER TABLE [dbo].[tblMWSDESC] ADD CONSTRAINT [PK__tblMWSDE__43110C3B267ABA7A] PRIMARY KEY CLUSTERED ([MWSDESCNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblMWSITEM
-- ----------------------------
ALTER TABLE [dbo].[tblMWSITEM] ADD CONSTRAINT [PK_tblMWSITEM] PRIMARY KEY CLUSTERED ([MWSITEMID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblParticulars
-- ----------------------------
ALTER TABLE [dbo].[tblParticulars] ADD CONSTRAINT [PK__tblParti__9A9CFCF26383C8BA] PRIMARY KEY CLUSTERED ([PARTID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPayroll
-- ----------------------------
ALTER TABLE [dbo].[tblPayroll] ADD CONSTRAINT [PK__tblPayro__94B051E637A5467C] PRIMARY KEY CLUSTERED ([PAYROLLID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPayrollCash
-- ----------------------------
ALTER TABLE [dbo].[tblPayrollCash] ADD CONSTRAINT [PK__tblPayro__3214EC273C69FB99] PRIMARY KEY CLUSTERED ([ID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPayrollDeductions
-- ----------------------------
ALTER TABLE [dbo].[tblPayrollDeductions] ADD CONSTRAINT [PK__tblDeduc__3214EC27403A8C7D] PRIMARY KEY CLUSTERED ([ID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPCV
-- ----------------------------
ALTER TABLE [dbo].[tblPCV] ADD CONSTRAINT [PK__tblPCV__7AD558E3300424B4] PRIMARY KEY CLUSTERED ([PCVNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPCVItems
-- ----------------------------
ALTER TABLE [dbo].[tblPCVItems] ADD CONSTRAINT [PK__tblPCVIt__9A9CFCF247DBAE45] PRIMARY KEY CLUSTERED ([PARTID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPODESC
-- ----------------------------
ALTER TABLE [dbo].[tblPODESC] ADD CONSTRAINT [PK__tblPODES__5F02AAA72C3393D0] PRIMARY KEY CLUSTERED ([PONO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPOITEM
-- ----------------------------
ALTER TABLE [dbo].[tblPOITEM] ADD CONSTRAINT [PK_tblPOITEM] PRIMARY KEY CLUSTERED ([POITEMID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPRSDESC
-- ----------------------------
ALTER TABLE [dbo].[tblPRSDESC] ADD CONSTRAINT [PK__tblPRSDE__0433594134C8D9D1] PRIMARY KEY CLUSTERED ([PRSNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPRSITEM
-- ----------------------------
ALTER TABLE [dbo].[tblPRSITEM] ADD CONSTRAINT [PK__tblPRSIT__77A279120AD2A005] PRIMARY KEY CLUSTERED ([PRSITEMID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblRFP
-- ----------------------------
ALTER TABLE [dbo].[tblRFP] ADD CONSTRAINT [PK__tblRFP__ABF47D872D27B809] PRIMARY KEY CLUSTERED ([RFPNO])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblRFPItems
-- ----------------------------
ALTER TABLE [dbo].[tblRFPItems] ADD CONSTRAINT [PK__tblRFPIt__9A9CFCF25441852A] PRIMARY KEY CLUSTERED ([PARTID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblUsers
-- ----------------------------
ALTER TABLE [dbo].[tblUsers] ADD CONSTRAINT [PK__tblUsers__CB9A1CDF4CA06362] PRIMARY KEY CLUSTERED ([userID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


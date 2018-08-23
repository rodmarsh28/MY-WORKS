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

 Date: 16/08/2018 17:00:38
*/


-- ----------------------------
-- Table structure for tblBenefitsPaymentSum
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblBenefitsPaymentSum]') AND type IN ('U'))
	DROP TABLE [dbo].[tblBenefitsPaymentSum]
GO

CREATE TABLE [dbo].[tblBenefitsPaymentSum] (
  [premsID] int  IDENTITY(1,1) NOT NULL,
  [empPayrollTransNo] int  NULL,
  [erSSS] money  NULL,
  [erPI] money  NULL,
  [erPH] money  NULL
)
GO

ALTER TABLE [dbo].[tblBenefitsPaymentSum] SET (LOCK_ESCALATION = TABLE)
GO


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
-- Records of tblEmployeesInfo
-- ----------------------------
INSERT INTO [dbo].[tblEmployeesInfo]  VALUES (N'EMP-00001', N'asdasda', N'asdasd', N'asdads', N'asdasdsa', N'sadasda', N'sadasdasd', N'asdasda', N'Male', N'2018-07-12 00:00:00.0000000', N'Single', N'', N'', N'adasdasd', N'350', N'1', N'Daily', N'2018-07-12 00:00:00.0000000', N'Regular', N'Work Hours', N'', N'', N'', N'', N'', N'Employees Info Added 07/12/2018')
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
-- Table structure for tblPayroll
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPayroll]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPayroll]
GO

CREATE TABLE [dbo].[tblPayroll] (
  [payrollID] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [dateCreated] datetime2(7)  NULL,
  [dateFrom] datetime2(7)  NULL,
  [dateTo] datetime2(7)  NULL,
  [totalEmployees] int  NULL,
  [totalOvertime] money  NULL,
  [totalGrossPay] money  NULL,
  [totalDeduction] money  NULL,
  [totalNetpay] money  NULL,
  [preparedBy] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [remarks] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblPayroll] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPayroll
-- ----------------------------
INSERT INTO [dbo].[tblPayroll]  VALUES (N'PR-00002', N'2018-08-14 00:00:00.0000000', N'2018-08-01 00:00:00.0000000', N'2018-08-15 00:00:00.0000000', N'1', N'.0000', N'4189.0600', N'.0000', N'4189.0600', N'Unknown', N'Payroll Generated:08/14/2018')
GO

INSERT INTO [dbo].[tblPayroll]  VALUES (N'PR-00003', N'2018-08-14 00:00:00.0000000', N'2018-08-16 00:00:00.0000000', N'2018-08-31 00:00:00.0000000', N'1', N'.0000', N'4189.0600', N'.0000', N'4189.0600', N'Unknown', N'Payroll Generated:08/14/2018')
GO

INSERT INTO [dbo].[tblPayroll]  VALUES (N'PR-00004', N'2018-08-14 00:00:00.0000000', N'2018-09-01 00:00:00.0000000', N'2018-09-15 00:00:00.0000000', N'1', N'.0000', N'4189.0600', N'.0000', N'4189.0600', N'Unknown', N'Payroll Generated:08/14/2018')
GO

INSERT INTO [dbo].[tblPayroll]  VALUES (N'PR-00005', N'2018-08-14 00:00:00.0000000', N'2018-09-16 00:00:00.0000000', N'2018-09-30 00:00:00.0000000', N'1', N'.0000', N'4189.0600', N'.0000', N'4189.0600', N'Unknown', N'Payroll Generated:08/14/2018')
GO


-- ----------------------------
-- Table structure for tblPayrollofEmployees
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblPayrollofEmployees]') AND type IN ('U'))
	DROP TABLE [dbo].[tblPayrollofEmployees]
GO

CREATE TABLE [dbo].[tblPayrollofEmployees] (
  [empPayrollTransNo] int  IDENTITY(1,1) NOT NULL,
  [payrollID] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [employeeID] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [totalWorkedDays] int  NULL,
  [absent] int  NULL,
  [regHolidays] int  NULL,
  [NonWorkHolidays] int  NULL,
  [leavePay] int  NULL,
  [overtimeHRS] int  NULL,
  [restdayReportHRS] int  NULL,
  [lateUTMins] int  NULL,
  [basicPay] money  NULL,
  [regHolidayPay] money  NULL,
  [nonWorkHolidayPay] money  NULL,
  [leavePayCash] money  NULL,
  [overtimePay] money  NULL,
  [restdayReportAmount] money  NULL,
  [lateUndertimeDed] money  NULL,
  [cashAdvance] money  NULL,
  [wHoldingTax] money  NULL,
  [sssPrems] money  NULL,
  [piPrems] money  NULL,
  [phPrems] money  NULL,
  [sssLoans] money  NULL,
  [piLoans] money  NULL,
  [ledgerBalance] money  NULL,
  [grossPay] money  NULL,
  [Deduction] money  NULL,
  [Netpay] money  NULL
)
GO

ALTER TABLE [dbo].[tblPayrollofEmployees] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblPayrollofEmployees
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblPayrollofEmployees] ON
GO

INSERT INTO [dbo].[tblPayrollofEmployees] ([empPayrollTransNo], [payrollID], [employeeID], [totalWorkedDays], [absent], [regHolidays], [NonWorkHolidays], [leavePay], [overtimeHRS], [restdayReportHRS], [lateUTMins], [basicPay], [regHolidayPay], [nonWorkHolidayPay], [leavePayCash], [overtimePay], [restdayReportAmount], [lateUndertimeDed], [cashAdvance], [wHoldingTax], [sssPrems], [piPrems], [phPrems], [sssLoans], [piLoans], [ledgerBalance], [grossPay], [Deduction], [Netpay]) VALUES (N'2', N'PR-00002', N'EMP-00001', N'12', N'1', N'0', N'0', N'0', N'0', N'0', N'15', N'4200.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'10.9400', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'4189.0600', N'.0000', N'4189.0600')
GO

SET IDENTITY_INSERT [dbo].[tblPayrollofEmployees] OFF
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
-- Table structure for tblSystemSettings
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSystemSettings]') AND type IN ('U'))
	DROP TABLE [dbo].[tblSystemSettings]
GO

CREATE TABLE [dbo].[tblSystemSettings] (
  [systemID] int  NOT NULL,
  [backupDir] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblSystemSettings] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Primary Key structure for table tblBenefitsPaymentSum
-- ----------------------------
ALTER TABLE [dbo].[tblBenefitsPaymentSum] ADD CONSTRAINT [PK__tblBenef__9FE512694CA06362] PRIMARY KEY CLUSTERED ([premsID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
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
-- Primary Key structure for table tblPayroll
-- ----------------------------
ALTER TABLE [dbo].[tblPayroll] ADD CONSTRAINT [PK__tblPayro__EBDFA71A03317E3D] PRIMARY KEY CLUSTERED ([payrollID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tblPayrollofEmployees
-- ----------------------------
ALTER TABLE [dbo].[tblPayrollofEmployees] ADD CONSTRAINT [PK__tblPayro__AB921DDA0EA330E9] PRIMARY KEY CLUSTERED ([empPayrollTransNo])
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


-- ----------------------------
-- Primary Key structure for table tblSystemSettings
-- ----------------------------
ALTER TABLE [dbo].[tblSystemSettings] ADD CONSTRAINT [PK__tblSyste__5C4AE16E145C0A3F] PRIMARY KEY CLUSTERED ([systemID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


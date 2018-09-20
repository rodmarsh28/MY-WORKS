/*
 Navicat Premium Data Transfer

 Source Server         : generalLedgerDB
 Source Server Type    : SQL Server
 Source Server Version : 10001600
 Source Host           : dfarm3:1433
 Source Catalog        : GFLSPAYROLLDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 10001600
 File Encoding         : 65001

 Date: 18/09/2018 10:54:31
*/


-- ----------------------------
-- Table structure for tblBenefitsPaymentSum
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblBenefitsPaymentSum]') AND type IN ('U'))
	DROP TABLE [dbo].[tblBenefitsPaymentSum]
GO

CREATE TABLE [dbo].[tblBenefitsPaymentSum] (
  [premsID] int  IDENTITY(1,1) NOT NULL,
  [payrollID] varchar(50) COLLATE Latin1_General_CI_AS  NULL,
  [empPayrollTransNo] int  NULL,
  [erSSS] money  NULL,
  [erPI] money  NULL,
  [erPH] money  NULL
)
GO

ALTER TABLE [dbo].[tblBenefitsPaymentSum] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblBenefitsPaymentSum
-- ----------------------------
SET IDENTITY_INSERT [dbo].[tblBenefitsPaymentSum] ON
GO

INSERT INTO [dbo].[tblBenefitsPaymentSum] ([premsID], [payrollID], [empPayrollTransNo], [erSSS], [erPI], [erPH]) VALUES (N'8', N'PR-00002', N'80', N'.0000', N'.0000', N'.0000')
GO

INSERT INTO [dbo].[tblBenefitsPaymentSum] ([premsID], [payrollID], [empPayrollTransNo], [erSSS], [erPI], [erPH]) VALUES (N'9', N'PR-00002', N'81', N'1208.7000', N'100.0000', N'284.5200')
GO

SET IDENTITY_INSERT [dbo].[tblBenefitsPaymentSum] OFF
GO


-- ----------------------------
-- Table structure for tblEmployee
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tblEmployee]') AND type IN ('U'))
	DROP TABLE [dbo].[tblEmployee]
GO

CREATE TABLE [dbo].[tblEmployee] (
  [empid] varchar(255) COLLATE Latin1_General_CI_AS  NOT NULL,
  [lastname] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [firstname] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [middlename] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [address] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [contactNo] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [birthDate] datetime2(7)  NULL,
  [gender] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [civilStatus] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [position] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [rate] int  NULL,
  [payMethod] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [dateHired] datetime2(7)  NULL,
  [Status] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [sss] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [tin] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [pagibig] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [philhealth] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [allowPremsDeductions] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [remarks] varchar(255) COLLATE Latin1_General_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tblEmployee] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tblEmployee
-- ----------------------------
INSERT INTO [dbo].[tblEmployee]  VALUES (N'EMP-00001', N'DUMAGO', N'RODMAR', N'AGUILAR', N'GREENVILLE, CALUMPANG GENERAL SANTOS CITY', N'12312321', N'1996-06-19 00:00:00.0000000', N'Male', N'Single', N'TEACHER 1', N'20000', N'Monthly', N'2017-10-01 00:00:00.0000000', N'Active', N'SADSAD', N'ASDASD', N'ASDASD', N'ASDASDAS', N'Yes', N'Employee Updated of 18/07/2018 8:43:48 AM')
GO

INSERT INTO [dbo].[tblEmployee]  VALUES (N'EMP-00002', N'ADSDASD', N'ASDASDA', N'ASDASD', N'ASDASDA', N'ASDASDASD', N'2017-10-01 00:00:00.0000000', N'Male', N'Single', N'11231', N'10000', N'Monthly', N'2018-07-13 00:00:00.0000000', N'Active', N'', N'', N'', N'', N'No', N'Employee Added of 13/07/2018 4:01:16 PM')
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
INSERT INTO [dbo].[tblPayroll]  VALUES (N'PR-00001', N'2018-08-28 00:00:00.0000000', N'2018-08-01 00:00:00.0000000', N'2018-08-15 00:00:00.0000000', N'2', N'192.3100', N'15000.0000', N'.0000', N'15000.0000', N'rodmar dumago', N'Payroll Generated:08/28/2018')
GO

INSERT INTO [dbo].[tblPayroll]  VALUES (N'PR-00002', N'2018-09-06 00:00:00.0000000', N'2018-08-16 00:00:00.0000000', N'2018-08-31 00:00:00.0000000', N'2', N'288.4600', N'16021.6300', N'965.8200', N'15055.8100', N'Rodmar Dumago', N'Payroll Generated:09/06/2018')
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
  [empID] varchar(255) COLLATE Latin1_General_CI_AS  NULL,
  [absent] money  NULL,
  [regHolidays] int  NULL,
  [NonWorkHolidays] int  NULL,
  [leavePay] int  NULL,
  [overtimeHRS] money  NULL,
  [lateUTMins] int  NULL,
  [basicPay] money  NULL,
  [absentInAmount] money  NULL,
  [regHolidayPay] money  NULL,
  [nonWorkHolidayPay] money  NULL,
  [leavePayCash] money  NULL,
  [overtimePay] money  NULL,
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

INSERT INTO [dbo].[tblPayrollofEmployees] ([empPayrollTransNo], [payrollID], [empID], [absent], [regHolidays], [NonWorkHolidays], [leavePay], [overtimeHRS], [lateUTMins], [basicPay], [absentInAmount], [regHolidayPay], [nonWorkHolidayPay], [leavePayCash], [overtimePay], [lateUndertimeDed], [cashAdvance], [wHoldingTax], [sssPrems], [piPrems], [phPrems], [sssLoans], [piLoans], [ledgerBalance], [grossPay], [Deduction], [Netpay]) VALUES (N'65', N'PR-00001', N'EMP-00002', N'2.0000', N'0', N'0', N'0', N'.0000', N'0', N'5000.0000', N'96.1500', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'4903.8500', N'.0000', N'4903.8500')
GO

INSERT INTO [dbo].[tblPayrollofEmployees] ([empPayrollTransNo], [payrollID], [empID], [absent], [regHolidays], [NonWorkHolidays], [leavePay], [overtimeHRS], [lateUTMins], [basicPay], [absentInAmount], [regHolidayPay], [nonWorkHolidayPay], [leavePayCash], [overtimePay], [lateUndertimeDed], [cashAdvance], [wHoldingTax], [sssPrems], [piPrems], [phPrems], [sssLoans], [piLoans], [ledgerBalance], [grossPay], [Deduction], [Netpay]) VALUES (N'66', N'PR-00001', N'EMP-00001', N'1.0000', N'0', N'0', N'0', N'2.0000', N'0', N'10000.0000', N'96.1500', N'.0000', N'.0000', N'.0000', N'192.3100', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'10096.1500', N'.0000', N'10096.1500')
GO

INSERT INTO [dbo].[tblPayrollofEmployees] ([empPayrollTransNo], [payrollID], [empID], [absent], [regHolidays], [NonWorkHolidays], [leavePay], [overtimeHRS], [lateUTMins], [basicPay], [absentInAmount], [regHolidayPay], [nonWorkHolidayPay], [leavePayCash], [overtimePay], [lateUndertimeDed], [cashAdvance], [wHoldingTax], [sssPrems], [piPrems], [phPrems], [sssLoans], [piLoans], [ledgerBalance], [grossPay], [Deduction], [Netpay]) VALUES (N'80', N'PR-00002', N'EMP-00002', N'3.5500', N'0', N'0', N'500', N'2.0000', N'0', N'5000.0000', N'170.6700', N'.0000', N'.0000', N'500.0000', N'96.1500', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'.0000', N'5425.4800', N'.0000', N'5425.4800')
GO

INSERT INTO [dbo].[tblPayrollofEmployees] ([empPayrollTransNo], [payrollID], [empID], [absent], [regHolidays], [NonWorkHolidays], [leavePay], [overtimeHRS], [lateUTMins], [basicPay], [absentInAmount], [regHolidayPay], [nonWorkHolidayPay], [leavePayCash], [overtimePay], [lateUndertimeDed], [cashAdvance], [wHoldingTax], [sssPrems], [piPrems], [phPrems], [sssLoans], [piLoans], [ledgerBalance], [grossPay], [Deduction], [Netpay]) VALUES (N'81', N'PR-00002', N'EMP-00001', N'4.1200', N'0', N'0', N'800', N'2.0000', N'0', N'10000.0000', N'396.1500', N'.0000', N'.0000', N'800.0000', N'192.3100', N'.0000', N'.0000', N'.0000', N'581.3000', N'100.0000', N'284.5200', N'.0000', N'.0000', N'.0000', N'10596.1500', N'965.8200', N'9630.3300')
GO

SET IDENTITY_INSERT [dbo].[tblPayrollofEmployees] OFF
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
-- Primary Key structure for table tblEmployee
-- ----------------------------
ALTER TABLE [dbo].[tblEmployee] ADD CONSTRAINT [PK__tblEmplo__AF4CE8657F60ED59] PRIMARY KEY CLUSTERED ([empid])
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
-- Primary Key structure for table tblSystemSettings
-- ----------------------------
ALTER TABLE [dbo].[tblSystemSettings] ADD CONSTRAINT [PK__tblSyste__5C4AE16E145C0A3F] PRIMARY KEY CLUSTERED ([systemID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


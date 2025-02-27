USE [RiskApetite]
GO
ALTER TABLE [dbo].[UserProfile] DROP CONSTRAINT [FK_UserProfile_Role]
GO
ALTER TABLE [dbo].[SeverityForAnalysis] DROP CONSTRAINT [FK_SeverityForAnalysis_UserProfile]
GO
ALTER TABLE [dbo].[SeverityForAnalysis] DROP CONSTRAINT [FK_SeverityForAnalysis_SeverityForAnalysis]
GO
ALTER TABLE [dbo].[Severity] DROP CONSTRAINT [FK_Severity_UserProfile]
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserProfile]') AND type in (N'U'))
DROP TABLE [dbo].[UserProfile]
GO
/****** Object:  Table [dbo].[SeverityForAnalysis]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SeverityForAnalysis]') AND type in (N'U'))
DROP TABLE [dbo].[SeverityForAnalysis]
GO
/****** Object:  Table [dbo].[Severity]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Severity]') AND type in (N'U'))
DROP TABLE [dbo].[Severity]
GO
/****** Object:  Table [dbo].[SEBMarket_Risk]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SEBMarket_Risk]') AND type in (N'U'))
DROP TABLE [dbo].[SEBMarket_Risk]
GO
/****** Object:  Table [dbo].[SEBMacroeconomics]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SEBMacroeconomics]') AND type in (N'U'))
DROP TABLE [dbo].[SEBMacroeconomics]
GO
/****** Object:  Table [dbo].[SEBLiquidity_Risk]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SEBLiquidity_Risk]') AND type in (N'U'))
DROP TABLE [dbo].[SEBLiquidity_Risk]
GO
/****** Object:  Table [dbo].[SEBForcasted_Financial_Statement]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SEBForcasted_Financial_Statement]') AND type in (N'U'))
DROP TABLE [dbo].[SEBForcasted_Financial_Statement]
GO
/****** Object:  Table [dbo].[SEBCredit_risk]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SEBCredit_risk]') AND type in (N'U'))
DROP TABLE [dbo].[SEBCredit_risk]
GO
/****** Object:  Table [dbo].[SEBActual_financial_statement]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SEBActual_financial_statement]') AND type in (N'U'))
DROP TABLE [dbo].[SEBActual_financial_statement]
GO
/****** Object:  Table [dbo].[SDBLiquidity]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SDBLiquidity]') AND type in (N'U'))
DROP TABLE [dbo].[SDBLiquidity]
GO
/****** Object:  Table [dbo].[SDBForcastFinancialStatment]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SDBForcastFinancialStatment]') AND type in (N'U'))
DROP TABLE [dbo].[SDBForcastFinancialStatment]
GO
/****** Object:  Table [dbo].[SDBCredit]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SDBCredit]') AND type in (N'U'))
DROP TABLE [dbo].[SDBCredit]
GO
/****** Object:  Table [dbo].[SDBActualFinancialStatement]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SDBActualFinancialStatement]') AND type in (N'U'))
DROP TABLE [dbo].[SDBActualFinancialStatement]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Role]') AND type in (N'U'))
DROP TABLE [dbo].[Role]
GO
/****** Object:  Table [dbo].[Oprational_risk]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Oprational_risk]') AND type in (N'U'))
DROP TABLE [dbo].[Oprational_risk]
GO
/****** Object:  Table [dbo].[Market_risk]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Market_risk]') AND type in (N'U'))
DROP TABLE [dbo].[Market_risk]
GO
/****** Object:  Table [dbo].[APCredit]    Script Date: 11/04/2024 10:30:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[APCredit]') AND type in (N'U'))
DROP TABLE [dbo].[APCredit]
GO
/****** Object:  User [addisgashaw]    Script Date: 11/04/2024 10:30:53 ******/
DROP USER [addisgashaw]
GO
USE [master]
GO
/****** Object:  Database [RiskApetite]    Script Date: 11/04/2024 10:30:53 ******/
DROP DATABASE [RiskApetite]
GO

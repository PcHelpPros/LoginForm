USE [LoginDatabase]
GO

/****** Object: Table [dbo].[UserRegistration] Script Date: 4/6/2018 12:11:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserRegistration] (
    [UserID]       INT           NOT NULL,
    [First Name]    NVARCHAR (50) NOT NULL,
    [Last Name]     NVARCHAR (50) NOT NULL,
    [Username] NVARCHAR (50) NOT NULL,
    [Email Address]   NVARCHAR (50) NOT NULL,
    [Phone Number]   NVARCHAR (50) NOT NULL,   
);



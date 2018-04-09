USE [LoginDatabase]
GO

/****** Object: Table [dbo].[User Registration] Script Date: 4/9/2018 3:04:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User_Registration] (
    [UserID]        INT           IDENTITY (1, 1) NOT NULL,
    [First_Name]    NVARCHAR (50) NOT NULL,
    [Last_Name]     NVARCHAR (50) NOT NULL,
    [Username]      NVARCHAR (50) NOT NULL,
    [Password]      NVARCHAR (50) COLLATE Latin1_General_BIN2  ENCRYPTED WITH (
     COLUMN_ENCRYPTION_KEY = [CEK_Auto1],
     ALGORITHM = N'AEAD_AES_256_CBC_HMAC_SHA_256',
     ENCRYPTION_TYPE = RANDOMIZED
    ) NOT NULL,
    [Email_Address] NVARCHAR (50) NOT NULL,
    [Phone_Numbers] NVARCHAR (50) NULL
);



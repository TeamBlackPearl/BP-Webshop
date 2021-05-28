CREATE DATABASE BlackPearl_DBV2;
GO

use BlackPearl_DBV2;
CREATE TABLE [dbo].[AdminUsers] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Email]     NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [FirstName] NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [LastName]  NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [Password]  NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [Role]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AdminUsers] PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Users] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Email]       NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [Address]     NVARCHAR (MAX) NULL,
    [PhoneNumber] NVARCHAR (8)   NOT NULL,
    [FirstName]   NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [LastName]    NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [Password]    NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [Role]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Bracelets] (
    [JewelryID]      INT             IDENTITY (1, 1) NOT NULL,
    [BraceletLength] FLOAT (53)      NOT NULL,
    [BraceletWidth]  FLOAT (53)      NOT NULL,
    [JewelryTitle]   NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [Description]    NVARCHAR (150)  DEFAULT (N'') NOT NULL,
    [Color]          NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [Price]          DECIMAL (18, 2) NOT NULL,
    [AverageRating]  FLOAT (53)      NOT NULL,
    [ImageLink]      NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [BraceletType]   INT             DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Bracelets] PRIMARY KEY CLUSTERED ([JewelryID] ASC)
);

CREATE TABLE [dbo].[Earrings] (
    [JewelryID]     INT             IDENTITY (1, 1) NOT NULL,
    [EarringLength] FLOAT (53)      NOT NULL,
    [JewelryTitle]  NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [Description]   NVARCHAR (150)  DEFAULT (N'') NOT NULL,
    [Color]         NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [Price]         DECIMAL (18, 2) NOT NULL,
    [AverageRating] FLOAT (53)      NOT NULL,
    [ImageLink]     NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [EarringType]   INT             DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Earrings] PRIMARY KEY CLUSTERED ([JewelryID] ASC)
);
CREATE TABLE [dbo].[HeadJewelries] (
    [JewelryID]       INT             IDENTITY (1, 1) NOT NULL,
    [HeadJewelrySize] NVARCHAR (MAX)  NULL,
    [JewelryTitle]    NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [Description]     NVARCHAR (150)  DEFAULT (N'') NOT NULL,
    [Color]           NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [Price]           DECIMAL (18, 2) NOT NULL,
    [AverageRating]   FLOAT (53)      NOT NULL,
    [ImageLink]       NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [HeadJewType]     INT             DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_HeadJewelries] PRIMARY KEY CLUSTERED ([JewelryID] ASC)
);
CREATE TABLE [dbo].[Necklaces] (
    [JewelryID]      INT             IDENTITY (1, 1) NOT NULL,
    [NecklaceLength] FLOAT (53)      NOT NULL,
    [NecklaceWidth]  FLOAT (53)      NOT NULL,
    [JewelryTitle]   NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [Description]    NVARCHAR (150)  DEFAULT (N'') NOT NULL,
    [Color]          NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [Price]          DECIMAL (18, 2) NOT NULL,
    [AverageRating]  FLOAT (53)      NOT NULL,
    [ImageLink]      NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [NecklaceType]   INT             DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Necklaces] PRIMARY KEY CLUSTERED ([JewelryID] ASC)
);
CREATE TABLE [dbo].[Rings] (
    [JewelryID]     INT             IDENTITY (1, 1) NOT NULL,
    [JewelryTitle]  NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [Description]   NVARCHAR (150)  DEFAULT (N'') NOT NULL,
    [Color]         NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [Price]         DECIMAL (18, 2) NOT NULL,
    [AverageRating] FLOAT (53)      NOT NULL,
    [ImageLink]     NVARCHAR (MAX)  DEFAULT (N'') NOT NULL,
    [RingSize]      INT             DEFAULT ((0)) NOT NULL,
    [RingWidth]     FLOAT (53)      DEFAULT ((0.0000000000000000e+000)) NOT NULL,
    [RingType]      INT             DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Rings] PRIMARY KEY CLUSTERED ([JewelryID] ASC)
);
CREATE TABLE [dbo].[OrderLines] (
    [OrderLineId]  INT IDENTITY (1, 1) NOT NULL,
    [OrderId]      INT NOT NULL,
    [JewelryId]    INT NOT NULL,
    [ProductCount] INT NOT NULL,
    CONSTRAINT [PK_OrderLines] PRIMARY KEY CLUSTERED ([OrderLineId] ASC)
);
CREATE TABLE [dbo].[Orders] (
    [OrderId]       INT             IDENTITY (1, 1) NOT NULL,
    [OrderDate]     DATETIME2 (7)   NOT NULL,
    [Id]            INT             NOT NULL,
    [DeliveryPrice] DECIMAL (18, 2) NOT NULL,
    [TotalPrice]    DECIMAL (18, 2) NOT NULL,
    [UserId]        INT             NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Orders_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

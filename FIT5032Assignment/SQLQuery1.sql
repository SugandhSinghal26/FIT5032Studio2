CREATE TABLE [dbo].[Users](
   [Id] int IDENTITY(1,1) NOT NUll,
   [Name] nvarchar(max) NOT Null,
   [UserId]   nvarchar(max)  NOT Null
   PRIMARY KEY(ID)

);
GO

CREATE TABLE [dbo].[DietPlan](
      [Id] int IDENTITY(1,1) NOT NULL,
      [Name]  nvarchar(max) NOT NULL,
      [Level] nvarchar(max) NOT Null,
      [Description] nvarchar(max) NOT NULL
      PRIMARY KEY(Id),
      FOREIGN KEY(UserId) REFERENCES Users(Id)

);
GO


CREATE TABLE [dbo].[Exercises](
      [Id] int IDENTITY(1,1) NOT NULL,
      [Name]  nvarchar(max) NOT NULL,
      [Description] nvarchar(max) NOT NULL
      PRIMARY KEY(Id)
    
);
GO




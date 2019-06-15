
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/25/2019 12:11:58
-- Generated from EDMX file: C:\Demos\20190525\ConsoleApplication2\Database2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [StudentID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [CourseID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Scores'
CREATE TABLE [dbo].[Scores] (
    [ScoreID] int IDENTITY(1,1) NOT NULL,
    [Value] int  NOT NULL,
    [Course_CourseID] int  NOT NULL,
    [Student_StudentID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [StudentID] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([StudentID] ASC);
GO

-- Creating primary key on [CourseID] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([CourseID] ASC);
GO

-- Creating primary key on [ScoreID] in table 'Scores'
ALTER TABLE [dbo].[Scores]
ADD CONSTRAINT [PK_Scores]
    PRIMARY KEY CLUSTERED ([ScoreID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Course_CourseID] in table 'Scores'
ALTER TABLE [dbo].[Scores]
ADD CONSTRAINT [FK_CourseScore]
    FOREIGN KEY ([Course_CourseID])
    REFERENCES [dbo].[Courses]
        ([CourseID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseScore'
CREATE INDEX [IX_FK_CourseScore]
ON [dbo].[Scores]
    ([Course_CourseID]);
GO

-- Creating foreign key on [Student_StudentID] in table 'Scores'
ALTER TABLE [dbo].[Scores]
ADD CONSTRAINT [FK_StudentScore]
    FOREIGN KEY ([Student_StudentID])
    REFERENCES [dbo].[Students]
        ([StudentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentScore'
CREATE INDEX [IX_FK_StudentScore]
ON [dbo].[Scores]
    ([Student_StudentID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
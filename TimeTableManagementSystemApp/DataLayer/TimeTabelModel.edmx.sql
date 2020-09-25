
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/25/2020 22:22:25
-- Generated from EDMX file: C:\Users\Hasitha Samarasekara\source\repos\TimeTableManagmentSystemForSLIIT\TimeTableManagementSystemApp\DataLayer\TimeTabelModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TimetableManagementSystem];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BuildingID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rooms] DROP CONSTRAINT [FK_BuildingID];
GO
IF OBJECT_ID(N'[dbo].[FK_BuildingIDLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Location] DROP CONSTRAINT [FK_BuildingIDLocation];
GO
IF OBJECT_ID(N'[dbo].[FK_RoomIDLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Location] DROP CONSTRAINT [FK_RoomIDLocation];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Buildings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Buildings];
GO
IF OBJECT_ID(N'[dbo].[Lecturers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lecturers];
GO
IF OBJECT_ID(N'[dbo].[Location]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Location];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[Programmes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Programmes];
GO
IF OBJECT_ID(N'[dbo].[Rooms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rooms];
GO
IF OBJECT_ID(N'[dbo].[StudentDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentDetails];
GO
IF OBJECT_ID(N'[dbo].[Subjects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Subjects];
GO
IF OBJECT_ID(N'[dbo].[Tags]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tags];
GO
IF OBJECT_ID(N'[dbo].[workingDaysAndHours]', 'U') IS NOT NULL
    DROP TABLE [dbo].[workingDaysAndHours];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Buildings'
CREATE TABLE [dbo].[Buildings] (
    [id] int IDENTITY(1,1) NOT NULL,
    [BuidingName] varchar(255)  NOT NULL
);
GO

-- Creating table 'Lecturers'
CREATE TABLE [dbo].[Lecturers] (
    [id] int IDENTITY(1,1) NOT NULL,
    [lId] char(6)  NULL,
    [lName] varchar(255)  NOT NULL,
    [lFaculty] varchar(255)  NULL,
    [lDepartment] varchar(255)  NULL,
    [lCenter] varchar(255)  NULL,
    [lBuilding] varchar(255)  NULL,
    [lLevel] int  NOT NULL,
    [lRank] varchar(10)  NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [id] int IDENTITY(1,1) NOT NULL,
    [BuildingID] int  NULL,
    [RoomID] int  NULL
);
GO

-- Creating table 'Locations1'
CREATE TABLE [dbo].[Locations1] (
    [id] int IDENTITY(1,1) NOT NULL,
    [BuildingID] int  NULL,
    [RoomID] int  NULL
);
GO

-- Creating table 'Programmes'
CREATE TABLE [dbo].[Programmes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ProgrammeName] varchar(255)  NOT NULL
);
GO

-- Creating table 'Rooms'
CREATE TABLE [dbo].[Rooms] (
    [id] int IDENTITY(1,1) NOT NULL,
    [RoomName] varchar(255)  NOT NULL,
    [Capacity] int  NULL,
    [RoomType] int  NULL,
    [BuildingID] int  NULL
);
GO

-- Creating table 'StudentDetails'
CREATE TABLE [dbo].[StudentDetails] (
    [StudentId] varchar(255)  NOT NULL,
    [AcademicYearSemester] varchar(255)  NULL,
    [Programme] varchar(255)  NULL,
    [GroupNumber] int  NULL,
    [GroupId] varchar(255)  NULL,
    [SubGroupNumber] int  NULL,
    [SubGroupId] varchar(255)  NULL
);
GO

-- Creating table 'Subjects'
CREATE TABLE [dbo].[Subjects] (
    [id] int IDENTITY(1,1) NOT NULL,
    [sCode] varchar(10)  NOT NULL,
    [sName] varchar(255)  NOT NULL,
    [offYear] int  NOT NULL,
    [offSemester] int  NOT NULL,
    [lecHours] int  NULL,
    [tutHours] int  NULL,
    [labHours] int  NULL,
    [evaHours] int  NULL
);
GO

-- Creating table 'Tags'
CREATE TABLE [dbo].[Tags] (
    [id] int IDENTITY(1,1) NOT NULL,
    [TagName] varchar(255)  NOT NULL,
    [ShortName] varchar(255)  NULL
);
GO

-- Creating table 'workingDaysAndHours'
CREATE TABLE [dbo].[workingDaysAndHours] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [WorkingDaysPerWeek] int  NULL,
    [Monday] varchar(255)  NULL,
    [Tuesday] varchar(255)  NULL,
    [Wednesday] varchar(255)  NULL,
    [Thursday] varchar(255)  NULL,
    [Friday] varchar(255)  NULL,
    [Saturday] varchar(255)  NULL,
    [Sunday] varchar(255)  NULL,
    [workingTime] varchar(255)  NULL,
    [OneHourTimeSlots] int  NULL,
    [ThirtyMinutesTimeSlots] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Buildings'
ALTER TABLE [dbo].[Buildings]
ADD CONSTRAINT [PK_Buildings]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Lecturers'
ALTER TABLE [dbo].[Lecturers]
ADD CONSTRAINT [PK_Lecturers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Locations1'
ALTER TABLE [dbo].[Locations1]
ADD CONSTRAINT [PK_Locations1]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Programmes'
ALTER TABLE [dbo].[Programmes]
ADD CONSTRAINT [PK_Programmes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Rooms'
ALTER TABLE [dbo].[Rooms]
ADD CONSTRAINT [PK_Rooms]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [StudentId] in table 'StudentDetails'
ALTER TABLE [dbo].[StudentDetails]
ADD CONSTRAINT [PK_StudentDetails]
    PRIMARY KEY CLUSTERED ([StudentId] ASC);
GO

-- Creating primary key on [id] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [PK_Subjects]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Tags'
ALTER TABLE [dbo].[Tags]
ADD CONSTRAINT [PK_Tags]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'workingDaysAndHours'
ALTER TABLE [dbo].[workingDaysAndHours]
ADD CONSTRAINT [PK_workingDaysAndHours]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BuildingID] in table 'Rooms'
ALTER TABLE [dbo].[Rooms]
ADD CONSTRAINT [FK_BuildingID]
    FOREIGN KEY ([BuildingID])
    REFERENCES [dbo].[Buildings]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BuildingID'
CREATE INDEX [IX_FK_BuildingID]
ON [dbo].[Rooms]
    ([BuildingID]);
GO

-- Creating foreign key on [BuildingID] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [FK_BuildingIDLocation]
    FOREIGN KEY ([BuildingID])
    REFERENCES [dbo].[Buildings]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BuildingIDLocation'
CREATE INDEX [IX_FK_BuildingIDLocation]
ON [dbo].[Locations]
    ([BuildingID]);
GO

-- Creating foreign key on [RoomID] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [FK_RoomIDLocation]
    FOREIGN KEY ([RoomID])
    REFERENCES [dbo].[Rooms]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoomIDLocation'
CREATE INDEX [IX_FK_RoomIDLocation]
ON [dbo].[Locations]
    ([RoomID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
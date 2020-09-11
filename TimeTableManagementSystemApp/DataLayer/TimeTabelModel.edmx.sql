
-- Creating table 'WorkingDays'
CREATE TABLE [dbo].[WorkingDays] (
    [WorkingDayID] int IDENTITY(1,1) NOT NULL,
    [workingdayGroup] varchar(100)  NULL,
    [workingdayYear] int  NULL,
    [workingdaySemester] int  NULL,
    [workingday1] varchar(100)  NULL,
    [workingday2] varchar(100)  NULL,
    [workingday3] varchar(100)  NULL,
    [workingday4] varchar(100)  NULL,
    [workingday5] varchar(100)  NULL,
    [workingday6] varchar(100)  NULL,
    [workingday7] varchar(100)  NULL,
    [workingdayOneHourTimeSlots] int  NULL,
    [ThirtyMinutesTimeSlots] int  NULL
);
GO

-- Creating primary key on [WorkingDayID] in table 'WorkingDays'
ALTER TABLE [dbo].[WorkingDays]
ADD CONSTRAINT [PK_WorkingDays]
    PRIMARY KEY CLUSTERED ([WorkingDayID] ASC);
GO

-----------------------------------------
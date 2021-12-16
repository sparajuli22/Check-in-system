CREATE TABLE [dbo].[OtherVisits] (
    [V_ID]     INT           NULL,
    [Vs_Email] VARCHAR (255) NULL,
    FOREIGN KEY ([V_ID]) REFERENCES [dbo].[Visits] ([ID]),
    FOREIGN KEY ([Vs_Email]) REFERENCES [dbo].[Visitor] ([Email])
);


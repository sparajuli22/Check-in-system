CREATE TABLE [dbo].[Visits] (
    [ID]        INT           NOT NULL,
    [Purpose]   VARCHAR (255) NULL,
    [IC_ID]     INT           NULL,
    [EntryTime] DATETIME2 (2) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([IC_ID]) REFERENCES [dbo].[ISC_Staff] ([ID])
);


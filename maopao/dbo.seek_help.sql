CREATE TABLE [dbo].[seek help] (
    [Title]           NCHAR (30) NOT NULL,
    [Content]         NTEXT      NOT NULL,
    [NeedRemoteHelp]  NCHAR (10) NULL,
    [Reward]          INT        NULL,
    [PublishDateTime] DATETIME   NOT NULL,
    PRIMARY KEY CLUSTERED ([Title] ASC)
);


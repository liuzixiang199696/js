CREATE TABLE [dbo].[registered] (
    [number]                INT        IDENTITY (1, 1) NOT NULL,
    [user name]             NCHAR (10) NOT NULL,
    [Password]              NCHAR (20) NOT NULL,
    [Verification Password] NCHAR (20) NOT NULL,
    [Inviter]               NCHAR (10) NULL,
    [Invitation code]       INT        NULL,
    [Verification Code]     NCHAR (4)  NOT NULL,
    PRIMARY KEY CLUSTERED ([number] ASC)
);


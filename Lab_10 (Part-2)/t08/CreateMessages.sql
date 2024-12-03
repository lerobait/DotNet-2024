CREATE TABLE [dbo].[Messages] (
    [MessageID]       INT           IDENTITY (1, 1) NOT NULL,
    [SenderUserID]    INT           NOT NULL,
    [RecipientUserID] INT           NOT NULL,
    [Theme]           NVARCHAR(100) NOT NULL,
    [Text]            NVARCHAR(MAX) NOT NULL,
    [Date]            DATETIME      NOT NULL,
    CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED ([MessageID] ASC),
    CONSTRAINT [FK_Messages_SenderUser] FOREIGN KEY ([SenderUserID]) REFERENCES [dbo].[Users] ([UserID]),
    CONSTRAINT [FK_Messages_RecipientUser] FOREIGN KEY ([RecipientUserID]) REFERENCES [dbo].[Users] ([UserID])
);

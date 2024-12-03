CREATE TABLE [dbo].[Users] (
    [UserID]   INT            IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR(50)   NOT NULL,
    [Password] NVARCHAR(255)  NOT NULL,
    [Email]    NVARCHAR(100)  NOT NULL,
    [Phone]    NVARCHAR(20)   NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserID] ASC),
    CONSTRAINT [UQ_Users_Username] UNIQUE ([Username]),
    CONSTRAINT [UQ_Users_Email] UNIQUE ([Email]),
    CONSTRAINT [UQ_Users_Phone] UNIQUE ([Phone])
);

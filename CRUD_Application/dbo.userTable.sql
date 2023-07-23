CREATE TABLE [dbo].[userTable] (
    [id]    INT           NOT NULL,
    [name]  NVARCHAR (50) NOT NULL,
    [email] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_userTable] PRIMARY KEY CLUSTERED ([id] ASC)
);


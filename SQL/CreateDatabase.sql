USE master;

DROP Database if exists newsApplication;
GO
Create Database NewsApplication;
GO

USE NewsApplication;
CREATE TABLE Article(
	Id INT NOT NULL ,
	Headline VARCHAR(100) NOT NULL,
	Content  VARCHAR NOT NULL,
	Created DATETIME2 NOT NULL,
	Author Varchar(50),
	CONSTRAINT PK_Article PRIMARY KEY(Id)
);

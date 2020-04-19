USE [Vidzy]
GO

/****** Object:  StoredProcedure [dbo].[spAddVideo]    Script Date: 4/18/2020 8:09:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spAddVideo]
(
	@Name varchar(255),
	@ReleaseDate datetime,
	@GenreId tinyInt,
	@Classification tinyInt
)
AS


	INSERT INTO Videos (Name, ReleaseDate, GenreId, Classification)
	VALUES (@Name, @ReleaseDate, @GenreId, @Classification)

GO



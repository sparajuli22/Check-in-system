
CREATE PROCEDURE [dbo].[usp_CheckLogin] (@ID varchar(255), @Pwd varchar(255))
AS
SELECT count(*) AS [Count]
FROM LoginInfo
WHERE LoginID = 'lgonzalez' and Password = 'lgonzalez123'
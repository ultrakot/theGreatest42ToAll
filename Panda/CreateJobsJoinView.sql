CREATE VIEW [dbo].[Jobs_view] AS
SELECT MAX([dbo].[Test_JobTitles].JobTitleId) JobTitleId, MAX([dbo].[Test_JobTitles].[JobTitleName]) [JobTitleName], [dbo].[Test_Jobs].[State], [dbo].[Test_Jobs].City
FROM [Test_Jobs]
JOIN [dbo].[Test_JobTitles]
ON [dbo].[Test_JobTitles].JobTitleId = [dbo].[Test_Jobs].JobTitleId
GROUP BY [dbo].[Test_JobTitles].[JobTitleName],[dbo].[Test_Jobs].[State], [dbo].[Test_Jobs].City;
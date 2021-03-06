
USE [MartianRationDB]
GO
/****** Object:  Table [dbo].[PacketRation]    Script Date: 27/12/2019 7:06:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PacketRation](
	[PacketId] [int] IDENTITY(1,1) NOT NULL,
	[PacketTypeId] [int] NULL,
	[PacketContent] [varchar](max) NULL,
	[Calories] [decimal](18, 2) NULL,
	[ExpiryDate] [datetime] NULL,
	[Quantity] [decimal](18, 2) NULL,
 CONSTRAINT [PK_PacketRation] PRIMARY KEY CLUSTERED 
(
	[PacketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PacketType]    Script Date: 27/12/2019 7:06:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PacketType](
	[PacketTypeId] [int] IDENTITY(1,1) NOT NULL,
	[PacketNameType] [varchar](24) NULL,
 CONSTRAINT [PK_PacketType] PRIMARY KEY CLUSTERED 
(
	[PacketTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PacketRation] ON 

INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (1, 1, N'MRP', CAST(500.00 AS Decimal(18, 2)), CAST(N'2020-11-02T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (3, 2, NULL, NULL, NULL, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (6, 1, N'Rice', CAST(1000.00 AS Decimal(18, 2)), CAST(N'2020-05-12T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (7, 1, N'Dry fruits', CAST(1000.00 AS Decimal(18, 2)), CAST(N'2020-10-06T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (8, 1, N'Biscuits', CAST(2000.00 AS Decimal(18, 2)), NULL, NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (9, 2, NULL, NULL, NULL, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (11, 2, NULL, NULL, NULL, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (12, 2, NULL, NULL, NULL, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (13, 1, N'Apple Pie', CAST(600.00 AS Decimal(18, 2)), CAST(N'2020-11-08T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (14, 1, N'Protein Bar', CAST(2500.00 AS Decimal(18, 2)), CAST(N'2020-09-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (15, 1, N'Nutella', CAST(3000.00 AS Decimal(18, 2)), CAST(N'2020-09-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (16, 1, N'Nutella Choclate Bar', CAST(3500.00 AS Decimal(18, 2)), CAST(N'2020-09-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (17, 1, N'Chocalate Cyrup', CAST(4000.00 AS Decimal(18, 2)), CAST(N'2020-09-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (18, 2, NULL, NULL, NULL, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (19, 2, NULL, NULL, NULL, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (23, 1, N'Peanut', CAST(500.00 AS Decimal(18, 2)), CAST(N'2020-09-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (28, 1, N'Soya Dish', CAST(3000.00 AS Decimal(18, 2)), CAST(N'2019-12-28T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (29, 1, N'Veg Burger', CAST(700.00 AS Decimal(18, 2)), CAST(N'2019-12-28T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (30, 2, NULL, NULL, NULL, CAST(4.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (31, 1, N'Pizza', CAST(1000.00 AS Decimal(18, 2)), CAST(N'2019-12-29T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (32, 1, N'French Fries', CAST(600.00 AS Decimal(18, 2)), CAST(N'2019-12-29T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (33, 2, NULL, NULL, NULL, CAST(1.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (34, 1, N'HotDog', CAST(700.00 AS Decimal(18, 2)), CAST(N'2019-12-30T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (35, 1, N'Hydrabadi Biryani', CAST(800.00 AS Decimal(18, 2)), CAST(N'2019-12-31T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (36, 2, NULL, NULL, NULL, CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (37, 2, NULL, NULL, NULL, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (38, 2, NULL, NULL, NULL, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (39, 2, NULL, NULL, NULL, CAST(2.00 AS Decimal(18, 2)))
INSERT [dbo].[PacketRation] ([PacketId], [PacketTypeId], [PacketContent], [Calories], [ExpiryDate], [Quantity]) VALUES (40, 2, NULL, NULL, NULL, CAST(2.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[PacketRation] OFF
SET IDENTITY_INSERT [dbo].[PacketType] ON 

INSERT [dbo].[PacketType] ([PacketTypeId], [PacketNameType]) VALUES (1, N'Food')
INSERT [dbo].[PacketType] ([PacketTypeId], [PacketNameType]) VALUES (2, N'Water')
SET IDENTITY_INSERT [dbo].[PacketType] OFF
/****** Object:  StoredProcedure [dbo].[getViewSchedule]    Script Date: 27/12/2019 7:06:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
-- EXEC [dbo].[getViewSchedule] '12/27/2019 12:00:00 AM'
CREATE PROCEDURE [dbo].[getViewSchedule]
(
	@StartDate datetime = NULL
)
AS
BEGIN
	--declare @date date = '12/24/2019'
	--declare @dateWater date = '12/24/2019'

	SET FMTONLY OFF;

	set nocount off 

	declare @date datetime = @StartDate
	declare @dateWater datetime = @StartDate



	SELECT ROW_NUMBER() OVER(ORDER BY [Quantity]) AS RowId,
	@date AS StartDate , [PacketId]
	,[PacketTypeId]
	,[PacketContent]
	,[Calories]
	,[ExpiryDate]
	,[Quantity]
	INTO #TempFood1
	FROM [MartianRationDB ].[dbo].[PacketRation] where [Calories]>=2500.00 and [ExpiryDate]>=@StartDate order by [ExpiryDate] 
	--select * from #TempFood1

	--select * from #Temp
	delete from #TempFood1 where [ExpiryDate]< StartDate
	update #TempFood1 set StartDate = DATEADD(dd,RowId-1,@date)


	SELECT
	ROW_NUMBER() OVER(ORDER BY [Quantity]) AS RowId,
	@date t , [PacketId]
	,[PacketTypeId]
	,[PacketContent]
	,[Calories]
	,[ExpiryDate]
	,[Quantity]
	INTO #TempFood2
	FROM [MartianRationDB ].[dbo].[PacketRation] where [Calories]<2500.00  and [ExpiryDate]>=@StartDate  order by [ExpiryDate] 
	--select * from #Temp2


	declare @datetemp date, @count int = 0
	select @datetemp= max(StartDate) from #TempFood1

	select @count = count(*) from #TempFood2
	set @datetemp = DATEADD(dd,1,@datetemp)
	while(@count>0)
	begin

	declare @calo decimal(18,2) = 0.00
	while( @calo<2500.00 and @count>0)
	begin
	declare @calotemp decimal(18,2) = 0.00, @packetid int

	-------
	select top 1 @calotemp=Calories , @packetid = PacketId from #TempFood2 ORDER BY ABS( 2500.00 -  ([Calories] +@calo)) ,[ExpiryDate]

	set @calo = @calo+ @calotemp

	SET IDENTITY_INSERT #TempFood1 ON  
	INSERT INTO #TempFood1(RowId,StartDate,PacketId,PacketTypeId,PacketContent,Calories,ExpiryDate,Quantity)
	select RowId,
	@datetemp
	,[PacketId]
	,[PacketTypeId]
	,[PacketContent]
	,[Calories]
	,[ExpiryDate]
	,[Quantity] from #TempFood2 where PacketId = @packetid
	SET IDENTITY_INSERT #TempFood1 OFF  

	delete from #TempFood2 where PacketId = @packetid
	select @count = count(*) from #TempFood2
	--select @count
	end


	set @datetemp = DATEADD(dd,1,@datetemp)


	end

	--select * from #TempFood1 ORDER BY t ASC
	--select StartDate from #TempFood1   group by StartDate having sum (Calories)>=2500.00 and min(ExpiryDate)<StartDate
	if exists (select StartDate from #TempFood1  group by StartDate having sum (Calories)>=2500.00  and min(ExpiryDate)<StartDate )
					 BEGIN
					 --select 'reorder'

					 --select * from #TempFood1 
					 select StartDate, max(ExpiryDate) maxExpiryDate , min (ExpiryDate) minExpiryDate
					 into #TempReorder


					  from #TempFood1   group by StartDate having sum (Calories)>=2500.00
					--select * from #TempReorder

					select @count = count(*) from #TempReorder
	 
						while(@count>0)
							BEGIN
							declare @maxExpiryDate date, @minExpiryDate date
							select top (1) @StartDate= StartDate,@maxExpiryDate= maxExpiryDate ,@minExpiryDate= minExpiryDate
							 from #TempReorder

							if exists (select * from #TempFood1 where  StartDate<= @StartDate group by StartDate  having min(ExpiryDate) >=@StartDate)
							 BEGIN
							 declare @tempStartDate date
								select top(1) @tempStartDate =StartDate from #TempFood1 where  StartDate<= @StartDate group by StartDate  having min(ExpiryDate) >=@StartDate
								--select @tempStartDate 
								update #TempFood1 set StartDate = null where StartDate = @tempStartDate
								update #TempFood1 set StartDate = @tempStartDate where StartDate = @StartDate
								update #TempFood1 set StartDate = @StartDate where StartDate is null
							 End
							 delete from #TempReorder where @StartDate= StartDate
							 select @count = count(*) from #TempReorder
							 --select * from #TempFood1
							END
					 END
	-----------------------------------------------------Water-----------------------------------

	SELECT
	ROW_NUMBER() OVER(ORDER BY [Quantity]) AS RowId,
	@dateWater AS StartDate, [PacketId]
	,[PacketTypeId]
	,[PacketContent]
	,[Calories]
	,[ExpiryDate]
	,[Quantity]
	INTO #TempWater1
	FROM [MartianRationDB ].[dbo].[PacketRation] where Quantity>=2
	update #TempWater1 set StartDate = DATEADD(dd,RowId-1,@dateWater)
	--select * from #TempWater1

	SELECT
	ROW_NUMBER() OVER(ORDER BY [Quantity]) AS RowId,
	@dateWater t , [PacketId]
	,[PacketTypeId]
	,[PacketContent]
	,[Calories]
	,[ExpiryDate]
	,[Quantity]
	INTO #TempWater2
	FROM [MartianRationDB ].[dbo].[PacketRation] where Quantity<2

	--select * from #Temp2


	declare @dateTempWater date, @countWater int = 0
	select @dateTempWater= max(StartDate) from #TempWater1

	select @countWater = count(*) from #TempWater2
	set @dateTempWater = DATEADD(dd,1,@dateTempWater)
	while(@countWater>0)
	begin

	declare @Qty decimal(18,2) = 0.00
	while( @Qty<2 and @countWater>0)
	begin
	declare @QtyTemp decimal(18,2) = 0.00, @waterPacketId int

	select top 1 @QtyTemp = Quantity , @waterPacketId = PacketId from #TempWater2  ORDER BY ABS( 2 -  (Quantity +@Qty))  

	set @Qty = @Qty+ @QtyTemp

	SET IDENTITY_INSERT #TempWater1 ON  
	INSERT INTO #TempWater1(RowId,StartDate,PacketId,PacketTypeId,PacketContent,Calories,ExpiryDate,Quantity)
	select RowId,
	@dateTempWater
	, [PacketId]
	,[PacketTypeId]
	,[PacketContent]
	,[Calories]
	,[ExpiryDate]
	,[Quantity] from #TempWater2 where PacketId = @waterPacketId
	SET IDENTITY_INSERT #TempWater1 OFF

	delete from #TempWater2 where PacketId = @waterPacketId
	select @countWater = count(*) from #TempWater2
	--select @countWater
	end


	set @dateTempWater = DATEADD(dd,1,@dateTempWater)


	end;

	--select * from #TempWater1


	WITH CTE AS
	( 
	    SELECT RowId,StartDate,PacketId,PacketTypeId,PacketContent,Calories,ExpiryDate,Quantity FROM #TempFood1 
		UNION ALL
		SELECT RowId,StartDate,PacketId,PacketTypeId,PacketContent,Calories,ExpiryDate,Quantity FROM #TempWater1 
	)
	SELECT * INTO #TempFoodWater FROM CTE





 	DELETE FROM #TempFoodWater 
	WHERE StartDate IN 
	(
		SELECT StartDate 
		FROM #TempFoodWater 
		GROUP BY StartDate
	    HAVING SUM(Calories)<2500.00 or sum (Quantity) <2 or sum (Quantity) is null or sum (Calories) is null
	 )

	--SELECT  RowId, Convert(datetime,StartDate) AS ScheduleDate,PacketId,PacketTypeId,ExpiryDate,
	SELECT  RowId, parse(CONVERT(varchar, StartDate) as datetime) AS ScheduleDate,PacketId,PacketTypeId,ExpiryDate,
	CASE
		WHEN PacketContent IS NULL THEN '-'
		ELSE PacketContent
		END AS PacketContent,
	CASE
		WHEN PacketTypeId = 1 THEN 'Food'
		WHEN PacketTypeId = 2 THEN 'Water' 
		ELSE CONVERT(varchar, PacketTypeId)
	END AS PacketType,
	CASE
	WHEN CONVERT(varchar, Calories) IS NULL THEN '-'
	ELSE CONVERT(varchar, Calories)
	END AS Calories,
	CASE
	WHEN CONVERT(varchar, Quantity) IS NULL THEN '-'
	ELSE CONVERT(varchar, Quantity)
	END AS Quantity,
	CASE
		WHEN PacketTypeId = 1 THEN ('F'+CONVERT(varchar, PacketId)) 
		WHEN PacketTypeId = 2 THEN ('W'+CONVERT(varchar, PacketId)) 
		ELSE CONVERT(varchar, PacketId)
	END AS QuantityText	

	FROM #TempFoodWater
	ORDER BY ScheduleDate ASC

	--DROP TABLE #TempFood1,#TempFood2,#TempWater1,#TempWater2,#TempFoodWater

END

GO

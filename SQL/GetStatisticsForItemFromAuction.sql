DROP PROCEDURE GetStatisticsForItemFromAuction IF EXISTS
DELIMITER //
CREATE procedure GetStatisticsForItemFromAuction (GetItemID int(10))
begin
SELECT * FROM
(SELECT COUNT(*) AS 'NoOfAuctions', AVG(Buyout) AS 'Mean', STDDEV(Buyout) AS 'Std. Deviation'
FROM auction WHERE Item_ID =GetItemID) AS t1,
(SELECT
	Buyout AS 'Median'
FROM (SELECT
	 @i:=@i+1 as Row_Num
,	Buyout
,	(SELECT count(1) from auction WHERE Item_ID = GetItemID) as Count
FROM (SELECT Buyout FROM auction
WHERE Item_ID = GetItemID
ORDER BY Buyout) main, (SELECT @i:=0) AS foo
) final
WHERE Row_Num = Count/2) AS t2,
(SELECT Buyout AS 'Mode' FROM Auction GROUP BY Buyout ORDER BY COUNT(*) DESC LIMIT 1) AS t3;
end
// 
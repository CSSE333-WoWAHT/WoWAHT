
DROP PROCEDURE IF EXISTS GetStatisticsForServer
DELIMITER //
CREATE PROCEDURE GetStatisticsForServer (ServerID smallint(10))
Begin
SELECT * FROM
(SELECT COUNT(*) AS 'NoOfAuctionsToday' FROM Auction WHERE Server_ID = 129 AND Listed_At <= current_timestamp() AND
Listed_At >= addtime(current_timestamp(),  -current_time())) AS Table1,
(SELECT COUNT(*) AS 'NoOfAuctionsInLastTwoWeeks' FROM Auction WHERE Server_ID = 129 AND Listed_At <=current_timestamp AND 
Listed_at >= DATE_ADD(current_timestamp, INTERVAL -2 WEEK)) AS Table2,
(SELECT COUNT(*) AS 'NoOfAuctionsEver' FROM Auction WHERE Server_ID = 129) AS Table3;

End
//
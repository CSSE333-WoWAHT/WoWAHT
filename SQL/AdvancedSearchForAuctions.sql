DROP PROCEDURE IF EXISTS AdvancedSearchForAuctions
DELIMITER ;;
CREATE PROCEDURE AdvancedSearchForAuctions (ItemName VarChar(50), Quantity_1 SmallInt, MaxBid Binary, MaxBuyout Binary,
 PlayerName VarChar(40), TimeRemaining VarChar(10), NoOfResults int, QntyGrtrThn Bit(1))
BEGIN
	if(NoOfResults IS NOT Null) then
		Set SQL_SELECT_LIMIT = NoOfResults;
	END IF;
	SELECT * FROM auctions WHERE (ItemName IS Null OR Name LIKE (ItemName + '%') ) AND (MaxBid IS Null OR Bid<=MaxBid) AND
    (MaxBuyout IS Null OR Buyout<=MaxBuyout) AND (TimeRemaining is Null OR 'Time'= TimeRemaining) AND (Quantity_1 is Null OR
    (QntyGrtrThn =1 AND Quantity_1 <= Quantity)OR(QntyGrtrThn=0 AND Quantity_1 >= Quantity)) ;
	Set SQL_SELECT_LIMIT = Default;
END;;
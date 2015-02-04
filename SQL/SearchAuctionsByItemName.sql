DROP PROCEDURE IF EXISTS SearchAuctionsByItemName
DELIMITER ;;
CREATE PROCEDURE SearchAuctionsByItemName (ItemName VarChar(50), NoOfResults int)
BEGIN
	if(NoOfResults IS NOT Null) then
		Set SQL_SELECT_LIMIT = NoOfResults;
	END IF; 
	SELECT * FROM auctions WHERE name LIKE (ItemName + '%') ;
	Set SQL_SELECT_LIMIT = Default;
END;;
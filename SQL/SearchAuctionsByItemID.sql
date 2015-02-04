DROP PROCEDURE IF EXISTS SearchAuctionsByItemID
DELIMITER ;;
CREATE PROCEDURE SearchAuctionsByItemID (ItemID VarChar(50), NoOfResults int)
BEGIN
	if(NoOfResults IS NOT Null) then
		Set SQL_SELECT_LIMIT = NoOfResults;
	END IF; 
	SELECT * FROM auctions WHERE WoW_Item_ID (ItemID) ;
	Set SQL_SELECT_LIMIT = Default;
END;;
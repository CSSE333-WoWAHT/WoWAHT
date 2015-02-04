DROP PROCEDURE IF EXISTS SearchServerByName
DELIMITER ;;
CREATE PROCEDURE SearchServerByName (ServerName VarChar(20), NoOfResults int)
BEGIN
	if(NoOfResults IS NOT Null) then
		Set SQL_SELECT_LIMIT = NoOfResults;
	END IF; 
	SELECT * FROM server WHERE name LIKE (ServerName + '%') ;
	Set SQL_SELECT_LIMIT = Default;
END;;
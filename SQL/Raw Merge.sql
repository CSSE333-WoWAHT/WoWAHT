-- Get New Players and Insert it
INSERT INTO PLAYER (Name, Server_ID) 
SELECT DISTINCT
	owner as Name
,	server.Server_ID
FROM auction_raw_copy2
INNER JOIN server on server.name = ownerRealm
LEFT JOIN player on player.Server_ID = server.Server_ID AND player.name = owner

WHERE player.Player_ID is NULL;


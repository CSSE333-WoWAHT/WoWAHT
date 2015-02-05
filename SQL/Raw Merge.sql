-- Get New Players
INSERT INTO memory_player_import (auction_id, Player_ID, Server_ID, Player_Name, Player_Server) 
SELECT
	auction as auction_id 
,	player.Player_ID 
,	server.Server_ID
,	auction_raw.owner as Player_Name
,	auction_raw.ownerRealm as Player_Server
FROM auction_raw
INNER JOIN server on auction_raw.ownerRealm = server.Name
LEFT JOIN player on auction_raw.owner = player.Name and player.Server_ID = server.Server_ID;

-- If null add to player
INSERT INTO player (Name, Server_ID)
SELECT DISTINCT
	Player_Name as Name
,	Server_ID
FROM memory_player_import
WHERE Player_ID IS NULL;

UPDATE memory_player_import
INNER JOIN player on memory_player_import.Player_Name = player.name and memory_player_import.Server_ID = player.Server_ID
SET
	memory_player_import.Player_ID = player.Player_ID
WHERE memory_player_import.Player_ID IS NULL;

-- Get New Items
INSERT INTO memory_item_import (auction_id, item_id, rand, seed, context, internal_item_id)
(SELECT
	auction_raw.auction as auction_id
,	auction_raw.item as item_id
,	auction_raw.rand
,	auction_raw.seed
,	auction_raw.context
,	item.Item_ID as internal_item_id
FROM auction_raw
LEFT JOIN item on (auction_raw.item = item.WoW_Item_ID AND auction_raw.rand = item.rand AND auction_raw.seed = item.seed AND auction_raw.context = item.context));


INSERT INTO item (WoW_Item_ID, rand, seed, context)
SELECT DISTINCT
	memory_item_import.item_id
,	memory_item_import.rand
,	memory_item_import.seed
,	memory_item_import.context
FROM memory_item_import
WHERE memory_item_import.internal_item_id is NULL;	

UPDATE memory_item_import
INNER JOIN item on memory_item_import.item_id = item.WoW_Item_ID and memory_item_import.rand = item.rand AND memory_item_import.seed = item.seed AND memory_item_import.context = item.context
SET memory_item_import.internal_item_id = item.Item_ID
WHERE memory_item_import.internal_item_id IS NULL;


-- Make the insert into auction
INSERT INTO auction (	`Auction_ID` ,	`Item_ID`,	`Quantity` ,	`Buyout`
	,	`Bid`,	`Active`,	`Player_ID`,	`Server_ID`,	`Posted_WoW_Time_ID`,	`Current_WoW_Time_ID`)
SELECT
	auction_raw.auction 				AS Auction_ID
,	memory_item_import.internal_item_id	AS Item_ID
,	auction_raw.quantity				AS Quantity
,	auction_raw.buyout					AS Buyout
,	auction_raw.bid						AS Bid
,	1 									as Active							
,	memory_player_import.Player_ID		
,	server.Server_ID					
,	time.Time_ID						AS Posted_WoW_Time_ID
,	time.Time_ID						AS Current_WoW_Time_ID

FROM auction_raw
INNER JOIN memory_item_import on auction_raw.auction = memory_item_import.auction_id
INNER JOIN memory_player_import on auction_raw.auction = memory_player_import.auction_id
INNER JOIN server on auction_raw.realm = server.Name
INNER JOIN time on auction_raw.timeLeft = time.Name

ON DUPLICATE KEY UPDATE
	auction.Current_WoW_Time_ID = time.Time_ID
,	auction.Bid = auction_Raw.bid;


-- Clean up the temp tables
TRUNCATE TABLE memory_item_import;
TRUNCATE TABLE memory_player_import;
TRUNCATE TABLE auction_raw;

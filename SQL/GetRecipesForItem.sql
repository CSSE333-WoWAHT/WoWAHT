DELIMITER //
CREATE PROCEDURE GetRecipesForItem (GetItemID int(10))
begin
SELECT r.Recipe_ID, r.Name, p.Name, r.Note
FROM recipe r, recipe_output r_out, profession p
WHERE r.Recipe_ID = r_out.Recipe_ID AND r.Profession_ID = p.Profession_ID AND r_out.Item_ID = GetItemID;
end
//
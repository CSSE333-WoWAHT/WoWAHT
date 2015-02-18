using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerUpdater
{
    public class Emblem
    {
        public int icon { get; set; }
        public string iconColor { get; set; }
        public int border { get; set; }
        public string borderColor { get; set; }
        public string backgroundColor { get; set; }
    }

    public class Guild
    {
        public string name { get; set; }
        public string realm { get; set; }
        public string battlegroup { get; set; }
        public int members { get; set; }
        public int achievementPoints { get; set; }
        public Emblem emblem { get; set; }
    }

    public class Achievement
    {
        public int id { get; set; }
        public string title { get; set; }
        public int points { get; set; }
        public string description { get; set; }
        public List<object> rewardItems { get; set; }
        public string icon { get; set; }
        public List<object> criteria { get; set; }
        public bool accountWide { get; set; }
        public int factionId { get; set; }
        public string reward { get; set; }
    }

    public class Criteria
    {
        public int id { get; set; }
        public string description { get; set; }
        public int orderIndex { get; set; }
        public int max { get; set; }
    }

    public class Feed
    {
        public string type { get; set; }
        public object timestamp { get; set; }
        public Achievement achievement { get; set; }
        public bool featOfStrength { get; set; }
        public Criteria criteria { get; set; }
        public int? itemId { get; set; }
        public int? quantity { get; set; }
        public string name { get; set; }
    }

    public class TooltipParams
    {
    }

    public class Stat
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Head
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams tooltipParams { get; set; }
        public List<Stat> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<object> bonusLists { get; set; }
    }

    public class TooltipParams2
    {
    }

    public class Stat2
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Neck
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams2 tooltipParams { get; set; }
        public List<Stat2> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class TooltipParams3
    {
    }

    public class Stat3
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Shoulder
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams3 tooltipParams { get; set; }
        public List<Stat3> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class TooltipParams4
    {
    }

    public class Stat4
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Back
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams4 tooltipParams { get; set; }
        public List<Stat4> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class TooltipParams5
    {
    }

    public class Stat5
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Chest
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams5 tooltipParams { get; set; }
        public List<Stat5> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class TooltipParams6
    {
    }

    public class Shirt
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams6 tooltipParams { get; set; }
        public List<object> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<object> bonusLists { get; set; }
    }

    public class TooltipParams7
    {
    }

    public class Stat6
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Wrist
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams7 tooltipParams { get; set; }
        public List<Stat6> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class TooltipParams8
    {
    }

    public class Stat7
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Hands
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams8 tooltipParams { get; set; }
        public List<Stat7> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class TooltipParams9
    {
    }

    public class Stat8
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Waist
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams9 tooltipParams { get; set; }
        public List<Stat8> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class TooltipParams10
    {
        public int gem0 { get; set; }
    }

    public class Stat9
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Legs
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams10 tooltipParams { get; set; }
        public List<Stat9> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class TooltipParams11
    {
    }

    public class Stat10
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Feet
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams11 tooltipParams { get; set; }
        public List<Stat10> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<object> bonusLists { get; set; }
    }

    public class TooltipParams12
    {
    }

    public class Stat11
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Finger1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams12 tooltipParams { get; set; }
        public List<Stat11> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<object> bonusLists { get; set; }
    }

    public class TooltipParams13
    {
    }

    public class Stat12
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Finger2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams13 tooltipParams { get; set; }
        public List<Stat12> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<object> bonusLists { get; set; }
    }

    public class TooltipParams14
    {
    }

    public class Stat13
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Trinket1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams14 tooltipParams { get; set; }
        public List<Stat13> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class TooltipParams15
    {
    }

    public class Stat14
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class Trinket2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams15 tooltipParams { get; set; }
        public List<Stat14> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class TooltipParams16
    {
    }

    public class Stat15
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class PlayerWeaponInfo
    {
        public Damage damage { get; set; }
        public double weaponSpeed { get; set; }
        public double dps { get; set; }
    }

    public class MainHand
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams16 tooltipParams { get; set; }
        public List<Stat15> stats { get; set; }
        public int armor { get; set; }
        public PlayerWeaponInfo weaponInfo { get; set; }
        public string context { get; set; }
        public List<object> bonusLists { get; set; }
    }

    public class TooltipParams17
    {
    }

    public class Stat16
    {
        public int stat { get; set; }
        public int amount { get; set; }
    }

    public class OffHand
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams17 tooltipParams { get; set; }
        public List<Stat16> stats { get; set; }
        public int armor { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }

    public class Items
    {
        public int averageItemLevel { get; set; }
        public int averageItemLevelEquipped { get; set; }
        public Head head { get; set; }
        public Neck neck { get; set; }
        public Shoulder shoulder { get; set; }
        public Back back { get; set; }
        public Chest chest { get; set; }
        public Shirt shirt { get; set; }
        public Wrist wrist { get; set; }
        public Hands hands { get; set; }
        public Waist waist { get; set; }
        public Legs legs { get; set; }
        public Feet feet { get; set; }
        public Finger1 finger1 { get; set; }
        public Finger2 finger2 { get; set; }
        public Trinket1 trinket1 { get; set; }
        public Trinket2 trinket2 { get; set; }
        public MainHand mainHand { get; set; }
        public OffHand offHand { get; set; }
    }

    public class Stats
    {
        public int health { get; set; }
        public string powerType { get; set; }
        public int power { get; set; }
        public int str { get; set; }
        public int agi { get; set; }
        public int @int { get; set; }
        public int sta { get; set; }
        public double speedRating { get; set; }
        public double speedRatingBonus { get; set; }
        public double crit { get; set; }
        public int critRating { get; set; }
        public double haste { get; set; }
        public int hasteRating { get; set; }
        public double hasteRatingPercent { get; set; }
        public double mastery { get; set; }
        public int masteryRating { get; set; }
        public int spr { get; set; }
        public int bonusArmor { get; set; }
        public double multistrike { get; set; }
        public double multistrikeRating { get; set; }
        public double multistrikeRatingBonus { get; set; }
        public double leech { get; set; }
        public double leechRating { get; set; }
        public double leechRatingBonus { get; set; }
        public int versatility { get; set; }
        public double versatilityDamageDoneBonus { get; set; }
        public double versatilityHealingDoneBonus { get; set; }
        public double versatilityDamageTakenBonus { get; set; }
        public double avoidanceRating { get; set; }
        public double avoidanceRatingBonus { get; set; }
        public int spellPower { get; set; }
        public int spellPen { get; set; }
        public double spellCrit { get; set; }
        public int spellCritRating { get; set; }
        public double mana5 { get; set; }
        public double mana5Combat { get; set; }
        public int armor { get; set; }
        public double dodge { get; set; }
        public int dodgeRating { get; set; }
        public double parry { get; set; }
        public int parryRating { get; set; }
        public double block { get; set; }
        public int blockRating { get; set; }
        public double mainHandDmgMin { get; set; }
        public double mainHandDmgMax { get; set; }
        public double mainHandSpeed { get; set; }
        public double mainHandDps { get; set; }
        public double offHandDmgMin { get; set; }
        public double offHandDmgMax { get; set; }
        public double offHandSpeed { get; set; }
        public double offHandDps { get; set; }
        public double rangedDmgMin { get; set; }
        public double rangedDmgMax { get; set; }
        public double rangedSpeed { get; set; }
        public double rangedDps { get; set; }
        public int attackPower { get; set; }
        public int rangedAttackPower { get; set; }
    }

    public class Primary
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int rank { get; set; }
        public int max { get; set; }
        public List<int> recipes { get; set; }
    }

    public class Secondary
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int rank { get; set; }
        public int max { get; set; }
        public List<object> recipes { get; set; }
    }

    public class Professions
    {
        public List<Primary> primary { get; set; }
        public List<Secondary> secondary { get; set; }
    }

    public class Reputation
    {
        public int id { get; set; }
        public string name { get; set; }
        public int standing { get; set; }
        public int value { get; set; }
        public int max { get; set; }
    }

    public class Title
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool? selected { get; set; }
    }

    public class Achievements
    {
        public List<int> achievementsCompleted { get; set; }
        public List<object> achievementsCompletedTimestamp { get; set; }
        public List<int> criteria { get; set; }
        public List<object> criteriaQuantity { get; set; }
        public List<object> criteriaTimestamp { get; set; }
        public List<object> criteriaCreated { get; set; }
    }

    public class Spell
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public string range { get; set; }
        public string castTime { get; set; }
        public string cooldown { get; set; }
        public string subtext { get; set; }
    }

    public class Talent2
    {
        public int tier { get; set; }
        public int column { get; set; }
        public Spell spell { get; set; }
    }

    public class Major
    {
        public int glyph { get; set; }
        public int item { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    }

    public class Minor
    {
        public int glyph { get; set; }
        public int item { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    }

    public class Glyphs
    {
        public List<Major> major { get; set; }
        public List<Minor> minor { get; set; }
    }

    public class Spec
    {
        public string name { get; set; }
        public string role { get; set; }
        public string backgroundImage { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public int order { get; set; }
    }

    public class Talent
    {
        public bool selected { get; set; }
        public List<Talent2> talents { get; set; }
        public Glyphs glyphs { get; set; }
        public Spec spec { get; set; }
        public string calcTalent { get; set; }
        public string calcSpec { get; set; }
        public string calcGlyph { get; set; }
    }

    public class Appearance
    {
        public int faceVariation { get; set; }
        public int skinColor { get; set; }
        public int hairVariation { get; set; }
        public int hairColor { get; set; }
        public int featureVariation { get; set; }
        public bool showHelm { get; set; }
        public bool showCloak { get; set; }
    }

    public class Collected
    {
        public string name { get; set; }
        public int spellId { get; set; }
        public int creatureId { get; set; }
        public int itemId { get; set; }
        public int qualityId { get; set; }
        public string icon { get; set; }
        public bool isGround { get; set; }
        public bool isFlying { get; set; }
        public bool isAquatic { get; set; }
        public bool isJumping { get; set; }
    }

    public class Mounts
    {
        public int numCollected { get; set; }
        public int numNotCollected { get; set; }
        public List<Collected> collected { get; set; }
    }

    public class Stats2
    {
        public int speciesId { get; set; }
        public int breedId { get; set; }
        public int petQualityId { get; set; }
        public int level { get; set; }
        public int health { get; set; }
        public int power { get; set; }
        public int speed { get; set; }
    }

    public class Collected2
    {
        public string name { get; set; }
        public int spellId { get; set; }
        public int creatureId { get; set; }
        public int itemId { get; set; }
        public int qualityId { get; set; }
        public string icon { get; set; }
        public Stats2 stats { get; set; }
        public string battlePetGuid { get; set; }
        public bool isFavorite { get; set; }
        public bool isFirstAbilitySlotSelected { get; set; }
        public bool isSecondAbilitySlotSelected { get; set; }
        public bool isThirdAbilitySlotSelected { get; set; }
        public string creatureName { get; set; }
        public bool canBattle { get; set; }
    }

    public class Pets
    {
        public int numCollected { get; set; }
        public int numNotCollected { get; set; }
        public List<Collected2> collected { get; set; }
    }

    public class PetSlot
    {
        public int slot { get; set; }
        public string battlePetGuid { get; set; }
        public bool isEmpty { get; set; }
        public bool isLocked { get; set; }
        public List<int> abilities { get; set; }
    }

    public class Boss
    {
        public int id { get; set; }
        public string name { get; set; }
        public int normalKills { get; set; }
        public object normalTimestamp { get; set; }
        public int? heroicKills { get; set; }
        public long? heroicTimestamp { get; set; }
        public int? lfrKills { get; set; }
        public long? lfrTimestamp { get; set; }
        public int? mythicKills { get; set; }
        public long? mythicTimestamp { get; set; }
    }

    public class Raid
    {
        public string name { get; set; }
        public int lfr { get; set; }
        public int normal { get; set; }
        public int heroic { get; set; }
        public int mythic { get; set; }
        public int id { get; set; }
        public List<Boss> bosses { get; set; }
    }

    public class Progression
    {
        public List<Raid> raids { get; set; }
    }

    public class ARENABRACKET2v2
    {
        public string slug { get; set; }
        public int rating { get; set; }
        public int weeklyPlayed { get; set; }
        public int weeklyWon { get; set; }
        public int weeklyLost { get; set; }
        public int seasonPlayed { get; set; }
        public int seasonWon { get; set; }
        public int seasonLost { get; set; }
    }

    public class ARENABRACKET3v3
    {
        public string slug { get; set; }
        public int rating { get; set; }
        public int weeklyPlayed { get; set; }
        public int weeklyWon { get; set; }
        public int weeklyLost { get; set; }
        public int seasonPlayed { get; set; }
        public int seasonWon { get; set; }
        public int seasonLost { get; set; }
    }

    public class ARENABRACKET5v5
    {
        public string slug { get; set; }
        public int rating { get; set; }
        public int weeklyPlayed { get; set; }
        public int weeklyWon { get; set; }
        public int weeklyLost { get; set; }
        public int seasonPlayed { get; set; }
        public int seasonWon { get; set; }
        public int seasonLost { get; set; }
    }

    public class ARENABRACKETRBG
    {
        public string slug { get; set; }
        public int rating { get; set; }
        public int weeklyPlayed { get; set; }
        public int weeklyWon { get; set; }
        public int weeklyLost { get; set; }
        public int seasonPlayed { get; set; }
        public int seasonWon { get; set; }
        public int seasonLost { get; set; }
    }

    public class UNKNOWN
    {
        public string slug { get; set; }
        public int rating { get; set; }
        public int weeklyPlayed { get; set; }
        public int weeklyWon { get; set; }
        public int weeklyLost { get; set; }
        public int seasonPlayed { get; set; }
        public int seasonWon { get; set; }
        public int seasonLost { get; set; }
    }

    public class Brackets
    {
        public ARENABRACKET2v2 ARENA_BRACKET_2v2 { get; set; }
        public ARENABRACKET3v3 ARENA_BRACKET_3v3 { get; set; }
        public ARENABRACKET5v5 ARENA_BRACKET_5v5 { get; set; }
        public ARENABRACKETRBG ARENA_BRACKET_RBG { get; set; }
        public UNKNOWN UNKNOWN { get; set; }
    }

    public class Pvp
    {
        public Brackets brackets { get; set; }
    }

    public class Slots
    {
        public int __invalid_name__2 { get; set; }
        public int __invalid_name__7 { get; set; }
        public int __invalid_name__6 { get; set; }
        public int __invalid_name__5 { get; set; }
        public int __invalid_name__4 { get; set; }
        public int __invalid_name__9 { get; set; }
        public int __invalid_name__15 { get; set; }
        public int __invalid_name__8 { get; set; }
        public int __invalid_name__14 { get; set; }
    }

    public class UnenchantedItems
    {
        public int __invalid_name__2 { get; set; }
        public int __invalid_name__7 { get; set; }
        public int __invalid_name__6 { get; set; }
        public int __invalid_name__4 { get; set; }
        public int __invalid_name__15 { get; set; }
        public int __invalid_name__9 { get; set; }
        public int __invalid_name__8 { get; set; }
        public int __invalid_name__14 { get; set; }
    }

    public class ItemsWithEmptySockets
    {
    }

    public class InappropriateArmorType
    {
    }

    public class LowLevelItems
    {
    }

    public class MissingExtraSockets
    {
        public int __invalid_name__5 { get; set; }
    }

    public class Spell2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public string castTime { get; set; }
    }

    public class ItemSpell
    {
        public int spellId { get; set; }
        public Spell2 spell { get; set; }
        public int nCharges { get; set; }
        public bool consumable { get; set; }
        public int categoryId { get; set; }
        public string trigger { get; set; }
    }

    public class RecommendedBeltBuckle
    {
        public int id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int stackable { get; set; }
        public int itemBind { get; set; }
        public List<object> bonusStats { get; set; }
        public List<ItemSpell> itemSpells { get; set; }
        public int buyPrice { get; set; }
        public int itemClass { get; set; }
        public int itemSubClass { get; set; }
        public int containerSlots { get; set; }
        public int inventoryType { get; set; }
        public bool equippable { get; set; }
        public int itemLevel { get; set; }
        public int maxCount { get; set; }
        public int maxDurability { get; set; }
        public int minFactionId { get; set; }
        public int minReputation { get; set; }
        public int quality { get; set; }
        public int sellPrice { get; set; }
        public int requiredSkill { get; set; }
        public int requiredLevel { get; set; }
        public int requiredSkillRank { get; set; }
        public ItemSource itemSource { get; set; }
        public int baseArmor { get; set; }
        public bool hasSockets { get; set; }
        public bool isAuctionable { get; set; }
        public int armor { get; set; }
        public int displayInfoId { get; set; }
        public string nameDescription { get; set; }
        public string nameDescriptionColor { get; set; }
        public bool upgradable { get; set; }
        public bool heroicTooltip { get; set; }
        public string context { get; set; }
        public List<object> bonusLists { get; set; }
        public List<string> availableContexts { get; set; }
        public BonusSummary bonusSummary { get; set; }
    }

    public class MissingBlacksmithSockets
    {
    }

    public class MissingEnchanterEnchants
    {
    }

    public class MissingEngineerEnchants
    {
    }

    public class MissingScribeEnchants
    {
    }

    public class MissingLeatherworkerEnchants
    {
        public int __invalid_name__8 { get; set; }
    }

    public class Audit
    {
        public int numberOfIssues { get; set; }
        public Slots slots { get; set; }
        public int emptyGlyphSlots { get; set; }
        public int unspentTalentPoints { get; set; }
        public bool noSpec { get; set; }
        public UnenchantedItems unenchantedItems { get; set; }
        public int emptySockets { get; set; }
        public ItemsWithEmptySockets itemsWithEmptySockets { get; set; }
        public int appropriateArmorType { get; set; }
        public InappropriateArmorType inappropriateArmorType { get; set; }
        public LowLevelItems lowLevelItems { get; set; }
        public int lowLevelThreshold { get; set; }
        public MissingExtraSockets missingExtraSockets { get; set; }
        public RecommendedBeltBuckle recommendedBeltBuckle { get; set; }
        public MissingBlacksmithSockets missingBlacksmithSockets { get; set; }
        public MissingEnchanterEnchants missingEnchanterEnchants { get; set; }
        public MissingEngineerEnchants missingEngineerEnchants { get; set; }
        public MissingScribeEnchants missingScribeEnchants { get; set; }
        public int nMissingJewelcrafterGems { get; set; }
        public MissingLeatherworkerEnchants missingLeatherworkerEnchants { get; set; }
    }

    public class Player
    {
        public long lastModified { get; set; }
        public string name { get; set; }
        public string realm { get; set; }
        public string battlegroup { get; set; }
        public int @class { get; set; }
        public int race { get; set; }
        public int gender { get; set; }
        public int level { get; set; }
        public int achievementPoints { get; set; }
        public string thumbnail { get; set; }
        public string calcClass { get; set; }
        public Guild guild { get; set; }
        public List<Feed> feed { get; set; }
        public Items items { get; set; }
        public Stats stats { get; set; }
        public Professions professions { get; set; }
        public List<Reputation> reputation { get; set; }
        public List<Title> titles { get; set; }
        public Achievements achievements { get; set; }
        public List<Talent> talents { get; set; }
        public Appearance appearance { get; set; }
        public Mounts mounts { get; set; }
        public Pets pets { get; set; }
        public List<PetSlot> petSlots { get; set; }
        public Progression progression { get; set; }
        public Pvp pvp { get; set; }
        public List<int> quests { get; set; }
        public Audit audit { get; set; }
        public int totalHonorableKills { get; set; }


        public static Player getPlayer(String server, String name)
        {
            var webRequest = WebRequest.Create(@"http://us.battle.net/api/wow/character/" + server + @"/" + name + "?fields=professions");

            String data;
            try
            {
                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    data = reader.ReadToEnd();
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Player>(data);
            }
            catch (WebException)
            {
                return null;
            }
        }
    }

    
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace RandomizerAPI.Models.GameModels
{
    public class InputOoTSpoilerLog : SpoilerLog
    {
        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("randomized_settings")]
        public RandomizedSettings RandomizedSettings { get; set; }

        [JsonProperty("starting_items")]
        public Dictionary<string, int> StartingItems { get; set; }

        [JsonProperty("item_pool")]
        public Dictionary<string, int> ItemPool { get; set; }

        [JsonProperty("dungeons")]
        public Dictionary<string, string> Dungeons { get; set; }

        [JsonProperty("trials")]
        public Trials Trials { get; set; }

        [JsonProperty("entrances")]
        public Entrances Entrances { get; set; }

        [JsonProperty("locations")]
        public OOTInputLocations Locations { get; set; }

        //[JsonProperty(":woth_locations")]
        //public WothLocations WothLocations { get; set; }

        //[JsonProperty(":barren_regions")]
        //public string[] BarrenRegions { get; set; }

        [JsonProperty("gossip_stones")]
        public GossipStones GossipStones { get; set; }

        //[JsonProperty(":playthrough")]
        //public Dictionary<string, Dictionary<string, string>> Playthrough { get; set; }

        //[JsonProperty(":entrance_playthrough")]
        //public Dictionary<string, EntrancePlaythrough> EntrancePlaythrough { get; set; }
    }

    public partial class Dungeons
    {
        [JsonProperty("Deku Tree")]
        public string DekuTree { get; set; }

        [JsonProperty("Dodongos Cavern")]
        public string DodongosCavern { get; set; }

        [JsonProperty("Jabu Jabus Belly")]
        public string JabuJabusBelly { get; set; }

        [JsonProperty("Bottom of the Well")]
        public string BottomOfTheWell { get; set; }

        [JsonProperty("Ice Cavern")]
        public string IceCavern { get; set; }

        [JsonProperty("Gerudo Training Grounds")]
        public string GerudoTrainingGrounds { get; set; }

        [JsonProperty("Forest Temple")]
        public string ForestTemple { get; set; }

        [JsonProperty("Fire Temple")]
        public string FireTemple { get; set; }

        [JsonProperty("Water Temple")]
        public string WaterTemple { get; set; }

        [JsonProperty("Spirit Temple")]
        public string SpiritTemple { get; set; }

        [JsonProperty("Shadow Temple")]
        public string ShadowTemple { get; set; }

        [JsonProperty("Ganons Castle")]
        public string GanonsCastle { get; set; }
    }

    public partial class EntrancePlaythrough
    {
        [JsonProperty("Death Mountain -> Kakariko Village Behind Gate", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance DeathMountainKakarikoVillageBehindGate { get; set; }

        [JsonProperty("Desert Colossus -> Spirit Temple Lobby", NullValueHandling = NullValueHandling.Ignore)]
        public string DesertColossusSpiritTempleLobby { get; set; }

        [JsonProperty("Dodongos Cavern Entryway -> Dodongos Cavern Beginning", NullValueHandling = NullValueHandling.Ignore)]
        public string DodongosCavernEntrywayDodongosCavernBeginning { get; set; }

        [JsonProperty("Gerudo Valley Far Side -> Carpenter Tent", NullValueHandling = NullValueHandling.Ignore)]
        public string GerudoValleyFarSideCarpenterTent { get; set; }

        [JsonProperty("Goron City -> Death Mountain", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance GoronCityDeathMountain { get; set; }

        [JsonProperty("Graveyard -> Kakariko Village", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance GraveyardKakarikoVillage { get; set; }

        [JsonProperty("Graveyard -> Shield Grave", NullValueHandling = NullValueHandling.Ignore)]
        public string GraveyardShieldGrave { get; set; }

        [JsonProperty("Hyrule Field -> Castle Town Entrance", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance HyruleFieldCastleTownEntrance { get; set; }

        [JsonProperty("Hyrule Field -> Gerudo Valley", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance HyruleFieldGerudoValley { get; set; }

        [JsonProperty("Hyrule Field -> Kakariko Village", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance HyruleFieldKakarikoVillage { get; set; }

        [JsonProperty("Hyrule Field -> Lon Lon Ranch", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance HyruleFieldLonLonRanch { get; set; }

        [JsonProperty("Hyrule Field -> Zora River Front", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance HyruleFieldZoraRiverFront { get; set; }

        [JsonProperty("Kakariko Village -> Hyrule Field", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance KakarikoVillageHyruleField { get; set; }

        [JsonProperty("Kakariko Village -> Impas House", NullValueHandling = NullValueHandling.Ignore)]
        public string KakarikoVillageImpasHouse { get; set; }

        [JsonProperty("Kakariko Village -> Kakariko Potion Shop Front", NullValueHandling = NullValueHandling.Ignore)]
        public string KakarikoVillageKakarikoPotionShopFront { get; set; }

        [JsonProperty("Kakariko Village -> Kakariko Shooting Gallery", NullValueHandling = NullValueHandling.Ignore)]
        public string KakarikoVillageKakarikoShootingGallery { get; set; }

        [JsonProperty("Kakariko Village Backyard -> Kakariko Back Grotto", NullValueHandling = NullValueHandling.Ignore)]
        public string KakarikoVillageBackyardKakarikoBackGrotto { get; set; }

        [JsonProperty("Kakariko Village Behind Gate -> Death Mountain", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance KakarikoVillageBehindGateDeathMountain { get; set; }

        [JsonProperty("Kokiri Forest -> Links House", NullValueHandling = NullValueHandling.Ignore)]
        public string KokiriForestLinksHouse { get; set; }

        [JsonProperty("Kokiri Forest -> Lost Woods Bridge From Forest", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance KokiriForestLostWoodsBridgeFromForest { get; set; }

        [JsonProperty("Kokiri Forest -> Mido House", NullValueHandling = NullValueHandling.Ignore)]
        public string KokiriForestMidoHouse { get; set; }

        [JsonProperty("Kokiri Forest -> Saria House", NullValueHandling = NullValueHandling.Ignore)]
        public string KokiriForestSariaHouse { get; set; }

        [JsonProperty("Lake Hylia -> Hyrule Field", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance LakeHyliaHyruleField { get; set; }

        [JsonProperty("Links House -> Kokiri Forest", NullValueHandling = NullValueHandling.Ignore)]
        public string LinksHouseKokiriForest { get; set; }

        [JsonProperty("Lon Lon Ranch -> Lon Lon Corner Tower", NullValueHandling = NullValueHandling.Ignore)]
        public string LonLonRanchLonLonCornerTower { get; set; }

        [JsonProperty("Lon Lon Ranch -> Talon House", NullValueHandling = NullValueHandling.Ignore)]
        public string LonLonRanchTalonHouse { get; set; }

        [JsonProperty("Lost Woods -> Goron City Woods Warp", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance LostWoodsGoronCityWoodsWarp { get; set; }

        [JsonProperty("Lost Woods Bridge -> Kokiri Forest", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance LostWoodsBridgeKokiriForest { get; set; }

        [JsonProperty("Lost Woods Forest Exit -> Kokiri Forest", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance LostWoodsForestExitKokiriForest { get; set; }

        [JsonProperty("Temple of Time -> Temple of Time Exterior", NullValueHandling = NullValueHandling.Ignore)]
        public string TempleOfTimeTempleOfTimeExterior { get; set; }

        [JsonProperty("Zoras Domain -> Zora River Behind Waterfall", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance ZorasDomainZoraRiverBehindWaterfall { get; set; }

        [JsonProperty("Death Mountain Crater Upper Nearby -> Top of Crater Grotto", NullValueHandling = NullValueHandling.Ignore)]
        public string DeathMountainCraterUpperNearbyTopOfCraterGrotto { get; set; }

        [JsonProperty("Death Mountain Summit -> Mountain Bombable Grotto", NullValueHandling = NullValueHandling.Ignore)]
        public string DeathMountainSummitMountainBombableGrotto { get; set; }

        [JsonProperty("Gerudo Fortress -> Gerudo Training Grounds Lobby", NullValueHandling = NullValueHandling.Ignore)]
        public string GerudoFortressGerudoTrainingGroundsLobby { get; set; }

        [JsonProperty("Hyrule Field -> Field North Lon Lon Grotto", NullValueHandling = NullValueHandling.Ignore)]
        public string HyruleFieldFieldNorthLonLonGrotto { get; set; }

        [JsonProperty("Zora River -> Lost Woods", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance ZoraRiverLostWoods { get; set; }

        [JsonProperty("Castle Town -> Castle Town Potion Shop", NullValueHandling = NullValueHandling.Ignore)]
        public string CastleTownCastleTownPotionShop { get; set; }

        [JsonProperty("Castle Town -> Castle Town Shooting Gallery", NullValueHandling = NullValueHandling.Ignore)]
        public string CastleTownCastleTownShootingGallery { get; set; }

        [JsonProperty("Castle Town -> Temple of Time Exterior", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance CastleTownTempleOfTimeExterior { get; set; }

        [JsonProperty("Castle Town Entrance -> Castle Town", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance CastleTownEntranceCastleTown { get; set; }

        [JsonProperty("Hyrule Field -> Field Valley Grotto", NullValueHandling = NullValueHandling.Ignore)]
        public string HyruleFieldFieldValleyGrotto { get; set; }

        [JsonProperty("Lake Hylia -> Fishing Hole", NullValueHandling = NullValueHandling.Ignore)]
        public string LakeHyliaFishingHole { get; set; }

        [JsonProperty("Lake Hylia Owl Flight -> Hyrule Field", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance LakeHyliaOwlFlightHyruleField { get; set; }

        [JsonProperty("Lost Woods Beyond Mido -> Sacred Forest Meadow Entryway", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance LostWoodsBeyondMidoSacredForestMeadowEntryway { get; set; }

        [JsonProperty("Temple of Time Exterior -> Temple of Time", NullValueHandling = NullValueHandling.Ignore)]
        public string TempleOfTimeExteriorTempleOfTime { get; set; }

        [JsonProperty("Zoras Fountain -> Zoras Fountain Fairy", NullValueHandling = NullValueHandling.Ignore)]
        public string ZorasFountainZorasFountainFairy { get; set; }

        [JsonProperty("Death Mountain Crater Lower Nearby -> Darunias Chamber", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance DeathMountainCraterLowerNearbyDaruniasChamber { get; set; }

        [JsonProperty("Zora River Behind Waterfall -> Zoras Domain", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance ZoraRiverBehindWaterfallZorasDomain { get; set; }

        [JsonProperty("Zoras Fountain -> Ice Cavern Beginning", NullValueHandling = NullValueHandling.Ignore)]
        public string ZorasFountainIceCavernBeginning { get; set; }

        [JsonProperty("Gerudo Valley -> Gerudo Valley Octorok Grotto", NullValueHandling = NullValueHandling.Ignore)]
        public string GerudoValleyGerudoValleyOctorokGrotto { get; set; }

        [JsonProperty("Lon Lon Ranch -> Lon Lon Grotto", NullValueHandling = NullValueHandling.Ignore)]
        public string LonLonRanchLonLonGrotto { get; set; }

        [JsonProperty("Zoras Fountain -> Jabu Jabus Belly Beginning", NullValueHandling = NullValueHandling.Ignore)]
        public string ZorasFountainJabuJabusBellyBeginning { get; set; }

        [JsonProperty("Lake Hylia -> Water Temple Lobby", NullValueHandling = NullValueHandling.Ignore)]
        public string LakeHyliaWaterTempleLobby { get; set; }

        [JsonProperty("Haunted Wasteland Near Colossus -> Desert Colossus", NullValueHandling = NullValueHandling.Ignore)]
        public Entrance HauntedWastelandNearColossusDesertColossus { get; set; }

        [JsonProperty("Sacred Forest Meadow -> Forest Temple Lobby", NullValueHandling = NullValueHandling.Ignore)]
        public string SacredForestMeadowForestTempleLobby { get; set; }

        [JsonProperty("Death Mountain Crater Lower Nearby -> Crater Fairy", NullValueHandling = NullValueHandling.Ignore)]
        public string DeathMountainCraterLowerNearbyCraterFairy { get; set; }

        [JsonProperty("Kakariko Village -> Bottom of the Well", NullValueHandling = NullValueHandling.Ignore)]
        public string KakarikoVillageBottomOfTheWell { get; set; }

        [JsonProperty("Outside Deku Tree -> Deku Tree Lobby", NullValueHandling = NullValueHandling.Ignore)]
        public string OutsideDekuTreeDekuTreeLobby { get; set; }

        [JsonProperty("Zora River -> Zora River Storms Grotto", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoraRiverZoraRiverStormsGrotto { get; set; }

        [JsonProperty("Fire Temple Entrance -> Fire Temple Lower", NullValueHandling = NullValueHandling.Ignore)]
        public string FireTempleEntranceFireTempleLower { get; set; }

        [JsonProperty("Shadow Temple Warp Region -> Shadow Temple Entryway", NullValueHandling = NullValueHandling.Ignore)]
        public string ShadowTempleWarpRegionShadowTempleEntryway { get; set; }
    }

    public partial class Entrances
    {
        [JsonProperty("Death Mountain -> Mountain Storms Grotto")]
        public string DeathMountainMountainStormsGrotto { get; set; }

        [JsonProperty("Death Mountain Crater Lower Nearby -> DMC Hammer Grotto")]
        public string DeathMountainCraterLowerNearbyDmcHammerGrotto { get; set; }

        [JsonProperty("Death Mountain Crater Upper Nearby -> Top of Crater Grotto")]
        public string DeathMountainCraterUpperNearbyTopOfCraterGrotto { get; set; }

        [JsonProperty("Death Mountain Summit -> Mountain Bombable Grotto")]
        public string DeathMountainSummitMountainBombableGrotto { get; set; }

        [JsonProperty("Desert Colossus -> Desert Colossus Grotto")]
        public string DesertColossusDesertColossusGrotto { get; set; }

        [JsonProperty("Gerudo Fortress -> Gerudo Fortress Storms Grotto")]
        public string GerudoFortressGerudoFortressStormsGrotto { get; set; }

        [JsonProperty("Gerudo Valley -> Gerudo Valley Octorok Grotto")]
        public string GerudoValleyGerudoValleyOctorokGrotto { get; set; }

        [JsonProperty("Gerudo Valley Far Side -> Gerudo Valley Storms Grotto")]
        public string GerudoValleyFarSideGerudoValleyStormsGrotto { get; set; }

        [JsonProperty("Goron City -> Goron City Grotto")]
        public string GoronCityGoronCityGrotto { get; set; }

        [JsonProperty("Graveyard -> Composer Grave")]
        public string GraveyardComposerGrave { get; set; }

        [JsonProperty("Graveyard -> Dampes Grave")]
        public string GraveyardDampesGrave { get; set; }

        [JsonProperty("Graveyard -> Heart Piece Grave")]
        public string GraveyardHeartPieceGrave { get; set; }

        [JsonProperty("Graveyard -> Shield Grave")]
        public string GraveyardShieldGrave { get; set; }

        [JsonProperty("Hyrule Castle Grounds -> Castle Storms Grotto")]
        public string HyruleCastleGroundsCastleStormsGrotto { get; set; }

        [JsonProperty("Hyrule Field -> Field Far West Castle Town Grotto")]
        public string HyruleFieldFieldFarWestCastleTownGrotto { get; set; }

        [JsonProperty("Hyrule Field -> Field Kakariko Grotto")]
        public string HyruleFieldFieldKakarikoGrotto { get; set; }

        [JsonProperty("Hyrule Field -> Field Near Lake Inside Fence Grotto")]
        public string HyruleFieldFieldNearLakeInsideFenceGrotto { get; set; }

        [JsonProperty("Hyrule Field -> Field Near Lake Outside Fence Grotto")]
        public string HyruleFieldFieldNearLakeOutsideFenceGrotto { get; set; }

        [JsonProperty("Hyrule Field -> Field North Lon Lon Grotto")]
        public string HyruleFieldFieldNorthLonLonGrotto { get; set; }

        [JsonProperty("Hyrule Field -> Field Valley Grotto")]
        public string HyruleFieldFieldValleyGrotto { get; set; }

        [JsonProperty("Hyrule Field -> Field West Castle Town Grotto")]
        public string HyruleFieldFieldWestCastleTownGrotto { get; set; }

        [JsonProperty("Hyrule Field -> Remote Southern Grotto")]
        public string HyruleFieldRemoteSouthernGrotto { get; set; }

        [JsonProperty("Kakariko Village -> Kakariko Bombable Grotto")]
        public string KakarikoVillageKakarikoBombableGrotto { get; set; }

        [JsonProperty("Kakariko Village Backyard -> Kakariko Back Grotto")]
        public string KakarikoVillageBackyardKakarikoBackGrotto { get; set; }

        [JsonProperty("Kokiri Forest -> Kokiri Forest Storms Grotto")]
        public string KokiriForestKokiriForestStormsGrotto { get; set; }

        [JsonProperty("Lake Hylia -> Lake Hylia Grotto")]
        public string LakeHyliaLakeHyliaGrotto { get; set; }

        [JsonProperty("Lon Lon Ranch -> Lon Lon Grotto")]
        public string LonLonRanchLonLonGrotto { get; set; }

        [JsonProperty("Lost Woods -> Lost Woods Generic Grotto")]
        public string LostWoodsLostWoodsGenericGrotto { get; set; }

        [JsonProperty("Lost Woods Beyond Mido -> Deku Theater")]
        public string LostWoodsBeyondMidoDekuTheater { get; set; }

        [JsonProperty("Lost Woods Beyond Mido -> Lost Woods Sales Grotto")]
        public string LostWoodsBeyondMidoLostWoodsSalesGrotto { get; set; }

        [JsonProperty("Sacred Forest Meadow -> Meadow Fairy Grotto")]
        public string SacredForestMeadowMeadowFairyGrotto { get; set; }

        [JsonProperty("Sacred Forest Meadow -> Meadow Storms Grotto")]
        public string SacredForestMeadowMeadowStormsGrotto { get; set; }

        [JsonProperty("Sacred Forest Meadow Entryway -> Front of Meadow Grotto")]
        public string SacredForestMeadowEntrywayFrontOfMeadowGrotto { get; set; }

        [JsonProperty("Zora River -> Zora River Plateau Bombable Grotto")]
        public string ZoraRiverZoraRiverPlateauBombableGrotto { get; set; }

        [JsonProperty("Zora River -> Zora River Plateau Open Grotto")]
        public string ZoraRiverZoraRiverPlateauOpenGrotto { get; set; }

        [JsonProperty("Zora River -> Zora River Storms Grotto")]
        public string ZoraRiverZoraRiverStormsGrotto { get; set; }

        [JsonProperty("Zoras Domain -> Zoras Domain Storms Grotto")]
        public string ZorasDomainZorasDomainStormsGrotto { get; set; }

        [JsonProperty("Castle Town -> Castle Town Bazaar")]
        public string CastleTownCastleTownBazaar { get; set; }

        [JsonProperty("Castle Town -> Castle Town Bombchu Bowling")]
        public string CastleTownCastleTownBombchuBowling { get; set; }

        [JsonProperty("Castle Town -> Castle Town Bombchu Shop")]
        public string CastleTownCastleTownBombchuShop { get; set; }

        [JsonProperty("Castle Town -> Castle Town Man in Green House")]
        public string CastleTownCastleTownManInGreenHouse { get; set; }

        [JsonProperty("Castle Town -> Castle Town Mask Shop")]
        public string CastleTownCastleTownMaskShop { get; set; }

        [JsonProperty("Castle Town -> Castle Town Potion Shop")]
        public string CastleTownCastleTownPotionShop { get; set; }

        [JsonProperty("Castle Town -> Castle Town Shooting Gallery")]
        public string CastleTownCastleTownShootingGallery { get; set; }

        [JsonProperty("Castle Town -> Castle Town Treasure Chest Game")]
        public string CastleTownCastleTownTreasureChestGame { get; set; }

        [JsonProperty("Castle Town Entrance -> Castle Town Rupee Room")]
        public string CastleTownEntranceCastleTownRupeeRoom { get; set; }

        [JsonProperty("Death Mountain Crater Lower Nearby -> Crater Fairy")]
        public string DeathMountainCraterLowerNearbyCraterFairy { get; set; }

        [JsonProperty("Death Mountain Summit -> Mountain Summit Fairy")]
        public string DeathMountainSummitMountainSummitFairy { get; set; }

        [JsonProperty("Desert Colossus -> Colossus Fairy")]
        public string DesertColossusColossusFairy { get; set; }

        [JsonProperty("Ganons Castle Grounds -> Ganons Castle Fairy")]
        public string GanonsCastleGroundsGanonsCastleFairy { get; set; }

        [JsonProperty("Gerudo Valley Far Side -> Carpenter Tent")]
        public string GerudoValleyFarSideCarpenterTent { get; set; }

        [JsonProperty("Goron City -> Goron Shop")]
        public string GoronCityGoronShop { get; set; }

        [JsonProperty("Graveyard -> Dampes House")]
        public string GraveyardDampesHouse { get; set; }

        [JsonProperty("Hyrule Castle Grounds -> Hyrule Castle Fairy")]
        public string HyruleCastleGroundsHyruleCastleFairy { get; set; }

        [JsonProperty("Kakariko Impa Ledge -> Impas House Back")]
        public string KakarikoImpaLedgeImpasHouseBack { get; set; }

        [JsonProperty("Kakariko Village -> Carpenter Boss House")]
        public string KakarikoVillageCarpenterBossHouse { get; set; }

        [JsonProperty("Kakariko Village -> House of Skulltula")]
        public string KakarikoVillageHouseOfSkulltula { get; set; }

        [JsonProperty("Kakariko Village -> Impas House")]
        public string KakarikoVillageImpasHouse { get; set; }

        [JsonProperty("Kakariko Village -> Kakariko Bazaar")]
        public string KakarikoVillageKakarikoBazaar { get; set; }

        [JsonProperty("Kakariko Village -> Kakariko Potion Shop Front")]
        public string KakarikoVillageKakarikoPotionShopFront { get; set; }

        [JsonProperty("Kakariko Village -> Kakariko Shooting Gallery")]
        public string KakarikoVillageKakarikoShootingGallery { get; set; }

        [JsonProperty("Kakariko Village -> Windmill")]
        public string KakarikoVillageWindmill { get; set; }

        [JsonProperty("Kakariko Village Backyard -> Kakariko Potion Shop Back")]
        public string KakarikoVillageBackyardKakarikoPotionShopBack { get; set; }

        [JsonProperty("Kakariko Village Backyard -> Odd Medicine Building")]
        public string KakarikoVillageBackyardOddMedicineBuilding { get; set; }

        [JsonProperty("Kokiri Forest -> House of Twins")]
        public string KokiriForestHouseOfTwins { get; set; }

        [JsonProperty("Kokiri Forest -> Know It All House")]
        public string KokiriForestKnowItAllHouse { get; set; }

        [JsonProperty("Kokiri Forest -> Kokiri Shop")]
        public string KokiriForestKokiriShop { get; set; }

        [JsonProperty("Kokiri Forest -> Links House")]
        public string KokiriForestLinksHouse { get; set; }

        [JsonProperty("Kokiri Forest -> Mido House")]
        public string KokiriForestMidoHouse { get; set; }

        [JsonProperty("Kokiri Forest -> Saria House")]
        public string KokiriForestSariaHouse { get; set; }

        [JsonProperty("Lake Hylia -> Fishing Hole")]
        public string LakeHyliaFishingHole { get; set; }

        [JsonProperty("Lake Hylia -> Lake Hylia Lab")]
        public string LakeHyliaLakeHyliaLab { get; set; }

        [JsonProperty("Lon Lon Ranch -> Ingo Barn")]
        public string LonLonRanchIngoBarn { get; set; }

        [JsonProperty("Lon Lon Ranch -> Lon Lon Corner Tower")]
        public string LonLonRanchLonLonCornerTower { get; set; }

        [JsonProperty("Lon Lon Ranch -> Talon House")]
        public string LonLonRanchTalonHouse { get; set; }

        [JsonProperty("Temple of Time Exterior -> Temple of Time")]
        public string TempleOfTimeExteriorTempleOfTime { get; set; }

        [JsonProperty("Zoras Domain -> Zora Shop")]
        public string ZorasDomainZoraShop { get; set; }

        [JsonProperty("Zoras Fountain -> Zoras Fountain Fairy")]
        public string ZorasFountainZorasFountainFairy { get; set; }

        [JsonProperty("Desert Colossus -> Spirit Temple Lobby")]
        public string DesertColossusSpiritTempleLobby { get; set; }

        [JsonProperty("Dodongos Cavern Entryway -> Dodongos Cavern Beginning")]
        public string DodongosCavernEntrywayDodongosCavernBeginning { get; set; }

        [JsonProperty("Fire Temple Entrance -> Fire Temple Lower")]
        public string FireTempleEntranceFireTempleLower { get; set; }

        [JsonProperty("Gerudo Fortress -> Gerudo Training Grounds Lobby")]
        public string GerudoFortressGerudoTrainingGroundsLobby { get; set; }

        [JsonProperty("Kakariko Village -> Bottom of the Well")]
        public string KakarikoVillageBottomOfTheWell { get; set; }

        [JsonProperty("Lake Hylia -> Water Temple Lobby")]
        public string LakeHyliaWaterTempleLobby { get; set; }

        [JsonProperty("Outside Deku Tree -> Deku Tree Lobby")]
        public string OutsideDekuTreeDekuTreeLobby { get; set; }

        [JsonProperty("Sacred Forest Meadow -> Forest Temple Lobby")]
        public string SacredForestMeadowForestTempleLobby { get; set; }

        [JsonProperty("Shadow Temple Warp Region -> Shadow Temple Entryway")]
        public string ShadowTempleWarpRegionShadowTempleEntryway { get; set; }

        [JsonProperty("Zoras Fountain -> Ice Cavern Beginning")]
        public string ZorasFountainIceCavernBeginning { get; set; }

        [JsonProperty("Zoras Fountain -> Jabu Jabus Belly Beginning")]
        public string ZorasFountainJabuJabusBellyBeginning { get; set; }

        [JsonProperty("Castle Grounds -> Castle Town")]
        public Entrance CastleGroundsCastleTown { get; set; }

        [JsonProperty("Castle Town -> Castle Grounds")]
        public Entrance CastleTownCastleGrounds { get; set; }

        [JsonProperty("Castle Town -> Castle Town Entrance")]
        public Entrance CastleTownCastleTownEntrance { get; set; }

        [JsonProperty("Castle Town -> Temple of Time Exterior")]
        public Entrance CastleTownTempleOfTimeExterior { get; set; }

        [JsonProperty("Castle Town Entrance -> Castle Town")]
        public Entrance CastleTownEntranceCastleTown { get; set; }

        [JsonProperty("Castle Town Entrance -> Hyrule Field")]
        public Entrance CastleTownEntranceHyruleField { get; set; }

        [JsonProperty("Darunias Chamber -> Death Mountain Crater Lower Local")]
        public Entrance DaruniasChamberDeathMountainCraterLowerLocal { get; set; }

        [JsonProperty("Death Mountain -> Goron City")]
        public Entrance DeathMountainGoronCity { get; set; }

        [JsonProperty("Death Mountain -> Kakariko Village Behind Gate")]
        public Entrance DeathMountainKakarikoVillageBehindGate { get; set; }

        [JsonProperty("Death Mountain Crater Lower Nearby -> Darunias Chamber")]
        public Entrance DeathMountainCraterLowerNearbyDaruniasChamber { get; set; }

        [JsonProperty("Death Mountain Crater Upper Nearby -> Death Mountain Summit")]
        public Entrance DeathMountainCraterUpperNearbyDeathMountainSummit { get; set; }

        [JsonProperty("Death Mountain Summit -> Death Mountain Crater Upper Local")]
        public Entrance DeathMountainSummitDeathMountainCraterUpperLocal { get; set; }

        [JsonProperty("Desert Colossus -> Haunted Wasteland Near Colossus")]
        public Entrance DesertColossusHauntedWastelandNearColossus { get; set; }

        [JsonProperty("Gerudo Fortress -> Gerudo Valley Far Side")]
        public Entrance GerudoFortressGerudoValleyFarSide { get; set; }

        [JsonProperty("Gerudo Fortress Outside Gate -> Haunted Wasteland Near Fortress")]
        public Entrance GerudoFortressOutsideGateHauntedWastelandNearFortress { get; set; }

        [JsonProperty("Gerudo Valley -> Hyrule Field")]
        public Entrance GerudoValleyHyruleField { get; set; }

        [JsonProperty("Gerudo Valley Far Side -> Gerudo Fortress")]
        public Entrance GerudoValleyFarSideGerudoFortress { get; set; }

        [JsonProperty("Goron City -> Death Mountain")]
        public Entrance GoronCityDeathMountain { get; set; }

        [JsonProperty("Goron City Woods Warp -> Lost Woods")]
        public Entrance GoronCityWoodsWarpLostWoods { get; set; }

        [JsonProperty("Graveyard -> Kakariko Village")]
        public Entrance GraveyardKakarikoVillage { get; set; }

        [JsonProperty("Haunted Wasteland Near Colossus -> Desert Colossus")]
        public Entrance HauntedWastelandNearColossusDesertColossus { get; set; }

        [JsonProperty("Haunted Wasteland Near Fortress -> Gerudo Fortress Outside Gate")]
        public Entrance HauntedWastelandNearFortressGerudoFortressOutsideGate { get; set; }

        [JsonProperty("Hyrule Field -> Castle Town Entrance")]
        public Entrance HyruleFieldCastleTownEntrance { get; set; }

        [JsonProperty("Hyrule Field -> Gerudo Valley")]
        public Entrance HyruleFieldGerudoValley { get; set; }

        [JsonProperty("Hyrule Field -> Kakariko Village")]
        public Entrance HyruleFieldKakarikoVillage { get; set; }

        [JsonProperty("Hyrule Field -> Lake Hylia")]
        public Entrance HyruleFieldLakeHylia { get; set; }

        [JsonProperty("Hyrule Field -> Lon Lon Ranch")]
        public Entrance HyruleFieldLonLonRanch { get; set; }

        [JsonProperty("Hyrule Field -> Lost Woods Bridge")]
        public Entrance HyruleFieldLostWoodsBridge { get; set; }

        [JsonProperty("Hyrule Field -> Zora River Front")]
        public Entrance HyruleFieldZoraRiverFront { get; set; }

        [JsonProperty("Kakariko Village -> Graveyard")]
        public Entrance KakarikoVillageGraveyard { get; set; }

        [JsonProperty("Kakariko Village -> Hyrule Field")]
        public Entrance KakarikoVillageHyruleField { get; set; }

        [JsonProperty("Kakariko Village Behind Gate -> Death Mountain")]
        public Entrance KakarikoVillageBehindGateDeathMountain { get; set; }

        [JsonProperty("Kokiri Forest -> Lost Woods")]
        public Entrance KokiriForestLostWoods { get; set; }

        [JsonProperty("Kokiri Forest -> Lost Woods Bridge From Forest")]
        public Entrance KokiriForestLostWoodsBridgeFromForest { get; set; }

        [JsonProperty("Lake Hylia -> Hyrule Field")]
        public Entrance LakeHyliaHyruleField { get; set; }

        [JsonProperty("Lake Hylia -> Zoras Domain")]
        public Entrance LakeHyliaZorasDomain { get; set; }

        [JsonProperty("Lon Lon Ranch -> Hyrule Field")]
        public Entrance LonLonRanchHyruleField { get; set; }

        [JsonProperty("Lost Woods -> Goron City Woods Warp")]
        public Entrance LostWoodsGoronCityWoodsWarp { get; set; }

        [JsonProperty("Lost Woods -> Zora River")]
        public Entrance LostWoodsZoraRiver { get; set; }

        [JsonProperty("Lost Woods Beyond Mido -> Sacred Forest Meadow Entryway")]
        public Entrance LostWoodsBeyondMidoSacredForestMeadowEntryway { get; set; }

        [JsonProperty("Lost Woods Bridge -> Hyrule Field")]
        public Entrance LostWoodsBridgeHyruleField { get; set; }

        [JsonProperty("Lost Woods Bridge -> Kokiri Forest")]
        public Entrance LostWoodsBridgeKokiriForest { get; set; }

        [JsonProperty("Lost Woods Forest Exit -> Kokiri Forest")]
        public Entrance LostWoodsForestExitKokiriForest { get; set; }

        [JsonProperty("Sacred Forest Meadow Entryway -> Lost Woods Beyond Mido")]
        public Entrance SacredForestMeadowEntrywayLostWoodsBeyondMido { get; set; }

        [JsonProperty("Temple of Time Exterior -> Castle Town")]
        public Entrance TempleOfTimeExteriorCastleTown { get; set; }

        [JsonProperty("Zora River -> Lost Woods")]
        public Entrance ZoraRiverLostWoods { get; set; }

        [JsonProperty("Zora River Behind Waterfall -> Zoras Domain")]
        public Entrance ZoraRiverBehindWaterfallZorasDomain { get; set; }

        [JsonProperty("Zora River Front -> Hyrule Field")]
        public Entrance ZoraRiverFrontHyruleField { get; set; }

        [JsonProperty("Zoras Domain -> Lake Hylia")]
        public Entrance ZorasDomainLakeHylia { get; set; }

        [JsonProperty("Zoras Domain -> Zora River Behind Waterfall")]
        public Entrance ZorasDomainZoraRiverBehindWaterfall { get; set; }

        [JsonProperty("Zoras Domain Behind King Zora -> Zoras Fountain")]
        public Entrance ZorasDomainBehindKingZoraZorasFountain { get; set; }

        [JsonProperty("Zoras Fountain -> Zoras Domain Behind King Zora")]
        public Entrance ZorasFountainZorasDomainBehindKingZora { get; set; }

        [JsonProperty("Death Mountain Summit Owl Flight -> Kakariko Impa Ledge")]
        public Entrance DeathMountainSummitOwlFlightKakarikoImpaLedge { get; set; }

        [JsonProperty("Lake Hylia Owl Flight -> Hyrule Field")]
        public Entrance LakeHyliaOwlFlightHyruleField { get; set; }
    }

    public partial class GossipStones
    {
        [JsonProperty("Death Mountain Crater (Bombable Wall)")]
        public GossipStone DeathMountainCraterBombableWall { get; set; }

        [JsonProperty("Death Mountain Crater (Rock Grotto)")]
        public GossipStone DeathMountainCraterRockGrotto { get; set; }

        [JsonProperty("Death Mountain Trail (Biggoron)")]
        public GossipStone DeathMountainTrailBiggoron { get; set; }

        [JsonProperty("Death Mountain Trail (Storms Grotto)")]
        public GossipStone DeathMountainTrailStormsGrotto { get; set; }

        [JsonProperty("Desert Colossus (Spirit Temple)")]
        public GossipStone DesertColossusSpiritTemple { get; set; }

        [JsonProperty("Dodongos Cavern (Bombable Wall)")]
        public GossipStone DodongosCavernBombableWall { get; set; }

        [JsonProperty("Gerudo Valley (Waterfall)")]
        public GossipStone GerudoValleyWaterfall { get; set; }

        [JsonProperty("Goron City (Maze)")]
        public GossipStone GoronCityMaze { get; set; }

        [JsonProperty("Goron City (Medigoron)")]
        public GossipStone GoronCityMedigoron { get; set; }

        [JsonProperty("Graveyard (Shadow Temple)")]
        public GossipStone GraveyardShadowTemple { get; set; }

        [JsonProperty("Hyrule Castle (Malon)")]
        public GossipStone HyruleCastleMalon { get; set; }

        [JsonProperty("Hyrule Castle (Rock Wall)")]
        public GossipStone HyruleCastleRockWall { get; set; }

        [JsonProperty("Hyrule Castle (Storms Grotto)")]
        public GossipStone HyruleCastleStormsGrotto { get; set; }

        [JsonProperty("Hyrule Field (Castle Moat Grotto)")]
        public GossipStone HyruleFieldCastleMoatGrotto { get; set; }

        [JsonProperty("Hyrule Field (Hammer Grotto)")]
        public GossipStone HyruleFieldHammerGrotto { get; set; }

        [JsonProperty("Hyrule Field (Open Grotto)")]
        public GossipStone HyruleFieldOpenGrotto { get; set; }

        [JsonProperty("Hyrule Field (Rock Grotto)")]
        public GossipStone HyruleFieldRockGrotto { get; set; }

        [JsonProperty("Kakariko (Potion Grotto)")]
        public GossipStone KakarikoPotionGrotto { get; set; }

        [JsonProperty("Kokiri Forest (Deku Tree Left)")]
        public GossipStone KokiriForestDekuTreeLeft { get; set; }

        [JsonProperty("Kokiri Forest (Deku Tree Right)")]
        public GossipStone KokiriForestDekuTreeRight { get; set; }

        [JsonProperty("Kokiri Forest (Storms Grotto)")]
        public GossipStone KokiriForestStormsGrotto { get; set; }

        [JsonProperty("Kokiri Forest (Storms)")]
        public GossipStone KokiriForestStorms { get; set; }

        [JsonProperty("Lake Hylia (Lab)")]
        public GossipStone LakeHyliaLab { get; set; }

        [JsonProperty("Lake Hylia (Southeast Corner)")]
        public GossipStone LakeHyliaSoutheastCorner { get; set; }

        [JsonProperty("Lake Hylia (Southwest Corner)")]
        public GossipStone LakeHyliaSouthwestCorner { get; set; }

        [JsonProperty("Lost Woods (Bridge)")]
        public GossipStone LostWoodsBridge { get; set; }

        [JsonProperty("Lost Woods (Rock Grotto)")]
        public GossipStone LostWoodsRockGrotto { get; set; }

        [JsonProperty("Sacred Forest Meadow (Maze Lower)")]
        public GossipStone SacredForestMeadowMazeLower { get; set; }

        [JsonProperty("Sacred Forest Meadow (Maze Upper)")]
        public GossipStone SacredForestMeadowMazeUpper { get; set; }

        [JsonProperty("Sacred Forest Meadow (Saria)")]
        public GossipStone SacredForestMeadowSaria { get; set; }

        [JsonProperty("Temple of Time (Left)")]
        public GossipStone TempleOfTimeLeft { get; set; }

        [JsonProperty("Temple of Time (Left-Center)")]
        public GossipStone TempleOfTimeLeftCenter { get; set; }

        [JsonProperty("Temple of Time (Right)")]
        public GossipStone TempleOfTimeRight { get; set; }

        [JsonProperty("Temple of Time (Right-Center)")]
        public GossipStone TempleOfTimeRightCenter { get; set; }

        [JsonProperty("Zoras Domain (Mweep)")]
        public GossipStone ZorasDomainMweep { get; set; }

        [JsonProperty("Zoras Fountain (Fairy)")]
        public GossipStone ZorasFountainFairy { get; set; }

        [JsonProperty("Zoras Fountain (Jabu)")]
        public GossipStone ZorasFountainJabu { get; set; }

        [JsonProperty("Zoras River (Open Grotto)")]
        public GossipStone ZorasRiverOpenGrotto { get; set; }

        [JsonProperty("Zoras River (Plateau)")]
        public GossipStone ZorasRiverPlateau { get; set; }

        [JsonProperty("Zoras River (Waterfall)")]
        public GossipStone ZorasRiverWaterfall { get; set; }
    }

    public partial class OOTInputLocations
    {
        [JsonProperty("Links Pocket")]
        public OOTInputLocationItem LinksPocket { get; set; }

        [JsonProperty("Queen Gohma")]
        public OOTInputLocationItem QueenGohma { get; set; }

        [JsonProperty("King Dodongo")]
        public OOTInputLocationItem KingDodongo { get; set; }

        [JsonProperty("Barinade")]
        public OOTInputLocationItem Barinade { get; set; }

        [JsonProperty("Phantom Ganon")]
        public OOTInputLocationItem PhantomGanon { get; set; }

        [JsonProperty("Volvagia")]
        public OOTInputLocationItem Volvagia { get; set; }

        [JsonProperty("Morpha")]
        public OOTInputLocationItem Morpha { get; set; }

        [JsonProperty("Bongo Bongo")]
        public OOTInputLocationItem BongoBongo { get; set; }

        [JsonProperty("Twinrova")]
        public OOTInputLocationItem Twinrova { get; set; }

        [JsonProperty("Song from Saria")]
        public OOTInputLocationItem SongFromSaria { get; set; }

        [JsonProperty("Sheik Forest Song")]
        public OOTInputLocationItem SheikForestSong { get; set; }

        [JsonProperty("Song from Ocarina of Time")]
        public OOTInputLocationItem SongFromOcarinaOfTime { get; set; }

        [JsonProperty("Sheik at Colossus")]
        public OOTInputLocationItem SheikAtColossus { get; set; }

        [JsonProperty("Sheik at Temple")]
        public OOTInputLocationItem SheikAtTemple { get; set; }

        [JsonProperty("Impa at Castle")]
        public OOTInputLocationItem ImpaAtCastle { get; set; }

        [JsonProperty("Sheik in Kakariko")]
        public OOTInputLocationItem SheikInKakariko { get; set; }

        [JsonProperty("Song at Windmill")]
        public OOTInputLocationItem SongAtWindmill { get; set; }

        [JsonProperty("Song from Composer Grave")]
        public OOTInputLocationItem SongFromComposerGrave { get; set; }

        [JsonProperty("Sheik in Crater")]
        public OOTInputLocationItem SheikInCrater { get; set; }

        [JsonProperty("Song from Malon")]
        public OOTInputLocationItem SongFromMalon { get; set; }

        [JsonProperty("Sheik in Ice Cavern")]
        public OOTInputLocationItem SheikInIceCavern { get; set; }

        [JsonProperty("Kokiri Sword Chest")]
        public OOTInputLocationItem KokiriSwordChest { get; set; }

        [JsonProperty("GS Kokiri Know It All House")]
        public OOTInputLocationItem GsKokiriKnowItAllHouse { get; set; }

        [JsonProperty("GS Kokiri Bean Patch")]
        public OOTInputLocationItem GsKokiriBeanPatch { get; set; }

        [JsonProperty("GS Kokiri House of Twins")]
        public OOTInputLocationItem GsKokiriHouseOfTwins { get; set; }

        [JsonProperty("Mido Chest Top Left")]
        public OOTInputLocationItem MidoChestTopLeft { get; set; }

        [JsonProperty("Mido Chest Top Right")]
        public OOTInputLocationItem MidoChestTopRight { get; set; }

        [JsonProperty("Mido Chest Bottom Left")]
        public OOTInputLocationItem MidoChestBottomLeft { get; set; }

        [JsonProperty("Mido Chest Bottom Right")]
        public OOTInputLocationItem MidoChestBottomRight { get; set; }

        [JsonProperty("Kokiri Shop Item 1")]
        public OOTInputLocationItem KokiriShopItem1 { get; set; }

        [JsonProperty("Kokiri Shop Item 2")]
        public OOTInputLocationItem KokiriShopItem2 { get; set; }

        [JsonProperty("Kokiri Shop Item 3")]
        public OOTInputLocationItem KokiriShopItem3 { get; set; }

        [JsonProperty("Kokiri Shop Item 4")]
        public OOTInputLocationItem KokiriShopItem4 { get; set; }

        [JsonProperty("Kokiri Shop Item 5")]
        public OOTInputLocationItem KokiriShopItem5 { get; set; }

        [JsonProperty("Kokiri Shop Item 6")]
        public OOTInputLocationItem KokiriShopItem6 { get; set; }

        [JsonProperty("Kokiri Shop Item 7")]
        public OOTInputLocationItem KokiriShopItem7 { get; set; }

        [JsonProperty("Kokiri Shop Item 8")]
        public OOTInputLocationItem KokiriShopItem8 { get; set; }

        [JsonProperty("Skull Kid")]
        public OOTInputLocationItem SkullKid { get; set; }

        [JsonProperty("Ocarina Memory Game")]
        public OOTInputLocationItem OcarinaMemoryGame { get; set; }

        [JsonProperty("Target in Woods")]
        public OOTInputLocationItem TargetInWoods { get; set; }

        [JsonProperty("LW Deku Scrub Deku Stick Upgrade")]
        public OOTInputLocationItem LwDekuScrubDekuStickUpgrade { get; set; }

        [JsonProperty("GS Lost Woods Bean Patch Near Bridge")]
        public OOTInputLocationItem GsLostWoodsBeanPatchNearBridge { get; set; }

        [JsonProperty("GS Lost Woods Above Stage")]
        public OOTInputLocationItem GsLostWoodsAboveStage { get; set; }

        [JsonProperty("GS Lost Woods Bean Patch Near Stage")]
        public OOTInputLocationItem GsLostWoodsBeanPatchNearStage { get; set; }

        [JsonProperty("GS Sacred Forest Meadow")]
        public OOTInputLocationItem GsSacredForestMeadow { get; set; }

        [JsonProperty("Gift from Saria")]
        public OOTInputLocationItem GiftFromSaria { get; set; }

        [JsonProperty("Ocarina of Time")]
        public OOTInputLocationItem OcarinaOfTime { get; set; }

        [JsonProperty("Underwater Bottle")]
        public OOTInputLocationItem UnderwaterBottle { get; set; }

        [JsonProperty("Lake Hylia Sun")]
        public OOTInputLocationItem LakeHyliaSun { get; set; }

        [JsonProperty("Lake Hylia Freestanding PoH")]
        public OOTInputLocationItem LakeHyliaFreestandingPoH { get; set; }

        [JsonProperty("GS Lake Hylia Bean Patch")]
        public OOTInputLocationItem GsLakeHyliaBeanPatch { get; set; }

        [JsonProperty("GS Lake Hylia Lab Wall")]
        public OOTInputLocationItem GsLakeHyliaLabWall { get; set; }

        [JsonProperty("GS Lake Hylia Small Island")]
        public OOTInputLocationItem GsLakeHyliaSmallIsland { get; set; }

        [JsonProperty("GS Lake Hylia Giant Tree")]
        public OOTInputLocationItem GsLakeHyliaGiantTree { get; set; }

        [JsonProperty("Diving in the Lab")]
        public OOTInputLocationItem DivingInTheLab { get; set; }

        [JsonProperty("GS Lab Underwater Crate")]
        public OOTInputLocationItem GsLabUnderwaterCrate { get; set; }

        [JsonProperty("Child Fishing")]
        public OOTInputLocationItem ChildFishing { get; set; }

        [JsonProperty("Adult Fishing")]
        public OOTInputLocationItem AdultFishing { get; set; }

        [JsonProperty("GS Gerudo Valley Small Bridge")]
        public OOTInputLocationItem GsGerudoValleySmallBridge { get; set; }

        [JsonProperty("Gerudo Valley Waterfall Freestanding PoH")]
        public OOTInputLocationItem GerudoValleyWaterfallFreestandingPoH { get; set; }

        [JsonProperty("GS Gerudo Valley Bean Patch")]
        public OOTInputLocationItem GsGerudoValleyBeanPatch { get; set; }

        [JsonProperty("Gerudo Valley Crate Freestanding PoH")]
        public OOTInputLocationItem GerudoValleyCrateFreestandingPoH { get; set; }

        [JsonProperty("Gerudo Valley Hammer Rocks Chest")]
        public OOTInputLocationItem GerudoValleyHammerRocksChest { get; set; }

        [JsonProperty("GS Gerudo Valley Behind Tent")]
        public OOTInputLocationItem GsGerudoValleyBehindTent { get; set; }

        [JsonProperty("GS Gerudo Valley Pillar")]
        public OOTInputLocationItem GsGerudoValleyPillar { get; set; }

        [JsonProperty("Gerudo Fortress Rooftop Chest")]
        public OOTInputLocationItem GerudoFortressRooftopChest { get; set; }

        [JsonProperty("Horseback Archery 1000 Points")]
        public OOTInputLocationItem HorsebackArchery1000Points { get; set; }

        [JsonProperty("Horseback Archery 1500 Points")]
        public OOTInputLocationItem HorsebackArchery1500Points { get; set; }

        [JsonProperty("Gerudo Fortress North F1 Carpenter")]
        public OOTInputLocationItem GerudoFortressNorthF1Carpenter { get; set; }

        [JsonProperty("Gerudo Fortress Membership Card")]
        public OOTInputLocationItem GerudoFortressMembershipCard { get; set; }

        [JsonProperty("GS Gerudo Fortress Archery Range")]
        public OOTInputLocationItem GsGerudoFortressArcheryRange { get; set; }

        [JsonProperty("GS Gerudo Fortress Top Floor")]
        public OOTInputLocationItem GsGerudoFortressTopFloor { get; set; }

        [JsonProperty("Haunted Wasteland Structure Chest")]
        public OOTInputLocationItem HauntedWastelandStructureChest { get; set; }

        [JsonProperty("GS Wasteland Ruins")]
        public OOTInputLocationItem GsWastelandRuins { get; set; }

        [JsonProperty("Colossus Freestanding PoH")]
        public OOTInputLocationItem ColossusFreestandingPoH { get; set; }

        [JsonProperty("GS Desert Colossus Bean Patch")]
        public OOTInputLocationItem GsDesertColossusBeanPatch { get; set; }

        [JsonProperty("GS Desert Colossus Tree")]
        public OOTInputLocationItem GsDesertColossusTree { get; set; }

        [JsonProperty("GS Desert Colossus Hill")]
        public OOTInputLocationItem GsDesertColossusHill { get; set; }

        [JsonProperty("Desert Colossus Fairy Reward")]
        public OOTInputLocationItem DesertColossusFairyReward { get; set; }

        [JsonProperty("Zelda")]
        public OOTInputLocationItem Zelda { get; set; }

        [JsonProperty("Malon Egg")]
        public OOTInputLocationItem MalonEgg { get; set; }

        [JsonProperty("GS Hyrule Castle Tree")]
        public OOTInputLocationItem GsHyruleCastleTree { get; set; }

        [JsonProperty("Hyrule Castle Fairy Reward")]
        public OOTInputLocationItem HyruleCastleFairyReward { get; set; }

        [JsonProperty("GS Outside Ganon's Castle")]
        public OOTInputLocationItem GsOutsideGanonSCastle { get; set; }

        [JsonProperty("Ganons Castle Fairy Reward")]
        public OOTInputLocationItem GanonsCastleFairyReward { get; set; }

        [JsonProperty("10 Big Poes")]
        public OOTInputLocationItem The10BigPoes { get; set; }

        [JsonProperty("GS Castle Market Guard House")]
        public OOTInputLocationItem GsCastleMarketGuardHouse { get; set; }

        [JsonProperty("Castle Town Bazaar Item 1")]
        public OOTInputLocationItem CastleTownBazaarItem1 { get; set; }

        [JsonProperty("Castle Town Bazaar Item 2")]
        public OOTInputLocationItem CastleTownBazaarItem2 { get; set; }

        [JsonProperty("Castle Town Bazaar Item 3")]
        public OOTInputLocationItem CastleTownBazaarItem3 { get; set; }

        [JsonProperty("Castle Town Bazaar Item 4")]
        public OOTInputLocationItem CastleTownBazaarItem4 { get; set; }

        [JsonProperty("Castle Town Bazaar Item 5")]
        public OOTInputLocationItem CastleTownBazaarItem5 { get; set; }

        [JsonProperty("Castle Town Bazaar Item 6")]
        public OOTInputLocationItem CastleTownBazaarItem6 { get; set; }

        [JsonProperty("Castle Town Bazaar Item 7")]
        public OOTInputLocationItem CastleTownBazaarItem7 { get; set; }

        [JsonProperty("Castle Town Bazaar Item 8")]
        public OOTInputLocationItem CastleTownBazaarItem8 { get; set; }

        [JsonProperty("Child Shooting Gallery")]
        public OOTInputLocationItem ChildShootingGallery { get; set; }

        [JsonProperty("Bombchu Bowling Bomb Bag")]
        public OOTInputLocationItem BombchuBowlingBombBag { get; set; }

        [JsonProperty("Bombchu Bowling Piece of Heart")]
        public OOTInputLocationItem BombchuBowlingPieceOfHeart { get; set; }

        [JsonProperty("Castle Town Potion Shop Item 1")]
        public OOTInputLocationItem CastleTownPotionShopItem1 { get; set; }

        [JsonProperty("Castle Town Potion Shop Item 2")]
        public OOTInputLocationItem CastleTownPotionShopItem2 { get; set; }

        [JsonProperty("Castle Town Potion Shop Item 3")]
        public OOTInputLocationItem CastleTownPotionShopItem3 { get; set; }

        [JsonProperty("Castle Town Potion Shop Item 4")]
        public OOTInputLocationItem CastleTownPotionShopItem4 { get; set; }

        [JsonProperty("Castle Town Potion Shop Item 5")]
        public OOTInputLocationItem CastleTownPotionShopItem5 { get; set; }

        [JsonProperty("Castle Town Potion Shop Item 6")]
        public OOTInputLocationItem CastleTownPotionShopItem6 { get; set; }

        [JsonProperty("Castle Town Potion Shop Item 7")]
        public OOTInputLocationItem CastleTownPotionShopItem7 { get; set; }

        [JsonProperty("Castle Town Potion Shop Item 8")]
        public OOTInputLocationItem CastleTownPotionShopItem8 { get; set; }

        [JsonProperty("Treasure Chest Game")]
        public OOTInputLocationItem TreasureChestGame { get; set; }

        [JsonProperty("Bombchu Shop Item 1")]
        public OOTInputLocationItem BombchuShopItem1 { get; set; }

        [JsonProperty("Bombchu Shop Item 2")]
        public OOTInputLocationItem BombchuShopItem2 { get; set; }

        [JsonProperty("Bombchu Shop Item 3")]
        public OOTInputLocationItem BombchuShopItem3 { get; set; }

        [JsonProperty("Bombchu Shop Item 4")]
        public OOTInputLocationItem BombchuShopItem4 { get; set; }

        [JsonProperty("Bombchu Shop Item 5")]
        public OOTInputLocationItem BombchuShopItem5 { get; set; }

        [JsonProperty("Bombchu Shop Item 6")]
        public OOTInputLocationItem BombchuShopItem6 { get; set; }

        [JsonProperty("Bombchu Shop Item 7")]
        public OOTInputLocationItem BombchuShopItem7 { get; set; }

        [JsonProperty("Bombchu Shop Item 8")]
        public OOTInputLocationItem BombchuShopItem8 { get; set; }

        [JsonProperty("Dog Lady")]
        public OOTInputLocationItem DogLady { get; set; }

        [JsonProperty("Anju as Adult")]
        public OOTInputLocationItem AnjuAsAdult { get; set; }

        [JsonProperty("Anjus Chickens")]
        public OOTInputLocationItem AnjusChickens { get; set; }

        [JsonProperty("GS Kakariko House Under Construction")]
        public OOTInputLocationItem GsKakarikoHouseUnderConstruction { get; set; }

        [JsonProperty("GS Kakariko Skulltula House")]
        public OOTInputLocationItem GsKakarikoSkulltulaHouse { get; set; }

        [JsonProperty("GS Kakariko Guard's House")]
        public OOTInputLocationItem GsKakarikoGuardSHouse { get; set; }

        [JsonProperty("GS Kakariko Tree")]
        public OOTInputLocationItem GsKakarikoTree { get; set; }

        [JsonProperty("GS Kakariko Watchtower")]
        public OOTInputLocationItem GsKakarikoWatchtower { get; set; }

        [JsonProperty("GS Kakariko Above Impa's House")]
        public OOTInputLocationItem GsKakarikoAboveImpaSHouse { get; set; }

        [JsonProperty("Man on Roof")]
        public OOTInputLocationItem ManOnRoof { get; set; }

        [JsonProperty("10 Gold Skulltula Reward")]
        public OOTInputLocationItem The10GoldSkulltulaReward { get; set; }

        [JsonProperty("20 Gold Skulltula Reward")]
        public OOTInputLocationItem The20GoldSkulltulaReward { get; set; }

        [JsonProperty("30 Gold Skulltula Reward")]
        public OOTInputLocationItem The30GoldSkulltulaReward { get; set; }

        [JsonProperty("40 Gold Skulltula Reward")]
        public OOTInputLocationItem The40GoldSkulltulaReward { get; set; }

        [JsonProperty("50 Gold Skulltula Reward")]
        public OOTInputLocationItem The50GoldSkulltulaReward { get; set; }

        [JsonProperty("Impa House Freestanding PoH")]
        public OOTInputLocationItem ImpaHouseFreestandingPoH { get; set; }

        [JsonProperty("Windmill Freestanding PoH")]
        public OOTInputLocationItem WindmillFreestandingPoH { get; set; }

        [JsonProperty("Kakariko Bazaar Item 1")]
        public OOTInputLocationItem KakarikoBazaarItem1 { get; set; }

        [JsonProperty("Kakariko Bazaar Item 2")]
        public OOTInputLocationItem KakarikoBazaarItem2 { get; set; }

        [JsonProperty("Kakariko Bazaar Item 3")]
        public OOTInputLocationItem KakarikoBazaarItem3 { get; set; }

        [JsonProperty("Kakariko Bazaar Item 4")]
        public OOTInputLocationItem KakarikoBazaarItem4 { get; set; }

        [JsonProperty("Kakariko Bazaar Item 5")]
        public OOTInputLocationItem KakarikoBazaarItem5 { get; set; }

        [JsonProperty("Kakariko Bazaar Item 6")]
        public OOTInputLocationItem KakarikoBazaarItem6 { get; set; }

        [JsonProperty("Kakariko Bazaar Item 7")]
        public OOTInputLocationItem KakarikoBazaarItem7 { get; set; }

        [JsonProperty("Kakariko Bazaar Item 8")]
        public OOTInputLocationItem KakarikoBazaarItem8 { get; set; }

        [JsonProperty("Adult Shooting Gallery")]
        public OOTInputLocationItem AdultShootingGallery { get; set; }

        [JsonProperty("Kakariko Potion Shop Item 1")]
        public OOTInputLocationItem KakarikoPotionShopItem1 { get; set; }

        [JsonProperty("Kakariko Potion Shop Item 2")]
        public OOTInputLocationItem KakarikoPotionShopItem2 { get; set; }

        [JsonProperty("Kakariko Potion Shop Item 3")]
        public OOTInputLocationItem KakarikoPotionShopItem3 { get; set; }

        [JsonProperty("Kakariko Potion Shop Item 4")]
        public OOTInputLocationItem KakarikoPotionShopItem4 { get; set; }

        [JsonProperty("Kakariko Potion Shop Item 5")]
        public OOTInputLocationItem KakarikoPotionShopItem5 { get; set; }

        [JsonProperty("Kakariko Potion Shop Item 6")]
        public OOTInputLocationItem KakarikoPotionShopItem6 { get; set; }

        [JsonProperty("Kakariko Potion Shop Item 7")]
        public OOTInputLocationItem KakarikoPotionShopItem7 { get; set; }

        [JsonProperty("Kakariko Potion Shop Item 8")]
        public OOTInputLocationItem KakarikoPotionShopItem8 { get; set; }

        [JsonProperty("Graveyard Freestanding PoH")]
        public OOTInputLocationItem GraveyardFreestandingPoH { get; set; }

        [JsonProperty("Gravedigging Tour")]
        public OOTInputLocationItem GravediggingTour { get; set; }

        [JsonProperty("GS Graveyard Wall")]
        public OOTInputLocationItem GsGraveyardWall { get; set; }

        [JsonProperty("GS Graveyard Bean Patch")]
        public OOTInputLocationItem GsGraveyardBeanPatch { get; set; }

        [JsonProperty("Shield Grave Chest")]
        public OOTInputLocationItem ShieldGraveChest { get; set; }

        [JsonProperty("Heart Piece Grave Chest")]
        public OOTInputLocationItem HeartPieceGraveChest { get; set; }

        [JsonProperty("Composer Grave Chest")]
        public OOTInputLocationItem ComposerGraveChest { get; set; }

        [JsonProperty("Hookshot Chest")]
        public OOTInputLocationItem HookshotChest { get; set; }

        [JsonProperty("Dampe Race Freestanding PoH")]
        public OOTInputLocationItem DampeRaceFreestandingPoH { get; set; }

        [JsonProperty("Death Mountain Bombable Chest")]
        public OOTInputLocationItem DeathMountainBombableChest { get; set; }

        [JsonProperty("DM Trail Freestanding PoH")]
        public OOTInputLocationItem DmTrailFreestandingPoH { get; set; }

        [JsonProperty("GS Mountain Trail Bean Patch")]
        public OOTInputLocationItem GsMountainTrailBeanPatch { get; set; }

        [JsonProperty("GS Mountain Trail Bomb Alcove")]
        public OOTInputLocationItem GsMountainTrailBombAlcove { get; set; }

        [JsonProperty("GS Mountain Trail Above Dodongo's Cavern")]
        public OOTInputLocationItem GsMountainTrailAboveDodongoSCavern { get; set; }

        [JsonProperty("Biggoron")]
        public OOTInputLocationItem Biggoron { get; set; }

        [JsonProperty("GS Mountain Trail Path to Crater")]
        public OOTInputLocationItem GsMountainTrailPathToCrater { get; set; }

        [JsonProperty("Goron City Leftmost Maze Chest")]
        public OOTInputLocationItem GoronCityLeftmostMazeChest { get; set; }

        [JsonProperty("Goron City Left Maze Chest")]
        public OOTInputLocationItem GoronCityLeftMazeChest { get; set; }

        [JsonProperty("Goron City Right Maze Chest")]
        public OOTInputLocationItem GoronCityRightMazeChest { get; set; }

        [JsonProperty("Goron City Pot Freestanding PoH")]
        public OOTInputLocationItem GoronCityPotFreestandingPoH { get; set; }

        [JsonProperty("Rolling Goron as Child")]
        public OOTInputLocationItem RollingGoronAsChild { get; set; }

        [JsonProperty("Link the Goron")]
        public OOTInputLocationItem LinkTheGoron { get; set; }

        [JsonProperty("GS Goron City Boulder Maze")]
        public OOTInputLocationItem GsGoronCityBoulderMaze { get; set; }

        [JsonProperty("GS Goron City Center Platform")]
        public OOTInputLocationItem GsGoronCityCenterPlatform { get; set; }

        [JsonProperty("Darunias Joy")]
        public OOTInputLocationItem DaruniasJoy { get; set; }

        [JsonProperty("Goron Shop Item 1")]
        public OOTInputLocationItem GoronShopItem1 { get; set; }

        [JsonProperty("Goron Shop Item 2")]
        public OOTInputLocationItem GoronShopItem2 { get; set; }

        [JsonProperty("Goron Shop Item 3")]
        public OOTInputLocationItem GoronShopItem3 { get; set; }

        [JsonProperty("Goron Shop Item 4")]
        public OOTInputLocationItem GoronShopItem4 { get; set; }

        [JsonProperty("Goron Shop Item 5")]
        public OOTInputLocationItem GoronShopItem5 { get; set; }

        [JsonProperty("Goron Shop Item 6")]
        public OOTInputLocationItem GoronShopItem6 { get; set; }

        [JsonProperty("Goron Shop Item 7")]
        public OOTInputLocationItem GoronShopItem7 { get; set; }

        [JsonProperty("Goron Shop Item 8")]
        public OOTInputLocationItem GoronShopItem8 { get; set; }

        [JsonProperty("DM Crater Wall Freestanding PoH")]
        public OOTInputLocationItem DmCraterWallFreestandingPoH { get; set; }

        [JsonProperty("GS Death Mountain Crater Crate")]
        public OOTInputLocationItem GsDeathMountainCraterCrate { get; set; }

        [JsonProperty("DM Crater Volcano Freestanding PoH")]
        public OOTInputLocationItem DmCraterVolcanoFreestandingPoH { get; set; }

        [JsonProperty("GS Mountain Crater Bean Patch")]
        public OOTInputLocationItem GsMountainCraterBeanPatch { get; set; }

        [JsonProperty("Crater Fairy Reward")]
        public OOTInputLocationItem CraterFairyReward { get; set; }

        [JsonProperty("Mountain Summit Fairy Reward")]
        public OOTInputLocationItem MountainSummitFairyReward { get; set; }

        [JsonProperty("GS Zora River Tree")]
        public OOTInputLocationItem GsZoraRiverTree { get; set; }

        [JsonProperty("Magic Bean Salesman")]
        public OOTInputLocationItem MagicBeanSalesman { get; set; }

        [JsonProperty("Frog Ocarina Game")]
        public OOTInputLocationItem FrogOcarinaGame { get; set; }

        [JsonProperty("Frogs in the Rain")]
        public OOTInputLocationItem FrogsInTheRain { get; set; }

        [JsonProperty("Zora River Lower Freestanding PoH")]
        public OOTInputLocationItem ZoraRiverLowerFreestandingPoH { get; set; }

        [JsonProperty("Zora River Upper Freestanding PoH")]
        public OOTInputLocationItem ZoraRiverUpperFreestandingPoH { get; set; }

        [JsonProperty("GS Zora River Ladder")]
        public OOTInputLocationItem GsZoraRiverLadder { get; set; }

        [JsonProperty("GS Zora River Near Raised Grottos")]
        public OOTInputLocationItem GsZoraRiverNearRaisedGrottos { get; set; }

        [JsonProperty("GS Zora River Above Bridge")]
        public OOTInputLocationItem GsZoraRiverAboveBridge { get; set; }

        [JsonProperty("Diving Minigame")]
        public OOTInputLocationItem DivingMinigame { get; set; }

        [JsonProperty("Zoras Domain Torch Run")]
        public OOTInputLocationItem ZorasDomainTorchRun { get; set; }

        [JsonProperty("King Zora Thawed")]
        public OOTInputLocationItem KingZoraThawed { get; set; }

        [JsonProperty("GS Zora's Domain Frozen Waterfall")]
        public OOTInputLocationItem GsZoraSDomainFrozenWaterfall { get; set; }

        [JsonProperty("Zoras Fountain Iceberg Freestanding PoH")]
        public OOTInputLocationItem ZorasFountainIcebergFreestandingPoH { get; set; }

        [JsonProperty("Zoras Fountain Bottom Freestanding PoH")]
        public OOTInputLocationItem ZorasFountainBottomFreestandingPoH { get; set; }

        [JsonProperty("GS Zora's Fountain Tree")]
        public OOTInputLocationItem GsZoraSFountainTree { get; set; }

        [JsonProperty("GS Zora's Fountain Above the Log")]
        public OOTInputLocationItem GsZoraSFountainAboveTheLog { get; set; }

        [JsonProperty("GS Zora's Fountain Hidden Cave")]
        public OOTInputLocationItem GsZoraSFountainHiddenCave { get; set; }

        [JsonProperty("Zora Shop Item 1")]
        public OOTInputLocationItem ZoraShopItem1 { get; set; }

        [JsonProperty("Zora Shop Item 2")]
        public OOTInputLocationItem ZoraShopItem2 { get; set; }

        [JsonProperty("Zora Shop Item 3")]
        public OOTInputLocationItem ZoraShopItem3 { get; set; }

        [JsonProperty("Zora Shop Item 4")]
        public OOTInputLocationItem ZoraShopItem4 { get; set; }

        [JsonProperty("Zora Shop Item 5")]
        public OOTInputLocationItem ZoraShopItem5 { get; set; }

        [JsonProperty("Zora Shop Item 6")]
        public OOTInputLocationItem ZoraShopItem6 { get; set; }

        [JsonProperty("Zora Shop Item 7")]
        public OOTInputLocationItem ZoraShopItem7 { get; set; }

        [JsonProperty("Zora Shop Item 8")]
        public OOTInputLocationItem ZoraShopItem8 { get; set; }

        [JsonProperty("Zoras Fountain Fairy Reward")]
        public OOTInputLocationItem ZorasFountainFairyReward { get; set; }

        [JsonProperty("GS Lon Lon Ranch Tree")]
        public OOTInputLocationItem GsLonLonRanchTree { get; set; }

        [JsonProperty("GS Lon Lon Ranch Rain Shed")]
        public OOTInputLocationItem GsLonLonRanchRainShed { get; set; }

        [JsonProperty("GS Lon Lon Ranch House Window")]
        public OOTInputLocationItem GsLonLonRanchHouseWindow { get; set; }

        [JsonProperty("GS Lon Lon Ranch Back Wall")]
        public OOTInputLocationItem GsLonLonRanchBackWall { get; set; }

        [JsonProperty("Talons Chickens")]
        public OOTInputLocationItem TalonsChickens { get; set; }

        [JsonProperty("Lon Lon Tower Freestanding PoH")]
        public OOTInputLocationItem LonLonTowerFreestandingPoH { get; set; }

        [JsonProperty("Ganons Tower Boss Key Chest")]
        public OOTInputLocationItem GanonsTowerBossKeyChest { get; set; }

        [JsonProperty("Kokiri Forest Storms Grotto Chest")]
        public OOTInputLocationItem KokiriForestStormsGrottoChest { get; set; }

        [JsonProperty("Lost Woods Generic Grotto Chest")]
        public OOTInputLocationItem LostWoodsGenericGrottoChest { get; set; }

        [JsonProperty("Deku Theater Skull Mask")]
        public OOTInputLocationItem DekuTheaterSkullMask { get; set; }

        [JsonProperty("Deku Theater Mask of Truth")]
        public OOTInputLocationItem DekuTheaterMaskOfTruth { get; set; }

        [JsonProperty("LW Grotto Deku Scrub Deku Nut Upgrade")]
        public OOTInputLocationItem LwGrottoDekuScrubDekuNutUpgrade { get; set; }

        [JsonProperty("Wolfos Grotto Chest")]
        public OOTInputLocationItem WolfosGrottoChest { get; set; }

        [JsonProperty("Remote Southern Grotto Chest")]
        public OOTInputLocationItem RemoteSouthernGrottoChest { get; set; }

        [JsonProperty("Field Near Lake Outside Fence Grotto Chest")]
        public OOTInputLocationItem FieldNearLakeOutsideFenceGrottoChest { get; set; }

        [JsonProperty("HF Grotto Deku Scrub Piece of Heart")]
        public OOTInputLocationItem HfGrottoDekuScrubPieceOfHeart { get; set; }

        [JsonProperty("GS Hyrule Field Near Gerudo Valley")]
        public OOTInputLocationItem GsHyruleFieldNearGerudoValley { get; set; }

        [JsonProperty("Field West Castle Town Grotto Chest")]
        public OOTInputLocationItem FieldWestCastleTownGrottoChest { get; set; }

        [JsonProperty("GS Hyrule Field near Kakariko")]
        public OOTInputLocationItem GsHyruleFieldNearKakariko { get; set; }

        [JsonProperty("Tektite Grotto Freestanding PoH")]
        public OOTInputLocationItem TektiteGrottoFreestandingPoH { get; set; }

        [JsonProperty("GS Hyrule Castle Grotto")]
        public OOTInputLocationItem GsHyruleCastleGrotto { get; set; }

        [JsonProperty("Redead Grotto Chest")]
        public OOTInputLocationItem RedeadGrottoChest { get; set; }

        [JsonProperty("Kakariko Back Grotto Chest")]
        public OOTInputLocationItem KakarikoBackGrottoChest { get; set; }

        [JsonProperty("Mountain Storms Grotto Chest")]
        public OOTInputLocationItem MountainStormsGrottoChest { get; set; }

        [JsonProperty("Top of Crater Grotto Chest")]
        public OOTInputLocationItem TopOfCraterGrottoChest { get; set; }

        [JsonProperty("Zora River Plateau Open Grotto Chest")]
        public OOTInputLocationItem ZoraRiverPlateauOpenGrottoChest { get; set; }

        [JsonProperty("Deku Tree Lobby Chest")]
        public OOTInputLocationItem DekuTreeLobbyChest { get; set; }

        [JsonProperty("Deku Tree Compass Chest")]
        public OOTInputLocationItem DekuTreeCompassChest { get; set; }

        [JsonProperty("Deku Tree Compass Room Side Chest")]
        public OOTInputLocationItem DekuTreeCompassRoomSideChest { get; set; }

        [JsonProperty("Deku Tree Basement Chest")]
        public OOTInputLocationItem DekuTreeBasementChest { get; set; }

        [JsonProperty("GS Deku Tree Compass Room")]
        public OOTInputLocationItem GsDekuTreeCompassRoom { get; set; }

        [JsonProperty("GS Deku Tree Basement Vines")]
        public OOTInputLocationItem GsDekuTreeBasementVines { get; set; }

        [JsonProperty("GS Deku Tree Basement Gate")]
        public OOTInputLocationItem GsDekuTreeBasementGate { get; set; }

        [JsonProperty("GS Deku Tree Basement Back Room")]
        public OOTInputLocationItem GsDekuTreeBasementBackRoom { get; set; }

        [JsonProperty("Deku Tree Slingshot Chest")]
        public OOTInputLocationItem DekuTreeSlingshotChest { get; set; }

        [JsonProperty("Deku Tree Slingshot Room Side Chest")]
        public OOTInputLocationItem DekuTreeSlingshotRoomSideChest { get; set; }

        [JsonProperty("Queen Gohma Heart")]
        public OOTInputLocationItem QueenGohmaHeart { get; set; }

        [JsonProperty("Dodongos Cavern Map Chest")]
        public OOTInputLocationItem DodongosCavernMapChest { get; set; }

        [JsonProperty("Dodongos Cavern Compass Chest")]
        public OOTInputLocationItem DodongosCavernCompassChest { get; set; }

        [JsonProperty("GS Dodongo's Cavern East Side Room")]
        public OOTInputLocationItem GsDodongoSCavernEastSideRoom { get; set; }

        [JsonProperty("GS Dodongo's Cavern Scarecrow")]
        public OOTInputLocationItem GsDodongoSCavernScarecrow { get; set; }

        [JsonProperty("Dodongos Cavern Bomb Flower Platform")]
        public OOTInputLocationItem DodongosCavernBombFlowerPlatform { get; set; }

        [JsonProperty("GS Dodongo's Cavern Vines Above Stairs")]
        public OOTInputLocationItem GsDodongoSCavernVinesAboveStairs { get; set; }

        [JsonProperty("Dodongos Cavern Bomb Bag Chest")]
        public OOTInputLocationItem DodongosCavernBombBagChest { get; set; }

        [JsonProperty("Dodongos Cavern End of Bridge Chest")]
        public OOTInputLocationItem DodongosCavernEndOfBridgeChest { get; set; }

        [JsonProperty("GS Dodongo's Cavern Alcove Above Stairs")]
        public OOTInputLocationItem GsDodongoSCavernAlcoveAboveStairs { get; set; }

        [JsonProperty("Chest Above King Dodongo")]
        public OOTInputLocationItem ChestAboveKingDodongo { get; set; }

        [JsonProperty("King Dodongo Heart")]
        public OOTInputLocationItem KingDodongoHeart { get; set; }

        [JsonProperty("GS Dodongo's Cavern Back Room")]
        public OOTInputLocationItem GsDodongoSCavernBackRoom { get; set; }

        [JsonProperty("Boomerang Chest")]
        public OOTInputLocationItem BoomerangChest { get; set; }

        [JsonProperty("GS Jabu Jabu Water Switch Room")]
        public OOTInputLocationItem GsJabuJabuWaterSwitchRoom { get; set; }

        [JsonProperty("GS Jabu Jabu Lobby Basement Lower")]
        public OOTInputLocationItem GsJabuJabuLobbyBasementLower { get; set; }

        [JsonProperty("GS Jabu Jabu Lobby Basement Upper")]
        public OOTInputLocationItem GsJabuJabuLobbyBasementUpper { get; set; }

        [JsonProperty("Jabu Jabus Belly Map Chest")]
        public OOTInputLocationItem JabuJabusBellyMapChest { get; set; }

        [JsonProperty("Jabu Jabus Belly Compass Chest")]
        public OOTInputLocationItem JabuJabusBellyCompassChest { get; set; }

        [JsonProperty("Barinade Heart")]
        public OOTInputLocationItem BarinadeHeart { get; set; }

        [JsonProperty("GS Jabu Jabu Near Boss")]
        public OOTInputLocationItem GsJabuJabuNearBoss { get; set; }

        [JsonProperty("Forest Temple First Chest")]
        public OOTInputLocationItem ForestTempleFirstChest { get; set; }

        [JsonProperty("Forest Temple Chest Behind Lobby")]
        public OOTInputLocationItem ForestTempleChestBehindLobby { get; set; }

        [JsonProperty("GS Forest Temple First Room")]
        public OOTInputLocationItem GsForestTempleFirstRoom { get; set; }

        [JsonProperty("GS Forest Temple Lobby")]
        public OOTInputLocationItem GsForestTempleLobby { get; set; }

        [JsonProperty("GS Forest Temple Outdoor West")]
        public OOTInputLocationItem GsForestTempleOutdoorWest { get; set; }

        [JsonProperty("Forest Temple Outside Hookshot Chest")]
        public OOTInputLocationItem ForestTempleOutsideHookshotChest { get; set; }

        [JsonProperty("GS Forest Temple Outdoor East")]
        public OOTInputLocationItem GsForestTempleOutdoorEast { get; set; }

        [JsonProperty("Forest Temple Well Chest")]
        public OOTInputLocationItem ForestTempleWellChest { get; set; }

        [JsonProperty("Forest Temple Map Chest")]
        public OOTInputLocationItem ForestTempleMapChest { get; set; }

        [JsonProperty("Forest Temple Falling Room Chest")]
        public OOTInputLocationItem ForestTempleFallingRoomChest { get; set; }

        [JsonProperty("Forest Temple Block Push Chest")]
        public OOTInputLocationItem ForestTempleBlockPushChest { get; set; }

        [JsonProperty("Forest Temple Boss Key Chest")]
        public OOTInputLocationItem ForestTempleBossKeyChest { get; set; }

        [JsonProperty("Forest Temple Floormaster Chest")]
        public OOTInputLocationItem ForestTempleFloormasterChest { get; set; }

        [JsonProperty("Forest Temple Bow Chest")]
        public OOTInputLocationItem ForestTempleBowChest { get; set; }

        [JsonProperty("Forest Temple Red Poe Chest")]
        public OOTInputLocationItem ForestTempleRedPoeChest { get; set; }

        [JsonProperty("Forest Temple Blue Poe Chest")]
        public OOTInputLocationItem ForestTempleBluePoeChest { get; set; }

        [JsonProperty("Forest Temple Near Boss Chest")]
        public OOTInputLocationItem ForestTempleNearBossChest { get; set; }

        [JsonProperty("Phantom Ganon Heart")]
        public OOTInputLocationItem PhantomGanonHeart { get; set; }

        [JsonProperty("GS Forest Temple Basement")]
        public OOTInputLocationItem GsForestTempleBasement { get; set; }

        [JsonProperty("Bottom of the Well Front Left Hidden Wall")]
        public OOTInputLocationItem BottomOfTheWellFrontLeftHiddenWall { get; set; }

        [JsonProperty("Bottom of the Well Front Center Bombable")]
        public OOTInputLocationItem BottomOfTheWellFrontCenterBombable { get; set; }

        [JsonProperty("Bottom of the Well Right Bottom Hidden Wall")]
        public OOTInputLocationItem BottomOfTheWellRightBottomHiddenWall { get; set; }

        [JsonProperty("Bottom of the Well Center Large Chest")]
        public OOTInputLocationItem BottomOfTheWellCenterLargeChest { get; set; }

        [JsonProperty("Bottom of the Well Center Small Chest")]
        public OOTInputLocationItem BottomOfTheWellCenterSmallChest { get; set; }

        [JsonProperty("Bottom of the Well Back Left Bombable")]
        public OOTInputLocationItem BottomOfTheWellBackLeftBombable { get; set; }

        [JsonProperty("Bottom of the Well Freestanding Key")]
        public OOTInputLocationItem BottomOfTheWellFreestandingKey { get; set; }

        [JsonProperty("Bottom of the Well Defeat Boss")]
        public OOTInputLocationItem BottomOfTheWellDefeatBoss { get; set; }

        [JsonProperty("Bottom of the Well Invisible Chest")]
        public OOTInputLocationItem BottomOfTheWellInvisibleChest { get; set; }

        [JsonProperty("Bottom of the Well Underwater Front Chest")]
        public OOTInputLocationItem BottomOfTheWellUnderwaterFrontChest { get; set; }

        [JsonProperty("Bottom of the Well Underwater Left Chest")]
        public OOTInputLocationItem BottomOfTheWellUnderwaterLeftChest { get; set; }

        [JsonProperty("Bottom of the Well Basement Chest")]
        public OOTInputLocationItem BottomOfTheWellBasementChest { get; set; }

        [JsonProperty("Bottom of the Well Locked Pits")]
        public OOTInputLocationItem BottomOfTheWellLockedPits { get; set; }

        [JsonProperty("Bottom of the Well Behind Right Grate")]
        public OOTInputLocationItem BottomOfTheWellBehindRightGrate { get; set; }

        [JsonProperty("GS Well West Inner Room")]
        public OOTInputLocationItem GsWellWestInnerRoom { get; set; }

        [JsonProperty("GS Well East Inner Room")]
        public OOTInputLocationItem GsWellEastInnerRoom { get; set; }

        [JsonProperty("GS Well Like Like Cage")]
        public OOTInputLocationItem GsWellLikeLikeCage { get; set; }

        [JsonProperty("Fire Temple Chest Near Boss")]
        public OOTInputLocationItem FireTempleChestNearBoss { get; set; }

        [JsonProperty("Fire Temple Fire Dancer Chest")]
        public OOTInputLocationItem FireTempleFireDancerChest { get; set; }

        [JsonProperty("Fire Temple Boss Key Chest")]
        public OOTInputLocationItem FireTempleBossKeyChest { get; set; }

        [JsonProperty("Volvagia Heart")]
        public OOTInputLocationItem VolvagiaHeart { get; set; }

        [JsonProperty("GS Fire Temple Basement")]
        public OOTInputLocationItem GsFireTempleBasement { get; set; }

        [JsonProperty("Fire Temple Big Lava Room Open Chest")]
        public OOTInputLocationItem FireTempleBigLavaRoomOpenChest { get; set; }

        [JsonProperty("Fire Temple Big Lava Room Bombable Chest")]
        public OOTInputLocationItem FireTempleBigLavaRoomBombableChest { get; set; }

        [JsonProperty("GS Fire Temple Song of Time Room")]
        public OOTInputLocationItem GsFireTempleSongOfTimeRoom { get; set; }

        [JsonProperty("Fire Temple Boulder Maze Lower Chest")]
        public OOTInputLocationItem FireTempleBoulderMazeLowerChest { get; set; }

        [JsonProperty("Fire Temple Boulder Maze Upper Chest")]
        public OOTInputLocationItem FireTempleBoulderMazeUpperChest { get; set; }

        [JsonProperty("Fire Temple Boulder Maze Side Room")]
        public OOTInputLocationItem FireTempleBoulderMazeSideRoom { get; set; }

        [JsonProperty("Fire Temple Boulder Maze Bombable Pit")]
        public OOTInputLocationItem FireTempleBoulderMazeBombablePit { get; set; }

        [JsonProperty("Fire Temple Scarecrow Chest")]
        public OOTInputLocationItem FireTempleScarecrowChest { get; set; }

        [JsonProperty("Fire Temple Map Chest")]
        public OOTInputLocationItem FireTempleMapChest { get; set; }

        [JsonProperty("Fire Temple Compass Chest")]
        public OOTInputLocationItem FireTempleCompassChest { get; set; }

        [JsonProperty("GS Fire Temple Unmarked Bomb Wall")]
        public OOTInputLocationItem GsFireTempleUnmarkedBombWall { get; set; }

        [JsonProperty("GS Fire Temple East Tower Climb")]
        public OOTInputLocationItem GsFireTempleEastTowerClimb { get; set; }

        [JsonProperty("GS Fire Temple East Tower Top")]
        public OOTInputLocationItem GsFireTempleEastTowerTop { get; set; }

        [JsonProperty("Fire Temple Highest Goron Chest")]
        public OOTInputLocationItem FireTempleHighestGoronChest { get; set; }

        [JsonProperty("Fire Temple Megaton Hammer Chest")]
        public OOTInputLocationItem FireTempleMegatonHammerChest { get; set; }

        [JsonProperty("Ice Cavern Map Chest")]
        public OOTInputLocationItem IceCavernMapChest { get; set; }

        [JsonProperty("Ice Cavern Compass Chest")]
        public OOTInputLocationItem IceCavernCompassChest { get; set; }

        [JsonProperty("Ice Cavern Iron Boots Chest")]
        public OOTInputLocationItem IceCavernIronBootsChest { get; set; }

        [JsonProperty("Ice Cavern Freestanding PoH")]
        public OOTInputLocationItem IceCavernFreestandingPoH { get; set; }

        [JsonProperty("GS Ice Cavern Spinning Scythe Room")]
        public OOTInputLocationItem GsIceCavernSpinningScytheRoom { get; set; }

        [JsonProperty("GS Ice Cavern Heart Piece Room")]
        public OOTInputLocationItem GsIceCavernHeartPieceRoom { get; set; }

        [JsonProperty("GS Ice Cavern Push Block Room")]
        public OOTInputLocationItem GsIceCavernPushBlockRoom { get; set; }

        [JsonProperty("Morpha Heart")]
        public OOTInputLocationItem MorphaHeart { get; set; }

        [JsonProperty("Water Temple Map Chest")]
        public OOTInputLocationItem WaterTempleMapChest { get; set; }

        [JsonProperty("Water Temple Compass Chest")]
        public OOTInputLocationItem WaterTempleCompassChest { get; set; }

        [JsonProperty("Water Temple Torches Chest")]
        public OOTInputLocationItem WaterTempleTorchesChest { get; set; }

        [JsonProperty("Water Temple Central Bow Target Chest")]
        public OOTInputLocationItem WaterTempleCentralBowTargetChest { get; set; }

        [JsonProperty("GS Water Temple South Basement")]
        public OOTInputLocationItem GsWaterTempleSouthBasement { get; set; }

        [JsonProperty("Water Temple Boss Key Chest")]
        public OOTInputLocationItem WaterTempleBossKeyChest { get; set; }

        [JsonProperty("GS Water Temple Near Boss Key Chest")]
        public OOTInputLocationItem GsWaterTempleNearBossKeyChest { get; set; }

        [JsonProperty("Water Temple Cracked Wall Chest")]
        public OOTInputLocationItem WaterTempleCrackedWallChest { get; set; }

        [JsonProperty("Water Temple Dragon Chest")]
        public OOTInputLocationItem WaterTempleDragonChest { get; set; }

        [JsonProperty("Water Temple Central Pillar Chest")]
        public OOTInputLocationItem WaterTempleCentralPillarChest { get; set; }

        [JsonProperty("GS Water Temple Central Room")]
        public OOTInputLocationItem GsWaterTempleCentralRoom { get; set; }

        [JsonProperty("Water Temple Dark Link Chest")]
        public OOTInputLocationItem WaterTempleDarkLinkChest { get; set; }

        [JsonProperty("Water Temple River Chest")]
        public OOTInputLocationItem WaterTempleRiverChest { get; set; }

        [JsonProperty("GS Water Temple Serpent River")]
        public OOTInputLocationItem GsWaterTempleSerpentRiver { get; set; }

        [JsonProperty("GS Water Temple Falling Platform Room")]
        public OOTInputLocationItem GsWaterTempleFallingPlatformRoom { get; set; }

        [JsonProperty("Shadow Temple Map Chest")]
        public OOTInputLocationItem ShadowTempleMapChest { get; set; }

        [JsonProperty("Shadow Temple Hover Boots Chest")]
        public OOTInputLocationItem ShadowTempleHoverBootsChest { get; set; }

        [JsonProperty("Shadow Temple Compass Chest")]
        public OOTInputLocationItem ShadowTempleCompassChest { get; set; }

        [JsonProperty("Shadow Temple Early Silver Rupee Chest")]
        public OOTInputLocationItem ShadowTempleEarlySilverRupeeChest { get; set; }

        [JsonProperty("Shadow Temple Invisible Blades Visible Chest")]
        public OOTInputLocationItem ShadowTempleInvisibleBladesVisibleChest { get; set; }

        [JsonProperty("Shadow Temple Invisible Blades Invisible Chest")]
        public OOTInputLocationItem ShadowTempleInvisibleBladesInvisibleChest { get; set; }

        [JsonProperty("Shadow Temple Falling Spikes Lower Chest")]
        public OOTInputLocationItem ShadowTempleFallingSpikesLowerChest { get; set; }

        [JsonProperty("Shadow Temple Falling Spikes Upper Chest")]
        public OOTInputLocationItem ShadowTempleFallingSpikesUpperChest { get; set; }

        [JsonProperty("Shadow Temple Falling Spikes Switch Chest")]
        public OOTInputLocationItem ShadowTempleFallingSpikesSwitchChest { get; set; }

        [JsonProperty("Shadow Temple Invisible Spikes Chest")]
        public OOTInputLocationItem ShadowTempleInvisibleSpikesChest { get; set; }

        [JsonProperty("Shadow Temple Freestanding Key")]
        public OOTInputLocationItem ShadowTempleFreestandingKey { get; set; }

        [JsonProperty("GS Shadow Temple Like Like Room")]
        public OOTInputLocationItem GsShadowTempleLikeLikeRoom { get; set; }

        [JsonProperty("GS Shadow Temple Crusher Room")]
        public OOTInputLocationItem GsShadowTempleCrusherRoom { get; set; }

        [JsonProperty("GS Shadow Temple Single Giant Pot")]
        public OOTInputLocationItem GsShadowTempleSingleGiantPot { get; set; }

        [JsonProperty("Shadow Temple Wind Hint Chest")]
        public OOTInputLocationItem ShadowTempleWindHintChest { get; set; }

        [JsonProperty("Shadow Temple After Wind Enemy Chest")]
        public OOTInputLocationItem ShadowTempleAfterWindEnemyChest { get; set; }

        [JsonProperty("Shadow Temple After Wind Hidden Chest")]
        public OOTInputLocationItem ShadowTempleAfterWindHiddenChest { get; set; }

        [JsonProperty("GS Shadow Temple Near Ship")]
        public OOTInputLocationItem GsShadowTempleNearShip { get; set; }

        [JsonProperty("Shadow Temple Spike Walls Left Chest")]
        public OOTInputLocationItem ShadowTempleSpikeWallsLeftChest { get; set; }

        [JsonProperty("Shadow Temple Boss Key Chest")]
        public OOTInputLocationItem ShadowTempleBossKeyChest { get; set; }

        [JsonProperty("Shadow Temple Hidden Floormaster Chest")]
        public OOTInputLocationItem ShadowTempleHiddenFloormasterChest { get; set; }

        [JsonProperty("Bongo Bongo Heart")]
        public OOTInputLocationItem BongoBongoHeart { get; set; }

        [JsonProperty("GS Shadow Temple Triple Giant Pot")]
        public OOTInputLocationItem GsShadowTempleTripleGiantPot { get; set; }

        [JsonProperty("Gerudo Training Grounds Lobby Left Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsLobbyLeftChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Lobby Right Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsLobbyRightChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Stalfos Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsStalfosChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Beamos Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsBeamosChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Hidden Ceiling Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsHiddenCeilingChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Maze Path First Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsMazePathFirstChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Maze Path Second Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsMazePathSecondChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Maze Path Third Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsMazePathThirdChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Maze Path Final Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsMazePathFinalChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Maze Right Central Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsMazeRightCentralChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Maze Right Side Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsMazeRightSideChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Freestanding Key")]
        public OOTInputLocationItem GerudoTrainingGroundsFreestandingKey { get; set; }

        [JsonProperty("Gerudo Training Grounds Underwater Silver Rupee Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsUnderwaterSilverRupeeChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Hammer Room Clear Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsHammerRoomClearChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Hammer Room Switch Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsHammerRoomSwitchChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Eye Statue Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsEyeStatueChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Near Scarecrow Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsNearScarecrowChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Before Heavy Block Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsBeforeHeavyBlockChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Heavy Block First Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsHeavyBlockFirstChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Heavy Block Second Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsHeavyBlockSecondChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Heavy Block Third Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsHeavyBlockThirdChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Heavy Block Fourth Chest")]
        public OOTInputLocationItem GerudoTrainingGroundsHeavyBlockFourthChest { get; set; }

        [JsonProperty("Spirit Temple Child Left Chest")]
        public OOTInputLocationItem SpiritTempleChildLeftChest { get; set; }

        [JsonProperty("Spirit Temple Child Right Chest")]
        public OOTInputLocationItem SpiritTempleChildRightChest { get; set; }

        [JsonProperty("GS Spirit Temple Metal Fence")]
        public OOTInputLocationItem GsSpiritTempleMetalFence { get; set; }

        [JsonProperty("Spirit Temple Child Climb East Chest")]
        public OOTInputLocationItem SpiritTempleChildClimbEastChest { get; set; }

        [JsonProperty("Spirit Temple Child Climb North Chest")]
        public OOTInputLocationItem SpiritTempleChildClimbNorthChest { get; set; }

        [JsonProperty("GS Spirit Temple Bomb for Light Room")]
        public OOTInputLocationItem GsSpiritTempleBombForLightRoom { get; set; }

        [JsonProperty("Spirit Temple Compass Chest")]
        public OOTInputLocationItem SpiritTempleCompassChest { get; set; }

        [JsonProperty("Spirit Temple Early Adult Right Chest")]
        public OOTInputLocationItem SpiritTempleEarlyAdultRightChest { get; set; }

        [JsonProperty("Spirit Temple First Mirror Right Chest")]
        public OOTInputLocationItem SpiritTempleFirstMirrorRightChest { get; set; }

        [JsonProperty("Spirit Temple First Mirror Left Chest")]
        public OOTInputLocationItem SpiritTempleFirstMirrorLeftChest { get; set; }

        [JsonProperty("GS Spirit Temple Boulder Room")]
        public OOTInputLocationItem GsSpiritTempleBoulderRoom { get; set; }

        [JsonProperty("Spirit Temple Map Chest")]
        public OOTInputLocationItem SpiritTempleMapChest { get; set; }

        [JsonProperty("Spirit Temple Sun Block Room Chest")]
        public OOTInputLocationItem SpiritTempleSunBlockRoomChest { get; set; }

        [JsonProperty("Spirit Temple Statue Hand Chest")]
        public OOTInputLocationItem SpiritTempleStatueHandChest { get; set; }

        [JsonProperty("Spirit Temple NE Main Room Chest")]
        public OOTInputLocationItem SpiritTempleNeMainRoomChest { get; set; }

        [JsonProperty("GS Spirit Temple Hall to West Iron Knuckle")]
        public OOTInputLocationItem GsSpiritTempleHallToWestIronKnuckle { get; set; }

        [JsonProperty("GS Spirit Temple Lobby")]
        public OOTInputLocationItem GsSpiritTempleLobby { get; set; }

        [JsonProperty("Silver Gauntlets Chest")]
        public OOTInputLocationItem SilverGauntletsChest { get; set; }

        [JsonProperty("Mirror Shield Chest")]
        public OOTInputLocationItem MirrorShieldChest { get; set; }

        [JsonProperty("Spirit Temple Near Four Armos Chest")]
        public OOTInputLocationItem SpiritTempleNearFourArmosChest { get; set; }

        [JsonProperty("Spirit Temple Hallway Left Invisible Chest")]
        public OOTInputLocationItem SpiritTempleHallwayLeftInvisibleChest { get; set; }

        [JsonProperty("Spirit Temple Hallway Right Invisible Chest")]
        public OOTInputLocationItem SpiritTempleHallwayRightInvisibleChest { get; set; }

        [JsonProperty("Spirit Temple Boss Key Chest")]
        public OOTInputLocationItem SpiritTempleBossKeyChest { get; set; }

        [JsonProperty("Spirit Temple Topmost Chest")]
        public OOTInputLocationItem SpiritTempleTopmostChest { get; set; }

        [JsonProperty("Twinrova Heart")]
        public OOTInputLocationItem TwinrovaHeart { get; set; }

        [JsonProperty("Ganons Castle Forest Trial Chest")]
        public OOTInputLocationItem GanonsCastleForestTrialChest { get; set; }

        [JsonProperty("Ganons Castle Water Trial Left Chest")]
        public OOTInputLocationItem GanonsCastleWaterTrialLeftChest { get; set; }

        [JsonProperty("Ganons Castle Water Trial Right Chest")]
        public OOTInputLocationItem GanonsCastleWaterTrialRightChest { get; set; }

        [JsonProperty("Ganons Castle Shadow Trial First Chest")]
        public OOTInputLocationItem GanonsCastleShadowTrialFirstChest { get; set; }

        [JsonProperty("Ganons Castle Shadow Trial Second Chest")]
        public OOTInputLocationItem GanonsCastleShadowTrialSecondChest { get; set; }

        [JsonProperty("Ganons Castle Spirit Trial First Chest")]
        public OOTInputLocationItem GanonsCastleSpiritTrialFirstChest { get; set; }

        [JsonProperty("Ganons Castle Spirit Trial Second Chest")]
        public OOTInputLocationItem GanonsCastleSpiritTrialSecondChest { get; set; }

        [JsonProperty("Ganons Castle Light Trial First Left Chest")]
        public OOTInputLocationItem GanonsCastleLightTrialFirstLeftChest { get; set; }

        [JsonProperty("Ganons Castle Light Trial Second Left Chest")]
        public OOTInputLocationItem GanonsCastleLightTrialSecondLeftChest { get; set; }

        [JsonProperty("Ganons Castle Light Trial Third Left Chest")]
        public OOTInputLocationItem GanonsCastleLightTrialThirdLeftChest { get; set; }

        [JsonProperty("Ganons Castle Light Trial First Right Chest")]
        public OOTInputLocationItem GanonsCastleLightTrialFirstRightChest { get; set; }

        [JsonProperty("Ganons Castle Light Trial Second Right Chest")]
        public OOTInputLocationItem GanonsCastleLightTrialSecondRightChest { get; set; }

        [JsonProperty("Ganons Castle Light Trial Third Right Chest")]
        public OOTInputLocationItem GanonsCastleLightTrialThirdRightChest { get; set; }

        [JsonProperty("Ganons Castle Light Trial Invisible Enemies Chest")]
        public OOTInputLocationItem GanonsCastleLightTrialInvisibleEnemiesChest { get; set; }

        [JsonProperty("Ganons Castle Light Trial Lullaby Chest")]
        public OOTInputLocationItem GanonsCastleLightTrialLullabyChest { get; set; }
    }

    public partial class RandomizedSettings
    {
        [JsonProperty("starting_age")]
        public string StartingAge { get; set; }

        [JsonProperty("triforce_hunt")]
        public bool TriforceHunt { get; set; }

        [JsonProperty("triforce_goal_per_world")]
        public long TriforceGoalPerWorld { get; set; }

        [JsonProperty("entrance_shuffle")]
        public string EntranceShuffle { get; set; }

        [JsonProperty("bombchus_in_logic")]
        public bool BombchusInLogic { get; set; }

        [JsonProperty("one_item_per_dungeon")]
        public bool OneItemPerDungeon { get; set; }

        [JsonProperty("open_forest")]
        public string OpenForest { get; set; }

        [JsonProperty("open_door_of_time")]
        public bool OpenDoorOfTime { get; set; }

        [JsonProperty("zora_fountain")]
        public string ZoraFountain { get; set; }

        [JsonProperty("gerudo_fortress")]
        public string GerudoFortress { get; set; }

        [JsonProperty("bridge")]
        public string Bridge { get; set; }

        [JsonProperty("bridge_tokens")]
        public long BridgeTokens { get; set; }

        [JsonProperty("trials_random")]
        public bool TrialsRandom { get; set; }

        [JsonProperty("trials")]
        public long Trials { get; set; }

        [JsonProperty("shopsanity")]
        public string Shopsanity { get; set; }

        [JsonProperty("tokensanity")]
        public string Tokensanity { get; set; }

        [JsonProperty("shuffle_scrubs")]
        public string ShuffleScrubs { get; set; }

        [JsonProperty("shuffle_cows")]
        public bool ShuffleCows { get; set; }

        [JsonProperty("shuffle_song_items")]
        public bool ShuffleSongItems { get; set; }

        [JsonProperty("shuffle_kokiri_sword")]
        public bool ShuffleKokiriSword { get; set; }

        [JsonProperty("shuffle_ocarinas")]
        public bool ShuffleOcarinas { get; set; }

        [JsonProperty("shuffle_weird_egg")]
        public bool ShuffleWeirdEgg { get; set; }

        [JsonProperty("shuffle_gerudo_card")]
        public bool ShuffleGerudoCard { get; set; }

        [JsonProperty("shuffle_beans")]
        public bool ShuffleBeans { get; set; }

        [JsonProperty("shuffle_mapcompass")]
        public string ShuffleMapcompass { get; set; }

        [JsonProperty("shuffle_smallkeys")]
        public string ShuffleSmallkeys { get; set; }

        [JsonProperty("shuffle_bosskeys")]
        public string ShuffleBosskeys { get; set; }

        [JsonProperty("shuffle_ganon_bosskey")]
        public string ShuffleGanonBosskey { get; set; }

        [JsonProperty("enhance_map_compass")]
        public bool EnhanceMapCompass { get; set; }
    }

    public partial class Settings
    {
        [JsonProperty("world_count")]
        public long WorldCount { get; set; }

        [JsonProperty("create_spoiler")]
        public bool CreateSpoiler { get; set; }

        [JsonProperty("randomize_settings")]
        public bool RandomizeSettings { get; set; }

        [JsonProperty("logic_rules")]
        public string LogicRules { get; set; }

        [JsonProperty("all_reachable")]
        public bool AllReachable { get; set; }

        [JsonProperty("no_escape_sequence")]
        public bool NoEscapeSequence { get; set; }

        [JsonProperty("no_guard_stealth")]
        public bool NoGuardStealth { get; set; }

        [JsonProperty("no_epona_race")]
        public bool NoEponaRace { get; set; }

        [JsonProperty("no_first_dampe_race")]
        public bool NoFirstDampeRace { get; set; }

        [JsonProperty("useful_cutscenes")]
        public bool UsefulCutscenes { get; set; }

        [JsonProperty("fast_chests")]
        public bool FastChests { get; set; }

        [JsonProperty("logic_no_night_tokens_without_suns_song")]
        public bool LogicNoNightTokensWithoutSunsSong { get; set; }

        [JsonProperty("free_scarecrow")]
        public bool FreeScarecrow { get; set; }

        [JsonProperty("start_with_rupees")]
        public bool StartWithRupees { get; set; }

        [JsonProperty("start_with_consumables")]
        public bool StartWithConsumables { get; set; }

        [JsonProperty("starting_hearts")]
        public long StartingHearts { get; set; }

        [JsonProperty("chicken_count_random")]
        public bool ChickenCountRandom { get; set; }

        [JsonProperty("chicken_count")]
        public long ChickenCount { get; set; }

        [JsonProperty("big_poe_count_random")]
        public bool BigPoeCountRandom { get; set; }

        [JsonProperty("big_poe_count")]
        public long BigPoeCount { get; set; }

        [JsonProperty("mq_dungeons_random")]
        public bool MqDungeonsRandom { get; set; }

        [JsonProperty("mq_dungeons")]
        public long MqDungeons { get; set; }

        [JsonProperty("disabled_locations")]
        public object[] DisabledLocations { get; set; }

        [JsonProperty("allowed_tricks")]
        public object[] AllowedTricks { get; set; }

        [JsonProperty("logic_earliest_adult_trade")]
        public string LogicEarliestAdultTrade { get; set; }

        [JsonProperty("logic_latest_adult_trade")]
        public string LogicLatestAdultTrade { get; set; }

        [JsonProperty("logic_lens")]
        public string LogicLens { get; set; }

        [JsonProperty("starting_equipment")]
        public object[] StartingEquipment { get; set; }

        [JsonProperty("starting_items")]
        public object[] StartingItems { get; set; }

        [JsonProperty("starting_songs")]
        public object[] StartingSongs { get; set; }

        [JsonProperty("ocarina_songs")]
        public bool OcarinaSongs { get; set; }

        [JsonProperty("correct_chest_sizes")]
        public bool CorrectChestSizes { get; set; }

        [JsonProperty("clearer_hints")]
        public bool ClearerHints { get; set; }

        [JsonProperty("hints")]
        public string Hints { get; set; }

        [JsonProperty("hint_dist")]
        public string HintDist { get; set; }

        [JsonProperty("text_shuffle")]
        public string TextShuffle { get; set; }

        [JsonProperty("ice_trap_appearance")]
        public string IceTrapAppearance { get; set; }

        [JsonProperty("junk_ice_traps")]
        public string JunkIceTraps { get; set; }

        [JsonProperty("item_pool_value")]
        public string ItemPoolValue { get; set; }

        [JsonProperty("damage_multiplier")]
        public string DamageMultiplier { get; set; }

        [JsonProperty("starting_tod")]
        public string StartingTod { get; set; }
    }

    public partial class Trials
    {
        [JsonProperty("Forest")]
        public string Forest { get; set; }

        [JsonProperty("Fire")]
        public string Fire { get; set; }

        [JsonProperty("Water")]
        public string Water { get; set; }

        [JsonProperty("Spirit")]
        public string Spirit { get; set; }

        [JsonProperty("Shadow")]
        public string Shadow { get; set; }

        [JsonProperty("Light")]
        public string Light { get; set; }
    }

    public partial class WothLocations
    {
        [JsonProperty("Sheik at Colossus")]
        public string SheikAtColossus { get; set; }

        [JsonProperty("LW Grotto Deku Scrub Deku Nut Upgrade")]
        public OOTInputLocationItem LwGrottoDekuScrubDekuNutUpgrade { get; set; }

        [JsonProperty("Forest Temple Chest Behind Lobby")]
        public string ForestTempleChestBehindLobby { get; set; }

        [JsonProperty("Bombchu Bowling Piece of Heart")]
        public string BombchuBowlingPieceOfHeart { get; set; }

        [JsonProperty("GS Mountain Trail Bomb Alcove")]
        public string GsMountainTrailBombAlcove { get; set; }

        [JsonProperty("Field Near Lake Outside Fence Grotto Chest")]
        public string FieldNearLakeOutsideFenceGrottoChest { get; set; }

        [JsonProperty("Malon Egg")]
        public string MalonEgg { get; set; }

        [JsonProperty("Magic Bean Salesman")]
        public string MagicBeanSalesman { get; set; }

        [JsonProperty("Zoras Domain Torch Run")]
        public string ZorasDomainTorchRun { get; set; }

        [JsonProperty("Lon Lon Tower Freestanding PoH")]
        public string LonLonTowerFreestandingPoH { get; set; }

        [JsonProperty("Redead Grotto Chest")]
        public string RedeadGrottoChest { get; set; }

        [JsonProperty("GS Gerudo Valley Bean Patch")]
        public string GsGerudoValleyBeanPatch { get; set; }

        [JsonProperty("Sheik in Crater")]
        public string SheikInCrater { get; set; }

        [JsonProperty("Dodongos Cavern Compass Chest")]
        public string DodongosCavernCompassChest { get; set; }

        [JsonProperty("Forest Temple Floormaster Chest")]
        public string ForestTempleFloormasterChest { get; set; }

        [JsonProperty("Gerudo Training Grounds Maze Right Side Chest")]
        public string GerudoTrainingGroundsMazeRightSideChest { get; set; }

        [JsonProperty("Colossus Freestanding PoH")]
        public string ColossusFreestandingPoH { get; set; }

        [JsonProperty("Talons Chickens")]
        public string TalonsChickens { get; set; }

        [JsonProperty("GS Hyrule Field near Kakariko")]
        public string GsHyruleFieldNearKakariko { get; set; }

        [JsonProperty("Deku Tree Slingshot Room Side Chest")]
        public string DekuTreeSlingshotRoomSideChest { get; set; }

        [JsonProperty("GS Kokiri House of Twins")]
        public string GsKokiriHouseOfTwins { get; set; }

        [JsonProperty("Man on Roof")]
        public string ManOnRoof { get; set; }

        [JsonProperty("Chest Above King Dodongo")]
        public string ChestAboveKingDodongo { get; set; }

        [JsonProperty("Gerudo Training Grounds Hammer Room Clear Chest")]
        public string GerudoTrainingGroundsHammerRoomClearChest { get; set; }

        [JsonProperty("GS Gerudo Valley Small Bridge")]
        public string GsGerudoValleySmallBridge { get; set; }

        [JsonProperty("Mountain Summit Fairy Reward")]
        public string MountainSummitFairyReward { get; set; }

        [JsonProperty("GS Zora's Fountain Above the Log")]
        public string GsZoraSFountainAboveTheLog { get; set; }

        [JsonProperty("Shadow Temple Invisible Blades Visible Chest")]
        public string ShadowTempleInvisibleBladesVisibleChest { get; set; }

        [JsonProperty("Shadow Temple Invisible Spikes Chest")]
        public string ShadowTempleInvisibleSpikesChest { get; set; }

        [JsonProperty("GS Shadow Temple Near Ship")]
        public string GsShadowTempleNearShip { get; set; }

        [JsonProperty("Gerudo Training Grounds Heavy Block First Chest")]
        public string GerudoTrainingGroundsHeavyBlockFirstChest { get; set; }

        [JsonProperty("Horseback Archery 1500 Points")]
        public string HorsebackArchery1500Points { get; set; }

        [JsonProperty("Spirit Temple Map Chest")]
        public string SpiritTempleMapChest { get; set; }

        [JsonProperty("Field West Castle Town Grotto Chest")]
        public string FieldWestCastleTownGrottoChest { get; set; }

        [JsonProperty("Forest Temple Near Boss Chest")]
        public string ForestTempleNearBossChest { get; set; }

        [JsonProperty("Sheik in Ice Cavern")]
        public string SheikInIceCavern { get; set; }
    }


    public partial class Entrance
    {
        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }
    }

    public partial class GossipStone
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }
    }


    [JsonConverter(typeof(OOTInputLocationItemConverter))]
    public partial class OOTInputLocationItem
    {
        [JsonProperty("item")]
        public string Item { get; set; }
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public long Price { get; set; }
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }
    }

    public class OOTInputLocationItemConverter : JsonConverter<OOTInputLocationItem>
    {
        public override OOTInputLocationItem ReadJson(JsonReader reader, Type objectType, OOTInputLocationItem existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            OOTInputLocationItem item = new OOTInputLocationItem();
            if (reader.TokenType != JsonToken.Null)
            {
                if (reader.TokenType == JsonToken.StartObject)
                {
                    reader.Read(); //read the next line.
                    while (reader.TokenType != JsonToken.EndObject)
                    {
                        if (reader.TokenType == JsonToken.PropertyName)
                        {
                            string propertyName = (string)new JValue(reader.Value);
                            reader.Read();
                            switch (propertyName)
                            {
                                case "item":
                                    item.Item = (string)new JValue(reader.Value);
                                    break;
                                case "model":
                                    item.Model = (string)new JValue(reader.Value);
                                    break;
                                case "price":
                                    item.Price = (long)new JValue(reader.Value);
                                    break;
                                default:
                                    Console.WriteLine("Default case");
                                    Console.WriteLine(reader.TokenType.ToString());
                                    break;
                            }
                            reader.Read();
                        }
                    }
                }
                else
                {
                    JValue jValue = new JValue(reader.Value);
                    switch (reader.TokenType)
                    {
                        case JsonToken.String:
                            item.Item = (string)jValue;
                            break;
                        default:
                            Console.WriteLine("Default case");
                            Console.WriteLine(reader.TokenType.ToString());
                            break;
                    }
                }
            }
            return item;
        }

        public override void WriteJson(JsonWriter writer, OOTInputLocationItem value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}

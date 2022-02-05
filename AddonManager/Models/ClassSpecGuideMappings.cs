﻿namespace AddonManager.Models;
public class ClassGuideMapping
{
    public ClassGuideMapping(string fileName, string specName, string className, List<GuideMapping> guideMappings)
    {
        FileName = fileName; 
        SpecName = specName;
        ClassName = className;
        GuideMappings = guideMappings;
    }

    public string FileName { get; set; }
    public string SpecName { get; set; }
    public string ClassName { get; set; }
    public List<GuideMapping> GuideMappings { get; set; }
}

public class GuideMapping
{
    public GuideMapping(string slotHtmlId, string slot)
    {
        SlotHtmlId = slotHtmlId;
        Slot = slot;
    }
    public string SlotHtmlId { get; }
    public string Slot { get; }
}

public class ClassSpecGuideMappings
{
    public List<ClassGuideMapping> GuideMappings { get; set; }
    public ClassSpecGuideMappings()
    {
        GuideMappings = new List<ClassGuideMapping>();

        GuideMappings.Add(new ClassGuideMapping("DruidBalance", "Balance", "Druid", new List<GuideMapping> 
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#1-handed-weapons", "MH"),
            new GuideMapping("#2-handed-weapons", "2H"),
            new GuideMapping("#offhands", "OH"),
            new GuideMapping("#idols", "Idol")
        }));

        GuideMappings.Add(new ClassGuideMapping("DruidCat", "Cat", "Druid", new List<GuideMapping> 
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#weapons", "2H"),
            new GuideMapping("#idols", "Idol")
        }));

        GuideMappings.Add(new ClassGuideMapping("DruidBear", "Bear", "Druid", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#weapons", "2H"),
            new GuideMapping("#idols", "Idol")
        }));

        GuideMappings.Add(new ClassGuideMapping("DruidRestoration", "Resto", "Druid", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#1-handed-weapons", "MH"),
            new GuideMapping("#2-handed-weapons", "2H"),
            new GuideMapping("#offhands", "OH"),
            new GuideMapping("#idols", "Idol")
        }));

        GuideMappings.Add(new ClassGuideMapping("Hunter", "", "Hunter", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#main-hand", "MH"),
            new GuideMapping("#offhand", "OH"),
            new GuideMapping("#two-handed", "2H"),
            new GuideMapping("#ranged-weapon", "Ranged")
        }));

        GuideMappings.Add(new ClassGuideMapping("Mage", "", "Mage", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#1-handed-weapons", "MH"),
            new GuideMapping("#2-handed-weapons", "2H"),
            new GuideMapping("#offhands", "OH"),
            new GuideMapping("#wands", "Wand")
        }));

        GuideMappings.Add(new ClassGuideMapping("PaladinHoly", "Holy", "Paladin", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#1-handed-weapons", "MH"),
            new GuideMapping("#offhands-and-shields", "OH"),
            new GuideMapping("#librams", "Libram")
        }));

        GuideMappings.Add(new ClassGuideMapping("PaladinProtection", "Prot", "Paladin", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#1-handed-weapons", "MH"),
            new GuideMapping("#librams", "Libram"),
            new GuideMapping("#shields", "Shield")
        }));

        GuideMappings.Add(new ClassGuideMapping("PaladinRetribution", "Ret", "Paladin", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#2-handed-weapons", "2H"),
            new GuideMapping("#librams", "Libram")
        }));

        GuideMappings.Add(new ClassGuideMapping("PriestHoly", "Holy", "Priest", new List<GuideMapping>
        {        
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#main-and-two-handed", "MH"),
            new GuideMapping("#off-hands", "OH"),
            new GuideMapping("#wands", "Wand")
        }));

        GuideMappings.Add(new ClassGuideMapping("PriestShadow", "Shadow", "Priest", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#main-and-two-handed-weapons", "MH"),
            new GuideMapping("#off-hand", "OH"),
            new GuideMapping("#wands", "Wand")
        }));

        GuideMappings.Add(new ClassGuideMapping("Rogue", "", "Rogue", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#main-hand-weapons", "MH"),
            new GuideMapping("#off-hand-weapons", "OH"),
            new GuideMapping("#guns-and-bows", "Ranged")
        }));

        GuideMappings.Add(new ClassGuideMapping("ShamanElemental", "Elemental", "Shaman", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#weapons", "MH"),
            new GuideMapping("#shields-off-hands", "OH"),
            new GuideMapping("#totems", "Totem")
        }));

        GuideMappings.Add(new ClassGuideMapping("ShamanEnhancement", "Enhance", "Shaman", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#1-handed-weapons", "MH"),
            new GuideMapping("#totems", "Totem")
        }));

        GuideMappings.Add(new ClassGuideMapping("ShamanRestoration", "Resto", "Shaman", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#weapons", "MH"),
            new GuideMapping("#shields-off-hands", "OH"),
            new GuideMapping("#totems", "Totem")
        }));

        GuideMappings.Add(new ClassGuideMapping("Warlock", "", "Warlock", new List<GuideMapping>
        {

            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#1-handed", "MH"),
            new GuideMapping("#2-handed-weapons", "2H"),
            new GuideMapping("#wands", "Wand"),
            new GuideMapping("#offhands", "OH")
        }));

        GuideMappings.Add(new ClassGuideMapping("WarriorDPS", "DPS", "Warrior", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#main-hand-weapons", "MH"),
            new GuideMapping("#off-hand-weapons", "OH"),
            new GuideMapping("#2-handed-weapons", "2H"),
            new GuideMapping("#guns-and-bows", "Ranged"),
        }));

        GuideMappings.Add(new ClassGuideMapping("WarriorProtection", "Prot", "Warrior", new List<GuideMapping>
        {
            new GuideMapping("#head", "Head"),
            new GuideMapping("#shoulders", "Shoulders"),
            new GuideMapping("#back", "Back"),
            new GuideMapping("#chest", "Chest"),
            new GuideMapping("#wrists", "Bracers"),
            new GuideMapping("#hands", "Gloves"),
            new GuideMapping("#waist", "Belt"),
            new GuideMapping("#legs", "Legs"),
            new GuideMapping("#feet", "Feet"),
            new GuideMapping("#neck", "Neck"),
            new GuideMapping("#rings", "Ring"),
            new GuideMapping("#trinkets", "Trinket"),
            new GuideMapping("#1-handed-weapons", "MH"),
            new GuideMapping("#shields", "Shield"),
            new GuideMapping("#guns-and-bows", "Ranged")
        }));
    }
}

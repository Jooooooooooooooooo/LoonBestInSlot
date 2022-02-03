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
    public GuideMapping(int tableIndex, string slot)
    {
        TableIndex = tableIndex;
        Slot = slot;
    }
    public int TableIndex { get; }
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
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "2H"),
            new GuideMapping(15, "OH"),
            new GuideMapping(16, "Idol")
        }));

        GuideMappings.Add(new ClassGuideMapping("DruidCat", "Cat", "Druid", new List<GuideMapping> 
        {
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "2H"),
            new GuideMapping(14, "Idol")
        }));

        GuideMappings.Add(new ClassGuideMapping("DruidBear", "Bear", "Druid", new List<GuideMapping>
        {
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "2H"),
            new GuideMapping(14, "Idol")
        }));

        GuideMappings.Add(new ClassGuideMapping("DruidRestoration", "Resto", "Druid", new List<GuideMapping>
        {
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "2H"),
            new GuideMapping(15, "OH"),
            new GuideMapping(16, "Idol")
        }));

        GuideMappings.Add(new ClassGuideMapping("Hunter", "", "Hunter", new List<GuideMapping>
        {
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "OH"),
            new GuideMapping(15, "2H"),
            new GuideMapping(16, "Ranged")
        }));

        GuideMappings.Add(new ClassGuideMapping("Mage", "", "Mage", new List<GuideMapping>
        {
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "2H"),
            new GuideMapping(15, "OH"),
            new GuideMapping(16, "Wand")
        }));

        GuideMappings.Add(new ClassGuideMapping("PaladinHoly", "Holy", "Paladin", new List<GuideMapping>
        {
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "OH"),
            new GuideMapping(15, "Shield")
        }));

        GuideMappings.Add(new ClassGuideMapping("PaladinProtection", "Prot", "Paladin", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "Libram"),
            new GuideMapping(15, "Shield")
        }));

        GuideMappings.Add(new ClassGuideMapping("PaladinRetribution", "Ret", "Paladin", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "2H"),
            new GuideMapping(14, "Shield")
        }));

        GuideMappings.Add(new ClassGuideMapping("PriestHoly", "Holy", "Priest", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "OH"),
            new GuideMapping(15, "Wand")
        }));

        GuideMappings.Add(new ClassGuideMapping("PriestShadow", "Shadow", "Priest", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "OH"),
            new GuideMapping(15, "Wand")
        }));

        GuideMappings.Add(new ClassGuideMapping("Rogue", "", "Rogue", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "OH"),
            new GuideMapping(15, "Ranged")
        }));

        GuideMappings.Add(new ClassGuideMapping("ShamanElemental", "Elemental", "Shaman", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "OH"),
            new GuideMapping(15, "Totem")
        }));

        GuideMappings.Add(new ClassGuideMapping("ShamanEnhancement", "Enhance", "Shaman", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "Totem")
        }));

        GuideMappings.Add(new ClassGuideMapping("ShamanRestoration", "Resto", "Shaman", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "OH"),
            new GuideMapping(15, "Totem")
        }));

        GuideMappings.Add(new ClassGuideMapping("Warlock", "", "Warlock", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "2H"),
            new GuideMapping(15, "Wand"),
            new GuideMapping(16, "OH")
        }));

        GuideMappings.Add(new ClassGuideMapping("WarriorDPS", "DPS", "Warrior", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "OH"),
            new GuideMapping(15, "2H"),
            new GuideMapping(16, "Ranged"),
        }));

        GuideMappings.Add(new ClassGuideMapping("WarriorProtection", "Prot", "Warrior", new List<GuideMapping>
        {        
            new GuideMapping(1, "Head"),
            new GuideMapping(2, "Shoulders"),
            new GuideMapping(3, "Back"),
            new GuideMapping(4, "Chest"),
            new GuideMapping(5, "Bracers"),
            new GuideMapping(6, "Gloves"),
            new GuideMapping(7, "Belt"),
            new GuideMapping(8, "Legs"),
            new GuideMapping(9, "Feet"),
            new GuideMapping(10, "Neck"),
            new GuideMapping(11, "Ring"),
            new GuideMapping(12, "Trinket"),
            new GuideMapping(13, "MH"),
            new GuideMapping(14, "Shield"),
            new GuideMapping(15, "Ranged")
        }));
    }
}

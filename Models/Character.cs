namespace TerminalHyperspace.Models;

public class Character
{
    public string Name { get; set; } = "";
    public string SpeciesName { get; set; } = "";
    public string RoleName { get; set; } = "";
    public bool IsPlayer { get; set; }

    public Dictionary<AttributeType, DiceCode> Attributes { get; set; } = new();
    public Dictionary<SkillType, DiceCode> SkillBonuses { get; set; } = new();

    public List<Item> Inventory { get; set; } = new();
    public Item? EquippedWeapon { get; set; }
    public Armor EquippedArmor { get; set; } = new();
    public Vehicle? SpaceVehicle { get; set; }
    public Vehicle? LandVehicle { get; set; }
    public bool InVehicle { get; set; }
    public bool InSpaceVehicle { get; set; }

    public int CurrentResolve { get; set; }
    public bool IsDefeated => CurrentResolve <= 0;

    /// Faction standing values. Each tracked faction starts at 0; mission outcomes
    /// nudge the value up or down. The Neutral sentinel never appears here.
    public Dictionary<Faction, int> Standings { get; set; } = new()
    {
        [Faction.Empire]     = 0,
        [Faction.Rebellion]  = 0,
        [Faction.Mandalore]  = 0,
        [Faction.BlackSun]   = 0,
        [Faction.HuttCartel] = 0,
        [Faction.Jedi]       = 0,
    };

    public int GetStanding(Faction f)
        => f != Faction.Neutral && Standings.TryGetValue(f, out var v) ? v : 0;

    public void AdjustStanding(Faction f, int delta)
    {
        if (f == Faction.Neutral) return;
        Standings[f] = GetStanding(f) + delta;
    }

    public DiceCode GetAttribute(AttributeType attr)
        => Attributes.TryGetValue(attr, out var val) ? val : new DiceCode(1);

    public DiceCode GetSkill(SkillType skill)
    {
        var attrCode = GetAttribute(SkillMap.GetAttribute(skill));
        if (SkillBonuses.TryGetValue(skill, out var bonus))
            return attrCode + bonus;
        return attrCode;
    }

    public DiceCode GetBestFor(SkillType skill)
    {
        var attrCode = GetAttribute(SkillMap.GetAttribute(skill));
        var skillCode = GetSkill(skill);
        return skillCode >= attrCode ? skillCode : attrCode;
    }

    public int Defense
    {
        get
        {
            var dex = GetAttribute(AttributeType.Dexterity);
            var agilityPips = SkillBonuses.TryGetValue(SkillType.Agility, out var b) ? b.Dice * 3 + b.Pips : 0;
            return 6 + dex.Dice + agilityPips;
        }
    }

    public int Initiative
    {
        get
        {
            var per = GetAttribute(AttributeType.Perception);
            var tacticsPips = SkillBonuses.TryGetValue(SkillType.Tactics, out var b) ? b.Dice * 3 + b.Pips : 0;
            return 6 + per.Dice + tacticsPips;
        }
    }

    public int Resolve
    {
        get
        {
            var str = GetAttribute(AttributeType.Strength);
            var staminaPips = SkillBonuses.TryGetValue(SkillType.Stamina, out var b) ? b.Dice * 3 + b.Pips : 0;
            return 6 + str.Dice + staminaPips;
        }
    }

    public void InitializeResolve() => CurrentResolve = Resolve;

    public Vehicle? ActiveVehicle => InVehicle ? (InSpaceVehicle ? SpaceVehicle : LandVehicle) : null;
}

namespace TerminalHyperspace.Models;

public class Vehicle
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public bool IsSpace { get; set; }
    public DiceCode Maneuverability { get; set; }
    public int Resolve { get; set; }
    public int CurrentResolve { get; set; }
    public VehicleShield Shield { get; set; } = new();
    public List<VehicleWeapon> Weapons { get; set; } = new();
    public List<VehicleEquipment> Equipment { get; set; } = new();
    public int Price { get; set; }

    public bool IsDestroyed => CurrentResolve <= 0;

    public void InitializeResolve() => CurrentResolve = Resolve;

    public DiceCode GetSkillBonus(SkillType skill)
    {
        var bonus = new DiceCode(0);
        foreach (var eq in Equipment)
            if (eq.BonusSkill == skill)
                bonus = bonus + eq.Bonus;
        return bonus;
    }

    public override string ToString()
        => $"{Name} (Maneuver: {Maneuverability}, Resolve: {Resolve}, Shields: {Shield})";
}

public class VehicleWeapon
{
    public string Name { get; set; } = "";
    public DiceCode Damage { get; set; }
    public SkillType AttackSkill { get; set; } = SkillType.Gunnery;

    public override string ToString() => $"{Name} (Dmg: {Damage})";
}

public class VehicleEquipment
{
    public string Name { get; set; } = "";
    public SkillType BonusSkill { get; set; }
    public DiceCode Bonus { get; set; }

    public override string ToString() => $"{Name} (+{Bonus} {BonusSkill})";
}

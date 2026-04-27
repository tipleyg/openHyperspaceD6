namespace TerminalHyperspace.Models;

/// Galactic factions whose standing the player can raise or lower through
/// mission outcomes. `Neutral` is a sentinel meaning "no standing effect."
public enum Faction
{
    Empire,
    Rebellion,
    Mandalore,
    BlackSun,
    HuttCartel,
    Jedi,
    Neutral
}

public static class FactionData
{
    /// All factions that maintain a standing value (excludes Neutral).
    public static readonly Faction[] Tracked =
    {
        Faction.Empire, Faction.Rebellion, Faction.Mandalore,
        Faction.BlackSun, Faction.HuttCartel, Faction.Jedi
    };

    /// Human-readable display labels.
    public static string Label(Faction f) => f switch
    {
        Faction.Empire     => "Empire",
        Faction.Rebellion  => "Rebellion",
        Faction.Mandalore  => "Mandalore",
        Faction.BlackSun   => "Black Sun",
        Faction.HuttCartel => "Hutt Cartel",
        Faction.Jedi       => "Jedi",
        Faction.Neutral    => "Neutral",
        _                  => f.ToString(),
    };
}

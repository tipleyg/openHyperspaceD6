using TerminalHyperspace.Models;

namespace TerminalHyperspace.Content;

public enum CheckDifficulty { Easy, Moderate, Difficult, Challenging }

public class SkillCheckEvent
{
    public string Id { get; set; } = "";
    public string Description { get; set; } = "";
    public string SuccessText { get; set; } = "";
    public string FailText { get; set; } = "";
    public SkillType Skill { get; set; }
    public CheckDifficulty Difficulty { get; set; }
    public int TargetNumber { get; set; }
    public int CreditReward { get; set; }
    public int UpgradePointReward { get; set; }
    public bool Repeatable { get; set; }
}

public static class SkillCheckData
{
    // --- Location-triggered checks (happen on entry or via 'search') ---

    public static SkillCheckEvent CantinaLockbox => new()
    {
        Id = "cantina_lockbox",
        Description = "You notice a secure lockbox wedged under a cantina booth. Its electronic lock blinks red.",
        SuccessText = "You slice through the encryption with ease. Inside: a credit chip and a data stick.",
        FailText = "The lock flashes angrily and emits a warning tone. You back off before drawing attention.",
        Skill = SkillType.Computers, Difficulty = CheckDifficulty.Moderate,
        TargetNumber = 12, CreditReward = 60, UpgradePointReward = 1,
    };

    public static SkillCheckEvent AlleyBrokenDroid => new()
    {
        Id = "alley_broken_droid",
        Description = "A battered astromech droid lies on its side in the filth, sparking feebly. It beeps a distress call.",
        SuccessText = "You patch the droid's motivator and it whirs back to life. It chirps gratefully and transfers a reward to your account.",
        FailText = "You fumble with the droid's internals and accidentally short out its memory core. It goes silent.",
        Skill = SkillType.Droids, Difficulty = CheckDifficulty.Moderate,
        TargetNumber = 11, CreditReward = 40, UpgradePointReward = 1,
    };

    public static SkillCheckEvent TunnelsPoisonGas => new()
    {
        Id = "tunnels_poison_gas",
        Description = "A ruptured pipe leaks a noxious green gas into the corridor. You'll need to hold your breath and push through.",
        SuccessText = "You power through the toxic cloud, lungs burning but intact. On the other side, you find an abandoned supply cache.",
        FailText = "The gas overwhelms you and you stumble back, coughing and disoriented.",
        Skill = SkillType.Stamina, Difficulty = CheckDifficulty.Moderate,
        TargetNumber = 13, CreditReward = 30, UpgradePointReward = 1,
    };

    public static SkillCheckEvent ReactorOverload => new()
    {
        Id = "reactor_overload",
        Description = "A reactor conduit is cycling dangerously. If you can reroute the power flow, it could be stabilized — and the station crew would owe you one.",
        SuccessText = "You recalibrate the conduit matrix and the warning lights go green. A grateful technician transfers hazard pay to your account.",
        FailText = "Sparks fly as you cross the wrong circuits. You narrowly dodge an arc of plasma and retreat.",
        Skill = SkillType.Armament, Difficulty = CheckDifficulty.Difficult,
        TargetNumber = 17, CreditReward = 100, UpgradePointReward = 2,
    };

    public static SkillCheckEvent CommandTerminal => new()
    {
        Id = "command_terminal",
        Description = "An unattended command terminal displays classified Imperial shipping routes. If you can download the data...",
        SuccessText = "You bypass security and download the route data. This intelligence is worth a fortune on the black market.",
        FailText = "An alarm triggers and the terminal locks down. You clear out before security arrives.",
        Skill = SkillType.Computers, Difficulty = CheckDifficulty.Difficult,
        TargetNumber = 16, CreditReward = 120, UpgradePointReward = 2,
    };

    public static SkillCheckEvent MarketHaggle => new()
    {
        Id = "market_haggle",
        Description = "A vendor is selling a crate of surplus supplies at a steep markup. Think you can talk the price down?",
        SuccessText = "Your silver tongue works wonders. The vendor sighs and gives you the 'friends and family' discount.",
        FailText = "The vendor sees right through your bluff. 'Nice try, spacer. Full price or move along.'",
        Skill = SkillType.Persuade, Difficulty = CheckDifficulty.Easy,
        TargetNumber = 8, CreditReward = 35, UpgradePointReward = 0,
    };

    public static SkillCheckEvent UpperDistrictForge => new()
    {
        Id = "upper_forged_docs",
        Description = "A contact offers to sell you forged transit papers — if you can verify they're convincing enough to pass Imperial inspection.",
        SuccessText = "You spot the telltale signs of quality work. These will pass any checkpoint. The contact throws in a bonus for your eye.",
        FailText = "You can't tell the real from the fake. The contact shrugs. 'Maybe next time.'",
        Skill = SkillType.Streetwise, Difficulty = CheckDifficulty.Moderate,
        TargetNumber = 13, CreditReward = 50, UpgradePointReward = 1,
    };

    public static SkillCheckEvent DerelictForceEcho => new()
    {
        Id = "derelict_force_echo",
        Description = "The Force ripples here — an echo of something terrible. If you open yourself to it, you might learn what happened on this station.",
        SuccessText = "Visions flood your mind: a research project, a breach, something from beyond. The knowledge strengthens your connection to the Force.",
        FailText = "The vision overwhelms you. You gasp and stumble, the echo fading before you can grasp it.",
        Skill = SkillType.Sense, Difficulty = CheckDifficulty.Challenging,
        TargetNumber = 22, CreditReward = 0, UpgradePointReward = 3,
    };

    public static SkillCheckEvent HangarShipInspect => new()
    {
        Id = "hangar_ship_inspect",
        Description = "A mechanic waves you over. 'Hey, you look like you know ships. Can you take a look at this hyperdrive motivator?'",
        SuccessText = "You diagnose the fault in minutes — a misaligned fuel injector. The mechanic is impressed and pays you for the consult.",
        FailText = "You poke around but can't find the issue. The mechanic thanks you for trying.",
        Skill = SkillType.Vehicles, Difficulty = CheckDifficulty.Easy,
        TargetNumber = 8, CreditReward = 30, UpgradePointReward = 1,
    };

    public static SkillCheckEvent DockingBaySmuggle => new()
    {
        Id = "docking_bay_smuggle",
        Description = "A nervous-looking Bothan approaches. 'I need a crate moved past the customs droid. No questions asked. You in?'",
        SuccessText = "You distract the customs droid with a fake manifest while the crate slips through. The Bothan pays handsomely.",
        FailText = "The customs droid isn't fooled. The Bothan vanishes into the crowd and you're left with nothing.",
        Skill = SkillType.Deceive, Difficulty = CheckDifficulty.Moderate,
        TargetNumber = 12, CreditReward = 70, UpgradePointReward = 1,
    };

    public static SkillCheckEvent OrbitSensorSweep => new()
    {
        Id = "orbit_sensor_sweep",
        Description = "Your sensors detect a faint signal — could be a distress beacon or a salvage marker. Want to try to isolate it?",
        SuccessText = "You lock onto the signal. It's a tagged cargo pod — someone's stashed emergency supplies out here. Finders keepers.",
        FailText = "The signal fades into background noise. Whatever it was, it's gone now.",
        Skill = SkillType.Sensors, Difficulty = CheckDifficulty.Moderate,
        TargetNumber = 14, CreditReward = 55, UpgradePointReward = 1,
    };

    public static SkillCheckEvent DeepSpaceNavHazard => new()
    {
        Id = "deep_space_nav_hazard",
        Description = "The asteroid field ahead is thick. You'll need to plot a precise course to navigate safely.",
        SuccessText = "Your calculations are flawless. You thread through the debris field and discover a hidden salvage depot on the far side.",
        FailText = "A miscalculation sends you skimming an asteroid. Minor hull damage — no reward, just relief.",
        Skill = SkillType.Astrogation, Difficulty = CheckDifficulty.Difficult,
        TargetNumber = 16, CreditReward = 80, UpgradePointReward = 2,
    };

    // --- Talk-triggered checks (quests from NPCs) ---

    public static SkillCheckEvent TalkMedicineRequest => new()
    {
        Id = "talk_medicine",
        Description = "A wounded spacer leans against the wall, clutching a blaster burn. 'Please... can you patch me up?'",
        SuccessText = "You clean and dress the wound with practiced hands. The spacer thanks you profusely and insists on paying.",
        FailText = "You do your best, but the wound needs more than you can offer. 'Thanks for trying,' the spacer winces.",
        Skill = SkillType.Medicine, Difficulty = CheckDifficulty.Easy,
        TargetNumber = 9, CreditReward = 25, UpgradePointReward = 1,
    };

    public static SkillCheckEvent TalkWillpowerInterrogation => new()
    {
        Id = "talk_willpower",
        Description = "An Imperial agent approaches. 'We're looking for a fugitive. You wouldn't happen to know anything, would you?' Their gaze is piercing.",
        SuccessText = "You meet their stare without flinching. 'Can't help you.' The agent moves on, satisfied you're not hiding anything.",
        FailText = "You stammer and avert your eyes. The agent narrows their gaze. 'We'll be watching you, spacer.'",
        Skill = SkillType.Willpower, Difficulty = CheckDifficulty.Moderate,
        TargetNumber = 13, CreditReward = 0, UpgradePointReward = 1,
    };

    public static SkillCheckEvent TalkXenologyIdentify => new()
    {
        Id = "talk_xenology",
        Description = "A collector shows you a strange artifact. 'I found this in the Outer Rim. Can you tell me what species made it?'",
        SuccessText = "You recognize the markings immediately — ancient Draelith ritual carvings. The collector is delighted and rewards your knowledge.",
        FailText = "The script is unfamiliar. You shake your head. 'Never seen anything like it.'",
        Skill = SkillType.Xenology, Difficulty = CheckDifficulty.Moderate,
        TargetNumber = 12, CreditReward = 45, UpgradePointReward = 1,
    };

    public static SkillCheckEvent TalkGalaxyIntel => new()
    {
        Id = "talk_galaxy_intel",
        Description = "A rebel sympathizer whispers: 'We've intercepted an Imperial transmission but can't decode the sector references. Know your way around the galaxy?'",
        SuccessText = "You cross-reference the coordinates from memory. 'That's the Kessel Run waypoint — they're moving prisoners.' The sympathizer nods gravely and pays you.",
        FailText = "The sector codes don't ring any bells. 'Sorry, can't help with this one.'",
        Skill = SkillType.Galaxy, Difficulty = CheckDifficulty.Difficult,
        TargetNumber = 15, CreditReward = 75, UpgradePointReward = 2,
    };

    public static SkillCheckEvent TalkSurvivalGuide => new()
    {
        Id = "talk_survival",
        Description = "A group of settlers is planning an expedition to a dangerous moon. 'We need someone who knows how to survive out there. Any advice?'",
        SuccessText = "You brief them on water sources, predator patterns, and shelter construction. They're impressed and pay for the consultation.",
        FailText = "You offer some general advice, but it's clear you're out of your element. They thank you politely.",
        Skill = SkillType.Survival, Difficulty = CheckDifficulty.Easy,
        TargetNumber = 9, CreditReward = 30, UpgradePointReward = 1,
    };

    public static SkillCheckEvent TalkControlCalm => new()
    {
        Id = "talk_control",
        Description = "A panicked child has gotten separated from their family in the crowd. They're crying and won't let anyone near. Perhaps the Force can help calm them.",
        SuccessText = "You reach out with the Force, projecting warmth and safety. The child calms and lets you guide them to their grateful parent, who rewards you.",
        FailText = "You try to project calm, but your focus wavers. The child only cries louder. Someone else steps in to help.",
        Skill = SkillType.Control, Difficulty = CheckDifficulty.Moderate,
        TargetNumber = 14, CreditReward = 20, UpgradePointReward = 2,
    };

    // Mapping: locationId -> checks that can appear there
    public static Dictionary<string, List<SkillCheckEvent>> LocationChecks => new()
    {
        ["cantina"] = new() { CantinaLockbox },
        ["alley"] = new() { AlleyBrokenDroid },
        ["tunnels"] = new() { TunnelsPoisonGas },
        ["reactor"] = new() { ReactorOverload },
        ["command"] = new() { CommandTerminal },
        ["market"] = new() { MarketHaggle },
        ["upper_district"] = new() { UpperDistrictForge },
        ["derelict_interior"] = new() { DerelictForceEcho },
        ["hangar"] = new() { HangarShipInspect },
        ["docking_bay"] = new() { DockingBaySmuggle },
        ["orbit"] = new() { OrbitSensorSweep },
        ["deep_space"] = new() { DeepSpaceNavHazard },
    };

    // Pool of talk-triggered checks (any location with friendly NPCs)
    public static List<SkillCheckEvent> TalkChecks => new()
    {
        TalkMedicineRequest, TalkWillpowerInterrogation, TalkXenologyIdentify,
        TalkGalaxyIntel, TalkSurvivalGuide, TalkControlCalm,
    };

    public static string DifficultyLabel(CheckDifficulty d) => d switch
    {
        CheckDifficulty.Easy => "Easy (TN 4-10)",
        CheckDifficulty.Moderate => "Moderate (TN 10-15)",
        CheckDifficulty.Difficult => "Difficult (TN 15-20)",
        CheckDifficulty.Challenging => "Challenging (TN 20-30)",
        _ => "Unknown"
    };
}

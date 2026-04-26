using Avalonia.Media;

namespace TerminalHyperspace.UI;

/// Shared color palette used across the GUI. Mirrored as XAML resources
/// in App.axaml — keep both in sync if a value changes.
public static class Palette
{
    public static readonly Color PinkCoral       = Color.Parse("#FF595E");
    public static readonly Color OrangeTangerine = Color.Parse("#FF924C");
    public static readonly Color GoldPollen      = Color.Parse("#FFCA3A");
    public static readonly Color LimeLemon       = Color.Parse("#C5CA30");
    public static readonly Color GreenMid        = Color.Parse("#77E632");
    public static readonly Color GreenDark       = Color.Parse("#4A9416");
    public static readonly Color CyanMid         = Color.Parse("#50D5D6");
    public static readonly Color CyanDark        = Color.Parse("#36949D");
    public static readonly Color BlueMid         = Color.Parse("#1982C4");
    public static readonly Color BlueDark        = Color.Parse("#4267AC");
    public static readonly Color PurpleDark      = Color.Parse("#565AA0");
    public static readonly Color VioletMid       = Color.Parse("#C252C5");
    public static readonly Color VioletDark      = Color.Parse("#6A4C93");
    public static readonly Color BrownBg         = Color.Parse("#22171B");
    public static readonly Color GreenBg         = Color.Parse("#272D2B");
    public static readonly Color BlueBg          = Color.Parse("#171D22");

    public static readonly SolidColorBrush PinkCoralBrush       = new(PinkCoral);
    public static readonly SolidColorBrush OrangeTangerineBrush = new(OrangeTangerine);
    public static readonly SolidColorBrush GoldPollenBrush      = new(GoldPollen);
    public static readonly SolidColorBrush LimeLemonBrush       = new(LimeLemon);
    public static readonly SolidColorBrush GreenMidBrush        = new(GreenMid);
    public static readonly SolidColorBrush GreenDarkBrush       = new(GreenDark);
    public static readonly SolidColorBrush CyanMidBrush         = new(CyanMid);
    public static readonly SolidColorBrush CyanDarkBrush        = new(CyanDark);
    public static readonly SolidColorBrush BlueMidBrush         = new(BlueMid);
    public static readonly SolidColorBrush BlueDarkBrush        = new(BlueDark);
    public static readonly SolidColorBrush PurpleDarkBrush      = new(PurpleDark);
    public static readonly SolidColorBrush VioletMidBrush       = new(VioletMid);
    public static readonly SolidColorBrush VioletDarkBrush      = new(VioletDark);
    public static readonly SolidColorBrush BrownBgBrush         = new(BrownBg);
    public static readonly SolidColorBrush GreenBgBrush         = new(GreenBg);
    public static readonly SolidColorBrush BlueBgBrush          = new(BlueBg);
}

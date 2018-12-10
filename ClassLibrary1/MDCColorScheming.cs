using Foundation;
using UIKit;

[Protocol, Model]
interface MDCColorScheming
{
    // @required @property (readonly, nonatomic) UIColor * _Nonnull primaryColor;
    [Abstract]
    [Export ("primaryColor")]
    UIColor PrimaryColor { get; }

    // @required @property (readonly, nonatomic) UIColor * _Nonnull primaryColorVariant;
    [Abstract]
    [Export ("primaryColorVariant")]
    UIColor PrimaryColorVariant { get; }

    // @required @property (readonly, nonatomic) UIColor * _Nonnull secondaryColor;
    [Abstract]
    [Export ("secondaryColor")]
    UIColor SecondaryColor { get; }

    // @required @property (readonly, nonatomic) UIColor * _Nonnull errorColor;
    [Abstract]
    [Export ("errorColor")]
    UIColor ErrorColor { get; }

    // @required @property (readonly, nonatomic) UIColor * _Nonnull surfaceColor;
    [Abstract]
    [Export ("surfaceColor")]
    UIColor SurfaceColor { get; }

    // @required @property (readonly, nonatomic) UIColor * _Nonnull backgroundColor;
    [Abstract]
    [Export ("backgroundColor")]
    UIColor BackgroundColor { get; }

    // @required @property (readonly, nonatomic) UIColor * _Nonnull onPrimaryColor;
    [Abstract]
    [Export ("onPrimaryColor")]
    UIColor OnPrimaryColor { get; }

    // @required @property (readonly, nonatomic) UIColor * _Nonnull onSecondaryColor;
    [Abstract]
    [Export ("onSecondaryColor")]
    UIColor OnSecondaryColor { get; }

    // @required @property (readonly, nonatomic) UIColor * _Nonnull onSurfaceColor;
    [Abstract]
    [Export ("onSurfaceColor")]
    UIColor OnSurfaceColor { get; }

    // @required @property (readonly, nonatomic) UIColor * _Nonnull onBackgroundColor;
    [Abstract]
    [Export ("onBackgroundColor")]
    UIColor OnBackgroundColor { get; }
}
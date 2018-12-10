using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCPalette
{
    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull redPalette;
    [Static]
    [Export ("redPalette", ArgumentSemantic.Strong)]
    MDCPalette RedPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull pinkPalette;
    [Static]
    [Export ("pinkPalette", ArgumentSemantic.Strong)]
    MDCPalette PinkPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull purplePalette;
    [Static]
    [Export ("purplePalette", ArgumentSemantic.Strong)]
    MDCPalette PurplePalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull deepPurplePalette;
    [Static]
    [Export ("deepPurplePalette", ArgumentSemantic.Strong)]
    MDCPalette DeepPurplePalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull indigoPalette;
    [Static]
    [Export ("indigoPalette", ArgumentSemantic.Strong)]
    MDCPalette IndigoPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull bluePalette;
    [Static]
    [Export ("bluePalette", ArgumentSemantic.Strong)]
    MDCPalette BluePalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull lightBluePalette;
    [Static]
    [Export ("lightBluePalette", ArgumentSemantic.Strong)]
    MDCPalette LightBluePalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull cyanPalette;
    [Static]
    [Export ("cyanPalette", ArgumentSemantic.Strong)]
    MDCPalette CyanPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull tealPalette;
    [Static]
    [Export ("tealPalette", ArgumentSemantic.Strong)]
    MDCPalette TealPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull greenPalette;
    [Static]
    [Export ("greenPalette", ArgumentSemantic.Strong)]
    MDCPalette GreenPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull lightGreenPalette;
    [Static]
    [Export ("lightGreenPalette", ArgumentSemantic.Strong)]
    MDCPalette LightGreenPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull limePalette;
    [Static]
    [Export ("limePalette", ArgumentSemantic.Strong)]
    MDCPalette LimePalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull yellowPalette;
    [Static]
    [Export ("yellowPalette", ArgumentSemantic.Strong)]
    MDCPalette YellowPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull amberPalette;
    [Static]
    [Export ("amberPalette", ArgumentSemantic.Strong)]
    MDCPalette AmberPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull orangePalette;
    [Static]
    [Export ("orangePalette", ArgumentSemantic.Strong)]
    MDCPalette OrangePalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull deepOrangePalette;
    [Static]
    [Export ("deepOrangePalette", ArgumentSemantic.Strong)]
    MDCPalette DeepOrangePalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull brownPalette;
    [Static]
    [Export ("brownPalette", ArgumentSemantic.Strong)]
    MDCPalette BrownPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull greyPalette;
    [Static]
    [Export ("greyPalette", ArgumentSemantic.Strong)]
    MDCPalette GreyPalette { get; }

    // @property (readonly, nonatomic, strong, class) MDCPalette * _Nonnull blueGreyPalette;
    [Static]
    [Export ("blueGreyPalette", ArgumentSemantic.Strong)]
    MDCPalette BlueGreyPalette { get; }

    // +(instancetype _Nonnull)paletteGeneratedFromColor:(UIColor * _Nonnull)target500Color;
    [Static]
    [Export ("paletteGeneratedFromColor:")]
    MDCPalette PaletteGeneratedFromColor (UIColor target500Color);

    // +(instancetype _Nonnull)paletteWithTints:(NSDictionary<MDCPaletteTint,UIColor *> * _Nonnull)tints accents:(NSDictionary<MDCPaletteAccent,UIColor *> * _Nullable)accents;
    [Static]
    [Export ("paletteWithTints:accents:")]
    MDCPalette PaletteWithTints (NSDictionary<NSString, UIColor> tints, [NullAllowed] NSDictionary<NSString, UIColor> accents);

    // -(instancetype _Nonnull)initWithTints:(NSDictionary<MDCPaletteTint,UIColor *> * _Nonnull)tints accents:(NSDictionary<MDCPaletteAccent,UIColor *> * _Nullable)accents;
    [Export ("initWithTints:accents:")]
    IntPtr Constructor (NSDictionary<NSString, UIColor> tints, [NullAllowed] NSDictionary<NSString, UIColor> accents);

    // @property (readonly, nonatomic) UIColor * _Nonnull tint50;
    [Export ("tint50")]
    UIColor Tint50 { get; }

    // @property (readonly, nonatomic) UIColor * _Nonnull tint100;
    [Export ("tint100")]
    UIColor Tint100 { get; }

    // @property (readonly, nonatomic) UIColor * _Nonnull tint200;
    [Export ("tint200")]
    UIColor Tint200 { get; }

    // @property (readonly, nonatomic) UIColor * _Nonnull tint300;
    [Export ("tint300")]
    UIColor Tint300 { get; }

    // @property (readonly, nonatomic) UIColor * _Nonnull tint400;
    [Export ("tint400")]
    UIColor Tint400 { get; }

    // @property (readonly, nonatomic) UIColor * _Nonnull tint500;
    [Export ("tint500")]
    UIColor Tint500 { get; }

    // @property (readonly, nonatomic) UIColor * _Nonnull tint600;
    [Export ("tint600")]
    UIColor Tint600 { get; }

    // @property (readonly, nonatomic) UIColor * _Nonnull tint700;
    [Export ("tint700")]
    UIColor Tint700 { get; }

    // @property (readonly, nonatomic) UIColor * _Nonnull tint800;
    [Export ("tint800")]
    UIColor Tint800 { get; }

    // @property (readonly, nonatomic) UIColor * _Nonnull tint900;
    [Export ("tint900")]
    UIColor Tint900 { get; }

    // @property (readonly, nonatomic) UIColor * _Nullable accent100;
    [NullAllowed, Export ("accent100")]
    UIColor Accent100 { get; }

    // @property (readonly, nonatomic) UIColor * _Nullable accent200;
    [NullAllowed, Export ("accent200")]
    UIColor Accent200 { get; }

    // @property (readonly, nonatomic) UIColor * _Nullable accent400;
    [NullAllowed, Export ("accent400")]
    UIColor Accent400 { get; }

    // @property (readonly, nonatomic) UIColor * _Nullable accent700;
    [NullAllowed, Export ("accent700")]
    UIColor Accent700 { get; }
}
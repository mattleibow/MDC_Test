using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCSemanticColorScheme : IMDCColorScheming
{
    // @property (readwrite, nonatomic) UIColor * _Nonnull primaryColor;
    [Export ("primaryColor", ArgumentSemantic.Assign)]
    UIColor PrimaryColor { get; set; }

    // @property (readwrite, nonatomic) UIColor * _Nonnull primaryColorVariant;
    [Export ("primaryColorVariant", ArgumentSemantic.Assign)]
    UIColor PrimaryColorVariant { get; set; }

    // @property (readwrite, nonatomic) UIColor * _Nonnull secondaryColor;
    [Export ("secondaryColor", ArgumentSemantic.Assign)]
    UIColor SecondaryColor { get; set; }

    // @property (readwrite, nonatomic) UIColor * _Nonnull errorColor;
    [Export ("errorColor", ArgumentSemantic.Assign)]
    UIColor ErrorColor { get; set; }

    // @property (readwrite, nonatomic) UIColor * _Nonnull surfaceColor;
    [Export ("surfaceColor", ArgumentSemantic.Assign)]
    UIColor SurfaceColor { get; set; }

    // @property (readwrite, nonatomic) UIColor * _Nonnull backgroundColor;
    [Export ("backgroundColor", ArgumentSemantic.Assign)]
    UIColor BackgroundColor { get; set; }

    // @property (readwrite, nonatomic) UIColor * _Nonnull onPrimaryColor;
    [Export ("onPrimaryColor", ArgumentSemantic.Assign)]
    UIColor OnPrimaryColor { get; set; }

    // @property (readwrite, nonatomic) UIColor * _Nonnull onSecondaryColor;
    [Export ("onSecondaryColor", ArgumentSemantic.Assign)]
    UIColor OnSecondaryColor { get; set; }

    // @property (readwrite, nonatomic) UIColor * _Nonnull onSurfaceColor;
    [Export ("onSurfaceColor", ArgumentSemantic.Assign)]
    UIColor OnSurfaceColor { get; set; }

    // @property (readwrite, nonatomic) UIColor * _Nonnull onBackgroundColor;
    [Export ("onBackgroundColor", ArgumentSemantic.Assign)]
    UIColor OnBackgroundColor { get; set; }

    // -(instancetype _Nonnull)initWithDefaults:(MDCColorSchemeDefaults)defaults;
    [Export ("initWithDefaults:")]
    IntPtr Constructor (MDCColorSchemeDefaults defaults);

    // +(UIColor * _Nonnull)blendColor:(UIColor * _Nonnull)color withBackgroundColor:(UIColor * _Nonnull)backgroundColor;
    [Static]
    [Export ("blendColor:withBackgroundColor:")]
    UIColor BlendColor (UIColor color, UIColor backgroundColor);
}
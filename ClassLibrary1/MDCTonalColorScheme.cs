using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDCTonalColorScheme : IMDCColorScheme, INSCopying
{
    // @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryColor;
    [Export ("primaryColor", ArgumentSemantic.Strong)]
    UIColor PrimaryColor { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryLightColor;
    [Export ("primaryLightColor", ArgumentSemantic.Strong)]
    UIColor PrimaryLightColor { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryDarkColor;
    [Export ("primaryDarkColor", ArgumentSemantic.Strong)]
    UIColor PrimaryDarkColor { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryColor;
    [Export ("secondaryColor", ArgumentSemantic.Strong)]
    UIColor SecondaryColor { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryLightColor;
    [Export ("secondaryLightColor", ArgumentSemantic.Strong)]
    UIColor SecondaryLightColor { get; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryDarkColor;
    [Export ("secondaryDarkColor", ArgumentSemantic.Strong)]
    UIColor SecondaryDarkColor { get; }

    // @property (readonly, nonatomic, strong) MDCTonalPalette * _Nonnull primaryTonalPalette;
    [Export ("primaryTonalPalette", ArgumentSemantic.Strong)]
    MDCTonalPalette PrimaryTonalPalette { get; }

    // @property (readonly, nonatomic, strong) MDCTonalPalette * _Nonnull secondaryTonalPalette;
    [Export ("secondaryTonalPalette", ArgumentSemantic.Strong)]
    MDCTonalPalette SecondaryTonalPalette { get; }

    // -(instancetype _Nonnull)initWithPrimaryTonalPalette:(MDCTonalPalette * _Nonnull)primaryTonalPalette secondaryTonalPalette:(MDCTonalPalette * _Nonnull)secondaryTonalPalette __attribute__((objc_designated_initializer));
    [Export ("initWithPrimaryTonalPalette:secondaryTonalPalette:")]
    [DesignatedInitializer]
    IntPtr Constructor (MDCTonalPalette primaryTonalPalette, MDCTonalPalette secondaryTonalPalette);
}
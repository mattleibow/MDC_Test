using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDCBasicColorScheme : IMDCColorScheme, INSCopying
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

    // -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor primaryLightColor:(UIColor * _Nonnull)primaryLightColor primaryDarkColor:(UIColor * _Nonnull)primaryDarkColor secondaryColor:(UIColor * _Nonnull)secondaryColor secondaryLightColor:(UIColor * _Nonnull)secondaryLightColor secondaryDarkColor:(UIColor * _Nonnull)secondaryDarkColor __attribute__((objc_designated_initializer));
    [Export ("initWithPrimaryColor:primaryLightColor:primaryDarkColor:secondaryColor:secondaryLightColor:secondaryDarkColor:")]
    [DesignatedInitializer]
    IntPtr Constructor (UIColor primaryColor, UIColor primaryLightColor, UIColor primaryDarkColor, UIColor secondaryColor, UIColor secondaryLightColor, UIColor secondaryDarkColor);

    // -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor;
    [Export ("initWithPrimaryColor:")]
    IntPtr Constructor (UIColor primaryColor);

    // -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor primaryLightColor:(UIColor * _Nonnull)primaryLightColor primaryDarkColor:(UIColor * _Nonnull)primaryDarkColor;
    [Export ("initWithPrimaryColor:primaryLightColor:primaryDarkColor:")]
    IntPtr Constructor (UIColor primaryColor, UIColor primaryLightColor, UIColor primaryDarkColor);

    // -(instancetype _Nonnull)initWithPrimaryColor:(UIColor * _Nonnull)primaryColor secondaryColor:(UIColor * _Nonnull)secondaryColor;
    [Export ("initWithPrimaryColor:secondaryColor:")]
    IntPtr Constructor (UIColor primaryColor, UIColor secondaryColor);
}
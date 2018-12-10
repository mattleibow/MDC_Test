using Foundation;
using ObjCRuntime;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCColorScheme
{
    // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryColor;
    [Abstract]
    [Export ("primaryColor", ArgumentSemantic.Strong)]
    UIColor PrimaryColor { get; }

    // @optional @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryLightColor;
    [Export ("primaryLightColor", ArgumentSemantic.Strong)]
    UIColor PrimaryLightColor { get; }

    // @optional @property (readonly, nonatomic, strong) UIColor * _Nonnull primaryDarkColor;
    [Export ("primaryDarkColor", ArgumentSemantic.Strong)]
    UIColor PrimaryDarkColor { get; }

    // @optional @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryColor;
    [Export ("secondaryColor", ArgumentSemantic.Strong)]
    UIColor SecondaryColor { get; }

    // @optional @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryLightColor;
    [Export ("secondaryLightColor", ArgumentSemantic.Strong)]
    UIColor SecondaryLightColor { get; }

    // @optional @property (readonly, nonatomic, strong) UIColor * _Nonnull secondaryDarkColor;
    [Export ("secondaryDarkColor", ArgumentSemantic.Strong)]
    UIColor SecondaryDarkColor { get; }
}
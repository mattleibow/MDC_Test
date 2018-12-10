using Foundation;
using ObjCRuntime;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCFontScheme
{
    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline1;
    [Abstract]
    [NullAllowed, Export ("headline1", ArgumentSemantic.Strong)]
    UIFont Headline1 { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline2;
    [Abstract]
    [NullAllowed, Export ("headline2", ArgumentSemantic.Strong)]
    UIFont Headline2 { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline3;
    [Abstract]
    [NullAllowed, Export ("headline3", ArgumentSemantic.Strong)]
    UIFont Headline3 { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline4;
    [Abstract]
    [NullAllowed, Export ("headline4", ArgumentSemantic.Strong)]
    UIFont Headline4 { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline5;
    [Abstract]
    [NullAllowed, Export ("headline5", ArgumentSemantic.Strong)]
    UIFont Headline5 { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable headline6;
    [Abstract]
    [NullAllowed, Export ("headline6", ArgumentSemantic.Strong)]
    UIFont Headline6 { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable subtitle1;
    [Abstract]
    [NullAllowed, Export ("subtitle1", ArgumentSemantic.Strong)]
    UIFont Subtitle1 { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable subtitle2;
    [Abstract]
    [NullAllowed, Export ("subtitle2", ArgumentSemantic.Strong)]
    UIFont Subtitle2 { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable body1;
    [Abstract]
    [NullAllowed, Export ("body1", ArgumentSemantic.Strong)]
    UIFont Body1 { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable body2;
    [Abstract]
    [NullAllowed, Export ("body2", ArgumentSemantic.Strong)]
    UIFont Body2 { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable caption;
    [Abstract]
    [NullAllowed, Export ("caption", ArgumentSemantic.Strong)]
    UIFont Caption { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable button;
    [Abstract]
    [NullAllowed, Export ("button", ArgumentSemantic.Strong)]
    UIFont Button { get; }

    // @required @property (readonly, nonatomic, strong) UIFont * _Nullable overline;
    [Abstract]
    [NullAllowed, Export ("overline", ArgumentSemantic.Strong)]
    UIFont Overline { get; }
}
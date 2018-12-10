using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCBasicFontScheme : IMDCFontScheme
{
    // @property (nonatomic) UIFont * _Nullable headline1;
    [NullAllowed, Export ("headline1", ArgumentSemantic.Assign)]
    UIFont Headline1 { get; set; }

    // @property (nonatomic) UIFont * _Nullable headline2;
    [NullAllowed, Export ("headline2", ArgumentSemantic.Assign)]
    UIFont Headline2 { get; set; }

    // @property (nonatomic) UIFont * _Nullable headline3;
    [NullAllowed, Export ("headline3", ArgumentSemantic.Assign)]
    UIFont Headline3 { get; set; }

    // @property (nonatomic) UIFont * _Nullable headline4;
    [NullAllowed, Export ("headline4", ArgumentSemantic.Assign)]
    UIFont Headline4 { get; set; }

    // @property (nonatomic) UIFont * _Nullable headline5;
    [NullAllowed, Export ("headline5", ArgumentSemantic.Assign)]
    UIFont Headline5 { get; set; }

    // @property (nonatomic) UIFont * _Nullable headline6;
    [NullAllowed, Export ("headline6", ArgumentSemantic.Assign)]
    UIFont Headline6 { get; set; }

    // @property (nonatomic) UIFont * _Nullable subtitle1;
    [NullAllowed, Export ("subtitle1", ArgumentSemantic.Assign)]
    UIFont Subtitle1 { get; set; }

    // @property (nonatomic) UIFont * _Nullable subtitle2;
    [NullAllowed, Export ("subtitle2", ArgumentSemantic.Assign)]
    UIFont Subtitle2 { get; set; }

    // @property (nonatomic) UIFont * _Nullable body1;
    [NullAllowed, Export ("body1", ArgumentSemantic.Assign)]
    UIFont Body1 { get; set; }

    // @property (nonatomic) UIFont * _Nullable body2;
    [NullAllowed, Export ("body2", ArgumentSemantic.Assign)]
    UIFont Body2 { get; set; }

    // @property (nonatomic) UIFont * _Nullable caption;
    [NullAllowed, Export ("caption", ArgumentSemantic.Assign)]
    UIFont Caption { get; set; }

    // @property (nonatomic) UIFont * _Nullable button;
    [NullAllowed, Export ("button", ArgumentSemantic.Assign)]
    UIFont Button { get; set; }

    // @property (nonatomic) UIFont * _Nullable overline;
    [NullAllowed, Export ("overline", ArgumentSemantic.Assign)]
    UIFont Overline { get; set; }
}
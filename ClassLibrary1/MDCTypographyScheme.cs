using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCTypographyScheme : IMDCTypographyScheming
{
    // @property (readwrite, nonatomic) UIFont * _Nonnull headline1;
    [Export ("headline1", ArgumentSemantic.Assign)]
    UIFont Headline1 { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull headline2;
    [Export ("headline2", ArgumentSemantic.Assign)]
    UIFont Headline2 { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull headline3;
    [Export ("headline3", ArgumentSemantic.Assign)]
    UIFont Headline3 { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull headline4;
    [Export ("headline4", ArgumentSemantic.Assign)]
    UIFont Headline4 { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull headline5;
    [Export ("headline5", ArgumentSemantic.Assign)]
    UIFont Headline5 { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull headline6;
    [Export ("headline6", ArgumentSemantic.Assign)]
    UIFont Headline6 { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull subtitle1;
    [Export ("subtitle1", ArgumentSemantic.Assign)]
    UIFont Subtitle1 { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull subtitle2;
    [Export ("subtitle2", ArgumentSemantic.Assign)]
    UIFont Subtitle2 { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull body1;
    [Export ("body1", ArgumentSemantic.Assign)]
    UIFont Body1 { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull body2;
    [Export ("body2", ArgumentSemantic.Assign)]
    UIFont Body2 { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull caption;
    [Export ("caption", ArgumentSemantic.Assign)]
    UIFont Caption { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull button;
    [Export ("button", ArgumentSemantic.Assign)]
    UIFont Button { get; set; }

    // @property (readwrite, nonatomic) UIFont * _Nonnull overline;
    [Export ("overline", ArgumentSemantic.Assign)]
    UIFont Overline { get; set; }

    // -(instancetype _Nonnull)initWithDefaults:(MDCTypographySchemeDefaults)defaults;
    [Export ("initWithDefaults:")]
    IntPtr Constructor (MDCTypographySchemeDefaults defaults);
}
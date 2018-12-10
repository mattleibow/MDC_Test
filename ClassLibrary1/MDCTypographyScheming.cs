using Foundation;
using UIKit;

[Protocol, Model]
interface MDCTypographyScheming
{
    // @required @property (readonly, nonatomic) UIFont * _Nonnull headline1;
    [Abstract]
    [Export ("headline1")]
    UIFont Headline1 { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull headline2;
    [Abstract]
    [Export ("headline2")]
    UIFont Headline2 { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull headline3;
    [Abstract]
    [Export ("headline3")]
    UIFont Headline3 { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull headline4;
    [Abstract]
    [Export ("headline4")]
    UIFont Headline4 { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull headline5;
    [Abstract]
    [Export ("headline5")]
    UIFont Headline5 { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull headline6;
    [Abstract]
    [Export ("headline6")]
    UIFont Headline6 { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull subtitle1;
    [Abstract]
    [Export ("subtitle1")]
    UIFont Subtitle1 { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull subtitle2;
    [Abstract]
    [Export ("subtitle2")]
    UIFont Subtitle2 { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull body1;
    [Abstract]
    [Export ("body1")]
    UIFont Body1 { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull body2;
    [Abstract]
    [Export ("body2")]
    UIFont Body2 { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull caption;
    [Abstract]
    [Export ("caption")]
    UIFont Caption { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull button;
    [Abstract]
    [Export ("button")]
    UIFont Button { get; }

    // @required @property (readonly, nonatomic) UIFont * _Nonnull overline;
    [Abstract]
    [Export ("overline")]
    UIFont Overline { get; }
}
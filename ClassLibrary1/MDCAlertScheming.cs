using System;
using Foundation;

[Protocol, Model]
interface MDCAlertScheming
{
    // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
    [Abstract]
    [Export ("colorScheme")]
    MDCColorScheming ColorScheme { get; }

    // @required @property (readonly, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
    [Abstract]
    [Export ("typographyScheme")]
    MDCTypographyScheming TypographyScheme { get; }

    // @required @property (readonly, nonatomic) id<MDCButtonScheming> _Nonnull buttonScheme;
    [Abstract]
    [Export ("buttonScheme")]
    MDCButtonScheming ButtonScheme { get; }

    // @required @property (readonly, nonatomic) CGFloat cornerRadius;
    [Abstract]
    [Export ("cornerRadius")]
    nfloat CornerRadius { get; }

    // @required @property (readonly, nonatomic) CGFloat elevation;
    [Abstract]
    [Export ("elevation")]
    nfloat Elevation { get; }
}
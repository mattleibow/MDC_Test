using System;
using Foundation;

[Protocol, Model]
interface MDCButtonScheming
{
    // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
    [Abstract]
    [Export ("colorScheme")]
    MDCColorScheming ColorScheme { get; }

    // @required @property (readonly, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
    [Abstract]
    [Export ("typographyScheme")]
    MDCTypographyScheming TypographyScheme { get; }

    // @required @property (readonly, nonatomic) CGFloat cornerRadius;
    [Abstract]
    [Export ("cornerRadius")]
    nfloat CornerRadius { get; }

    // @required @property (readonly, nonatomic) CGFloat minimumHeight;
    [Abstract]
    [Export ("minimumHeight")]
    nfloat MinimumHeight { get; }
}
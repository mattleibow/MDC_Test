using Foundation;

[Protocol, Model]
interface MDCListScheming
{
    // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
    [Abstract]
    [Export ("colorScheme")]
    MDCColorScheming ColorScheme { get; }

    // @required @property (readonly, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
    [Abstract]
    [Export ("typographyScheme")]
    MDCTypographyScheming TypographyScheme { get; }
}
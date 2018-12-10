using Foundation;

[Protocol, Model]
interface MDCCardScheming
{
    // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
    [Abstract]
    [Export ("colorScheme")]
    MDCColorScheming ColorScheme { get; }
}
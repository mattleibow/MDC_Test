using Foundation;

[Protocol, Model]
interface MDCCardScheming
{
    // @required @property (readonly, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
    [Abstract]
    [Export ("colorScheme")]
    MDCColorScheming ColorScheme { get; }

    // @required @property (readonly, nonatomic) id<MDCShapeScheming> _Nonnull shapeScheme;
    [Abstract]
    [Export ("shapeScheme")]
    MDCShapeScheming ShapeScheme { get; }
}
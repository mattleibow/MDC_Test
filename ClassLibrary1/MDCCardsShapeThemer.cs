using Foundation;

[BaseType (typeof(NSObject))]
interface MDCCardsShapeThemer
{
    // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toCard:(MDCCard * _Nonnull)card;
    [Static]
    [Export ("applyShapeScheme:toCard:")]
    void ApplyShapeScheme (MDCShapeScheming shapeScheme, MDCCard card);

    // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toCardCell:(MDCCardCollectionCell * _Nonnull)cardCell;
    [Static]
    [Export ("applyShapeScheme:toCardCell:")]
    void ApplyShapeScheme (MDCShapeScheming shapeScheme, MDCCardCollectionCell cardCell);
}
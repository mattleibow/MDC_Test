using Foundation;

[BaseType (typeof(NSObject))]
interface MDCCardThemer
{
    // +(void)applyScheme:(id<MDCCardScheming> _Nonnull)scheme toCard:(MDCCard * _Nonnull)card;
    [Static]
    [Export ("applyScheme:toCard:")]
    void ApplyScheme (MDCCardScheming scheme, MDCCard card);

    // +(void)applyScheme:(id<MDCCardScheming> _Nonnull)scheme toCardCell:(MDCCardCollectionCell * _Nonnull)cardCell;
    [Static]
    [Export ("applyScheme:toCardCell:")]
    void ApplyScheme (MDCCardScheming scheme, MDCCardCollectionCell cardCell);

    // +(void)applyOutlinedVariantWithScheme:(id<MDCCardScheming> _Nonnull)scheme toCard:(MDCCard * _Nonnull)card;
    [Static]
    [Export ("applyOutlinedVariantWithScheme:toCard:")]
    void ApplyOutlinedVariantWithScheme (MDCCardScheming scheme, MDCCard card);

    // +(void)applyOutlinedVariantWithScheme:(id<MDCCardScheming> _Nonnull)scheme toCardCell:(MDCCardCollectionCell * _Nonnull)cardCell;
    [Static]
    [Export ("applyOutlinedVariantWithScheme:toCardCell:")]
    void ApplyOutlinedVariantWithScheme (MDCCardScheming scheme, MDCCardCollectionCell cardCell);
}
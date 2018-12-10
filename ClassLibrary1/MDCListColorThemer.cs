using Foundation;

[BaseType (typeof(NSObject))]
interface MDCListColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming>)colorScheme toSelfSizingStereoCell:(MDCSelfSizingStereoCell *)cell;
    [Static]
    [Export ("applySemanticColorScheme:toSelfSizingStereoCell:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCSelfSizingStereoCell cell);

    // +(void)applySemanticColorScheme:(id<MDCColorScheming>)colorScheme toBaseCell:(MDCBaseCell *)cell;
    [Static]
    [Export ("applySemanticColorScheme:toBaseCell:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCBaseCell cell);
}
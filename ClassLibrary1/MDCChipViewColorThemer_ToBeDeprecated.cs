using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCChipViewColorThemer))]
interface MDCChipViewColorThemer_ToBeDeprecated
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toStrokedChipView:(MDCChipView * _Nonnull)strokedChipView;
    [Static]
    [Export ("applySemanticColorScheme:toStrokedChipView:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCChipView strokedChipView);
}
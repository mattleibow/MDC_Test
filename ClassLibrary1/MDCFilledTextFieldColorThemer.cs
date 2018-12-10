using Foundation;

[BaseType (typeof(NSObject))]
interface MDCFilledTextFieldColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTextInputControllerFilled:(MDCTextInputControllerFilled * _Nonnull)textInputControllerFilled;
    [Static]
    [Export ("applySemanticColorScheme:toTextInputControllerFilled:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCTextInputControllerFilled textInputControllerFilled);
}
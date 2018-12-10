using Foundation;

[BaseType (typeof(NSObject))]
interface MDCOutlinedTextFieldColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
    [Static]
    [Export ("applySemanticColorScheme:toTextInputController:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCTextInputController textInputController);
}
using Foundation;

[BaseType (typeof(NSObject))]
interface MDCTextFieldFontThemer
{
    // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
    [Static]
    [Export ("applyFontScheme:toTextInputController:")]
    void ApplyFontScheme (MDCFontScheme fontScheme, MDCTextInputController textInputController);

    // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toAllTextInputControllersOfClass:(Class<MDCTextInputController> _Nonnull)textInputControllerClass;
    [Static]
    [Export ("applyFontScheme:toAllTextInputControllersOfClass:")]
    void ApplyFontScheme (MDCFontScheme fontScheme, MDCTextInputController textInputControllerClass);

    // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toTextField:(MDCTextField * _Nullable)textField;
    [Static]
    [Export ("applyFontScheme:toTextField:")]
    void ApplyFontScheme (MDCFontScheme fontScheme, [NullAllowed] MDCTextField textField);
}
using Foundation;

[BaseType (typeof(NSObject))]
interface MDCTextFieldTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
    [Static]
    [Export ("applyTypographyScheme:toTextInputController:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCTextInputController textInputController);

    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAllTextInputControllersOfClass:(Class<MDCTextInputController> _Nonnull)textInputControllerClass;
    [Static]
    [Export ("applyTypographyScheme:toAllTextInputControllersOfClass:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCTextInputController textInputControllerClass);

    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toTextInput:(id<MDCTextInput> _Nonnull)textInput;
    [Static]
    [Export ("applyTypographyScheme:toTextInput:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCTextInput textInput);
}
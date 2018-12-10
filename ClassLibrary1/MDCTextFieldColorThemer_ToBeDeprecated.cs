using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCTextFieldColorThemer))]
interface MDCTextFieldColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toTextInputController:(id<MDCTextInputController> _Nonnull)textInputController;
    [Static]
    [Export ("applyColorScheme:toTextInputController:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCTextInputController textInputController);

    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toAllTextInputControllersOfClass:(Class<MDCTextInputController> _Nonnull)textInputControllerClass;
    [Static]
    [Export ("applyColorScheme:toAllTextInputControllersOfClass:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCTextInputController textInputControllerClass);
}
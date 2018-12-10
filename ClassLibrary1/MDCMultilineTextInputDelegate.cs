using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCMultilineTextInputDelegate
{
    // @optional -(BOOL)multilineTextFieldShouldClear:(UIView<MDCTextInput> *)textField;
    [Export ("multilineTextFieldShouldClear:")]
    bool MultilineTextFieldShouldClear (MDCTextInput textField);
}
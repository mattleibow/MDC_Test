using Foundation;

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
    // extern NSString *const _Nonnull MDCTextFieldTextDidSetTextNotification;
    [Field ("MDCTextFieldTextDidSetTextNotification", "__Internal")]
    NSString MDCTextFieldTextDidSetTextNotification { get; }

    // extern NSString *const _Nonnull MDCTextInputDidToggleEnabledNotification;
    [Field ("MDCTextInputDidToggleEnabledNotification", "__Internal")]
    NSString MDCTextInputDidToggleEnabledNotification { get; }
}
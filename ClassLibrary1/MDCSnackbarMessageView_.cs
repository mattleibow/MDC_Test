using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCSnackbarMessageView))]
interface MDCSnackbarMessageView_
{
    // @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewTextColor __attribute__((deprecated("Use messsageTextColor instead."))) __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("snackbarMessageViewTextColor", ArgumentSemantic.Strong)]
    UIColor SnackbarMessageViewTextColor { get; set; }
}
using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCAlertController))]
interface MDCAlertController_ButtonForAction
{
    // -(MDCButton * _Nullable)buttonForAction:(MDCAlertAction * _Nonnull)action;
    [Export ("buttonForAction:")]
    [return: NullAllowed]
    MDCButton ButtonForAction (MDCAlertAction action);
}
using Foundation;
using UIKit;

[BaseType (typeof(MDCFlatButton))]
interface MDCButtonBarButton
{
    // -(void)setTitleFont:(UIFont * _Nullable)font forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setTitleFont:forState:")]
    void SetTitleFont ([NullAllowed] UIFont font, UIControlState state);
}
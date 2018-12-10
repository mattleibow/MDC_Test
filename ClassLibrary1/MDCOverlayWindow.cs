using Foundation;
using UIKit;

[BaseType (typeof(UIWindow))]
interface MDCOverlayWindow
{
    // -(void)activateOverlay:(UIView *)overlay withLevel:(UIWindowLevel)level;
    [Export ("activateOverlay:withLevel:")]
    void ActivateOverlay (UIView overlay, double level);

    // -(void)deactivateOverlay:(UIView *)overlay;
    [Export ("deactivateOverlay:")]
    void DeactivateOverlay (UIView overlay);
}
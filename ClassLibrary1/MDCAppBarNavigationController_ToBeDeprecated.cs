using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCAppBarNavigationController))]
interface MDCAppBarNavigationController_ToBeDeprecated
{
    // -(MDCAppBar * _Nullable)appBarForViewController:(UIViewController * _Nonnull)viewController;
    [Export ("appBarForViewController:")]
    [return: NullAllowed]
    MDCAppBar AppBarForViewController (UIViewController viewController);
}
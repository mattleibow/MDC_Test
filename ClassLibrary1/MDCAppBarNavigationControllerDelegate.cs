using Foundation;
using UIKit;

[Protocol, Model]
interface MDCAppBarNavigationControllerDelegate : IUINavigationControllerDelegate
{
    // @optional -(void)appBarNavigationController:(MDCAppBarNavigationController * _Nonnull)navigationController willAddAppBarViewController:(MDCAppBarViewController * _Nonnull)appBarViewController asChildOfViewController:(UIViewController * _Nonnull)viewController;
    [Export ("appBarNavigationController:willAddAppBarViewController:asChildOfViewController:")]
    void WillAddAppBarViewController (MDCAppBarNavigationController navigationController, MDCAppBarViewController appBarViewController, UIViewController viewController);

    // @optional -(void)appBarNavigationController:(MDCAppBarNavigationController * _Nonnull)navigationController willAddAppBar:(MDCAppBar * _Nonnull)appBar asChildOfViewController:(UIViewController * _Nonnull)viewController;
    [Export ("appBarNavigationController:willAddAppBar:asChildOfViewController:")]
    void WillAddAppBar (MDCAppBarNavigationController navigationController, MDCAppBar appBar, UIViewController viewController);
}
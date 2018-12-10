using Foundation;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCTabBarControllerDelegate
{
    // @optional -(BOOL)tabBarController:(MDCTabBarViewController * _Nonnull)tabBarController shouldSelectViewController:(UIViewController * _Nonnull)viewController;
    [Export ("tabBarController:shouldSelectViewController:")]
    bool TabBarController (MDCTabBarViewController tabBarController, UIViewController viewController);

    // @optional -(void)tabBarController:(MDCTabBarViewController * _Nonnull)tabBarController didSelectViewController:(UIViewController * _Nonnull)viewController;
    [Export ("tabBarController:didSelectViewController:")]
    void TabBarController (MDCTabBarViewController tabBarController, UIViewController viewController);
}
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UINavigationController))]
interface MDCAppBarNavigationController
{
    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCAppBarNavigationControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCAppBarNavigationControllerDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // -(MDCAppBarViewController * _Nullable)appBarViewControllerForViewController:(UIViewController * _Nonnull)viewController;
    [Export ("appBarViewControllerForViewController:")]
    [return: NullAllowed]
    MDCAppBarViewController AppBarViewControllerForViewController (UIViewController viewController);
}
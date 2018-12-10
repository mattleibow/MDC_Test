using Foundation;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDMTransitionNavigationControllerDelegate
{
    // +(instancetype _Nonnull)sharedInstance;
    [Static]
    [Export ("sharedInstance")]
    MDMTransitionNavigationControllerDelegate SharedInstance ();

    // +(id<UINavigationControllerDelegate> _Nonnull)sharedDelegate;
    [Static]
    [Export ("sharedDelegate")]
    [Verify (MethodToProperty)]
    UINavigationControllerDelegate SharedDelegate { get; }

    // -(id<UIViewControllerAnimatedTransitioning> _Nullable)navigationController:(UINavigationController * _Nonnull)navigationController animationControllerForOperation:(UINavigationControllerOperation)operation fromViewController:(UIViewController * _Nonnull)fromVC toViewController:(UIViewController * _Nonnull)toVC;
    [Export ("navigationController:animationControllerForOperation:fromViewController:toViewController:")]
    [return: NullAllowed]
    UIViewControllerAnimatedTransitioning NavigationController (UINavigationController navigationController, UINavigationControllerOperation operation, UIViewController fromVC, UIViewController toVC);

    // -(id<UIViewControllerInteractiveTransitioning> _Nullable)navigationController:(UINavigationController * _Nonnull)navigationController interactionControllerForAnimationController:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animationController;
    [Export ("navigationController:interactionControllerForAnimationController:")]
    [return: NullAllowed]
    UIViewControllerInteractiveTransitioning NavigationController (UINavigationController navigationController, UIViewControllerAnimatedTransitioning animationController);
}
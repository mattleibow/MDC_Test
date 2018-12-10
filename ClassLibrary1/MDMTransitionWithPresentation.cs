using Foundation;
using UIKit;

[Protocol, Model]
interface MDMTransitionWithPresentation : IMDMTransition
{
    // @required -(UIModalPresentationStyle)defaultModalPresentationStyle;
    [Abstract]
    [Export ("defaultModalPresentationStyle")]
    [Verify (MethodToProperty)]
    UIModalPresentationStyle DefaultModalPresentationStyle { get; }

    // @required -(UIPresentationController * _Nullable)presentationControllerForPresentedViewController:(UIViewController * _Nonnull)presented presentingViewController:(UIViewController * _Nonnull)presenting sourceViewController:(UIViewController * _Nullable)source;
    [Abstract]
    [Export ("presentationControllerForPresentedViewController:presentingViewController:sourceViewController:")]
    [return: NullAllowed]
    UIPresentationController PresentingViewController (UIViewController presented, UIViewController presenting, [NullAllowed] UIViewController source);
}
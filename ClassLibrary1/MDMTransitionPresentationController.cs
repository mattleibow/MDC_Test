using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIPresentationController))]
interface MDMTransitionPresentationController
{
    // -(instancetype _Nonnull)initWithPresentedViewController:(UIViewController * _Nonnull)presentedViewController presentingViewController:(UIViewController * _Nonnull)presentingViewController calculateFrameOfPresentedView:(MDMTransitionFrameCalculation _Nullable)calculateFrameOfPresentedView __attribute__((objc_designated_initializer));
    [Export ("initWithPresentedViewController:presentingViewController:calculateFrameOfPresentedView:")]
    [DesignatedInitializer]
    IntPtr Constructor (UIViewController presentedViewController, UIViewController presentingViewController, [NullAllowed] MDMTransitionFrameCalculation calculateFrameOfPresentedView);

    // @property (readonly, nonatomic, strong) UIView * _Nullable scrimView;
    [NullAllowed, Export ("scrimView", ArgumentSemantic.Strong)]
    UIView ScrimView { get; }

    // @property (nonatomic, strong) id<MDMTransitionPresentationAnimationControlling> _Nullable animationController;
    [NullAllowed, Export ("animationController", ArgumentSemantic.Strong)]
    MDMTransitionPresentationAnimationControlling AnimationController { get; set; }
}
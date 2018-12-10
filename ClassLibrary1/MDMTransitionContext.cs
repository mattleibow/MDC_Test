using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[Protocol, Model]
interface MDMTransitionContext
{
    // @required -(void)transitionDidEnd;
    [Abstract]
    [Export ("transitionDidEnd")]
    void TransitionDidEnd ();

    // @required @property (readonly, nonatomic) MDMTransitionDirection direction;
    [Abstract]
    [Export ("direction")]
    MDMTransitionDirection Direction { get; }

    // @required @property (readonly, nonatomic) NSTimeInterval duration;
    [Abstract]
    [Export ("duration")]
    double Duration { get; }

    // @required @property (readonly, nonatomic, strong) UIViewController * _Nullable sourceViewController;
    [Abstract]
    [NullAllowed, Export ("sourceViewController", ArgumentSemantic.Strong)]
    UIViewController SourceViewController { get; }

    // @required @property (readonly, nonatomic, strong) UIViewController * _Nonnull backViewController;
    [Abstract]
    [Export ("backViewController", ArgumentSemantic.Strong)]
    UIViewController BackViewController { get; }

    // @required @property (readonly, nonatomic, strong) UIViewController * _Nonnull foreViewController;
    [Abstract]
    [Export ("foreViewController", ArgumentSemantic.Strong)]
    UIViewController ForeViewController { get; }

    // @required @property (readonly, nonatomic, strong) UIView * _Nonnull containerView;
    [Abstract]
    [Export ("containerView", ArgumentSemantic.Strong)]
    UIView ContainerView { get; }

    // @required @property (readonly, nonatomic, strong) UIPresentationController * _Nullable presentationController;
    [Abstract]
    [NullAllowed, Export ("presentationController", ArgumentSemantic.Strong)]
    UIPresentationController PresentationController { get; }

    // @required -(void)composeWithTransition:(id<MDMTransition> _Nonnull)transition;
    [Abstract]
    [Export ("composeWithTransition:")]
    void ComposeWithTransition (MDMTransition transition);

    // @required -(void)deferToCompletion:(void (^ _Nonnull)(void))work;
    [Abstract]
    [Export ("deferToCompletion:")]
    void DeferToCompletion (Action work);
}
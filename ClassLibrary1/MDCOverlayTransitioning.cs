using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCOverlayTransitioning
{
    // @required @property (readonly, nonatomic) NSTimeInterval duration;
    [Abstract]
    [Export ("duration")]
    double Duration { get; }

    // @required @property (readonly, nonatomic) CAMediaTimingFunction * customTimingFunction;
    [Abstract]
    [Export ("customTimingFunction")]
    CAMediaTimingFunction CustomTimingFunction { get; }

    // @required @property (readonly, nonatomic) UIViewAnimationCurve animationCurve;
    [Abstract]
    [Export ("animationCurve")]
    UIViewAnimationCurve AnimationCurve { get; }

    // @required @property (readonly, nonatomic) CGRect compositeFrame;
    [Abstract]
    [Export ("compositeFrame")]
    CGRect CompositeFrame { get; }

    // @required -(CGRect)compositeFrameInView:(UIView *)targetView;
    [Abstract]
    [Export ("compositeFrameInView:")]
    CGRect CompositeFrameInView (UIView targetView);

    // @required -(void)enumerateOverlays:(void (^)(id<MDCOverlay>, NSUInteger, BOOL *))handler;
    [Abstract]
    [Export ("enumerateOverlays:")]
    unsafe void EnumerateOverlays (Action<MDCOverlay, nuint, bool*> handler);

    // @required -(void)animateAlongsideTransition:(void (^)(void))animations;
    [Abstract]
    [Export ("animateAlongsideTransition:")]
    void AnimateAlongsideTransition (Action animations);

    // @required -(void)animateAlongsideTransitionWithOptions:(UIViewAnimationOptions)options animations:(void (^)(void))animations completion:(void (^)(BOOL))completion;
    [Abstract]
    [Export ("animateAlongsideTransitionWithOptions:animations:completion:")]
    void AnimateAlongsideTransitionWithOptions (UIViewAnimationOptions options, Action animations, Action<bool> completion);
}
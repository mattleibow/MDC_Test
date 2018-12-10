using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDMMotionAnimator))]
interface MDMMotionAnimator_UIKitEquivalency
{
    // +(void)animateWithDuration:(NSTimeInterval)duration animations:(void (^ _Nonnull)(void))animations;
    [Static]
    [Export ("animateWithDuration:animations:")]
    void AnimateWithDuration (double duration, Action animations);

    // +(void)animateWithDuration:(NSTimeInterval)duration animations:(void (^ _Nonnull)(void))animations completion:(void (^ _Nullable)(BOOL))completion;
    [Static]
    [Export ("animateWithDuration:animations:completion:")]
    void AnimateWithDuration (double duration, Action animations, [NullAllowed] Action<bool> completion);

    // +(void)animateWithDuration:(NSTimeInterval)duration delay:(NSTimeInterval)delay options:(UIViewAnimationOptions)options animations:(void (^ _Nonnull)(void))animations completion:(void (^ _Nullable)(BOOL))completion;
    [Static]
    [Export ("animateWithDuration:delay:options:animations:completion:")]
    void AnimateWithDuration (double duration, double delay, UIViewAnimationOptions options, Action animations, [NullAllowed] Action<bool> completion);

    // +(void)animateWithDuration:(NSTimeInterval)duration delay:(NSTimeInterval)delay usingSpringWithDamping:(CGFloat)dampingRatio initialSpringVelocity:(CGFloat)velocity options:(UIViewAnimationOptions)options animations:(void (^ _Nonnull)(void))animations completion:(void (^ _Nullable)(BOOL))completion;
    [Static]
    [Export ("animateWithDuration:delay:usingSpringWithDamping:initialSpringVelocity:options:animations:completion:")]
    void AnimateWithDuration (double duration, double delay, nfloat dampingRatio, nfloat velocity, UIViewAnimationOptions options, Action animations, [NullAllowed] Action<bool> completion);
}
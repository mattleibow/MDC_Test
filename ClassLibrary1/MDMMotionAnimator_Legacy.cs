using System;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDMMotionAnimator))]
interface MDMMotionAnimator_Legacy
{
    // -(void)animateWithTiming:(MDMMotionTiming)timing toLayer:(CALayer * _Nonnull)layer withValues:(NSArray * _Nonnull)values keyPath:(MDMAnimatableKeyPath _Nonnull)keyPath;
    [Export ("animateWithTiming:toLayer:withValues:keyPath:")]
    [Verify (StronglyTypedNSArray)]
    void AnimateWithTiming (MDMMotionTiming timing, CALayer layer, NSObject[] values, string keyPath);

    // -(void)animateWithTiming:(MDMMotionTiming)timing toLayer:(CALayer * _Nonnull)layer withValues:(NSArray * _Nonnull)values keyPath:(MDMAnimatableKeyPath _Nonnull)keyPath completion:(void (^ _Nullable)(void))completion;
    [Export ("animateWithTiming:toLayer:withValues:keyPath:completion:")]
    [Verify (StronglyTypedNSArray)]
    void AnimateWithTiming (MDMMotionTiming timing, CALayer layer, NSObject[] values, string keyPath, [NullAllowed] Action completion);

    // -(void)animateWithTiming:(MDMMotionTiming)timing animations:(void (^ _Nonnull)(void))animations;
    [Export ("animateWithTiming:animations:")]
    void AnimateWithTiming (MDMMotionTiming timing, Action animations);

    // -(void)animateWithTiming:(MDMMotionTiming)timing animations:(void (^ _Nonnull)(void))animations completion:(void (^ _Nullable)(void))completion;
    [Export ("animateWithTiming:animations:completion:")]
    void AnimateWithTiming (MDMMotionTiming timing, Action animations, [NullAllowed] Action completion);
}
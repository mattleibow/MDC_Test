using System;
using CoreAnimation;
using Foundation;

[BaseType (typeof(NSObject))]
interface MDMMotionAnimator : IMDMCoreAnimationTraceable
{
    // @property (assign, nonatomic) CGFloat timeScaleFactor;
    [Export ("timeScaleFactor")]
    nfloat TimeScaleFactor { get; set; }

    // @property (assign, nonatomic) BOOL beginFromCurrentState;
    [Export ("beginFromCurrentState")]
    bool BeginFromCurrentState { get; set; }

    // @property (assign, nonatomic) BOOL additive;
    [Export ("additive")]
    bool Additive { get; set; }

    // -(void)animateWithTraits:(MDMAnimationTraits * _Nonnull)traits between:(NSArray * _Nonnull)values layer:(CALayer * _Nonnull)layer keyPath:(MDMAnimatableKeyPath _Nonnull)keyPath;
    [Export ("animateWithTraits:between:layer:keyPath:")]
    [Verify (StronglyTypedNSArray)]
    void AnimateWithTraits (MDMAnimationTraits traits, NSObject[] values, CALayer layer, string keyPath);

    // -(void)animateWithTraits:(MDMAnimationTraits * _Nonnull)traits between:(NSArray * _Nonnull)values layer:(CALayer * _Nonnull)layer keyPath:(MDMAnimatableKeyPath _Nonnull)keyPath completion:(void (^ _Nullable)(BOOL))completion;
    [Export ("animateWithTraits:between:layer:keyPath:completion:")]
    [Verify (StronglyTypedNSArray)]
    void AnimateWithTraits (MDMAnimationTraits traits, NSObject[] values, CALayer layer, string keyPath, [NullAllowed] Action<bool> completion);

    // @property (assign, nonatomic) BOOL shouldReverseValues;
    [Export ("shouldReverseValues")]
    bool ShouldReverseValues { get; set; }

    // -(void)animateWithTraits:(MDMAnimationTraits * _Nonnull)traits animations:(void (^ _Nonnull)(void))animations;
    [Export ("animateWithTraits:animations:")]
    void AnimateWithTraits (MDMAnimationTraits traits, Action animations);

    // -(void)animateWithTraits:(MDMAnimationTraits * _Nonnull)traits animations:(void (^ _Nonnull)(void))animations completion:(void (^ _Nullable)(BOOL))completion;
    [Export ("animateWithTraits:animations:completion:")]
    void AnimateWithTraits (MDMAnimationTraits traits, Action animations, [NullAllowed] Action<bool> completion);

    // -(void)removeAllAnimations;
    [Export ("removeAllAnimations")]
    void RemoveAllAnimations ();

    // -(void)stopAllAnimations;
    [Export ("stopAllAnimations")]
    void StopAllAnimations ();
}
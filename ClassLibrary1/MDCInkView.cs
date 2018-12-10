using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCInkView
{
    [Wrap ("WeakAnimationDelegate")]
    [NullAllowed]
    MDCInkViewDelegate AnimationDelegate { get; set; }

    // @property (nonatomic, weak) id<MDCInkViewDelegate> _Nullable animationDelegate;
    [NullAllowed, Export ("animationDelegate", ArgumentSemantic.Weak)]
    NSObject WeakAnimationDelegate { get; set; }

    // @property (assign, nonatomic) MDCInkStyle inkStyle;
    [Export ("inkStyle", ArgumentSemantic.Assign)]
    MDCInkStyle InkStyle { get; set; }

    // @property (nonatomic, strong) UIColor * _Nonnull inkColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("inkColor", ArgumentSemantic.Strong)]
    UIColor InkColor { get; set; }

    // @property (readonly, nonatomic, strong) UIColor * _Nonnull defaultInkColor;
    [Export ("defaultInkColor", ArgumentSemantic.Strong)]
    UIColor DefaultInkColor { get; }

    // @property (assign, nonatomic) CGFloat maxRippleRadius;
    [Export ("maxRippleRadius")]
    nfloat MaxRippleRadius { get; set; }

    // @property (assign, nonatomic) BOOL usesLegacyInkRipple;
    [Export ("usesLegacyInkRipple")]
    bool UsesLegacyInkRipple { get; set; }

    // @property (assign, nonatomic) BOOL usesCustomInkCenter;
    [Export ("usesCustomInkCenter")]
    bool UsesCustomInkCenter { get; set; }

    // @property (assign, nonatomic) CGPoint customInkCenter;
    [Export ("customInkCenter", ArgumentSemantic.Assign)]
    CGPoint CustomInkCenter { get; set; }

    // -(void)startTouchBeganAnimationAtPoint:(CGPoint)point completion:(MDCInkCompletionBlock _Nullable)completionBlock;
    [Export ("startTouchBeganAnimationAtPoint:completion:")]
    void StartTouchBeganAnimationAtPoint (CGPoint point, [NullAllowed] MDCInkCompletionBlock completionBlock);

    // -(void)startTouchEndedAnimationAtPoint:(CGPoint)point completion:(MDCInkCompletionBlock _Nullable)completionBlock;
    [Export ("startTouchEndedAnimationAtPoint:completion:")]
    void StartTouchEndedAnimationAtPoint (CGPoint point, [NullAllowed] MDCInkCompletionBlock completionBlock);

    // -(void)cancelAllAnimationsAnimated:(BOOL)animated;
    [Export ("cancelAllAnimationsAnimated:")]
    void CancelAllAnimationsAnimated (bool animated);

    // -(void)startTouchBeganAtPoint:(CGPoint)point animated:(BOOL)animated withCompletion:(MDCInkCompletionBlock _Nullable)completionBlock;
    [Export ("startTouchBeganAtPoint:animated:withCompletion:")]
    void StartTouchBeganAtPoint (CGPoint point, bool animated, [NullAllowed] MDCInkCompletionBlock completionBlock);

    // -(void)startTouchEndAtPoint:(CGPoint)point animated:(BOOL)animated withCompletion:(MDCInkCompletionBlock _Nullable)completionBlock;
    [Export ("startTouchEndAtPoint:animated:withCompletion:")]
    void StartTouchEndAtPoint (CGPoint point, bool animated, [NullAllowed] MDCInkCompletionBlock completionBlock);

    // +(MDCInkView * _Nonnull)injectedInkViewForView:(UIView * _Nonnull)view;
    [Static]
    [Export ("injectedInkViewForView:")]
    MDCInkView InjectedInkViewForView (UIView view);
}
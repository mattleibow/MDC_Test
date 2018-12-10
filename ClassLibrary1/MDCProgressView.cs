using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCProgressView
{
    // @property (nonatomic, strong) UIColor * _Null_unspecified progressTintColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("progressTintColor", ArgumentSemantic.Strong)]
    UIColor ProgressTintColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified trackTintColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("trackTintColor", ArgumentSemantic.Strong)]
    UIColor TrackTintColor { get; set; }

    // @property (assign, nonatomic) float progress;
    [Export ("progress")]
    float Progress { get; set; }

    // @property (assign, nonatomic) MDCProgressViewBackwardAnimationMode backwardProgressAnimationMode;
    [Export ("backwardProgressAnimationMode", ArgumentSemantic.Assign)]
    MDCProgressViewBackwardAnimationMode BackwardProgressAnimationMode { get; set; }

    // -(void)setProgress:(float)progress animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
    [Export ("setProgress:animated:completion:")]
    void SetProgress (float progress, bool animated, [NullAllowed] Action<bool> completion);

    // -(void)setHidden:(BOOL)hidden animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
    [Export ("setHidden:animated:completion:")]
    void SetHidden (bool hidden, bool animated, [NullAllowed] Action<bool> completion);
}
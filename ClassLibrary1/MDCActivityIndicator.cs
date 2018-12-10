using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCActivityIndicator
{
    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCActivityIndicatorDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCActivityIndicatorDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (getter = isAnimating, assign, nonatomic) BOOL animating;
    [Export ("animating")]
    bool Animating { [Bind ("isAnimating")] get; set; }

    // @property (assign, nonatomic) CGFloat radius __attribute__((annotate("ui_appearance_selector")));
    [Export ("radius")]
    nfloat Radius { get; set; }

    // @property (assign, nonatomic) CGFloat strokeWidth __attribute__((annotate("ui_appearance_selector")));
    [Export ("strokeWidth")]
    nfloat StrokeWidth { get; set; }

    // @property (assign, nonatomic) BOOL trackEnabled;
    [Export ("trackEnabled")]
    bool TrackEnabled { get; set; }

    // @property (assign, nonatomic) MDCActivityIndicatorMode indicatorMode;
    [Export ("indicatorMode", ArgumentSemantic.Assign)]
    MDCActivityIndicatorMode IndicatorMode { get; set; }

    // -(void)setIndicatorMode:(MDCActivityIndicatorMode)mode animated:(BOOL)animated;
    [Export ("setIndicatorMode:animated:")]
    void SetIndicatorMode (MDCActivityIndicatorMode mode, bool animated);

    // @property (assign, nonatomic) float progress;
    [Export ("progress")]
    float Progress { get; set; }

    // -(void)setProgress:(float)progress animated:(BOOL)animated;
    [Export ("setProgress:animated:")]
    void SetProgress (float progress, bool animated);

    // @property (copy, nonatomic) NSArray<UIColor *> * _Nonnull cycleColors __attribute__((annotate("ui_appearance_selector")));
    [Export ("cycleColors", ArgumentSemantic.Copy)]
    UIColor[] CycleColors { get; set; }

    // -(void)startAnimating;
    [Export ("startAnimating")]
    void StartAnimating ();

    // -(void)startAnimatingWithTransition:(MDCActivityIndicatorTransition * _Nonnull)startTransition cycleStartIndex:(NSInteger)cycleStartIndex;
    [Export ("startAnimatingWithTransition:cycleStartIndex:")]
    void StartAnimatingWithTransition (MDCActivityIndicatorTransition startTransition, nint cycleStartIndex);

    // -(void)stopAnimating;
    [Export ("stopAnimating")]
    void StopAnimating ();

    // -(void)stopAnimatingWithTransition:(MDCActivityIndicatorTransition * _Nonnull)stopTransition;
    [Export ("stopAnimatingWithTransition:")]
    void StopAnimatingWithTransition (MDCActivityIndicatorTransition stopTransition);
}
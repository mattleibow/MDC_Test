using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCFlexibleHeaderView
{
    // @property (nonatomic, strong) CALayer * _Nullable shadowLayer;
    [NullAllowed, Export ("shadowLayer", ArgumentSemantic.Strong)]
    CALayer ShadowLayer { get; set; }

    // -(void)setShadowLayer:(CALayer * _Nonnull)shadowLayer intensityDidChangeBlock:(MDCFlexibleHeaderShadowIntensityChangeBlock _Nonnull)block;
    [Export ("setShadowLayer:intensityDidChangeBlock:")]
    void SetShadowLayer (CALayer shadowLayer, MDCFlexibleHeaderShadowIntensityChangeBlock block);

    // -(void)trackingScrollViewDidScroll;
    [Export ("trackingScrollViewDidScroll")]
    void TrackingScrollViewDidScroll ();

    // -(void)trackingScrollWillChangeToScrollView:(UIScrollView * _Nullable)scrollView;
    [Export ("trackingScrollWillChangeToScrollView:")]
    void TrackingScrollWillChangeToScrollView ([NullAllowed] UIScrollView scrollView);

    // @property (readonly, nonatomic) BOOL prefersStatusBarHidden;
    [Export ("prefersStatusBarHidden")]
    bool PrefersStatusBarHidden { get; }

    // -(void)interfaceOrientationWillChange;
    [Export ("interfaceOrientationWillChange")]
    void InterfaceOrientationWillChange ();

    // -(void)interfaceOrientationIsChanging;
    [Export ("interfaceOrientationIsChanging")]
    void InterfaceOrientationIsChanging ();

    // -(void)interfaceOrientationDidChange;
    [Export ("interfaceOrientationDidChange")]
    void InterfaceOrientationDidChange ();

    // -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
    [Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
    void ViewWillTransitionToSize (CGSize size, UIViewControllerTransitionCoordinator coordinator);

    // -(void)changeContentInsets:(MDCFlexibleHeaderChangeContentInsetsBlock _Nonnull)block;
    [Export ("changeContentInsets:")]
    void ChangeContentInsets (MDCFlexibleHeaderChangeContentInsetsBlock block);

    // -(void)forwardTouchEventsForView:(UIView * _Nonnull)view;
    [Export ("forwardTouchEventsForView:")]
    void ForwardTouchEventsForView (UIView view);

    // -(void)stopForwardingTouchEventsForView:(UIView * _Nonnull)view;
    [Export ("stopForwardingTouchEventsForView:")]
    void StopForwardingTouchEventsForView (UIView view);

    // @property (readonly, nonatomic) MDCFlexibleHeaderScrollPhase scrollPhase;
    [Export ("scrollPhase")]
    MDCFlexibleHeaderScrollPhase ScrollPhase { get; }

    // @property (readonly, nonatomic) CGFloat scrollPhaseValue;
    [Export ("scrollPhaseValue")]
    nfloat ScrollPhaseValue { get; }

    // @property (readonly, nonatomic) CGFloat scrollPhasePercentage;
    [Export ("scrollPhasePercentage")]
    nfloat ScrollPhasePercentage { get; }

    // @property (nonatomic) CGFloat minimumHeight;
    [Export ("minimumHeight")]
    nfloat MinimumHeight { get; set; }

    // @property (nonatomic) CGFloat maximumHeight;
    [Export ("maximumHeight")]
    nfloat MaximumHeight { get; set; }

    // @property (nonatomic) BOOL minMaxHeightIncludesSafeArea;
    [Export ("minMaxHeightIncludesSafeArea")]
    bool MinMaxHeightIncludesSafeArea { get; set; }

    // @property (readonly, nonatomic) id _Nonnull topSafeAreaGuide;
    [Export ("topSafeAreaGuide")]
    NSObject TopSafeAreaGuide { get; }

    // @property (nonatomic) BOOL canOverExtend;
    [Export ("canOverExtend")]
    bool CanOverExtend { get; set; }

    // @property (nonatomic) float visibleShadowOpacity;
    [Export ("visibleShadowOpacity")]
    float VisibleShadowOpacity { get; set; }

    // @property (nonatomic) BOOL resetShadowAfterTrackingScrollViewIsReset;
    [Export ("resetShadowAfterTrackingScrollViewIsReset")]
    bool ResetShadowAfterTrackingScrollViewIsReset { get; set; }

    // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
    [NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
    UIScrollView TrackingScrollView { get; set; }

    // @property (nonatomic) BOOL observesTrackingScrollViewScrollEvents;
    [Export ("observesTrackingScrollViewScrollEvents")]
    bool ObservesTrackingScrollViewScrollEvents { get; set; }

    // @property (getter = isInFrontOfInfiniteContent, nonatomic) BOOL inFrontOfInfiniteContent;
    [Export ("inFrontOfInfiniteContent")]
    bool InFrontOfInfiniteContent { [Bind ("isInFrontOfInfiniteContent")] get; set; }

    // @property (nonatomic) BOOL sharedWithManyScrollViews;
    [Export ("sharedWithManyScrollViews")]
    bool SharedWithManyScrollViews { get; set; }

    // @property (nonatomic) BOOL disableContentInsetAdjustmentWhenContentInsetAdjustmentBehaviorIsNever __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
    [TV (11, 0), iOS (11, 0)]
    [Export ("disableContentInsetAdjustmentWhenContentInsetAdjustmentBehaviorIsNever")]
    bool DisableContentInsetAdjustmentWhenContentInsetAdjustmentBehaviorIsNever { get; set; }

    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCFlexibleHeaderViewDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCFlexibleHeaderViewDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }
}
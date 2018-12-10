using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIControl))]
interface MDCThumbTrack
{
    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCThumbTrackDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCThumbTrackDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified thumbEnabledColor;
    [Export ("thumbEnabledColor", ArgumentSemantic.Strong)]
    UIColor ThumbEnabledColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable thumbDisabledColor;
    [NullAllowed, Export ("thumbDisabledColor", ArgumentSemantic.Strong)]
    UIColor ThumbDisabledColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified trackOnColor;
    [Export ("trackOnColor", ArgumentSemantic.Strong)]
    UIColor TrackOnColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable trackOffColor;
    [NullAllowed, Export ("trackOffColor", ArgumentSemantic.Strong)]
    UIColor TrackOffColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable trackDisabledColor;
    [NullAllowed, Export ("trackDisabledColor", ArgumentSemantic.Strong)]
    UIColor TrackDisabledColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable trackOnTickColor;
    [NullAllowed, Export ("trackOnTickColor", ArgumentSemantic.Strong)]
    UIColor TrackOnTickColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable trackOffTickColor;
    [NullAllowed, Export ("trackOffTickColor", ArgumentSemantic.Strong)]
    UIColor TrackOffTickColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable inkColor;
    [NullAllowed, Export ("inkColor", ArgumentSemantic.Strong)]
    UIColor InkColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified valueLabelTextColor;
    [Export ("valueLabelTextColor", ArgumentSemantic.Strong)]
    UIColor ValueLabelTextColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified valueLabelBackgroundColor;
    [Export ("valueLabelBackgroundColor", ArgumentSemantic.Strong)]
    UIColor ValueLabelBackgroundColor { get; set; }

    // @property (assign, nonatomic) NSUInteger numDiscreteValues;
    [Export ("numDiscreteValues")]
    nuint NumDiscreteValues { get; set; }

    // @property (assign, nonatomic) CGFloat value;
    [Export ("value")]
    nfloat Value { get; set; }

    // @property (assign, nonatomic) CGFloat minimumValue;
    [Export ("minimumValue")]
    nfloat MinimumValue { get; set; }

    // @property (assign, nonatomic) CGFloat maximumValue;
    [Export ("maximumValue")]
    nfloat MaximumValue { get; set; }

    // @property (readonly, assign, nonatomic) CGPoint thumbPosition;
    [Export ("thumbPosition", ArgumentSemantic.Assign)]
    CGPoint ThumbPosition { get; }

    // @property (assign, nonatomic) CGFloat trackHeight;
    [Export ("trackHeight")]
    nfloat TrackHeight { get; set; }

    // @property (assign, nonatomic) CGFloat thumbRadius;
    [Export ("thumbRadius")]
    nfloat ThumbRadius { get; set; }

    // @property (assign, nonatomic) MDCShadowElevation thumbElevation;
    [Export ("thumbElevation")]
    double ThumbElevation { get; set; }

    // @property (assign, nonatomic) BOOL thumbIsSmallerWhenDisabled;
    [Export ("thumbIsSmallerWhenDisabled")]
    bool ThumbIsSmallerWhenDisabled { get; set; }

    // @property (assign, nonatomic) BOOL thumbIsHollowAtStart;
    [Export ("thumbIsHollowAtStart")]
    bool ThumbIsHollowAtStart { get; set; }

    // @property (assign, nonatomic) BOOL thumbGrowsWhenDragging;
    [Export ("thumbGrowsWhenDragging")]
    bool ThumbGrowsWhenDragging { get; set; }

    // @property (assign, nonatomic) CGFloat thumbMaxRippleRadius;
    [Export ("thumbMaxRippleRadius")]
    nfloat ThumbMaxRippleRadius { get; set; }

    // @property (assign, nonatomic) BOOL shouldDisplayInk;
    [Export ("shouldDisplayInk")]
    bool ShouldDisplayInk { get; set; }

    // @property (assign, nonatomic) BOOL shouldDisplayDiscreteDots;
    [Export ("shouldDisplayDiscreteDots")]
    bool ShouldDisplayDiscreteDots { get; set; }

    // @property (assign, nonatomic) BOOL shouldDisplayDiscreteValueLabel;
    [Export ("shouldDisplayDiscreteValueLabel")]
    bool ShouldDisplayDiscreteValueLabel { get; set; }

    // @property (assign, nonatomic) BOOL shouldDisplayFilledTrack;
    [Export ("shouldDisplayFilledTrack")]
    bool ShouldDisplayFilledTrack { get; set; }

    // @property (assign, nonatomic) BOOL disabledTrackHasThumbGaps;
    [Export ("disabledTrackHasThumbGaps")]
    bool DisabledTrackHasThumbGaps { get; set; }

    // @property (assign, nonatomic) BOOL trackEndsAreRounded;
    [Export ("trackEndsAreRounded")]
    bool TrackEndsAreRounded { get; set; }

    // @property (assign, nonatomic) BOOL trackEndsAreInset;
    [Export ("trackEndsAreInset")]
    bool TrackEndsAreInset { get; set; }

    // @property (assign, nonatomic) CGFloat filledTrackAnchorValue;
    [Export ("filledTrackAnchorValue")]
    nfloat FilledTrackAnchorValue { get; set; }

    // @property (nonatomic, strong) MDCThumbView * _Nullable thumbView;
    [NullAllowed, Export ("thumbView", ArgumentSemantic.Strong)]
    MDCThumbView ThumbView { get; set; }

    // @property (assign, nonatomic) BOOL continuousUpdateEvents;
    [Export ("continuousUpdateEvents")]
    bool ContinuousUpdateEvents { get; set; }

    // @property (assign, nonatomic) BOOL panningAllowedOnEntireControl;
    [Export ("panningAllowedOnEntireControl")]
    bool PanningAllowedOnEntireControl { get; set; }

    // @property (assign, nonatomic) BOOL tapsAllowedOnThumb;
    [Export ("tapsAllowedOnThumb")]
    bool TapsAllowedOnThumb { get; set; }

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame onTintColor:(UIColor * _Nullable)onTintColor;
    [Export ("initWithFrame:onTintColor:")]
    IntPtr Constructor (CGRect frame, [NullAllowed] UIColor onTintColor);

    // -(void)setValue:(CGFloat)value animated:(BOOL)animated;
    [Export ("setValue:animated:")]
    void SetValue (nfloat value, bool animated);

    // -(void)setValue:(CGFloat)value animated:(BOOL)animated animateThumbAfterMove:(BOOL)animateThumbAfterMove userGenerated:(BOOL)userGenerated completion:(void (^ _Nullable)(void))completion;
    [Export ("setValue:animated:animateThumbAfterMove:userGenerated:completion:")]
    void SetValue (nfloat value, bool animated, bool animateThumbAfterMove, bool userGenerated, [NullAllowed] Action completion);

    // -(void)setIcon:(UIImage * _Nullable)icon;
    [Export ("setIcon:")]
    void SetIcon ([NullAllowed] UIImage icon);

    // @property (nonatomic, strong) UIColor * _Nullable primaryColor;
    [NullAllowed, Export ("primaryColor", ArgumentSemantic.Strong)]
    UIColor PrimaryColor { get; set; }
}
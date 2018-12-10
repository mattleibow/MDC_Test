using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIControl))]
interface MDCSlider
{
    // @property (getter = isStatefulAPIEnabled, assign, nonatomic) BOOL statefulAPIEnabled;
    [Export ("statefulAPIEnabled")]
    bool StatefulAPIEnabled { [Bind ("isStatefulAPIEnabled")] get; set; }

    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCSliderDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCSliderDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // -(void)setThumbColor:(UIColor * _Nullable)thumbColor forState:(UIControlState)state;
    [Export ("setThumbColor:forState:")]
    void SetThumbColor ([NullAllowed] UIColor thumbColor, UIControlState state);

    // -(UIColor * _Nullable)thumbColorForState:(UIControlState)state;
    [Export ("thumbColorForState:")]
    [return: NullAllowed]
    UIColor ThumbColorForState (UIControlState state);

    // -(void)setTrackFillColor:(UIColor * _Nullable)fillColor forState:(UIControlState)state;
    [Export ("setTrackFillColor:forState:")]
    void SetTrackFillColor ([NullAllowed] UIColor fillColor, UIControlState state);

    // -(UIColor * _Nullable)trackFillColorForState:(UIControlState)state;
    [Export ("trackFillColorForState:")]
    [return: NullAllowed]
    UIColor TrackFillColorForState (UIControlState state);

    // -(void)setTrackBackgroundColor:(UIColor * _Nullable)backgroundColor forState:(UIControlState)state;
    [Export ("setTrackBackgroundColor:forState:")]
    void SetTrackBackgroundColor ([NullAllowed] UIColor backgroundColor, UIControlState state);

    // -(UIColor * _Nullable)trackBackgroundColorForState:(UIControlState)state;
    [Export ("trackBackgroundColorForState:")]
    [return: NullAllowed]
    UIColor TrackBackgroundColorForState (UIControlState state);

    // -(void)setFilledTrackTickColor:(UIColor * _Nullable)tickColor forState:(UIControlState)state;
    [Export ("setFilledTrackTickColor:forState:")]
    void SetFilledTrackTickColor ([NullAllowed] UIColor tickColor, UIControlState state);

    // -(UIColor * _Nullable)filledTrackTickColorForState:(UIControlState)state;
    [Export ("filledTrackTickColorForState:")]
    [return: NullAllowed]
    UIColor FilledTrackTickColorForState (UIControlState state);

    // -(void)setBackgroundTrackTickColor:(UIColor * _Nullable)tickColor forState:(UIControlState)state;
    [Export ("setBackgroundTrackTickColor:forState:")]
    void SetBackgroundTrackTickColor ([NullAllowed] UIColor tickColor, UIControlState state);

    // -(UIColor * _Nullable)backgroundTrackTickColorForState:(UIControlState)state;
    [Export ("backgroundTrackTickColorForState:")]
    [return: NullAllowed]
    UIColor BackgroundTrackTickColorForState (UIControlState state);

    // @property (nonatomic, strong) UIColor * _Nullable inkColor;
    [NullAllowed, Export ("inkColor", ArgumentSemantic.Strong)]
    UIColor InkColor { get; set; }

    // @property (assign, nonatomic) CGFloat thumbRadius __attribute__((annotate("ui_appearance_selector")));
    [Export ("thumbRadius")]
    nfloat ThumbRadius { get; set; }

    // @property (assign, nonatomic) MDCShadowElevation thumbElevation __attribute__((annotate("ui_appearance_selector")));
    [Export ("thumbElevation")]
    double ThumbElevation { get; set; }

    // @property (assign, nonatomic) NSUInteger numberOfDiscreteValues;
    [Export ("numberOfDiscreteValues")]
    nuint NumberOfDiscreteValues { get; set; }

    // @property (assign, nonatomic) CGFloat value;
    [Export ("value")]
    nfloat Value { get; set; }

    // -(void)setValue:(CGFloat)value animated:(BOOL)animated;
    [Export ("setValue:animated:")]
    void SetValue (nfloat value, bool animated);

    // @property (assign, nonatomic) CGFloat minimumValue;
    [Export ("minimumValue")]
    nfloat MinimumValue { get; set; }

    // @property (assign, nonatomic) CGFloat maximumValue;
    [Export ("maximumValue")]
    nfloat MaximumValue { get; set; }

    // @property (getter = isContinuous, assign, nonatomic) BOOL continuous;
    [Export ("continuous")]
    bool Continuous { [Bind ("isContinuous")] get; set; }

    // @property (assign, nonatomic) CGFloat filledTrackAnchorValue;
    [Export ("filledTrackAnchorValue")]
    nfloat FilledTrackAnchorValue { get; set; }

    // @property (assign, nonatomic) BOOL shouldDisplayDiscreteValueLabel;
    [Export ("shouldDisplayDiscreteValueLabel")]
    bool ShouldDisplayDiscreteValueLabel { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified valueLabelTextColor;
    [Export ("valueLabelTextColor", ArgumentSemantic.Strong)]
    UIColor ValueLabelTextColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified valueLabelBackgroundColor;
    [Export ("valueLabelBackgroundColor", ArgumentSemantic.Strong)]
    UIColor ValueLabelBackgroundColor { get; set; }

    // @property (getter = isThumbHollowAtStart, assign, nonatomic) BOOL thumbHollowAtStart;
    [Export ("thumbHollowAtStart")]
    bool ThumbHollowAtStart { [Bind ("isThumbHollowAtStart")] get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified disabledColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("disabledColor", ArgumentSemantic.Strong)]
    UIColor DisabledColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified color __attribute__((annotate("ui_appearance_selector")));
    [Export ("color", ArgumentSemantic.Strong)]
    UIColor Color { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified trackBackgroundColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("trackBackgroundColor", ArgumentSemantic.Strong)]
    UIColor TrackBackgroundColor { get; set; }
}
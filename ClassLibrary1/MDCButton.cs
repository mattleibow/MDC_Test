using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIButton))]
interface MDCButton
{
    // @property (assign, nonatomic) MDCInkStyle inkStyle __attribute__((annotate("ui_appearance_selector")));
    [Export ("inkStyle", ArgumentSemantic.Assign)]
    MDCInkStyle InkStyle { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified inkColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("inkColor", ArgumentSemantic.Strong)]
    UIColor InkColor { get; set; }

    // @property (assign, nonatomic) CGFloat inkMaxRippleRadius __attribute__((annotate("ui_appearance_selector")));
    [Export ("inkMaxRippleRadius")]
    nfloat InkMaxRippleRadius { get; set; }

    // @property (nonatomic) CGFloat disabledAlpha;
    [Export ("disabledAlpha")]
    nfloat DisabledAlpha { get; set; }

    // @property (getter = isUppercaseTitle, nonatomic) BOOL uppercaseTitle __attribute__((annotate("ui_appearance_selector")));
    [Export ("uppercaseTitle")]
    bool UppercaseTitle { [Bind ("isUppercaseTitle")] get; set; }

    // @property (nonatomic) UIEdgeInsets hitAreaInsets;
    [Export ("hitAreaInsets", ArgumentSemantic.Assign)]
    UIEdgeInsets HitAreaInsets { get; set; }

    // @property (assign, nonatomic) CGSize minimumSize __attribute__((annotate("ui_appearance_selector")));
    [Export ("minimumSize", ArgumentSemantic.Assign)]
    CGSize MinimumSize { get; set; }

    // @property (assign, nonatomic) CGSize maximumSize __attribute__((annotate("ui_appearance_selector")));
    [Export ("maximumSize", ArgumentSemantic.Assign)]
    CGSize MaximumSize { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable underlyingColorHint;
    [NullAllowed, Export ("underlyingColorHint", ArgumentSemantic.Strong)]
    UIColor UnderlyingColorHint { get; set; }

    // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }

    // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator;
    [NullAllowed, Export ("shapeGenerator", ArgumentSemantic.Strong)]
    MDCShapeGenerating ShapeGenerator { get; set; }

    // -(UIColor * _Nullable)backgroundColorForState:(UIControlState)state;
    [Export ("backgroundColorForState:")]
    [return: NullAllowed]
    UIColor BackgroundColorForState (UIControlState state);

    // -(void)setBackgroundColor:(UIColor * _Nullable)backgroundColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setBackgroundColor:forState:")]
    void SetBackgroundColor ([NullAllowed] UIColor backgroundColor, UIControlState state);

    // -(void)setBackgroundColor:(UIColor * _Nullable)backgroundColor;
    [Export ("setBackgroundColor:")]
    void SetBackgroundColor ([NullAllowed] UIColor backgroundColor);

    // -(UIFont * _Nullable)titleFontForState:(UIControlState)state;
    [Export ("titleFontForState:")]
    [return: NullAllowed]
    UIFont TitleFontForState (UIControlState state);

    // -(void)setTitleFont:(UIFont * _Nullable)font forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setTitleFont:forState:")]
    void SetTitleFont ([NullAllowed] UIFont font, UIControlState state);

    // -(void)setEnabled:(BOOL)enabled animated:(BOOL)animated;
    [Export ("setEnabled:animated:")]
    void SetEnabled (bool enabled, bool animated);

    // -(MDCShadowElevation)elevationForState:(UIControlState)state;
    [Export ("elevationForState:")]
    double ElevationForState (UIControlState state);

    // -(void)setElevation:(MDCShadowElevation)elevation forState:(UIControlState)state;
    [Export ("setElevation:forState:")]
    void SetElevation (double elevation, UIControlState state);

    // -(UIColor * _Nullable)borderColorForState:(UIControlState)state;
    [Export ("borderColorForState:")]
    [return: NullAllowed]
    UIColor BorderColorForState (UIControlState state);

    // -(void)setBorderColor:(UIColor * _Nullable)borderColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setBorderColor:forState:")]
    void SetBorderColor ([NullAllowed] UIColor borderColor, UIControlState state);

    // -(UIColor * _Nullable)imageTintColorForState:(UIControlState)state;
    [Export ("imageTintColorForState:")]
    [return: NullAllowed]
    UIColor ImageTintColorForState (UIControlState state);

    // -(void)setImageTintColor:(UIColor * _Nullable)imageTintColor forState:(UIControlState)state;
    [Export ("setImageTintColor:forState:")]
    void SetImageTintColor ([NullAllowed] UIColor imageTintColor, UIControlState state);

    // -(CGFloat)borderWidthForState:(UIControlState)state;
    [Export ("borderWidthForState:")]
    nfloat BorderWidthForState (UIControlState state);

    // -(void)setBorderWidth:(CGFloat)borderWidth forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setBorderWidth:forState:")]
    void SetBorderWidth (nfloat borderWidth, UIControlState state);

    // -(void)setShadowColor:(UIColor * _Nullable)shadowColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setShadowColor:forState:")]
    void SetShadowColor ([NullAllowed] UIColor shadowColor, UIControlState state);

    // -(UIColor * _Nullable)shadowColorForState:(UIControlState)state;
    [Export ("shadowColorForState:")]
    [return: NullAllowed]
    UIColor ShadowColorForState (UIControlState state);

    // @property (nonatomic, strong) UIColor * _Nullable customTitleColor __attribute__((deprecated("Use setTitleColor:forState: instead"))) __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("customTitleColor", ArgumentSemantic.Strong)]
    UIColor CustomTitleColor { get; set; }

    // @property (nonatomic) BOOL shouldRaiseOnTouch __attribute__((deprecated("Use MDCFlatButton instead of shouldRaiseOnTouch = NO")));
    [Export ("shouldRaiseOnTouch")]
    bool ShouldRaiseOnTouch { get; set; }

    // @property (nonatomic) BOOL shouldCapitalizeTitle __attribute__((deprecated("Use uppercaseTitle instead.")));
    [Export ("shouldCapitalizeTitle")]
    bool ShouldCapitalizeTitle { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable underlyingColor __attribute__((deprecated("Use underlyingColorHint instead.")));
    [NullAllowed, Export ("underlyingColor", ArgumentSemantic.Strong)]
    UIColor UnderlyingColor { get; set; }
}
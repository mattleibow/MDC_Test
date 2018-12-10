using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIControl))]
interface MDCChipView
{
    // @property (readonly, nonatomic) UIImageView * _Nonnull imageView;
    [Export ("imageView")]
    UIImageView ImageView { get; }

    // @property (readonly, nonatomic) UIImageView * _Nonnull selectedImageView;
    [Export ("selectedImageView")]
    UIImageView SelectedImageView { get; }

    // @property (nonatomic, strong) UIView * _Nullable accessoryView;
    [NullAllowed, Export ("accessoryView", ArgumentSemantic.Strong)]
    UIView AccessoryView { get; set; }

    // @property (readonly, nonatomic) UILabel * _Nonnull titleLabel;
    [Export ("titleLabel")]
    UILabel TitleLabel { get; }

    // @property (assign, nonatomic) UIEdgeInsets contentPadding __attribute__((annotate("ui_appearance_selector")));
    [Export ("contentPadding", ArgumentSemantic.Assign)]
    UIEdgeInsets ContentPadding { get; set; }

    // @property (assign, nonatomic) UIEdgeInsets imagePadding __attribute__((annotate("ui_appearance_selector")));
    [Export ("imagePadding", ArgumentSemantic.Assign)]
    UIEdgeInsets ImagePadding { get; set; }

    // @property (assign, nonatomic) UIEdgeInsets accessoryPadding __attribute__((annotate("ui_appearance_selector")));
    [Export ("accessoryPadding", ArgumentSemantic.Assign)]
    UIEdgeInsets AccessoryPadding { get; set; }

    // @property (assign, nonatomic) UIEdgeInsets titlePadding __attribute__((annotate("ui_appearance_selector")));
    [Export ("titlePadding", ArgumentSemantic.Assign)]
    UIEdgeInsets TitlePadding { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable titleFont __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("titleFont", ArgumentSemantic.Strong)]
    UIFont TitleFont { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified inkColor __attribute__((deprecated("Use setInkColor:forState:"))) __attribute__((annotate("ui_appearance_selector")));
    [Export ("inkColor", ArgumentSemantic.Strong)]
    UIColor InkColor { get; set; }

    // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("shapeGenerator", ArgumentSemantic.Strong)]
    MDCShapeGenerating ShapeGenerator { get; set; }

    // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }

    // @property (assign, nonatomic) CGSize minimumSize __attribute__((annotate("ui_appearance_selector")));
    [Export ("minimumSize", ArgumentSemantic.Assign)]
    CGSize MinimumSize { get; set; }

    // @property (assign, nonatomic) UIEdgeInsets hitAreaInsets;
    [Export ("hitAreaInsets", ArgumentSemantic.Assign)]
    UIEdgeInsets HitAreaInsets { get; set; }

    // -(UIColor * _Nullable)backgroundColorForState:(UIControlState)state;
    [Export ("backgroundColorForState:")]
    [return: NullAllowed]
    UIColor BackgroundColorForState (UIControlState state);

    // -(void)setBackgroundColor:(UIColor * _Nullable)backgroundColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setBackgroundColor:forState:")]
    void SetBackgroundColor ([NullAllowed] UIColor backgroundColor, UIControlState state);

    // -(UIColor * _Nullable)borderColorForState:(UIControlState)state;
    [Export ("borderColorForState:")]
    [return: NullAllowed]
    UIColor BorderColorForState (UIControlState state);

    // -(void)setBorderColor:(UIColor * _Nullable)borderColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setBorderColor:forState:")]
    void SetBorderColor ([NullAllowed] UIColor borderColor, UIControlState state);

    // -(CGFloat)borderWidthForState:(UIControlState)state;
    [Export ("borderWidthForState:")]
    nfloat BorderWidthForState (UIControlState state);

    // -(void)setBorderWidth:(CGFloat)borderWidth forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setBorderWidth:forState:")]
    void SetBorderWidth (nfloat borderWidth, UIControlState state);

    // -(MDCShadowElevation)elevationForState:(UIControlState)state;
    [Export ("elevationForState:")]
    double ElevationForState (UIControlState state);

    // -(void)setElevation:(MDCShadowElevation)elevation forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setElevation:forState:")]
    void SetElevation (double elevation, UIControlState state);

    // -(UIColor * _Nullable)inkColorForState:(UIControlState)state;
    [Export ("inkColorForState:")]
    [return: NullAllowed]
    UIColor InkColorForState (UIControlState state);

    // -(void)setInkColor:(UIColor * _Nullable)inkColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setInkColor:forState:")]
    void SetInkColor ([NullAllowed] UIColor inkColor, UIControlState state);

    // -(UIColor * _Nullable)shadowColorForState:(UIControlState)state;
    [Export ("shadowColorForState:")]
    [return: NullAllowed]
    UIColor ShadowColorForState (UIControlState state);

    // -(void)setShadowColor:(UIColor * _Nullable)shadowColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setShadowColor:forState:")]
    void SetShadowColor ([NullAllowed] UIColor shadowColor, UIControlState state);

    // -(UIColor * _Nullable)titleColorForState:(UIControlState)state;
    [Export ("titleColorForState:")]
    [return: NullAllowed]
    UIColor TitleColorForState (UIControlState state);

    // -(void)setTitleColor:(UIColor * _Nullable)titleColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setTitleColor:forState:")]
    void SetTitleColor ([NullAllowed] UIColor titleColor, UIControlState state);
}
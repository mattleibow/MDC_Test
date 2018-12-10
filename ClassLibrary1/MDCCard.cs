using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIControl))]
interface MDCCard
{
    // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
    [Export ("cornerRadius")]
    nfloat CornerRadius { get; set; }

    // @property (readonly, nonatomic, strong) MDCInkView * _Nonnull inkView;
    [Export ("inkView", ArgumentSemantic.Strong)]
    MDCInkView InkView { get; }

    // @property (getter = isInteractable, nonatomic) BOOL interactable;
    [Export ("interactable")]
    bool Interactable { [Bind ("isInteractable")] get; set; }

    // -(void)setShadowElevation:(MDCShadowElevation)shadowElevation forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setShadowElevation:forState:")]
    void SetShadowElevation (double shadowElevation, UIControlState state);

    // -(MDCShadowElevation)shadowElevationForState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("shadowElevationForState:")]
    double ShadowElevationForState (UIControlState state);

    // -(void)setBorderWidth:(CGFloat)borderWidth forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setBorderWidth:forState:")]
    void SetBorderWidth (nfloat borderWidth, UIControlState state);

    // -(CGFloat)borderWidthForState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("borderWidthForState:")]
    nfloat BorderWidthForState (UIControlState state);

    // -(void)setBorderColor:(UIColor * _Nullable)borderColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setBorderColor:forState:")]
    void SetBorderColor ([NullAllowed] UIColor borderColor, UIControlState state);

    // -(UIColor * _Nullable)borderColorForState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("borderColorForState:")]
    [return: NullAllowed]
    UIColor BorderColorForState (UIControlState state);

    // -(void)setShadowColor:(UIColor * _Nullable)shadowColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setShadowColor:forState:")]
    void SetShadowColor ([NullAllowed] UIColor shadowColor, UIControlState state);

    // -(UIColor * _Nullable)shadowColorForState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("shadowColorForState:")]
    [return: NullAllowed]
    UIColor ShadowColorForState (UIControlState state);

    // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator;
    [NullAllowed, Export ("shapeGenerator", ArgumentSemantic.Strong)]
    MDCShapeGenerating ShapeGenerator { get; set; }
}
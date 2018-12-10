using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UICollectionViewCell))]
interface MDCCardCollectionCell
{
    // @property (getter = isSelectable, assign, nonatomic) BOOL selectable;
    [Export ("selectable")]
    bool Selectable { [Bind ("isSelectable")] get; set; }

    // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
    [Export ("cornerRadius")]
    nfloat CornerRadius { get; set; }

    // @property (readonly, nonatomic, strong) MDCInkView * _Nonnull inkView;
    [Export ("inkView", ArgumentSemantic.Strong)]
    MDCInkView InkView { get; }

    // @property (getter = isInteractable, nonatomic) BOOL interactable;
    [Export ("interactable")]
    bool Interactable { [Bind ("isInteractable")] get; set; }

    // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator;
    [NullAllowed, Export ("shapeGenerator", ArgumentSemantic.Strong)]
    MDCShapeGenerating ShapeGenerator { get; set; }

    // -(void)setShadowElevation:(MDCShadowElevation)shadowElevation forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setShadowElevation:forState:")]
    void SetShadowElevation (double shadowElevation, MDCCardCellState state);

    // -(MDCShadowElevation)shadowElevationForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("shadowElevationForState:")]
    double ShadowElevationForState (MDCCardCellState state);

    // -(void)setBorderWidth:(CGFloat)borderWidth forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setBorderWidth:forState:")]
    void SetBorderWidth (nfloat borderWidth, MDCCardCellState state);

    // -(CGFloat)borderWidthForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("borderWidthForState:")]
    nfloat BorderWidthForState (MDCCardCellState state);

    // -(void)setBorderColor:(UIColor * _Nullable)borderColor forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setBorderColor:forState:")]
    void SetBorderColor ([NullAllowed] UIColor borderColor, MDCCardCellState state);

    // -(UIColor * _Nullable)borderColorForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("borderColorForState:")]
    [return: NullAllowed]
    UIColor BorderColorForState (MDCCardCellState state);

    // -(void)setShadowColor:(UIColor * _Nullable)shadowColor forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setShadowColor:forState:")]
    void SetShadowColor ([NullAllowed] UIColor shadowColor, MDCCardCellState state);

    // -(UIColor * _Nullable)shadowColorForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("shadowColorForState:")]
    [return: NullAllowed]
    UIColor ShadowColorForState (MDCCardCellState state);

    // -(UIImage * _Nullable)imageForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("imageForState:")]
    [return: NullAllowed]
    UIImage ImageForState (MDCCardCellState state);

    // -(void)setImage:(UIImage * _Nullable)image forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setImage:forState:")]
    void SetImage ([NullAllowed] UIImage image, MDCCardCellState state);

    // -(MDCCardCellHorizontalImageAlignment)horizontalImageAlignmentForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("horizontalImageAlignmentForState:")]
    MDCCardCellHorizontalImageAlignment HorizontalImageAlignmentForState (MDCCardCellState state);

    // -(void)setHorizontalImageAlignment:(MDCCardCellHorizontalImageAlignment)horizontalImageAlignment forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setHorizontalImageAlignment:forState:")]
    void SetHorizontalImageAlignment (MDCCardCellHorizontalImageAlignment horizontalImageAlignment, MDCCardCellState state);

    // -(MDCCardCellVerticalImageAlignment)verticalImageAlignmentForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("verticalImageAlignmentForState:")]
    MDCCardCellVerticalImageAlignment VerticalImageAlignmentForState (MDCCardCellState state);

    // -(void)setVerticalImageAlignment:(MDCCardCellVerticalImageAlignment)verticalImageAlignment forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setVerticalImageAlignment:forState:")]
    void SetVerticalImageAlignment (MDCCardCellVerticalImageAlignment verticalImageAlignment, MDCCardCellState state);

    // -(UIColor * _Nullable)imageTintColorForState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("imageTintColorForState:")]
    [return: NullAllowed]
    UIColor ImageTintColorForState (MDCCardCellState state);

    // -(void)setImageTintColor:(UIColor * _Nullable)imageTintColor forState:(MDCCardCellState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setImageTintColor:forState:")]
    void SetImageTintColor ([NullAllowed] UIColor imageTintColor, MDCCardCellState state);

    // @property (readonly, nonatomic) MDCCardCellState state;
    [Export ("state")]
    MDCCardCellState State { get; }
}
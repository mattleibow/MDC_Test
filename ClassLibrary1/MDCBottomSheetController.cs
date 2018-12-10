using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIViewController))]
interface MDCBottomSheetController
{
    // @property (readonly, nonatomic, strong) UIViewController * _Nonnull contentViewController;
    [Export ("contentViewController", ArgumentSemantic.Strong)]
    UIViewController ContentViewController { get; }

    // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
    [NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
    UIScrollView TrackingScrollView { get; set; }

    // @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
    [Export ("dismissOnBackgroundTap")]
    bool DismissOnBackgroundTap { get; set; }

    // @property (assign, nonatomic) BOOL isScrimAccessibilityElement;
    [Export ("isScrimAccessibilityElement")]
    bool IsScrimAccessibilityElement { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable scrimAccessibilityLabel;
    [NullAllowed, Export ("scrimAccessibilityLabel")]
    string ScrimAccessibilityLabel { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable scrimAccessibilityHint;
    [NullAllowed, Export ("scrimAccessibilityHint")]
    string ScrimAccessibilityHint { get; set; }

    // @property (assign, nonatomic) UIAccessibilityTraits scrimAccessibilityTraits;
    [Export ("scrimAccessibilityTraits")]
    ulong ScrimAccessibilityTraits { get; set; }

    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCBottomSheetControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCBottomSheetControllerDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (readonly, nonatomic) MDCSheetState state;
    [Export ("state")]
    MDCSheetState State { get; }

    // -(void)setShapeGenerator:(id<MDCShapeGenerating> _Nullable)shapeGenerator forState:(MDCSheetState)state;
    [Export ("setShapeGenerator:forState:")]
    void SetShapeGenerator ([NullAllowed] MDCShapeGenerating shapeGenerator, MDCSheetState state);

    // -(id<MDCShapeGenerating> _Nullable)shapeGeneratorForState:(MDCSheetState)state;
    [Export ("shapeGeneratorForState:")]
    [return: NullAllowed]
    MDCShapeGenerating ShapeGeneratorForState (MDCSheetState state);

    // -(instancetype _Nonnull)initWithContentViewController:(UIViewController * _Nonnull)contentViewController;
    [Export ("initWithContentViewController:")]
    IntPtr Constructor (UIViewController contentViewController);
}
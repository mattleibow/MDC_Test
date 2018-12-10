using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIPresentationController))]
interface MDCBottomSheetPresentationController
{
    // @property (nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
    [NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
    UIScrollView TrackingScrollView { get; set; }

    // @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
    [Export ("dismissOnBackgroundTap")]
    bool DismissOnBackgroundTap { get; set; }

    // @property (assign, nonatomic) CGFloat preferredSheetHeight;
    [Export ("preferredSheetHeight")]
    nfloat PreferredSheetHeight { get; set; }

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
    MDCBottomSheetPresentationControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCBottomSheetPresentationControllerDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }
}
using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCBottomSheetTransitionController))]
interface MDCBottomSheetTransitionController_ScrimAccessibility
{
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
}
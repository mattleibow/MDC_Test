using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCAlertControllerView
{
    // @property (nonatomic, strong) UIFont * _Nullable titleFont __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("titleFont", ArgumentSemantic.Strong)]
    UIFont TitleFont { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable titleColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("titleColor", ArgumentSemantic.Strong)]
    UIColor TitleColor { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable messageFont __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("messageFont", ArgumentSemantic.Strong)]
    UIFont MessageFont { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable messageColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("messageColor", ArgumentSemantic.Strong)]
    UIColor MessageColor { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable buttonFont __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("buttonFont", ArgumentSemantic.Strong)]
    UIFont ButtonFont { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable buttonColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("buttonColor", ArgumentSemantic.Strong)]
    UIColor ButtonColor { get; set; }

    // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }
}
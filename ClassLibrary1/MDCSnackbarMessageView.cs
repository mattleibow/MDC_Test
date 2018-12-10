using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCSnackbarMessageView
{
    // @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewBackgroundColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("snackbarMessageViewBackgroundColor", ArgumentSemantic.Strong)]
    UIColor SnackbarMessageViewBackgroundColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewShadowColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("snackbarMessageViewShadowColor", ArgumentSemantic.Strong)]
    UIColor SnackbarMessageViewShadowColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable messageTextColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("messageTextColor", ArgumentSemantic.Strong)]
    UIColor MessageTextColor { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable messageFont __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("messageFont", ArgumentSemantic.Strong)]
    UIFont MessageFont { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable buttonFont __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("buttonFont", ArgumentSemantic.Strong)]
    UIFont ButtonFont { get; set; }

    // @property (nonatomic, strong) NSMutableArray<MDCButton *> * _Nullable actionButtons;
    [NullAllowed, Export ("actionButtons", ArgumentSemantic.Strong)]
    NSMutableArray<MDCButton> ActionButtons { get; set; }

    // -(UIColor * _Nullable)buttonTitleColorForState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("buttonTitleColorForState:")]
    [return: NullAllowed]
    UIColor ButtonTitleColorForState (UIControlState state);

    // -(void)setButtonTitleColor:(UIColor * _Nullable)titleColor forState:(UIControlState)state __attribute__((annotate("ui_appearance_selector")));
    [Export ("setButtonTitleColor:forState:")]
    void SetButtonTitleColor ([NullAllowed] UIColor titleColor, UIControlState state);

    // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }
}
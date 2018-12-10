using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCSnackbarManager))]
interface MDCSnackbarManager_LegacyAPI
{
    // @property (assign, nonatomic, class) MDCSnackbarAlignment alignment;
    [Static]
    [Export ("alignment", ArgumentSemantic.Assign)]
    MDCSnackbarAlignment Alignment { get; set; }

    // +(void)showMessage:(MDCSnackbarMessage * _Nullable)message;
    [Static]
    [Export ("showMessage:")]
    void ShowMessage ([NullAllowed] MDCSnackbarMessage message);

    // +(void)setPresentationHostView:(UIView * _Nullable)hostView;
    [Static]
    [Export ("setPresentationHostView:")]
    void SetPresentationHostView ([NullAllowed] UIView hostView);

    // +(BOOL)hasMessagesShowingOrQueued;
    [Static]
    [Export ("hasMessagesShowingOrQueued")]
    [Verify (MethodToProperty)]
    bool HasMessagesShowingOrQueued { get; }

    // +(void)dismissAndCallCompletionBlocksWithCategory:(NSString * _Nullable)category;
    [Static]
    [Export ("dismissAndCallCompletionBlocksWithCategory:")]
    void DismissAndCallCompletionBlocksWithCategory ([NullAllowed] string category);

    // +(void)setBottomOffset:(CGFloat)offset;
    [Static]
    [Export ("setBottomOffset:")]
    void SetBottomOffset (nfloat offset);

    // +(id<MDCSnackbarSuspensionToken> _Nullable)suspendAllMessages;
    [Static]
    [NullAllowed, Export ("suspendAllMessages")]
    [Verify (MethodToProperty)]
    MDCSnackbarSuspensionToken SuspendAllMessages { get; }

    // +(id<MDCSnackbarSuspensionToken> _Nullable)suspendMessagesWithCategory:(NSString * _Nullable)category;
    [Static]
    [Export ("suspendMessagesWithCategory:")]
    [return: NullAllowed]
    MDCSnackbarSuspensionToken SuspendMessagesWithCategory ([NullAllowed] string category);

    // +(void)resumeMessagesWithToken:(id<MDCSnackbarSuspensionToken> _Nullable)token;
    [Static]
    [Export ("resumeMessagesWithToken:")]
    void ResumeMessagesWithToken ([NullAllowed] MDCSnackbarSuspensionToken token);

    // @property (nonatomic, strong, class) UIColor * _Nullable snackbarMessageViewBackgroundColor;
    [Static]
    [NullAllowed, Export ("snackbarMessageViewBackgroundColor", ArgumentSemantic.Strong)]
    UIColor SnackbarMessageViewBackgroundColor { get; set; }

    // @property (nonatomic, strong, class) UIColor * _Nullable snackbarMessageViewShadowColor;
    [Static]
    [NullAllowed, Export ("snackbarMessageViewShadowColor", ArgumentSemantic.Strong)]
    UIColor SnackbarMessageViewShadowColor { get; set; }

    // @property (nonatomic, strong, class) UIColor * _Nullable messageTextColor;
    [Static]
    [NullAllowed, Export ("messageTextColor", ArgumentSemantic.Strong)]
    UIColor MessageTextColor { get; set; }

    // @property (nonatomic, strong, class) UIFont * _Nullable messageFont;
    [Static]
    [NullAllowed, Export ("messageFont", ArgumentSemantic.Strong)]
    UIFont MessageFont { get; set; }

    // @property (nonatomic, strong, class) UIFont * _Nullable buttonFont;
    [Static]
    [NullAllowed, Export ("buttonFont", ArgumentSemantic.Strong)]
    UIFont ButtonFont { get; set; }

    // @property (assign, nonatomic, class) BOOL shouldApplyStyleChangesToVisibleSnackbars;
    [Static]
    [Export ("shouldApplyStyleChangesToVisibleSnackbars")]
    bool ShouldApplyStyleChangesToVisibleSnackbars { get; set; }

    // +(UIColor * _Nullable)buttonTitleColorForState:(UIControlState)state;
    [Static]
    [Export ("buttonTitleColorForState:")]
    [return: NullAllowed]
    UIColor ButtonTitleColorForState (UIControlState state);

    // +(void)setButtonTitleColor:(UIColor * _Nullable)titleColor forState:(UIControlState)state;
    [Static]
    [Export ("setButtonTitleColor:forState:")]
    void SetButtonTitleColor ([NullAllowed] UIColor titleColor, UIControlState state);

    // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:, class) BOOL mdc_adjustsFontForContentSizeCategory;
    [Static]
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }

    [Wrap ("WeakDelegate"), Static]
    [NullAllowed]
    MDCSnackbarManagerDelegate Delegate { get; set; }

    // @property (nonatomic, weak, class) id<MDCSnackbarManagerDelegate> _Nullable delegate;
    [Static]
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }
}
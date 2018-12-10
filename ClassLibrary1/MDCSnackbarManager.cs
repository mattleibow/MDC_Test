using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCSnackbarManager
{
    // @property (readonly, nonatomic, strong, class) MDCSnackbarManager * _Nonnull defaultManager;
    [Static]
    [Export ("defaultManager", ArgumentSemantic.Strong)]
    MDCSnackbarManager DefaultManager { get; }

    // @property (assign, nonatomic) MDCSnackbarAlignment alignment;
    [Export ("alignment", ArgumentSemantic.Assign)]
    MDCSnackbarAlignment Alignment { get; set; }

    // -(void)showMessage:(MDCSnackbarMessage * _Nullable)message;
    [Export ("showMessage:")]
    void ShowMessage ([NullAllowed] MDCSnackbarMessage message);

    // -(void)setPresentationHostView:(UIView * _Nullable)hostView;
    [Export ("setPresentationHostView:")]
    void SetPresentationHostView ([NullAllowed] UIView hostView);

    // -(BOOL)hasMessagesShowingOrQueued;
    [Export ("hasMessagesShowingOrQueued")]
    [Verify (MethodToProperty)]
    bool HasMessagesShowingOrQueued { get; }

    // -(void)dismissAndCallCompletionBlocksWithCategory:(NSString * _Nullable)category;
    [Export ("dismissAndCallCompletionBlocksWithCategory:")]
    void DismissAndCallCompletionBlocksWithCategory ([NullAllowed] string category);

    // -(void)setBottomOffset:(CGFloat)offset;
    [Export ("setBottomOffset:")]
    void SetBottomOffset (nfloat offset);

    // -(id<MDCSnackbarSuspensionToken> _Nullable)suspendAllMessages;
    [NullAllowed, Export ("suspendAllMessages")]
    [Verify (MethodToProperty)]
    MDCSnackbarSuspensionToken SuspendAllMessages { get; }

    // -(id<MDCSnackbarSuspensionToken> _Nullable)suspendMessagesWithCategory:(NSString * _Nullable)category;
    [Export ("suspendMessagesWithCategory:")]
    [return: NullAllowed]
    MDCSnackbarSuspensionToken SuspendMessagesWithCategory ([NullAllowed] string category);

    // -(void)resumeMessagesWithToken:(id<MDCSnackbarSuspensionToken> _Nullable)token;
    [Export ("resumeMessagesWithToken:")]
    void ResumeMessagesWithToken ([NullAllowed] MDCSnackbarSuspensionToken token);

    // @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewBackgroundColor;
    [NullAllowed, Export ("snackbarMessageViewBackgroundColor", ArgumentSemantic.Strong)]
    UIColor SnackbarMessageViewBackgroundColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable snackbarMessageViewShadowColor;
    [NullAllowed, Export ("snackbarMessageViewShadowColor", ArgumentSemantic.Strong)]
    UIColor SnackbarMessageViewShadowColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable messageTextColor;
    [NullAllowed, Export ("messageTextColor", ArgumentSemantic.Strong)]
    UIColor MessageTextColor { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable messageFont;
    [NullAllowed, Export ("messageFont", ArgumentSemantic.Strong)]
    UIFont MessageFont { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable buttonFont;
    [NullAllowed, Export ("buttonFont", ArgumentSemantic.Strong)]
    UIFont ButtonFont { get; set; }

    // @property (assign, nonatomic) BOOL shouldApplyStyleChangesToVisibleSnackbars;
    [Export ("shouldApplyStyleChangesToVisibleSnackbars")]
    bool ShouldApplyStyleChangesToVisibleSnackbars { get; set; }

    // -(UIColor * _Nullable)buttonTitleColorForState:(UIControlState)state;
    [Export ("buttonTitleColorForState:")]
    [return: NullAllowed]
    UIColor ButtonTitleColorForState (UIControlState state);

    // -(void)setButtonTitleColor:(UIColor * _Nullable)titleColor forState:(UIControlState)state;
    [Export ("setButtonTitleColor:forState:")]
    void SetButtonTitleColor ([NullAllowed] UIColor titleColor, UIControlState state);

    // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory;
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }

    // @property (assign, nonatomic) BOOL shouldEnableAccessibilityViewIsModal;
    [Export ("shouldEnableAccessibilityViewIsModal")]
    bool ShouldEnableAccessibilityViewIsModal { get; set; }

    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCSnackbarManagerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCSnackbarManagerDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }
}
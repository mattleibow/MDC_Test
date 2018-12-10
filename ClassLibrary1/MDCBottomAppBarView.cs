using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCBottomAppBarView
{
    // @property (getter = isFloatingButtonHidden, assign, nonatomic) BOOL floatingButtonHidden;
    [Export ("floatingButtonHidden")]
    bool FloatingButtonHidden { [Bind ("isFloatingButtonHidden")] get; set; }

    // @property (assign, nonatomic) MDCBottomAppBarFloatingButtonElevation floatingButtonElevation;
    [Export ("floatingButtonElevation", ArgumentSemantic.Assign)]
    MDCBottomAppBarFloatingButtonElevation FloatingButtonElevation { get; set; }

    // @property (assign, nonatomic) MDCBottomAppBarFloatingButtonPosition floatingButtonPosition;
    [Export ("floatingButtonPosition", ArgumentSemantic.Assign)]
    MDCBottomAppBarFloatingButtonPosition FloatingButtonPosition { get; set; }

    // @property (readonly, nonatomic, strong) MDCFloatingButton * _Nonnull floatingButton;
    [Export ("floatingButton", ArgumentSemantic.Strong)]
    MDCFloatingButton FloatingButton { get; }

    // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable leadingBarButtonItems;
    [NullAllowed, Export ("leadingBarButtonItems", ArgumentSemantic.Copy)]
    UIBarButtonItem[] LeadingBarButtonItems { get; set; }

    // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable trailingBarButtonItems;
    [NullAllowed, Export ("trailingBarButtonItems", ArgumentSemantic.Copy)]
    UIBarButtonItem[] TrailingBarButtonItems { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable barTintColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("barTintColor", ArgumentSemantic.Strong)]
    UIColor BarTintColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable shadowColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("shadowColor", ArgumentSemantic.Strong)]
    UIColor ShadowColor { get; set; }

    // -(void)setFloatingButtonHidden:(BOOL)floatingButtonHidden animated:(BOOL)animated;
    [Export ("setFloatingButtonHidden:animated:")]
    void SetFloatingButtonHidden (bool floatingButtonHidden, bool animated);

    // -(void)setFloatingButtonElevation:(MDCBottomAppBarFloatingButtonElevation)floatingButtonElevation animated:(BOOL)animated;
    [Export ("setFloatingButtonElevation:animated:")]
    void SetFloatingButtonElevation (MDCBottomAppBarFloatingButtonElevation floatingButtonElevation, bool animated);

    // -(void)setFloatingButtonPosition:(MDCBottomAppBarFloatingButtonPosition)floatingButtonPosition animated:(BOOL)animated;
    [Export ("setFloatingButtonPosition:animated:")]
    void SetFloatingButtonPosition (MDCBottomAppBarFloatingButtonPosition floatingButtonPosition, bool animated);
}
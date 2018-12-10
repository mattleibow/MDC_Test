using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCNavigationBar
{
    // @property (copy, nonatomic) NSString * _Nullable title;
    [NullAllowed, Export ("title")]
    string Title { get; set; }

    // @property (nonatomic, strong) UIView * _Nullable titleView;
    [NullAllowed, Export ("titleView", ArgumentSemantic.Strong)]
    UIView TitleView { get; set; }

    // @property (nonatomic) MDCNavigationBarTitleViewLayoutBehavior titleViewLayoutBehavior;
    [Export ("titleViewLayoutBehavior", ArgumentSemantic.Assign)]
    MDCNavigationBarTitleViewLayoutBehavior TitleViewLayoutBehavior { get; set; }

    // @property (nonatomic, strong) UIFont * _Null_unspecified titleFont;
    [Export ("titleFont", ArgumentSemantic.Strong)]
    UIFont TitleFont { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable titleTextColor;
    [NullAllowed, Export ("titleTextColor", ArgumentSemantic.Strong)]
    UIColor TitleTextColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable inkColor;
    [NullAllowed, Export ("inkColor", ArgumentSemantic.Strong)]
    UIColor InkColor { get; set; }

    // -(void)setButtonsTitleFont:(UIFont * _Nullable)font forState:(UIControlState)state;
    [Export ("setButtonsTitleFont:forState:")]
    void SetButtonsTitleFont ([NullAllowed] UIFont font, UIControlState state);

    // -(UIFont * _Nullable)buttonsTitleFontForState:(UIControlState)state;
    [Export ("buttonsTitleFontForState:")]
    [return: NullAllowed]
    UIFont ButtonsTitleFontForState (UIControlState state);

    // -(void)setButtonsTitleColor:(UIColor * _Nullable)color forState:(UIControlState)state;
    [Export ("setButtonsTitleColor:forState:")]
    void SetButtonsTitleColor ([NullAllowed] UIColor color, UIControlState state);

    // -(UIColor * _Nullable)buttonsTitleColorForState:(UIControlState)state;
    [Export ("buttonsTitleColorForState:")]
    [return: NullAllowed]
    UIColor ButtonsTitleColorForState (UIControlState state);

    // @property (nonatomic, strong) UIBarButtonItem * _Nullable backItem;
    [NullAllowed, Export ("backItem", ArgumentSemantic.Strong)]
    UIBarButtonItem BackItem { get; set; }

    // @property (nonatomic) BOOL hidesBackButton;
    [Export ("hidesBackButton")]
    bool HidesBackButton { get; set; }

    // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable leadingBarButtonItems;
    [NullAllowed, Export ("leadingBarButtonItems", ArgumentSemantic.Copy)]
    UIBarButtonItem[] LeadingBarButtonItems { get; set; }

    // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable trailingBarButtonItems;
    [NullAllowed, Export ("trailingBarButtonItems", ArgumentSemantic.Copy)]
    UIBarButtonItem[] TrailingBarButtonItems { get; set; }

    // @property (nonatomic) BOOL leadingItemsSupplementBackButton;
    [Export ("leadingItemsSupplementBackButton")]
    bool LeadingItemsSupplementBackButton { get; set; }

    // @property (nonatomic, strong) UIBarButtonItem * _Nullable leadingBarButtonItem;
    [NullAllowed, Export ("leadingBarButtonItem", ArgumentSemantic.Strong)]
    UIBarButtonItem LeadingBarButtonItem { get; set; }

    // @property (nonatomic, strong) UIBarButtonItem * _Nullable trailingBarButtonItem;
    [NullAllowed, Export ("trailingBarButtonItem", ArgumentSemantic.Strong)]
    UIBarButtonItem TrailingBarButtonItem { get; set; }

    // @property (nonatomic) MDCNavigationBarTitleAlignment titleAlignment;
    [Export ("titleAlignment", ArgumentSemantic.Assign)]
    MDCNavigationBarTitleAlignment TitleAlignment { get; set; }

    // -(void)observeNavigationItem:(UINavigationItem * _Nonnull)navigationItem;
    [Export ("observeNavigationItem:")]
    void ObserveNavigationItem (UINavigationItem navigationItem);

    // -(void)unobserveNavigationItem;
    [Export ("unobserveNavigationItem")]
    void UnobserveNavigationItem ();

    // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable leftBarButtonItems;
    [NullAllowed, Export ("leftBarButtonItems", ArgumentSemantic.Copy)]
    UIBarButtonItem[] LeftBarButtonItems { get; set; }

    // @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable rightBarButtonItems;
    [NullAllowed, Export ("rightBarButtonItems", ArgumentSemantic.Copy)]
    UIBarButtonItem[] RightBarButtonItems { get; set; }

    // @property (nonatomic, strong) UIBarButtonItem * _Nullable leftBarButtonItem;
    [NullAllowed, Export ("leftBarButtonItem", ArgumentSemantic.Strong)]
    UIBarButtonItem LeftBarButtonItem { get; set; }

    // @property (nonatomic, strong) UIBarButtonItem * _Nullable rightBarButtonItem;
    [NullAllowed, Export ("rightBarButtonItem", ArgumentSemantic.Strong)]
    UIBarButtonItem RightBarButtonItem { get; set; }

    // @property (nonatomic) BOOL leftItemsSupplementBackButton;
    [Export ("leftItemsSupplementBackButton")]
    bool LeftItemsSupplementBackButton { get; set; }

    // @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable titleTextAttributes __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("titleTextAttributes", ArgumentSemantic.Copy)]
    NSDictionary<NSString, NSObject> TitleTextAttributes { get; set; }

    // @property (nonatomic) NSTextAlignment textAlignment __attribute__((deprecated("Use titleAlignment instead.")));
    [Export ("textAlignment", ArgumentSemantic.Assign)]
    NSTextAlignment TextAlignment { get; set; }
}
using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCBottomNavigationBar
{
    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCBottomNavigationBarDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCBottomNavigationBarDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (assign, nonatomic) MDCBottomNavigationBarTitleVisibility titleVisibility __attribute__((annotate("ui_appearance_selector")));
    [Export ("titleVisibility", ArgumentSemantic.Assign)]
    MDCBottomNavigationBarTitleVisibility TitleVisibility { get; set; }

    // @property (assign, nonatomic) MDCBottomNavigationBarAlignment alignment __attribute__((annotate("ui_appearance_selector")));
    [Export ("alignment", ArgumentSemantic.Assign)]
    MDCBottomNavigationBarAlignment Alignment { get; set; }

    // @property (copy, nonatomic) NSArray<UITabBarItem *> * _Nonnull items;
    [Export ("items", ArgumentSemantic.Copy)]
    UITabBarItem[] Items { get; set; }

    // @property (nonatomic, weak) UITabBarItem * _Nullable selectedItem;
    [NullAllowed, Export ("selectedItem", ArgumentSemantic.Weak)]
    UITabBarItem SelectedItem { get; set; }

    // @property (nonatomic, strong) UIFont * _Nonnull itemTitleFont __attribute__((annotate("ui_appearance_selector")));
    [Export ("itemTitleFont", ArgumentSemantic.Strong)]
    UIFont ItemTitleFont { get; set; }

    // @property (readwrite, nonatomic, strong) UIColor * _Nonnull selectedItemTintColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("selectedItemTintColor", ArgumentSemantic.Strong)]
    UIColor SelectedItemTintColor { get; set; }

    // @property (readwrite, nonatomic, strong) UIColor * _Nonnull selectedItemTitleColor;
    [Export ("selectedItemTitleColor", ArgumentSemantic.Strong)]
    UIColor SelectedItemTitleColor { get; set; }

    // @property (readwrite, nonatomic, strong) UIColor * _Nonnull unselectedItemTintColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("unselectedItemTintColor", ArgumentSemantic.Strong)]
    UIColor UnselectedItemTintColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable barTintColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("barTintColor", ArgumentSemantic.Strong)]
    UIColor BarTintColor { get; set; }

    // @property (copy, nonatomic) UIColor * _Nullable backgroundColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("backgroundColor", ArgumentSemantic.Copy)]
    UIColor BackgroundColor { get; set; }

    // @property (assign, nonatomic) UIEdgeInsets itemsContentInsets;
    [Export ("itemsContentInsets", ArgumentSemantic.Assign)]
    UIEdgeInsets ItemsContentInsets { get; set; }

    // @property (assign, nonatomic) CGFloat itemsContentVerticalMargin;
    [Export ("itemsContentVerticalMargin")]
    nfloat ItemsContentVerticalMargin { get; set; }

    // @property (assign, nonatomic) CGFloat itemsContentHorizontalMargin;
    [Export ("itemsContentHorizontalMargin")]
    nfloat ItemsContentHorizontalMargin { get; set; }
}
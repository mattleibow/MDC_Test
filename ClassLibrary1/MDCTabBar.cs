using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCTabBar : IUIBarPositioning
{
    // +(CGFloat)defaultHeightForBarPosition:(UIBarPosition)position itemAppearance:(MDCTabBarItemAppearance)appearance;
    [Static]
    [Export ("defaultHeightForBarPosition:itemAppearance:")]
    nfloat DefaultHeightForBarPosition (UIBarPosition position, MDCTabBarItemAppearance appearance);

    // +(CGFloat)defaultHeightForItemAppearance:(MDCTabBarItemAppearance)appearance;
    [Static]
    [Export ("defaultHeightForItemAppearance:")]
    nfloat DefaultHeightForItemAppearance (MDCTabBarItemAppearance appearance);

    // @property (copy, nonatomic) NSArray<UITabBarItem *> * _Nonnull items;
    [Export ("items", ArgumentSemantic.Copy)]
    UITabBarItem[] Items { get; set; }

    // @property (nonatomic, strong) UITabBarItem * _Nullable selectedItem;
    [NullAllowed, Export ("selectedItem", ArgumentSemantic.Strong)]
    UITabBarItem SelectedItem { get; set; }

    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCTabBarDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCTabBarDelegate> _Nullable delegate __attribute__((iboutlet));
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified tintColor;
    [Export ("tintColor", ArgumentSemantic.Strong)]
    UIColor TintColor { get; set; }

    // @property (nonatomic) UIColor * _Nullable selectedItemTintColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("selectedItemTintColor", ArgumentSemantic.Assign)]
    UIColor SelectedItemTintColor { get; set; }

    // @property (nonatomic) UIColor * _Nonnull unselectedItemTintColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("unselectedItemTintColor", ArgumentSemantic.Assign)]
    UIColor UnselectedItemTintColor { get; set; }

    // @property (nonatomic) UIColor * _Nonnull inkColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("inkColor", ArgumentSemantic.Assign)]
    UIColor InkColor { get; set; }

    // @property (nonatomic) UIColor * _Nonnull bottomDividerColor;
    [Export ("bottomDividerColor", ArgumentSemantic.Assign)]
    UIColor BottomDividerColor { get; set; }

    // @property (nonatomic, strong) UIFont * _Nonnull selectedItemTitleFont __attribute__((annotate("ui_appearance_selector")));
    [Export ("selectedItemTitleFont", ArgumentSemantic.Strong)]
    UIFont SelectedItemTitleFont { get; set; }

    // @property (nonatomic, strong) UIFont * _Nonnull unselectedItemTitleFont __attribute__((annotate("ui_appearance_selector")));
    [Export ("unselectedItemTitleFont", ArgumentSemantic.Strong)]
    UIFont UnselectedItemTitleFont { get; set; }

    // @property (nonatomic) UIColor * _Nullable barTintColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("barTintColor", ArgumentSemantic.Assign)]
    UIColor BarTintColor { get; set; }

    // @property (nonatomic) MDCTabBarAlignment alignment;
    [Export ("alignment", ArgumentSemantic.Assign)]
    MDCTabBarAlignment Alignment { get; set; }

    // @property (nonatomic) MDCTabBarItemAppearance itemAppearance;
    [Export ("itemAppearance", ArgumentSemantic.Assign)]
    MDCTabBarItemAppearance ItemAppearance { get; set; }

    // @property (nonatomic) BOOL displaysUppercaseTitles;
    [Export ("displaysUppercaseTitles")]
    bool DisplaysUppercaseTitles { get; set; }

    // @property (nonatomic) MDCTabBarTextTransform titleTextTransform __attribute__((annotate("ui_appearance_selector")));
    [Export ("titleTextTransform", ArgumentSemantic.Assign)]
    MDCTabBarTextTransform TitleTextTransform { get; set; }

    // @property (nonatomic) id<MDCTabBarIndicatorTemplate> _Null_unspecified selectionIndicatorTemplate __attribute__((annotate("ui_appearance_selector")));
    [Export ("selectionIndicatorTemplate", ArgumentSemantic.Assign)]
    MDCTabBarIndicatorTemplate SelectionIndicatorTemplate { get; set; }

    // -(void)setSelectedItem:(UITabBarItem * _Nullable)selectedItem animated:(BOOL)animated;
    [Export ("setSelectedItem:animated:")]
    void SetSelectedItem ([NullAllowed] UITabBarItem selectedItem, bool animated);

    // -(void)setAlignment:(MDCTabBarAlignment)alignment animated:(BOOL)animated;
    [Export ("setAlignment:animated:")]
    void SetAlignment (MDCTabBarAlignment alignment, bool animated);

    // -(void)setTitleColor:(UIColor * _Nullable)color forState:(MDCTabBarItemState)state;
    [Export ("setTitleColor:forState:")]
    void SetTitleColor ([NullAllowed] UIColor color, MDCTabBarItemState state);

    // -(UIColor * _Nullable)titleColorForState:(MDCTabBarItemState)state;
    [Export ("titleColorForState:")]
    [return: NullAllowed]
    UIColor TitleColorForState (MDCTabBarItemState state);

    // -(void)setImageTintColor:(UIColor * _Nullable)color forState:(MDCTabBarItemState)state;
    [Export ("setImageTintColor:forState:")]
    void SetImageTintColor ([NullAllowed] UIColor color, MDCTabBarItemState state);

    // -(UIColor * _Nullable)imageTintColorForState:(MDCTabBarItemState)state;
    [Export ("imageTintColorForState:")]
    [return: NullAllowed]
    UIColor ImageTintColorForState (MDCTabBarItemState state);
}
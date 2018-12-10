using Foundation;
using ObjCRuntime;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCUINavigationItemObservables
{
    // @required @property (copy, nonatomic) NSString * _Nullable title;
    [Abstract]
    [NullAllowed, Export ("title")]
    string Title { get; set; }

    // @required @property (nonatomic, strong) UIView * _Nullable titleView;
    [Abstract]
    [NullAllowed, Export ("titleView", ArgumentSemantic.Strong)]
    UIView TitleView { get; set; }

    // @required @property (nonatomic) BOOL hidesBackButton;
    [Abstract]
    [Export ("hidesBackButton")]
    bool HidesBackButton { get; set; }

    // @required @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable leftBarButtonItems;
    [Abstract]
    [NullAllowed, Export ("leftBarButtonItems", ArgumentSemantic.Copy)]
    UIBarButtonItem[] LeftBarButtonItems { get; set; }

    // @required @property (copy, nonatomic) NSArray<UIBarButtonItem *> * _Nullable rightBarButtonItems;
    [Abstract]
    [NullAllowed, Export ("rightBarButtonItems", ArgumentSemantic.Copy)]
    UIBarButtonItem[] RightBarButtonItems { get; set; }

    // @required @property (nonatomic) BOOL leftItemsSupplementBackButton;
    [Abstract]
    [Export ("leftItemsSupplementBackButton")]
    bool LeftItemsSupplementBackButton { get; set; }

    // @required @property (nonatomic, strong) UIBarButtonItem * _Nullable leftBarButtonItem;
    [Abstract]
    [NullAllowed, Export ("leftBarButtonItem", ArgumentSemantic.Strong)]
    UIBarButtonItem LeftBarButtonItem { get; set; }

    // @required @property (nonatomic, strong) UIBarButtonItem * _Nullable rightBarButtonItem;
    [Abstract]
    [NullAllowed, Export ("rightBarButtonItem", ArgumentSemantic.Strong)]
    UIBarButtonItem RightBarButtonItem { get; set; }
}
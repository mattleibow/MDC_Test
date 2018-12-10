using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCAppBar
{
    // -(void)addSubviewsToParent;
    [Export ("addSubviewsToParent")]
    void AddSubviewsToParent ();

    // @property (readonly, nonatomic, strong) MDCFlexibleHeaderViewController * _Nonnull headerViewController;
    [Export ("headerViewController", ArgumentSemantic.Strong)]
    MDCFlexibleHeaderViewController HeaderViewController { get; }

    // @property (readonly, nonatomic, strong) MDCAppBarViewController * _Nonnull appBarViewController;
    [Export ("appBarViewController", ArgumentSemantic.Strong)]
    MDCAppBarViewController AppBarViewController { get; }

    // @property (readonly, nonatomic, strong) MDCNavigationBar * _Nonnull navigationBar;
    [Export ("navigationBar", ArgumentSemantic.Strong)]
    MDCNavigationBar NavigationBar { get; }

    // @property (readonly, nonatomic, strong) MDCHeaderStackView * _Nonnull headerStackView;
    [Export ("headerStackView", ArgumentSemantic.Strong)]
    MDCHeaderStackView HeaderStackView { get; }

    // @property (nonatomic) BOOL inferTopSafeAreaInsetFromViewController;
    [Export ("inferTopSafeAreaInsetFromViewController")]
    bool InferTopSafeAreaInsetFromViewController { get; set; }
}
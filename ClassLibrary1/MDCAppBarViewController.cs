using Foundation;
using ObjCRuntime;

[BaseType (typeof(MDCFlexibleHeaderViewController))]
interface MDCAppBarViewController
{
    // @property (nonatomic, strong) MDCNavigationBar * _Nonnull navigationBar;
    [Export ("navigationBar", ArgumentSemantic.Strong)]
    MDCNavigationBar NavigationBar { get; set; }

    // @property (nonatomic, strong) MDCHeaderStackView * _Nonnull headerStackView;
    [Export ("headerStackView", ArgumentSemantic.Strong)]
    MDCHeaderStackView HeaderStackView { get; set; }
}
using Foundation;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCButtonBarDelegate
{
    // @required -(UIView * _Nonnull)buttonBar:(MDCButtonBar * _Nonnull)buttonBar viewForItem:(UIBarButtonItem * _Nonnull)barButtonItem layoutHints:(MDCBarButtonItemLayoutHints)layoutHints;
    [Abstract]
    [Export ("buttonBar:viewForItem:layoutHints:")]
    UIView ViewForItem (MDCButtonBar buttonBar, UIBarButtonItem barButtonItem, MDCBarButtonItemLayoutHints layoutHints);
}
using Foundation;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCButtonBarDelegate
{
    // @optional -(void)buttonBarDidInvalidateIntrinsicContentSize:(MDCButtonBar * _Nonnull)buttonBar;
    [Export ("buttonBarDidInvalidateIntrinsicContentSize:")]
    void ButtonBarDidInvalidateIntrinsicContentSize (MDCButtonBar buttonBar);

    // @optional -(UIView * _Nonnull)buttonBar:(MDCButtonBar * _Nonnull)buttonBar viewForItem:(UIBarButtonItem * _Nonnull)barButtonItem layoutHints:(MDCBarButtonItemLayoutHints)layoutHints __attribute__((deprecated("There will be no replacement for this API.")));
    [Export ("buttonBar:viewForItem:layoutHints:")]
    UIView ButtonBar (MDCButtonBar buttonBar, UIBarButtonItem barButtonItem, MDCBarButtonItemLayoutHints layoutHints);
}
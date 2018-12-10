using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCSnackbarManagerDelegate
{
    // @required -(void)willPresentSnackbarWithMessageView:(MDCSnackbarMessageView * _Nullable)messageView;
    [Abstract]
    [Export ("willPresentSnackbarWithMessageView:")]
    void WillPresentSnackbarWithMessageView ([NullAllowed] MDCSnackbarMessageView messageView);
}
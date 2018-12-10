using Foundation;

[BaseType (typeof(NSObject))]
interface MDCButtonTitleColorAccessibilityMutator
{
    // +(void)changeTitleColorOfButton:(MDCButton *)button;
    [Static]
    [Export ("changeTitleColorOfButton:")]
    void ChangeTitleColorOfButton (MDCButton button);
}
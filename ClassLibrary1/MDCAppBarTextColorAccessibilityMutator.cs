using Foundation;

[BaseType (typeof(NSObject))]
interface MDCAppBarTextColorAccessibilityMutator
{
    // -(void)mutate:(MDCAppBar * _Nonnull)appBar;
    [Export ("mutate:")]
    void Mutate (MDCAppBar appBar);
}
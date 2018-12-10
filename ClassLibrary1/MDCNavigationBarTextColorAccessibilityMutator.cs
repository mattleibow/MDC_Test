using Foundation;

[BaseType (typeof(NSObject))]
interface MDCNavigationBarTextColorAccessibilityMutator
{
    // -(void)mutate:(MDCNavigationBar * _Nonnull)navBar;
    [Export ("mutate:")]
    void Mutate (MDCNavigationBar navBar);
}
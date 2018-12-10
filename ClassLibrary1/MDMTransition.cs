using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDMTransition
{
    // @required -(void)startWithContext:(id<MDMTransitionContext> _Nonnull)context;
    [Abstract]
    [Export ("startWithContext:")]
    void StartWithContext (MDMTransitionContext context);
}
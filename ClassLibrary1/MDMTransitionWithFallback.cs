using Foundation;

[Protocol, Model]
interface MDMTransitionWithFallback : IMDMTransition
{
    // @required -(id<MDMTransition> _Nonnull)fallbackTransitionWithContext:(id<MDMTransitionContext> _Nonnull)context;
    [Abstract]
    [Export ("fallbackTransitionWithContext:")]
    MDMTransition FallbackTransitionWithContext (MDMTransitionContext context);
}
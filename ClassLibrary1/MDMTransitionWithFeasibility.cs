using Foundation;

[Protocol, Model]
interface MDMTransitionWithFeasibility : IMDMTransition
{
    // @required -(BOOL)canPerformTransitionWithContext:(id<MDMTransitionContext> _Nonnull)context;
    [Abstract]
    [Export ("canPerformTransitionWithContext:")]
    bool CanPerformTransitionWithContext (MDMTransitionContext context);
}
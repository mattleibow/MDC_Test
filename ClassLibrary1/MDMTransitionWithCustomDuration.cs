using Foundation;

[Protocol, Model]
interface MDMTransitionWithCustomDuration : IMDMTransition
{
    // @required -(NSTimeInterval)transitionDurationWithContext:(id<MDMTransitionContext> _Nonnull)context;
    [Abstract]
    [Export ("transitionDurationWithContext:")]
    double TransitionDurationWithContext (MDMTransitionContext context);
}
using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDMTransitionPresentationAnimationControlling
{
    // @optional -(void)presentationController:(MDMTransitionPresentationController * _Nonnull)presentationController startWithContext:(NSObject<MDMTransitionContext> * _Nonnull)context;
    [Export ("presentationController:startWithContext:")]
    void PresentationController (MDMTransitionPresentationController presentationController, MDMTransitionContext context);

    // @optional -(void)dismissalTransitionWillBeginWithPresentationController:(MDMTransitionPresentationController * _Nonnull)presentationController;
    [Export ("dismissalTransitionWillBeginWithPresentationController:")]
    void DismissalTransitionWillBeginWithPresentationController (MDMTransitionPresentationController presentationController);

    // @optional -(void)presentationController:(MDMTransitionPresentationController * _Nonnull)presentationController dismissalTransitionDidEnd:(BOOL)completed;
    [Export ("presentationController:dismissalTransitionDidEnd:")]
    void PresentationController (MDMTransitionPresentationController presentationController, bool completed);
}
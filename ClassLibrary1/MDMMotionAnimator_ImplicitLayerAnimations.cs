using CoreAnimation;
using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDMMotionAnimator))]
interface MDMMotionAnimator_ImplicitLayerAnimations
{
    // +(id<CALayerDelegate> _Nonnull)sharedLayerDelegate __attribute__((deprecated("No longer needed for implicit animations of headless layers.")));
    [Static]
    [Export ("sharedLayerDelegate")]
    [Verify (MethodToProperty)]
    CALayerDelegate SharedLayerDelegate { get; }
}
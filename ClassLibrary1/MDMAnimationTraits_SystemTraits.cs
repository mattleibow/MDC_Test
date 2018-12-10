using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDMAnimationTraits))]
interface MDMAnimationTraits_SystemTraits
{
    // @property (readonly, nonatomic, strong, class) MDMAnimationTraits * _Nonnull systemModalMovement;
    [Static]
    [Export ("systemModalMovement", ArgumentSemantic.Strong)]
    MDMAnimationTraits SystemModalMovement { get; }
}
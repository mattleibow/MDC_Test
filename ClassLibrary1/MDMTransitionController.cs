using Foundation;
using ObjCRuntime;

[Protocol, Model]
interface MDMTransitionController
{
    // @required @property (nonatomic, strong) id<MDMTransition> _Nullable transition;
    [Abstract]
    [NullAllowed, Export ("transition", ArgumentSemantic.Strong)]
    MDMTransition Transition { get; set; }

    // @required @property (readonly, nonatomic, strong) id<MDMTransition> _Nullable activeTransition;
    [Abstract]
    [NullAllowed, Export ("activeTransition", ArgumentSemantic.Strong)]
    MDMTransition ActiveTransition { get; }
}
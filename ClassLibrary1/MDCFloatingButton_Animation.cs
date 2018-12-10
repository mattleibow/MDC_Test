using System;
using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCFloatingButton))]
interface MDCFloatingButton_Animation
{
    // -(void)expand:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
    [Export ("expand:completion:")]
    void Expand (bool animated, [NullAllowed] Action completion);

    // -(void)collapse:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
    [Export ("collapse:completion:")]
    void Collapse (bool animated, [NullAllowed] Action completion);
}
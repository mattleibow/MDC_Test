using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCTabBarIndicatorAttributes : INSCopying
{
    // @property (nonatomic) UIBezierPath * _Nullable path;
    [NullAllowed, Export ("path", ArgumentSemantic.Assign)]
    UIBezierPath Path { get; set; }
}
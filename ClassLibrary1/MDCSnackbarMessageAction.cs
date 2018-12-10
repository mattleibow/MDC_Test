using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCSnackbarMessageAction : IUIAccessibilityIdentification, INSCopying
{
    // @property (copy, nonatomic) NSString * _Nullable title;
    [NullAllowed, Export ("title")]
    string Title { get; set; }

    // @property (copy, nonatomic) MDCSnackbarMessageActionHandler _Nullable handler;
    [NullAllowed, Export ("handler", ArgumentSemantic.Copy)]
    MDCSnackbarMessageActionHandler Handler { get; set; }
}
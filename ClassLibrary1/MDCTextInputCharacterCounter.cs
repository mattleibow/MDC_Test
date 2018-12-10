using System;
using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCTextInputCharacterCounter
{
    // @required -(NSUInteger)characterCountForTextInput:(UIView<MDCTextInput> * _Nullable)textInput;
    [Abstract]
    [Export ("characterCountForTextInput:")]
    nuint CharacterCountForTextInput ([NullAllowed] MDCTextInput textInput);
}
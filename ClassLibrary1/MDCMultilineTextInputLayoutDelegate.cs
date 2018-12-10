using CoreGraphics;
using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCMultilineTextInputLayoutDelegate
{
    // @optional -(void)multilineTextField:(id<MDCMultilineTextInput> _Nonnull)multilineTextField didChangeContentSize:(CGSize)size;
    [Export ("multilineTextField:didChangeContentSize:")]
    void DidChangeContentSize (MDCMultilineTextInput multilineTextField, CGSize size);
}
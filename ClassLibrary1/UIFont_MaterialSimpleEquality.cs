using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(UIFont))]
interface UIFont_MaterialSimpleEquality
{
    // -(BOOL)mdc_isSimplyEqual:(UIFont *)font;
    [Export ("mdc_isSimplyEqual:")]
    bool Mdc_isSimplyEqual (UIFont font);
}
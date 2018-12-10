using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCFlexibleHeaderViewController))]
interface MDCFlexibleHeaderViewController_ToBeDeprecated
{
    // -(void)updateTopLayoutGuide;
    [Export ("updateTopLayoutGuide")]
    void UpdateTopLayoutGuide ();
}
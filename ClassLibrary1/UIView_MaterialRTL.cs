using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(UIView))]
interface UIView_MaterialRTL
{
    // @property (nonatomic, setter = mdf_setSemanticContentAttribute:) UISemanticContentAttribute mdf_semanticContentAttribute;
    [Export ("mdf_semanticContentAttribute", ArgumentSemantic.Assign)]
    UISemanticContentAttribute Mdf_semanticContentAttribute { get; [Bind ("mdf_setSemanticContentAttribute:")] set; }

    // @property (readonly, nonatomic) UIUserInterfaceLayoutDirection mdf_effectiveUserInterfaceLayoutDirection;
    [Export ("mdf_effectiveUserInterfaceLayoutDirection")]
    UIUserInterfaceLayoutDirection Mdf_effectiveUserInterfaceLayoutDirection { get; }

    // +(UIUserInterfaceLayoutDirection)mdf_userInterfaceLayoutDirectionForSemanticContentAttribute:(UISemanticContentAttribute)semanticContentAttribute;
    [Static]
    [Export ("mdf_userInterfaceLayoutDirectionForSemanticContentAttribute:")]
    UIUserInterfaceLayoutDirection Mdf_userInterfaceLayoutDirectionForSemanticContentAttribute (UISemanticContentAttribute semanticContentAttribute);

    // +(UIUserInterfaceLayoutDirection)mdf_userInterfaceLayoutDirectionForSemanticContentAttribute:(UISemanticContentAttribute)semanticContentAttribute relativeToLayoutDirection:(UIUserInterfaceLayoutDirection)layoutDirection;
    [Static]
    [Export ("mdf_userInterfaceLayoutDirectionForSemanticContentAttribute:relativeToLayoutDirection:")]
    UIUserInterfaceLayoutDirection Mdf_userInterfaceLayoutDirectionForSemanticContentAttribute (UISemanticContentAttribute semanticContentAttribute, UIUserInterfaceLayoutDirection layoutDirection);
}
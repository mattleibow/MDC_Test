using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(UIImage))]
interface UIImage_MaterialRTL
{
    // -(UIImage * _Nonnull)mdf_imageWithHorizontallyFlippedOrientation;
    [Export ("mdf_imageWithHorizontallyFlippedOrientation")]
    [Verify (MethodToProperty)]
    UIImage Mdf_imageWithHorizontallyFlippedOrientation { get; }
}
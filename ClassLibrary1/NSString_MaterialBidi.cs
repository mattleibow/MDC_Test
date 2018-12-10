using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(NSString))]
interface NSString_MaterialBidi
{
    // -(NSLocaleLanguageDirection)mdf_calculatedLanguageDirection;
    [Export ("mdf_calculatedLanguageDirection")]
    [Verify (MethodToProperty)]
    NSLocaleLanguageDirection Mdf_calculatedLanguageDirection { get; }

    // -(NSString * _Nonnull)mdf_stringWithBidiEmbedding:(NSLocaleLanguageDirection)languageDirection;
    [Export ("mdf_stringWithBidiEmbedding:")]
    string Mdf_stringWithBidiEmbedding (NSLocaleLanguageDirection languageDirection);

    // -(NSString * _Nonnull)mdf_stringWithBidiEmbedding;
    [Export ("mdf_stringWithBidiEmbedding")]
    [Verify (MethodToProperty)]
    string Mdf_stringWithBidiEmbedding { get; }

    // -(NSString * _Nonnull)mdf_stringWithStereoReset:(NSLocaleLanguageDirection)direction context:(NSLocaleLanguageDirection)contextDirection;
    [Export ("mdf_stringWithStereoReset:context:")]
    string Mdf_stringWithStereoReset (NSLocaleLanguageDirection direction, NSLocaleLanguageDirection contextDirection);

    // -(NSString * _Nonnull)mdf_stringWithBidiMarkersStripped;
    [Export ("mdf_stringWithBidiMarkersStripped")]
    [Verify (MethodToProperty)]
    string Mdf_stringWithBidiMarkersStripped { get; }
}
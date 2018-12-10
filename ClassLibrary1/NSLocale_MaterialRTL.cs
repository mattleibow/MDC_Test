using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(NSLocale))]
interface NSLocale_MaterialRTL
{
    // +(BOOL)mdf_isDefaultLanguageLTR;
    [Static]
    [Export ("mdf_isDefaultLanguageLTR")]
    [Verify (MethodToProperty)]
    bool Mdf_isDefaultLanguageLTR { get; }

    // +(BOOL)mdf_isDefaultLanguageRTL;
    [Static]
    [Export ("mdf_isDefaultLanguageRTL")]
    [Verify (MethodToProperty)]
    bool Mdf_isDefaultLanguageRTL { get; }
}
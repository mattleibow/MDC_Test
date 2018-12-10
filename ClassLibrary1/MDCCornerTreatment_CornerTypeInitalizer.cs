using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCCornerTreatment))]
interface MDCCornerTreatment_CornerTypeInitalizer
{
    // +(MDCRoundedCornerTreatment *)cornerWithRadius:(CGFloat)value;
    [Static]
    [Export ("cornerWithRadius:")]
    MDCRoundedCornerTreatment CornerWithRadius (nfloat value);

    // +(MDCRoundedCornerTreatment *)cornerWithRadius:(CGFloat)value valueType:(MDCCornerTreatmentValueType)valueType;
    [Static]
    [Export ("cornerWithRadius:valueType:")]
    MDCRoundedCornerTreatment CornerWithRadius (nfloat value, MDCCornerTreatmentValueType valueType);

    // +(MDCCutCornerTreatment *)cornerWithCut:(CGFloat)value;
    [Static]
    [Export ("cornerWithCut:")]
    MDCCutCornerTreatment CornerWithCut (nfloat value);

    // +(MDCCutCornerTreatment *)cornerWithCut:(CGFloat)value valueType:(MDCCornerTreatmentValueType)valueType;
    [Static]
    [Export ("cornerWithCut:valueType:")]
    MDCCutCornerTreatment CornerWithCut (nfloat value, MDCCornerTreatmentValueType valueType);

    // +(MDCCurvedCornerTreatment *)cornerWithCurve:(CGSize)value;
    [Static]
    [Export ("cornerWithCurve:")]
    MDCCurvedCornerTreatment CornerWithCurve (CGSize value);

    // +(MDCCurvedCornerTreatment *)cornerWithCurve:(CGSize)value valueType:(MDCCornerTreatmentValueType)valueType;
    [Static]
    [Export ("cornerWithCurve:valueType:")]
    MDCCurvedCornerTreatment CornerWithCurve (CGSize value, MDCCornerTreatmentValueType valueType);
}
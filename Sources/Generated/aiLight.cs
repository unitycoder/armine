//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.11
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Assimp {

public class aiLight : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiLight(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiLight obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiLight() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          assimp_swigPINVOKE.delete_aiLight(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public aiString mName {
    set {
      assimp_swigPINVOKE.aiLight_mName_set(swigCPtr, aiString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiLight_mName_get(swigCPtr);
      aiString ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiString(cPtr, false);
      return ret;
    } 
  }

  public aiLightSourceType mType {
    set {
      assimp_swigPINVOKE.aiLight_mType_set(swigCPtr, (int)value);
    } 
    get {
      aiLightSourceType ret = (aiLightSourceType)assimp_swigPINVOKE.aiLight_mType_get(swigCPtr);
      return ret;
    } 
  }

  public aiVector3D mPosition {
    set {
      assimp_swigPINVOKE.aiLight_mPosition_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiLight_mPosition_get(swigCPtr);
      aiVector3D ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

  public aiVector3D mDirection {
    set {
      assimp_swigPINVOKE.aiLight_mDirection_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiLight_mDirection_get(swigCPtr);
      aiVector3D ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

  public aiVector3D mUp {
    set {
      assimp_swigPINVOKE.aiLight_mUp_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiLight_mUp_get(swigCPtr);
      aiVector3D ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

  public float mAttenuationConstant {
    set {
      assimp_swigPINVOKE.aiLight_mAttenuationConstant_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiLight_mAttenuationConstant_get(swigCPtr);
      return ret;
    } 
  }

  public float mAttenuationLinear {
    set {
      assimp_swigPINVOKE.aiLight_mAttenuationLinear_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiLight_mAttenuationLinear_get(swigCPtr);
      return ret;
    } 
  }

  public float mAttenuationQuadratic {
    set {
      assimp_swigPINVOKE.aiLight_mAttenuationQuadratic_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiLight_mAttenuationQuadratic_get(swigCPtr);
      return ret;
    } 
  }

  public aiColor3D mColorDiffuse {
    set {
      assimp_swigPINVOKE.aiLight_mColorDiffuse_set(swigCPtr, aiColor3D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiLight_mColorDiffuse_get(swigCPtr);
      aiColor3D ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiColor3D(cPtr, false);
      return ret;
    } 
  }

  public aiColor3D mColorSpecular {
    set {
      assimp_swigPINVOKE.aiLight_mColorSpecular_set(swigCPtr, aiColor3D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiLight_mColorSpecular_get(swigCPtr);
      aiColor3D ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiColor3D(cPtr, false);
      return ret;
    } 
  }

  public aiColor3D mColorAmbient {
    set {
      assimp_swigPINVOKE.aiLight_mColorAmbient_set(swigCPtr, aiColor3D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiLight_mColorAmbient_get(swigCPtr);
      aiColor3D ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiColor3D(cPtr, false);
      return ret;
    } 
  }

  public float mAngleInnerCone {
    set {
      assimp_swigPINVOKE.aiLight_mAngleInnerCone_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiLight_mAngleInnerCone_get(swigCPtr);
      return ret;
    } 
  }

  public float mAngleOuterCone {
    set {
      assimp_swigPINVOKE.aiLight_mAngleOuterCone_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiLight_mAngleOuterCone_get(swigCPtr);
      return ret;
    } 
  }

  public aiVector2D mSize {
    set {
      assimp_swigPINVOKE.aiLight_mSize_set(swigCPtr, aiVector2D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiLight_mSize_get(swigCPtr);
      aiVector2D ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiVector2D(cPtr, false);
      return ret;
    } 
  }

  public aiLight() : this(assimp_swigPINVOKE.new_aiLight(), true) {
  }

}

}
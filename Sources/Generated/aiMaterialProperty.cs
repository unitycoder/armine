//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Assimp {

public class aiMaterialProperty : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMaterialProperty(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiMaterialProperty obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMaterialProperty() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          assimp_swigPINVOKE.delete_aiMaterialProperty(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public aiString mKey {
    set {
      assimp_swigPINVOKE.aiMaterialProperty_mKey_set(swigCPtr, aiString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiMaterialProperty_mKey_get(swigCPtr);
      aiString ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiString(cPtr, false);
      return ret;
    } 
  }

  public uint mSemantic {
    set {
      assimp_swigPINVOKE.aiMaterialProperty_mSemantic_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMaterialProperty_mSemantic_get(swigCPtr);
      return ret;
    } 
  }

  public uint mIndex {
    set {
      assimp_swigPINVOKE.aiMaterialProperty_mIndex_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMaterialProperty_mIndex_get(swigCPtr);
      return ret;
    } 
  }

  public uint mDataLength {
    set {
      assimp_swigPINVOKE.aiMaterialProperty_mDataLength_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMaterialProperty_mDataLength_get(swigCPtr);
      return ret;
    } 
  }

  public aiPropertyTypeInfo mType {
    set {
      assimp_swigPINVOKE.aiMaterialProperty_mType_set(swigCPtr, (int)value);
    } 
    get {
      aiPropertyTypeInfo ret = (aiPropertyTypeInfo)assimp_swigPINVOKE.aiMaterialProperty_mType_get(swigCPtr);
      return ret;
    } 
  }

  public string mData {
    set {
      assimp_swigPINVOKE.aiMaterialProperty_mData_set(swigCPtr, value);
    } 
    get {
      string ret = assimp_swigPINVOKE.aiMaterialProperty_mData_get(swigCPtr);
      return ret;
    } 
  }

  public aiMaterialProperty() : this(assimp_swigPINVOKE.new_aiMaterialProperty(), true) {
  }

}

}

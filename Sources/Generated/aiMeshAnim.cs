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

public class aiMeshAnim : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMeshAnim(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiMeshAnim obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMeshAnim() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          assimp_swigPINVOKE.delete_aiMeshAnim(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public aiString mName {
    set {
      assimp_swigPINVOKE.aiMeshAnim_mName_set(swigCPtr, aiString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiMeshAnim_mName_get(swigCPtr);
      aiString ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiString(cPtr, false);
      return ret;
    } 
  }

  public aiMeshKeyArray Keys {
    set {
      assimp_swigPINVOKE.aiMeshAnim_Keys_set(swigCPtr, aiMeshKeyArray.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiMeshAnim_Keys_get(swigCPtr);
      aiMeshKeyArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiMeshKeyArray(cPtr, false);
      return ret;
    } 
  }

  public aiMeshAnim() : this(assimp_swigPINVOKE.new_aiMeshAnim(), true) {
  }

}

}
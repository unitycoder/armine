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

public class aiMeshMorphAnim : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMeshMorphAnim(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiMeshMorphAnim obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMeshMorphAnim() {
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
          assimp_swigPINVOKE.delete_aiMeshMorphAnim(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public aiString mName {
    set {
      assimp_swigPINVOKE.aiMeshMorphAnim_mName_set(swigCPtr, aiString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiMeshMorphAnim_mName_get(swigCPtr);
      aiString ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiString(cPtr, false);
      return ret;
    } 
  }

  public uint mNumKeys {
    set {
      assimp_swigPINVOKE.aiMeshMorphAnim_mNumKeys_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMeshMorphAnim_mNumKeys_get(swigCPtr);
      return ret;
    } 
  }

  public aiMeshMorphKeyArray Keys {
    set {
      assimp_swigPINVOKE.aiMeshMorphAnim_Keys_set(swigCPtr, aiMeshMorphKeyArray.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiMeshMorphAnim_Keys_get(swigCPtr);
      aiMeshMorphKeyArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiMeshMorphKeyArray(cPtr, false);
      return ret;
    } 
  }

  public aiMeshMorphAnim() : this(assimp_swigPINVOKE.new_aiMeshMorphAnim(), true) {
  }

}

}

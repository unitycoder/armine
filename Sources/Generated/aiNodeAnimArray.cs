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

public class aiNodeAnimArray : global::System.IDisposable, Interface.Array<aiNodeAnim> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiNodeAnimArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiNodeAnimArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiNodeAnimArray() {
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
          assimp_swigPINVOKE.delete_aiNodeAnimArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public void Clear() {
    assimp_swigPINVOKE.aiNodeAnimArray_Clear(swigCPtr);
  }

  public void Reset() {
    assimp_swigPINVOKE.aiNodeAnimArray_Reset(swigCPtr);
  }

  public void Reserve(uint size, bool exact) {
    assimp_swigPINVOKE.aiNodeAnimArray_Reserve__SWIG_0(swigCPtr, size, exact);
  }

  public void Reserve(uint size) {
    assimp_swigPINVOKE.aiNodeAnimArray_Reserve__SWIG_1(swigCPtr, size);
  }

  public uint Size() {
    uint ret = assimp_swigPINVOKE.aiNodeAnimArray_Size(swigCPtr);
    return ret;
  }

  public aiNodeAnim Get(uint index) {
    aiNodeAnim ret = new aiNodeAnim(assimp_swigPINVOKE.aiNodeAnimArray_Get(swigCPtr, index), false);
    return ret;
  }

  public bool Set(uint index, aiNodeAnim value) {
    bool ret = assimp_swigPINVOKE.aiNodeAnimArray_Set(swigCPtr, index, aiNodeAnim.getCPtr(value));
    return ret;
  }

}

}

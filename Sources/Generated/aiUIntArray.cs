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

public class aiUIntArray : global::System.IDisposable, Interface.Array<uint> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiUIntArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiUIntArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiUIntArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          assimp_swigPINVOKE.delete_aiUIntArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void Clear() {
    assimp_swigPINVOKE.aiUIntArray_Clear(swigCPtr);
  }

  public void Reset() {
    assimp_swigPINVOKE.aiUIntArray_Reset(swigCPtr);
  }

  public void Reserve(uint size, bool exact) {
    assimp_swigPINVOKE.aiUIntArray_Reserve__SWIG_0(swigCPtr, size, exact);
  }

  public void Reserve(uint size) {
    assimp_swigPINVOKE.aiUIntArray_Reserve__SWIG_1(swigCPtr, size);
  }

  public uint Size() {
    uint ret = assimp_swigPINVOKE.aiUIntArray_Size(swigCPtr);
    return ret;
  }

  public uint Get(uint index) {
	uint ret = (uint) global::System.Runtime.InteropServices.Marshal.ReadInt32(assimp_swigPINVOKE.aiUIntArray_Get(swigCPtr, index));
	return ret;
}

  public bool Set(uint index, uint value) {
    bool ret = assimp_swigPINVOKE.aiUIntArray_Set(swigCPtr, index, value);
    return ret;
  }

}

}
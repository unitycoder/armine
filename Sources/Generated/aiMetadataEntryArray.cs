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

public class aiMetadataEntryArray : global::System.IDisposable, Interface.Array<aiMetadataEntry> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMetadataEntryArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiMetadataEntryArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMetadataEntryArray() {
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
          assimp_swigPINVOKE.delete_aiMetadataEntryArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public void Clear() {
    assimp_swigPINVOKE.aiMetadataEntryArray_Clear(swigCPtr);
  }

  public void Reset() {
    assimp_swigPINVOKE.aiMetadataEntryArray_Reset(swigCPtr);
  }

  public void Reserve(uint size, bool exact) {
    assimp_swigPINVOKE.aiMetadataEntryArray_Reserve__SWIG_0(swigCPtr, size, exact);
  }

  public void Reserve(uint size) {
    assimp_swigPINVOKE.aiMetadataEntryArray_Reserve__SWIG_1(swigCPtr, size);
  }

  public uint Size() {
    uint ret = assimp_swigPINVOKE.aiMetadataEntryArray_Size(swigCPtr);
    return ret;
  }

  public aiMetadataEntry Get(uint index) {
    aiMetadataEntry ret = new aiMetadataEntry(assimp_swigPINVOKE.aiMetadataEntryArray_Get(swigCPtr, index), false);
    return ret;
  }

  public bool Set(uint index, aiMetadataEntry value) {
    bool ret = assimp_swigPINVOKE.aiMetadataEntryArray_Set(swigCPtr, index, aiMetadataEntry.getCPtr(value));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

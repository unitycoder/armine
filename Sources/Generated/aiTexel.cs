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

public class aiTexel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiTexel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiTexel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiTexel() {
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
          assimp_swigPINVOKE.delete_aiTexel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public byte b {
    set {
      assimp_swigPINVOKE.aiTexel_b_set(swigCPtr, value);
    } 
    get {
      byte ret = assimp_swigPINVOKE.aiTexel_b_get(swigCPtr);
      return ret;
    } 
  }

  public byte g {
    set {
      assimp_swigPINVOKE.aiTexel_g_set(swigCPtr, value);
    } 
    get {
      byte ret = assimp_swigPINVOKE.aiTexel_g_get(swigCPtr);
      return ret;
    } 
  }

  public byte r {
    set {
      assimp_swigPINVOKE.aiTexel_r_set(swigCPtr, value);
    } 
    get {
      byte ret = assimp_swigPINVOKE.aiTexel_r_get(swigCPtr);
      return ret;
    } 
  }

  public byte a {
    set {
      assimp_swigPINVOKE.aiTexel_a_set(swigCPtr, value);
    } 
    get {
      byte ret = assimp_swigPINVOKE.aiTexel_a_get(swigCPtr);
      return ret;
    } 
  }

  public bool op_equal(aiTexel other) {
    bool ret = assimp_swigPINVOKE.aiTexel_op_equal(swigCPtr, aiTexel.getCPtr(other));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_not_equal(aiTexel other) {
    bool ret = assimp_swigPINVOKE.aiTexel_op_not_equal(swigCPtr, aiTexel.getCPtr(other));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiTexel() : this(assimp_swigPINVOKE.new_aiTexel(), true) {
  }

}

}

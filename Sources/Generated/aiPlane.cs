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

public class aiPlane : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiPlane(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiPlane obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiPlane() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          assimp_swigPINVOKE.delete_aiPlane(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public aiPlane() : this(assimp_swigPINVOKE.new_aiPlane__SWIG_0(), true) {
  }

  public aiPlane(float _a, float _b, float _c, float _d) : this(assimp_swigPINVOKE.new_aiPlane__SWIG_1(_a, _b, _c, _d), true) {
  }

  public aiPlane(aiPlane o) : this(assimp_swigPINVOKE.new_aiPlane__SWIG_2(aiPlane.getCPtr(o)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public float a {
    set {
      assimp_swigPINVOKE.aiPlane_a_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiPlane_a_get(swigCPtr);
      return ret;
    } 
  }

  public float b {
    set {
      assimp_swigPINVOKE.aiPlane_b_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiPlane_b_get(swigCPtr);
      return ret;
    } 
  }

  public float c {
    set {
      assimp_swigPINVOKE.aiPlane_c_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiPlane_c_get(swigCPtr);
      return ret;
    } 
  }

  public float d {
    set {
      assimp_swigPINVOKE.aiPlane_d_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiPlane_d_get(swigCPtr);
      return ret;
    } 
  }

}

}

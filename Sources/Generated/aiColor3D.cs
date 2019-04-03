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

public class aiColor3D : global::System.IDisposable, Interface.Unmanagable<aiColor3D> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiColor3D(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiColor3D obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiColor3D() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          assimp_swigPINVOKE.delete_aiColor3D(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public aiColor3D Unmanaged() {
    this.swigCMemOwn = false;
    return this;
  }

  public aiColor3D() : this(assimp_swigPINVOKE.new_aiColor3D__SWIG_0(), true) {
  }

  public aiColor3D(float _r, float _g, float _b) : this(assimp_swigPINVOKE.new_aiColor3D__SWIG_1(_r, _g, _b), true) {
  }

  public aiColor3D(float _r) : this(assimp_swigPINVOKE.new_aiColor3D__SWIG_2(_r), true) {
  }

  public aiColor3D(aiColor3D o) : this(assimp_swigPINVOKE.new_aiColor3D__SWIG_3(aiColor3D.getCPtr(o)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool op_equal(aiColor3D other) {
    bool ret = assimp_swigPINVOKE.aiColor3D_op_equal(swigCPtr, aiColor3D.getCPtr(other));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_not_equal(aiColor3D other) {
    bool ret = assimp_swigPINVOKE.aiColor3D_op_not_equal(swigCPtr, aiColor3D.getCPtr(other));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_lesser(aiColor3D other) {
    bool ret = assimp_swigPINVOKE.aiColor3D_op_lesser(swigCPtr, aiColor3D.getCPtr(other));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiColor3D op_add(aiColor3D c) {
    aiColor3D ret = new aiColor3D(assimp_swigPINVOKE.aiColor3D_op_add(swigCPtr, aiColor3D.getCPtr(c)), true);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiColor3D op_sub(aiColor3D c) {
    aiColor3D ret = new aiColor3D(assimp_swigPINVOKE.aiColor3D_op_sub(swigCPtr, aiColor3D.getCPtr(c)), true);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiColor3D op_mul(aiColor3D c) {
    aiColor3D ret = new aiColor3D(assimp_swigPINVOKE.aiColor3D_op_mul__SWIG_0(swigCPtr, aiColor3D.getCPtr(c)), true);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiColor3D op_mul(float f) {
    aiColor3D ret = new aiColor3D(assimp_swigPINVOKE.aiColor3D_op_mul__SWIG_1(swigCPtr, f), true);
    return ret;
  }

  public float op_get(uint i) {
    float ret = assimp_swigPINVOKE.aiColor3D_op_get(swigCPtr, i);
    return ret;
  }

  public bool IsBlack() {
    bool ret = assimp_swigPINVOKE.aiColor3D_IsBlack(swigCPtr);
    return ret;
  }

  public float r {
    set {
      assimp_swigPINVOKE.aiColor3D_r_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiColor3D_r_get(swigCPtr);
      return ret;
    } 
  }

  public float g {
    set {
      assimp_swigPINVOKE.aiColor3D_g_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiColor3D_g_get(swigCPtr);
      return ret;
    } 
  }

  public float b {
    set {
      assimp_swigPINVOKE.aiColor3D_b_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiColor3D_b_get(swigCPtr);
      return ret;
    } 
  }

}

}

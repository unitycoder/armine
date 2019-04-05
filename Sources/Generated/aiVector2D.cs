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

public class aiVector2D : global::System.IDisposable, Interface.Unmanagable<aiVector2D> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiVector2D(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiVector2D obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiVector2D() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          assimp_swigPINVOKE.delete_aiVector2D(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public aiVector2D Unmanaged() {
    this.swigCMemOwn = false;
    return this;
  }

  public aiVector2D() : this(assimp_swigPINVOKE.new_aiVector2D__SWIG_0(), true) {
  }

  public aiVector2D(float _x, float _y) : this(assimp_swigPINVOKE.new_aiVector2D__SWIG_1(_x, _y), true) {
  }

  public aiVector2D(float _xyz) : this(assimp_swigPINVOKE.new_aiVector2D__SWIG_2(_xyz), true) {
  }

  public aiVector2D(aiVector2D o) : this(assimp_swigPINVOKE.new_aiVector2D__SWIG_3(aiVector2D.getCPtr(o)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(float pX, float pY) {
    assimp_swigPINVOKE.aiVector2D_Set(swigCPtr, pX, pY);
  }

  public float SquareLength() {
    float ret = assimp_swigPINVOKE.aiVector2D_SquareLength(swigCPtr);
    return ret;
  }

  public float Length() {
    float ret = assimp_swigPINVOKE.aiVector2D_Length(swigCPtr);
    return ret;
  }

  public aiVector2D Normalize() {
    aiVector2D ret = new aiVector2D(assimp_swigPINVOKE.aiVector2D_Normalize(swigCPtr), false);
    return ret;
  }

  public aiVector2D op_add_and_set(aiVector2D o) {
    aiVector2D ret = new aiVector2D(assimp_swigPINVOKE.aiVector2D_op_add_and_set(swigCPtr, aiVector2D.getCPtr(o)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiVector2D op_sub_and_set(aiVector2D o) {
    aiVector2D ret = new aiVector2D(assimp_swigPINVOKE.aiVector2D_op_sub_and_set(swigCPtr, aiVector2D.getCPtr(o)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiVector2D op_mul_and_set(float f) {
    aiVector2D ret = new aiVector2D(assimp_swigPINVOKE.aiVector2D_op_mul_and_set(swigCPtr, f), false);
    return ret;
  }

  public aiVector2D op_div_and_set(float f) {
    aiVector2D ret = new aiVector2D(assimp_swigPINVOKE.aiVector2D_op_div_and_set(swigCPtr, f), false);
    return ret;
  }

  public float op_get(uint i) {
    float ret = assimp_swigPINVOKE.aiVector2D_op_get(swigCPtr, i);
    return ret;
  }

  public bool op_equal(aiVector2D other) {
    bool ret = assimp_swigPINVOKE.aiVector2D_op_equal(swigCPtr, aiVector2D.getCPtr(other));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_not_equal(aiVector2D other) {
    bool ret = assimp_swigPINVOKE.aiVector2D_op_not_equal(swigCPtr, aiVector2D.getCPtr(other));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equal(aiVector2D other, float epsilon) {
    bool ret = assimp_swigPINVOKE.aiVector2D_Equal__SWIG_0(swigCPtr, aiVector2D.getCPtr(other), epsilon);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equal(aiVector2D other) {
    bool ret = assimp_swigPINVOKE.aiVector2D_Equal__SWIG_1(swigCPtr, aiVector2D.getCPtr(other));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiVector2D op_set(float f) {
    aiVector2D ret = new aiVector2D(assimp_swigPINVOKE.aiVector2D_op_set(swigCPtr, f), false);
    return ret;
  }

  public aiVector2D SymMul(aiVector2D o) {
    aiVector2D ret = new aiVector2D(assimp_swigPINVOKE.aiVector2D_SymMul(swigCPtr, aiVector2D.getCPtr(o)), true);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float x {
    set {
      assimp_swigPINVOKE.aiVector2D_x_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiVector2D_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      assimp_swigPINVOKE.aiVector2D_y_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiVector2D_y_get(swigCPtr);
      return ret;
    } 
  }

}

}
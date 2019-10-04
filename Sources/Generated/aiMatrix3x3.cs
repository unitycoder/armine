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

public class aiMatrix3x3 : global::System.IDisposable, Interface.Unmanagable<aiMatrix3x3> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMatrix3x3(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiMatrix3x3 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMatrix3x3() {
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
          assimp_swigPINVOKE.delete_aiMatrix3x3(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public aiMatrix3x3 Unmanaged() {
    this.swigCMemOwn = false;
    return this;
  }

  public aiMatrix3x3() : this(assimp_swigPINVOKE.new_aiMatrix3x3__SWIG_0(), true) {
  }

  public aiMatrix3x3(float _a1, float _a2, float _a3, float _b1, float _b2, float _b3, float _c1, float _c2, float _c3) : this(assimp_swigPINVOKE.new_aiMatrix3x3__SWIG_1(_a1, _a2, _a3, _b1, _b2, _b3, _c1, _c2, _c3), true) {
  }

  public aiMatrix3x3 op_mul_and_set(aiMatrix3x3 m) {
    aiMatrix3x3 ret = new aiMatrix3x3(assimp_swigPINVOKE.aiMatrix3x3_op_mul_and_set(swigCPtr, aiMatrix3x3.getCPtr(m)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiMatrix3x3 op_mul(aiMatrix3x3 m) {
    aiMatrix3x3 ret = new aiMatrix3x3(assimp_swigPINVOKE.aiMatrix3x3_op_mul(swigCPtr, aiMatrix3x3.getCPtr(m)), true);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_equal(aiMatrix4x4 m) {
    bool ret = assimp_swigPINVOKE.aiMatrix3x3_op_equal(swigCPtr, aiMatrix4x4.getCPtr(m));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_not_equal(aiMatrix4x4 m) {
    bool ret = assimp_swigPINVOKE.aiMatrix3x3_op_not_equal(swigCPtr, aiMatrix4x4.getCPtr(m));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equal(aiMatrix4x4 m, float epsilon) {
    bool ret = assimp_swigPINVOKE.aiMatrix3x3_Equal__SWIG_0(swigCPtr, aiMatrix4x4.getCPtr(m), epsilon);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equal(aiMatrix4x4 m) {
    bool ret = assimp_swigPINVOKE.aiMatrix3x3_Equal__SWIG_1(swigCPtr, aiMatrix4x4.getCPtr(m));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiMatrix3x3(aiMatrix4x4 pMatrix) : this(assimp_swigPINVOKE.new_aiMatrix3x3__SWIG_2(aiMatrix4x4.getCPtr(pMatrix)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiMatrix3x3 Transpose() {
    aiMatrix3x3 ret = new aiMatrix3x3(assimp_swigPINVOKE.aiMatrix3x3_Transpose(swigCPtr), false);
    return ret;
  }

  public aiMatrix3x3 Inverse() {
    aiMatrix3x3 ret = new aiMatrix3x3(assimp_swigPINVOKE.aiMatrix3x3_Inverse(swigCPtr), false);
    return ret;
  }

  public float Determinant() {
    float ret = assimp_swigPINVOKE.aiMatrix3x3_Determinant(swigCPtr);
    return ret;
  }

  public static aiMatrix3x3 RotationZ(float a, aiMatrix3x3 out_) {
    aiMatrix3x3 ret = new aiMatrix3x3(assimp_swigPINVOKE.aiMatrix3x3_RotationZ(a, aiMatrix3x3.getCPtr(out_)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMatrix3x3 Rotation(float a, aiVector3D axis, aiMatrix3x3 out_) {
    aiMatrix3x3 ret = new aiMatrix3x3(assimp_swigPINVOKE.aiMatrix3x3_Rotation(a, aiVector3D.getCPtr(axis), aiMatrix3x3.getCPtr(out_)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMatrix3x3 Translation(aiVector2D v, aiMatrix3x3 out_) {
    aiMatrix3x3 ret = new aiMatrix3x3(assimp_swigPINVOKE.aiMatrix3x3_Translation(aiVector2D.getCPtr(v), aiMatrix3x3.getCPtr(out_)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMatrix3x3 FromToMatrix(aiVector3D from, aiVector3D to, aiMatrix3x3 out_) {
    aiMatrix3x3 ret = new aiMatrix3x3(assimp_swigPINVOKE.aiMatrix3x3_FromToMatrix(aiVector3D.getCPtr(from), aiVector3D.getCPtr(to), aiMatrix3x3.getCPtr(out_)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float a1 {
    set {
      assimp_swigPINVOKE.aiMatrix3x3_a1_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix3x3_a1_get(swigCPtr);
      return ret;
    } 
  }

  public float a2 {
    set {
      assimp_swigPINVOKE.aiMatrix3x3_a2_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix3x3_a2_get(swigCPtr);
      return ret;
    } 
  }

  public float a3 {
    set {
      assimp_swigPINVOKE.aiMatrix3x3_a3_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix3x3_a3_get(swigCPtr);
      return ret;
    } 
  }

  public float b1 {
    set {
      assimp_swigPINVOKE.aiMatrix3x3_b1_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix3x3_b1_get(swigCPtr);
      return ret;
    } 
  }

  public float b2 {
    set {
      assimp_swigPINVOKE.aiMatrix3x3_b2_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix3x3_b2_get(swigCPtr);
      return ret;
    } 
  }

  public float b3 {
    set {
      assimp_swigPINVOKE.aiMatrix3x3_b3_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix3x3_b3_get(swigCPtr);
      return ret;
    } 
  }

  public float c1 {
    set {
      assimp_swigPINVOKE.aiMatrix3x3_c1_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix3x3_c1_get(swigCPtr);
      return ret;
    } 
  }

  public float c2 {
    set {
      assimp_swigPINVOKE.aiMatrix3x3_c2_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix3x3_c2_get(swigCPtr);
      return ret;
    } 
  }

  public float c3 {
    set {
      assimp_swigPINVOKE.aiMatrix3x3_c3_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix3x3_c3_get(swigCPtr);
      return ret;
    } 
  }

}

}

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

public class aiQuaternion : global::System.IDisposable, Interface.Unmanagable<aiQuaternion> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiQuaternion(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiQuaternion obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiQuaternion() {
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
          assimp_swigPINVOKE.delete_aiQuaternion(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public aiQuaternion Unmanaged() {
    this.swigCMemOwn = false;
    return this;
  }

  public aiQuaternion() : this(assimp_swigPINVOKE.new_aiQuaternion__SWIG_0(), true) {
  }

  public aiQuaternion(float pw, float px, float py, float pz) : this(assimp_swigPINVOKE.new_aiQuaternion__SWIG_1(pw, px, py, pz), true) {
  }

  public aiQuaternion(aiMatrix3x3 pRotMatrix) : this(assimp_swigPINVOKE.new_aiQuaternion__SWIG_2(aiMatrix3x3.getCPtr(pRotMatrix)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiQuaternion(float rotx, float roty, float rotz) : this(assimp_swigPINVOKE.new_aiQuaternion__SWIG_3(rotx, roty, rotz), true) {
  }

  public aiQuaternion(aiVector3D axis, float angle) : this(assimp_swigPINVOKE.new_aiQuaternion__SWIG_4(aiVector3D.getCPtr(axis), angle), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiQuaternion(aiVector3D normalized) : this(assimp_swigPINVOKE.new_aiQuaternion__SWIG_5(aiVector3D.getCPtr(normalized)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiMatrix3x3 GetMatrix() {
    aiMatrix3x3 ret = new aiMatrix3x3(assimp_swigPINVOKE.aiQuaternion_GetMatrix(swigCPtr), true);
    return ret;
  }

  public bool op_equal(aiQuaternion o) {
    bool ret = assimp_swigPINVOKE.aiQuaternion_op_equal(swigCPtr, aiQuaternion.getCPtr(o));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_not_equal(aiQuaternion o) {
    bool ret = assimp_swigPINVOKE.aiQuaternion_op_not_equal(swigCPtr, aiQuaternion.getCPtr(o));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equal(aiQuaternion o, float epsilon) {
    bool ret = assimp_swigPINVOKE.aiQuaternion_Equal__SWIG_0(swigCPtr, aiQuaternion.getCPtr(o), epsilon);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equal(aiQuaternion o) {
    bool ret = assimp_swigPINVOKE.aiQuaternion_Equal__SWIG_1(swigCPtr, aiQuaternion.getCPtr(o));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiQuaternion Normalize() {
    aiQuaternion ret = new aiQuaternion(assimp_swigPINVOKE.aiQuaternion_Normalize(swigCPtr), false);
    return ret;
  }

  public aiQuaternion Conjugate() {
    aiQuaternion ret = new aiQuaternion(assimp_swigPINVOKE.aiQuaternion_Conjugate(swigCPtr), false);
    return ret;
  }

  public aiVector3D Rotate(aiVector3D in_) {
    aiVector3D ret = new aiVector3D(assimp_swigPINVOKE.aiQuaternion_Rotate(swigCPtr, aiVector3D.getCPtr(in_)), true);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiQuaternion op_mul(aiQuaternion two) {
    aiQuaternion ret = new aiQuaternion(assimp_swigPINVOKE.aiQuaternion_op_mul(swigCPtr, aiQuaternion.getCPtr(two)), true);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void Interpolate(aiQuaternion pOut, aiQuaternion pStart, aiQuaternion pEnd, float pFactor) {
    assimp_swigPINVOKE.aiQuaternion_Interpolate(aiQuaternion.getCPtr(pOut), aiQuaternion.getCPtr(pStart), aiQuaternion.getCPtr(pEnd), pFactor);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public float w {
    set {
      assimp_swigPINVOKE.aiQuaternion_w_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiQuaternion_w_get(swigCPtr);
      return ret;
    } 
  }

  public float x {
    set {
      assimp_swigPINVOKE.aiQuaternion_x_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiQuaternion_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      assimp_swigPINVOKE.aiQuaternion_y_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiQuaternion_y_get(swigCPtr);
      return ret;
    } 
  }

  public float z {
    set {
      assimp_swigPINVOKE.aiQuaternion_z_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiQuaternion_z_get(swigCPtr);
      return ret;
    } 
  }

}

}

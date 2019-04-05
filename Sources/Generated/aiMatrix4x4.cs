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

public class aiMatrix4x4 : global::System.IDisposable, Interface.Unmanagable<aiMatrix4x4> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMatrix4x4(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiMatrix4x4 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMatrix4x4() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          assimp_swigPINVOKE.delete_aiMatrix4x4(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public aiMatrix4x4 Unmanaged() {
    this.swigCMemOwn = false;
    return this;
  }

  public aiMatrix4x4() : this(assimp_swigPINVOKE.new_aiMatrix4x4__SWIG_0(), true) {
  }

  public aiMatrix4x4(float _a1, float _a2, float _a3, float _a4, float _b1, float _b2, float _b3, float _b4, float _c1, float _c2, float _c3, float _c4, float _d1, float _d2, float _d3, float _d4) : this(assimp_swigPINVOKE.new_aiMatrix4x4__SWIG_1(_a1, _a2, _a3, _a4, _b1, _b2, _b3, _b4, _c1, _c2, _c3, _c4, _d1, _d2, _d3, _d4), true) {
  }

  public aiMatrix4x4(aiMatrix3x3 m) : this(assimp_swigPINVOKE.new_aiMatrix4x4__SWIG_2(aiMatrix3x3.getCPtr(m)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiMatrix4x4(aiVector3D scaling, aiQuaternion rotation, aiVector3D position) : this(assimp_swigPINVOKE.new_aiMatrix4x4__SWIG_3(aiVector3D.getCPtr(scaling), aiQuaternion.getCPtr(rotation), aiVector3D.getCPtr(position)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool op_equal(aiMatrix4x4 m) {
    bool ret = assimp_swigPINVOKE.aiMatrix4x4_op_equal(swigCPtr, aiMatrix4x4.getCPtr(m));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_not_equal(aiMatrix4x4 m) {
    bool ret = assimp_swigPINVOKE.aiMatrix4x4_op_not_equal(swigCPtr, aiMatrix4x4.getCPtr(m));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equal(aiMatrix4x4 m, float epsilon) {
    bool ret = assimp_swigPINVOKE.aiMatrix4x4_Equal__SWIG_0(swigCPtr, aiMatrix4x4.getCPtr(m), epsilon);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equal(aiMatrix4x4 m) {
    bool ret = assimp_swigPINVOKE.aiMatrix4x4_Equal__SWIG_1(swigCPtr, aiMatrix4x4.getCPtr(m));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiMatrix4x4 op_mul_and_set(aiMatrix4x4 m) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_op_mul_and_set(swigCPtr, aiMatrix4x4.getCPtr(m)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiMatrix4x4 op_mul(aiMatrix4x4 m) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_op_mul__SWIG_0(swigCPtr, aiMatrix4x4.getCPtr(m)), true);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiMatrix4x4 op_mul(float aFloat) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_op_mul__SWIG_1(swigCPtr, aFloat), true);
    return ret;
  }

  public aiMatrix4x4 op_add(aiMatrix4x4 aMatrix) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_op_add(swigCPtr, aiMatrix4x4.getCPtr(aMatrix)), true);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiMatrix4x4 Transpose() {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_Transpose(swigCPtr), false);
    return ret;
  }

  public aiMatrix4x4 Inverse() {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_Inverse(swigCPtr), false);
    return ret;
  }

  public float Determinant() {
    float ret = assimp_swigPINVOKE.aiMatrix4x4_Determinant(swigCPtr);
    return ret;
  }

  public bool IsIdentity() {
    bool ret = assimp_swigPINVOKE.aiMatrix4x4_IsIdentity(swigCPtr);
    return ret;
  }

  public void Decompose(aiVector3D scaling, aiQuaternion rotation, aiVector3D position) {
    assimp_swigPINVOKE.aiMatrix4x4_Decompose__SWIG_0(swigCPtr, aiVector3D.getCPtr(scaling), aiQuaternion.getCPtr(rotation), aiVector3D.getCPtr(position));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Decompose(aiVector3D pScaling, aiVector3D pRotation, aiVector3D pPosition) {
    assimp_swigPINVOKE.aiMatrix4x4_Decompose__SWIG_1(swigCPtr, aiVector3D.getCPtr(pScaling), aiVector3D.getCPtr(pRotation), aiVector3D.getCPtr(pPosition));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DecomposeNoScaling(aiQuaternion rotation, aiVector3D position) {
    assimp_swigPINVOKE.aiMatrix4x4_DecomposeNoScaling(swigCPtr, aiQuaternion.getCPtr(rotation), aiVector3D.getCPtr(position));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiMatrix4x4 FromEulerAnglesXYZ(float x, float y, float z) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_FromEulerAnglesXYZ__SWIG_0(swigCPtr, x, y, z), false);
    return ret;
  }

  public aiMatrix4x4 FromEulerAnglesXYZ(aiVector3D blubb) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_FromEulerAnglesXYZ__SWIG_1(swigCPtr, aiVector3D.getCPtr(blubb)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMatrix4x4 RotationX(float a, aiMatrix4x4 arg1) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_RotationX(a, aiMatrix4x4.getCPtr(arg1)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMatrix4x4 RotationY(float a, aiMatrix4x4 arg1) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_RotationY(a, aiMatrix4x4.getCPtr(arg1)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMatrix4x4 RotationZ(float a, aiMatrix4x4 arg1) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_RotationZ(a, aiMatrix4x4.getCPtr(arg1)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMatrix4x4 Rotation(float a, aiVector3D axis, aiMatrix4x4 arg2) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_Rotation(a, aiVector3D.getCPtr(axis), aiMatrix4x4.getCPtr(arg2)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMatrix4x4 Translation(aiVector3D v, aiMatrix4x4 arg1) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_Translation(aiVector3D.getCPtr(v), aiMatrix4x4.getCPtr(arg1)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMatrix4x4 Scaling(aiVector3D v, aiMatrix4x4 arg1) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_Scaling(aiVector3D.getCPtr(v), aiMatrix4x4.getCPtr(arg1)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMatrix4x4 FromToMatrix(aiVector3D from, aiVector3D to, aiMatrix4x4 arg2) {
    aiMatrix4x4 ret = new aiMatrix4x4(assimp_swigPINVOKE.aiMatrix4x4_FromToMatrix(aiVector3D.getCPtr(from), aiVector3D.getCPtr(to), aiMatrix4x4.getCPtr(arg2)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float a1 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_a1_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_a1_get(swigCPtr);
      return ret;
    } 
  }

  public float a2 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_a2_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_a2_get(swigCPtr);
      return ret;
    } 
  }

  public float a3 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_a3_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_a3_get(swigCPtr);
      return ret;
    } 
  }

  public float a4 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_a4_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_a4_get(swigCPtr);
      return ret;
    } 
  }

  public float b1 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_b1_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_b1_get(swigCPtr);
      return ret;
    } 
  }

  public float b2 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_b2_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_b2_get(swigCPtr);
      return ret;
    } 
  }

  public float b3 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_b3_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_b3_get(swigCPtr);
      return ret;
    } 
  }

  public float b4 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_b4_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_b4_get(swigCPtr);
      return ret;
    } 
  }

  public float c1 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_c1_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_c1_get(swigCPtr);
      return ret;
    } 
  }

  public float c2 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_c2_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_c2_get(swigCPtr);
      return ret;
    } 
  }

  public float c3 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_c3_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_c3_get(swigCPtr);
      return ret;
    } 
  }

  public float c4 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_c4_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_c4_get(swigCPtr);
      return ret;
    } 
  }

  public float d1 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_d1_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_d1_get(swigCPtr);
      return ret;
    } 
  }

  public float d2 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_d2_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_d2_get(swigCPtr);
      return ret;
    } 
  }

  public float d3 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_d3_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_d3_get(swigCPtr);
      return ret;
    } 
  }

  public float d4 {
    set {
      assimp_swigPINVOKE.aiMatrix4x4_d4_set(swigCPtr, value);
    } 
    get {
      float ret = assimp_swigPINVOKE.aiMatrix4x4_d4_get(swigCPtr);
      return ret;
    } 
  }

}

}
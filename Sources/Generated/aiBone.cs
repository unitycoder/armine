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

public class aiBone : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiBone(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiBone obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiBone() {
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
          assimp_swigPINVOKE.delete_aiBone(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public aiString mName {
    set {
      assimp_swigPINVOKE.aiBone_mName_set(swigCPtr, aiString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiBone_mName_get(swigCPtr);
      aiString ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiString(cPtr, false);
      return ret;
    } 
  }

  public aiMatrix4x4 mOffsetMatrix {
    set {
      assimp_swigPINVOKE.aiBone_mOffsetMatrix_set(swigCPtr, aiMatrix4x4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiBone_mOffsetMatrix_get(swigCPtr);
      aiMatrix4x4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiMatrix4x4(cPtr, false);
      return ret;
    } 
  }

  public aiVertexWeightArray Weights {
    set {
      assimp_swigPINVOKE.aiBone_Weights_set(swigCPtr, aiVertexWeightArray.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiBone_Weights_get(swigCPtr);
      aiVertexWeightArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiVertexWeightArray(cPtr, false);
      return ret;
    } 
  }

  public aiBone() : this(assimp_swigPINVOKE.new_aiBone__SWIG_0(), true) {
  }

  public aiBone(aiBone other) : this(assimp_swigPINVOKE.new_aiBone__SWIG_1(aiBone.getCPtr(other)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiBone op_set(aiBone other) {
    aiBone ret = new aiBone(assimp_swigPINVOKE.aiBone_op_set(swigCPtr, aiBone.getCPtr(other)), false);
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_equal(aiBone rhs) {
    bool ret = assimp_swigPINVOKE.aiBone_op_equal(swigCPtr, aiBone.getCPtr(rhs));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

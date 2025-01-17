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

public class aiQuatKey : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiQuatKey(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiQuatKey obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiQuatKey() {
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
          assimp_swigPINVOKE.delete_aiQuatKey(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public double mTime {
    set {
      assimp_swigPINVOKE.aiQuatKey_mTime_set(swigCPtr, value);
    } 
    get {
      double ret = assimp_swigPINVOKE.aiQuatKey_mTime_get(swigCPtr);
      return ret;
    } 
  }

  public aiQuaternion mValue {
    set {
      assimp_swigPINVOKE.aiQuatKey_mValue_set(swigCPtr, aiQuaternion.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiQuatKey_mValue_get(swigCPtr);
      aiQuaternion ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiQuaternion(cPtr, false);
      return ret;
    } 
  }

  public aiQuatKey() : this(assimp_swigPINVOKE.new_aiQuatKey__SWIG_0(), true) {
  }

  public aiQuatKey(double time, aiQuaternion value) : this(assimp_swigPINVOKE.new_aiQuatKey__SWIG_1(time, aiQuaternion.getCPtr(value)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool op_equal(aiQuatKey rhs) {
    bool ret = assimp_swigPINVOKE.aiQuatKey_op_equal(swigCPtr, aiQuatKey.getCPtr(rhs));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_not_equal(aiQuatKey rhs) {
    bool ret = assimp_swigPINVOKE.aiQuatKey_op_not_equal(swigCPtr, aiQuatKey.getCPtr(rhs));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_lesser(aiQuatKey rhs) {
    bool ret = assimp_swigPINVOKE.aiQuatKey_op_lesser(swigCPtr, aiQuatKey.getCPtr(rhs));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool op_greater(aiQuatKey rhs) {
    bool ret = assimp_swigPINVOKE.aiQuatKey_op_greater(swigCPtr, aiQuatKey.getCPtr(rhs));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

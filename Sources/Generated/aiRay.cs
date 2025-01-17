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

public class aiRay : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiRay(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiRay obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiRay() {
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
          assimp_swigPINVOKE.delete_aiRay(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public aiRay() : this(assimp_swigPINVOKE.new_aiRay__SWIG_0(), true) {
  }

  public aiRay(aiVector3D _pos, aiVector3D _dir) : this(assimp_swigPINVOKE.new_aiRay__SWIG_1(aiVector3D.getCPtr(_pos), aiVector3D.getCPtr(_dir)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiRay(aiRay o) : this(assimp_swigPINVOKE.new_aiRay__SWIG_2(aiRay.getCPtr(o)), true) {
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiVector3D pos {
    set {
      assimp_swigPINVOKE.aiRay_pos_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiRay_pos_get(swigCPtr);
      aiVector3D ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

  public aiVector3D dir {
    set {
      assimp_swigPINVOKE.aiRay_dir_set(swigCPtr, aiVector3D.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiRay_dir_get(swigCPtr);
      aiVector3D ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiVector3D(cPtr, false);
      return ret;
    } 
  }

}

}

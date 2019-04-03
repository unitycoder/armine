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

public class aiMemoryInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiMemoryInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiMemoryInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiMemoryInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          assimp_swigPINVOKE.delete_aiMemoryInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public aiMemoryInfo() : this(assimp_swigPINVOKE.new_aiMemoryInfo(), true) {
  }

  public uint textures {
    set {
      assimp_swigPINVOKE.aiMemoryInfo_textures_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMemoryInfo_textures_get(swigCPtr);
      return ret;
    } 
  }

  public uint materials {
    set {
      assimp_swigPINVOKE.aiMemoryInfo_materials_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMemoryInfo_materials_get(swigCPtr);
      return ret;
    } 
  }

  public uint meshes {
    set {
      assimp_swigPINVOKE.aiMemoryInfo_meshes_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMemoryInfo_meshes_get(swigCPtr);
      return ret;
    } 
  }

  public uint nodes {
    set {
      assimp_swigPINVOKE.aiMemoryInfo_nodes_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMemoryInfo_nodes_get(swigCPtr);
      return ret;
    } 
  }

  public uint animations {
    set {
      assimp_swigPINVOKE.aiMemoryInfo_animations_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMemoryInfo_animations_get(swigCPtr);
      return ret;
    } 
  }

  public uint cameras {
    set {
      assimp_swigPINVOKE.aiMemoryInfo_cameras_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMemoryInfo_cameras_get(swigCPtr);
      return ret;
    } 
  }

  public uint lights {
    set {
      assimp_swigPINVOKE.aiMemoryInfo_lights_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMemoryInfo_lights_get(swigCPtr);
      return ret;
    } 
  }

  public uint total {
    set {
      assimp_swigPINVOKE.aiMemoryInfo_total_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiMemoryInfo_total_get(swigCPtr);
      return ret;
    } 
  }

}

}

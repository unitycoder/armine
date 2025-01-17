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

public class aiTexture : global::System.IDisposable, Interface.Unmanagable<aiTexture> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiTexture(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(aiTexture obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiTexture() {
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
          assimp_swigPINVOKE.delete_aiTexture(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  [global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet=global::System.Runtime.InteropServices.CharSet.Ansi)]
  private struct Texture {
    public uint mWidth;
    public uint mHeight;
    [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst=9)] public string achFormatHint;
    public global::System.IntPtr pcData;
  }

  public byte[] data {
    set {
      AllocData((uint) value.Length);
      
      Texture texture = (Texture) global::System.Runtime.InteropServices.Marshal.PtrToStructure(swigCPtr.Handle, typeof(Texture));
      global::System.Runtime.InteropServices.Marshal.Copy(value, 0, texture.pcData, value.Length);
    }
    get {
      byte[] data = null;
	
      if(mHeight == 0) {
        data = new byte[mWidth];

	    Texture texture = (Texture) global::System.Runtime.InteropServices.Marshal.PtrToStructure(swigCPtr.Handle, typeof(Texture));
        global::System.Runtime.InteropServices.Marshal.Copy(texture.pcData, data, 0, (int) texture.mWidth);
      }

      return data;
    }
  }

  // We need to define manually this method because swig seems to not accept multiple 'cscode' typemaps for the same class
  public aiTexture Unmanaged() {
    this.swigCMemOwn = false;
    return this;
  }

  public uint mWidth {
    set {
      assimp_swigPINVOKE.aiTexture_mWidth_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiTexture_mWidth_get(swigCPtr);
      return ret;
    } 
  }

  public uint mHeight {
    set {
      assimp_swigPINVOKE.aiTexture_mHeight_set(swigCPtr, value);
    } 
    get {
      uint ret = assimp_swigPINVOKE.aiTexture_mHeight_get(swigCPtr);
      return ret;
    } 
  }

  public string achFormatHint {
    set {
      assimp_swigPINVOKE.aiTexture_achFormatHint_set(swigCPtr, value);
    } 
    get {
      string ret = assimp_swigPINVOKE.aiTexture_achFormatHint_get(swigCPtr);
      return ret;
    } 
  }

  public aiString mFilename {
    set {
      assimp_swigPINVOKE.aiTexture_mFilename_set(swigCPtr, aiString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = assimp_swigPINVOKE.aiTexture_mFilename_get(swigCPtr);
      aiString ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiString(cPtr, false);
      return ret;
    } 
  }

  public bool CheckFormat(string s) {
    bool ret = assimp_swigPINVOKE.aiTexture_CheckFormat(swigCPtr, s);
    return ret;
  }

  public aiTexture() : this(assimp_swigPINVOKE.new_aiTexture(), true) {
  }

  public void AllocData(uint size) {
    assimp_swigPINVOKE.aiTexture_AllocData(swigCPtr, size);
  }

}

}

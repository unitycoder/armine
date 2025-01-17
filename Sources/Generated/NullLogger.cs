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

public class NullLogger : Logger {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal NullLogger(global::System.IntPtr cPtr, bool cMemoryOwn) : base(assimp_swigPINVOKE.NullLogger_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NullLogger obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          assimp_swigPINVOKE.delete_NullLogger(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual void OnDebug(string message) {
    assimp_swigPINVOKE.NullLogger_OnDebug(swigCPtr, message);
  }

  public virtual void OnInfo(string message) {
    assimp_swigPINVOKE.NullLogger_OnInfo(swigCPtr, message);
  }

  public virtual void OnWarn(string message) {
    assimp_swigPINVOKE.NullLogger_OnWarn(swigCPtr, message);
  }

  public virtual void OnError(string message) {
    assimp_swigPINVOKE.NullLogger_OnError(swigCPtr, message);
  }

  public override bool attachStream(LogStream pStream, Logger.ErrorSeverity severity) {
    bool ret = assimp_swigPINVOKE.NullLogger_attachStream(swigCPtr, LogStream.getCPtr(pStream), (uint)severity);
    return ret;
  }

  public override bool detatchStream(LogStream pStream, Logger.ErrorSeverity severity) {
    bool ret = assimp_swigPINVOKE.NullLogger_detatchStream(swigCPtr, LogStream.getCPtr(pStream), (uint)severity);
    return ret;
  }

}

}

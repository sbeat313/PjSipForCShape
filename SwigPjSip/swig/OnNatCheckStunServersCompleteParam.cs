//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pjsua2xamarin.pjsua2 {

public class OnNatCheckStunServersCompleteParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OnNatCheckStunServersCompleteParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnNatCheckStunServersCompleteParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OnNatCheckStunServersCompleteParam() {
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
          pjsua2PINVOKE.delete_OnNatCheckStunServersCompleteParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_void userData {
    set {
      pjsua2PINVOKE.OnNatCheckStunServersCompleteParam_userData_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnNatCheckStunServersCompleteParam_userData_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public int status {
    set {
      pjsua2PINVOKE.OnNatCheckStunServersCompleteParam_status_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.OnNatCheckStunServersCompleteParam_status_get(swigCPtr);
      return ret;
    } 
  }

  public string name {
    set {
      pjsua2PINVOKE.OnNatCheckStunServersCompleteParam_name_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.OnNatCheckStunServersCompleteParam_name_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string addr {
    set {
      pjsua2PINVOKE.OnNatCheckStunServersCompleteParam_addr_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.OnNatCheckStunServersCompleteParam_addr_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public OnNatCheckStunServersCompleteParam() : this(pjsua2PINVOKE.new_OnNatCheckStunServersCompleteParam(), true) {
  }

}

}

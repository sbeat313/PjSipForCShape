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

public class SipEventBody : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SipEventBody(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SipEventBody obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SipEventBody() {
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
          pjsua2PINVOKE.delete_SipEventBody(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TimerEvent timer {
    set {
      pjsua2PINVOKE.SipEventBody_timer_set(swigCPtr, TimerEvent.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipEventBody_timer_get(swigCPtr);
      TimerEvent ret = (cPtr == global::System.IntPtr.Zero) ? null : new TimerEvent(cPtr, false);
      return ret;
    } 
  }

  public TsxStateEvent tsxState {
    set {
      pjsua2PINVOKE.SipEventBody_tsxState_set(swigCPtr, TsxStateEvent.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipEventBody_tsxState_get(swigCPtr);
      TsxStateEvent ret = (cPtr == global::System.IntPtr.Zero) ? null : new TsxStateEvent(cPtr, false);
      return ret;
    } 
  }

  public TxMsgEvent txMsg {
    set {
      pjsua2PINVOKE.SipEventBody_txMsg_set(swigCPtr, TxMsgEvent.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipEventBody_txMsg_get(swigCPtr);
      TxMsgEvent ret = (cPtr == global::System.IntPtr.Zero) ? null : new TxMsgEvent(cPtr, false);
      return ret;
    } 
  }

  public TxErrorEvent txError {
    set {
      pjsua2PINVOKE.SipEventBody_txError_set(swigCPtr, TxErrorEvent.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipEventBody_txError_get(swigCPtr);
      TxErrorEvent ret = (cPtr == global::System.IntPtr.Zero) ? null : new TxErrorEvent(cPtr, false);
      return ret;
    } 
  }

  public RxMsgEvent rxMsg {
    set {
      pjsua2PINVOKE.SipEventBody_rxMsg_set(swigCPtr, RxMsgEvent.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipEventBody_rxMsg_get(swigCPtr);
      RxMsgEvent ret = (cPtr == global::System.IntPtr.Zero) ? null : new RxMsgEvent(cPtr, false);
      return ret;
    } 
  }

  public UserEvent user {
    set {
      pjsua2PINVOKE.SipEventBody_user_set(swigCPtr, UserEvent.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipEventBody_user_get(swigCPtr);
      UserEvent ret = (cPtr == global::System.IntPtr.Zero) ? null : new UserEvent(cPtr, false);
      return ret;
    } 
  }

  public SipEventBody() : this(pjsua2PINVOKE.new_SipEventBody(), true) {
  }

}

}

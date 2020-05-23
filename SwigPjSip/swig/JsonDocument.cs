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

public class JsonDocument : PersistentDocument {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal JsonDocument(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.JsonDocument_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JsonDocument obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_JsonDocument(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public JsonDocument() : this(pjsua2PINVOKE.new_JsonDocument(), true) {
  }

  public override void loadFile(string filename) {
    pjsua2PINVOKE.JsonDocument_loadFile(swigCPtr, filename);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void loadString(string input) {
    pjsua2PINVOKE.JsonDocument_loadString(swigCPtr, input);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void saveFile(string filename) {
    pjsua2PINVOKE.JsonDocument_saveFile(swigCPtr, filename);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override string saveString() {
    string ret = pjsua2PINVOKE.JsonDocument_saveString(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ContainerNode getRootContainer() {
    ContainerNode ret = new ContainerNode(pjsua2PINVOKE.JsonDocument_getRootContainer(swigCPtr), false);
    return ret;
  }

}

}

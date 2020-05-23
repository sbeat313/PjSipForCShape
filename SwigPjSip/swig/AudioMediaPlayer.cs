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

public class AudioMediaPlayer : AudioMedia {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AudioMediaPlayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.AudioMediaPlayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AudioMediaPlayer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_AudioMediaPlayer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public AudioMediaPlayer() : this(pjsua2PINVOKE.new_AudioMediaPlayer(), true) {
    SwigDirectorConnect();
  }

  public void createPlayer(string file_name, uint options) {
    pjsua2PINVOKE.AudioMediaPlayer_createPlayer__SWIG_0(swigCPtr, file_name, options);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void createPlayer(string file_name) {
    pjsua2PINVOKE.AudioMediaPlayer_createPlayer__SWIG_1(swigCPtr, file_name);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void createPlaylist(StringVector file_names, string label, uint options) {
    pjsua2PINVOKE.AudioMediaPlayer_createPlaylist__SWIG_0(swigCPtr, StringVector.getCPtr(file_names), label, options);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void createPlaylist(StringVector file_names, string label) {
    pjsua2PINVOKE.AudioMediaPlayer_createPlaylist__SWIG_1(swigCPtr, StringVector.getCPtr(file_names), label);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void createPlaylist(StringVector file_names) {
    pjsua2PINVOKE.AudioMediaPlayer_createPlaylist__SWIG_2(swigCPtr, StringVector.getCPtr(file_names));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public AudioMediaPlayerInfo getInfo() {
    AudioMediaPlayerInfo ret = new AudioMediaPlayerInfo(pjsua2PINVOKE.AudioMediaPlayer_getInfo(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getPos() {
    uint ret = pjsua2PINVOKE.AudioMediaPlayer_getPos(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPos(uint samples) {
    pjsua2PINVOKE.AudioMediaPlayer_setPos(swigCPtr, samples);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public static AudioMediaPlayer typecastFromAudioMedia(AudioMedia media) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.AudioMediaPlayer_typecastFromAudioMedia(AudioMedia.getCPtr(media));
    AudioMediaPlayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new AudioMediaPlayer(cPtr, false);
    return ret;
  }

  public virtual void onEof2() {
    if (SwigDerivedClassHasMethod("onEof2", swigMethodTypes0)) pjsua2PINVOKE.AudioMediaPlayer_onEof2SwigExplicitAudioMediaPlayer(swigCPtr); else pjsua2PINVOKE.AudioMediaPlayer_onEof2(swigCPtr);
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onEof2", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateAudioMediaPlayer_0(SwigDirectorMethodonEof2);
    pjsua2PINVOKE.AudioMediaPlayer_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(AudioMediaPlayer));
    return hasDerivedMethod;
  }

  private void SwigDirectorMethodonEof2() {
    onEof2();
  }

  public delegate void SwigDelegateAudioMediaPlayer_0();

  private SwigDelegateAudioMediaPlayer_0 swigDelegate0;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
}

}

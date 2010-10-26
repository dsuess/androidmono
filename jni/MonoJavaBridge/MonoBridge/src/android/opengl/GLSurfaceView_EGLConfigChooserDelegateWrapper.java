package android.opengl;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class GLSurfaceView_EGLConfigChooserDelegateWrapper extends java.lang.Object implements MonoProxy, android.opengl.GLSurfaceView.EGLConfigChooser
{
	static
	{
		MonoBridge.link(GLSurfaceView_EGLConfigChooserDelegateWrapper.class, "chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;", "javax.microedition.khronos.egl.EGL10,javax.microedition.khronos.egl.EGLDisplay");

	}

	@Override
	public native javax.microedition.khronos.egl.EGLConfig chooseConfig(javax.microedition.khronos.egl.EGL10 arg0,javax.microedition.khronos.egl.EGLDisplay arg1);


	long myGCHandle;
	public long getGCHandle() {
		return myGCHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGCHandle = gcHandle;
	}

	@Override
	protected void finalize() throws Throwable {
	    super.finalize();
	    MonoBridge.releaseGCHandle(myGCHandle);
	}
}
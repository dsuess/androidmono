package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DialogInterface_OnCancelListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.content.DialogInterface.OnCancelListener
{
	static
	{
		MonoBridge.link(DialogInterface_OnCancelListenerDelegateWrapper.class, "onCancel", "(Landroid/content/DialogInterface;)V", "android.content.DialogInterface");

	}

	@Override
	public native void onCancel(android.content.DialogInterface arg0);


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
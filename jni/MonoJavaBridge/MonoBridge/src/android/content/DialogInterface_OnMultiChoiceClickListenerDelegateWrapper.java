package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DialogInterface_OnMultiChoiceClickListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.content.DialogInterface.OnMultiChoiceClickListener
{
	static
	{
		MonoBridge.link(DialogInterface_OnMultiChoiceClickListenerDelegateWrapper.class, "onClick", "(Landroid/content/DialogInterface;IZ)V", "android.content.DialogInterface,System.Int32,System.Boolean");

	}

	@Override
	public native void onClick(android.content.DialogInterface arg0,int arg1,boolean arg2);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}

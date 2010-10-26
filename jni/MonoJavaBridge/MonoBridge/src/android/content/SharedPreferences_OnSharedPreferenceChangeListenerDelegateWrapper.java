package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.content.SharedPreferences.OnSharedPreferenceChangeListener
{
	static
	{
		MonoBridge.link(SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper.class, "onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V", "android.content.SharedPreferences,java.lang.String");

	}

	@Override
	public native void onSharedPreferenceChanged(android.content.SharedPreferences arg0,java.lang.String arg1);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}

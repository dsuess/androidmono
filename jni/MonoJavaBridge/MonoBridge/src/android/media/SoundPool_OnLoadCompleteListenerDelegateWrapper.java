package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SoundPool_OnLoadCompleteListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.media.SoundPool.OnLoadCompleteListener
{
	static
	{
		MonoBridge.link(SoundPool_OnLoadCompleteListenerDelegateWrapper.class, "onLoadComplete", "(Landroid/media/SoundPool;II)V", "android.media.SoundPool,System.Int32,System.Int32");

	}

	@Override
	public native void onLoadComplete(android.media.SoundPool arg0,int arg1,int arg2);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}

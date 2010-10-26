package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnVideoSizeChangedListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.media.MediaPlayer.OnVideoSizeChangedListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnVideoSizeChangedListenerDelegateWrapper.class, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V", "android.media.MediaPlayer,System.Int32,System.Int32");

	}

	@Override
	public native void onVideoSizeChanged(android.media.MediaPlayer arg0,int arg1,int arg2);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}

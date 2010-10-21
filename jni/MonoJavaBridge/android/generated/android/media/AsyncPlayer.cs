namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AsyncPlayer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AsyncPlayer()
		{
			InitJNI();
		}
		protected AsyncPlayer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _stop6964;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AsyncPlayer._stop6964);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AsyncPlayer.staticClass, global::android.media.AsyncPlayer._stop6964);
		}
		internal static global::MonoJavaBridge.MethodId _play6965;
		public virtual void play(android.content.Context arg0, android.net.Uri arg1, bool arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AsyncPlayer._play6965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AsyncPlayer.staticClass, global::android.media.AsyncPlayer._play6965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _AsyncPlayer6966;
		public AsyncPlayer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AsyncPlayer.staticClass, global::android.media.AsyncPlayer._AsyncPlayer6966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.AsyncPlayer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AsyncPlayer"));
			global::android.media.AsyncPlayer._stop6964 = @__env.GetMethodIDNoThrow(global::android.media.AsyncPlayer.staticClass, "stop", "()V");
			global::android.media.AsyncPlayer._play6965 = @__env.GetMethodIDNoThrow(global::android.media.AsyncPlayer.staticClass, "play", "(Landroid/content/Context;Landroid/net/Uri;ZI)V");
			global::android.media.AsyncPlayer._AsyncPlayer6966 = @__env.GetMethodIDNoThrow(global::android.media.AsyncPlayer.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}

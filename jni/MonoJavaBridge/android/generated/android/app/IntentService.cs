namespace android.app
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.IntentService_))]
	public abstract partial class IntentService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IntentService()
		{
			InitJNI();
		}
		protected IntentService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onBind1907;
		public override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.IntentService._onBind1907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.IntentService.staticClass, global::android.app.IntentService._onBind1907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1908;
		public override void onCreate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.IntentService._onCreate1908);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.IntentService.staticClass, global::android.app.IntentService._onCreate1908);
		}
		internal static global::MonoJavaBridge.MethodId _onStart1909;
		public override void onStart(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.IntentService._onStart1909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.IntentService.staticClass, global::android.app.IntentService._onStart1909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onStartCommand1910;
		public override int onStartCommand(android.content.Intent arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.IntentService._onStartCommand1910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.IntentService.staticClass, global::android.app.IntentService._onStartCommand1910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy1911;
		public override void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.IntentService._onDestroy1911);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.IntentService.staticClass, global::android.app.IntentService._onDestroy1911);
		}
		internal static global::MonoJavaBridge.MethodId _setIntentRedelivery1912;
		public virtual void setIntentRedelivery(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.IntentService._setIntentRedelivery1912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.IntentService.staticClass, global::android.app.IntentService._setIntentRedelivery1912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onHandleIntent1913;
		protected abstract void onHandleIntent(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _IntentService1914;
		public IntentService(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.IntentService.staticClass, global::android.app.IntentService._IntentService1914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.IntentService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/IntentService"));
			global::android.app.IntentService._onBind1907 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.app.IntentService._onCreate1908 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onCreate", "()V");
			global::android.app.IntentService._onStart1909 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onStart", "(Landroid/content/Intent;I)V");
			global::android.app.IntentService._onStartCommand1910 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I");
			global::android.app.IntentService._onDestroy1911 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onDestroy", "()V");
			global::android.app.IntentService._setIntentRedelivery1912 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "setIntentRedelivery", "(Z)V");
			global::android.app.IntentService._onHandleIntent1913 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onHandleIntent", "(Landroid/content/Intent;)V");
			global::android.app.IntentService._IntentService1914 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.IntentService))]
	public sealed partial class IntentService_ : android.app.IntentService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IntentService_()
		{
			InitJNI();
		}
		internal IntentService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onHandleIntent1915;
		protected override void onHandleIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.IntentService_._onHandleIntent1915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.IntentService_.staticClass, global::android.app.IntentService_._onHandleIntent1915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.IntentService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/IntentService"));
			global::android.app.IntentService_._onHandleIntent1915 = @__env.GetMethodIDNoThrow(global::android.app.IntentService_.staticClass, "onHandleIntent", "(Landroid/content/Intent;)V");
		}
	}
}

namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.BroadcastReceiver_))]
	public abstract partial class BroadcastReceiver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BroadcastReceiver()
		{
			InitJNI();
		}
		protected BroadcastReceiver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceive2582;
		public abstract void onReceive(android.content.Context arg0, android.content.Intent arg1);
		internal static global::MonoJavaBridge.MethodId _peekService2583;
		public virtual global::android.os.IBinder peekService(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver._peekService2583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._peekService2583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _setResultCode2584;
		public virtual void setResultCode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResultCode2584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultCode2584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultCode2585;
		public virtual int getResultCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getResultCode2585);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultCode2585);
		}
		internal static global::MonoJavaBridge.MethodId _setResultData2586;
		public virtual void setResultData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResultData2586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultData2586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultData2587;
		public virtual global::java.lang.String getResultData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getResultData2587)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultData2587)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setResultExtras2588;
		public virtual void setResultExtras(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResultExtras2588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResultExtras2588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultExtras2589;
		public virtual global::android.os.Bundle getResultExtras(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getResultExtras2589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getResultExtras2589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _setResult2590;
		public virtual void setResult(int arg0, java.lang.String arg1, android.os.Bundle arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setResult2590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setResult2590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAbortBroadcast2591;
		public virtual bool getAbortBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getAbortBroadcast2591);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getAbortBroadcast2591);
		}
		internal static global::MonoJavaBridge.MethodId _abortBroadcast2592;
		public virtual void abortBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._abortBroadcast2592);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._abortBroadcast2592);
		}
		internal static global::MonoJavaBridge.MethodId _clearAbortBroadcast2593;
		public virtual void clearAbortBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._clearAbortBroadcast2593);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._clearAbortBroadcast2593);
		}
		internal static global::MonoJavaBridge.MethodId _isOrderedBroadcast2594;
		public virtual bool isOrderedBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._isOrderedBroadcast2594);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._isOrderedBroadcast2594);
		}
		internal static global::MonoJavaBridge.MethodId _isInitialStickyBroadcast2595;
		public virtual bool isInitialStickyBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._isInitialStickyBroadcast2595);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._isInitialStickyBroadcast2595);
		}
		internal static global::MonoJavaBridge.MethodId _setOrderedHint2596;
		public virtual void setOrderedHint(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setOrderedHint2596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setOrderedHint2596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDebugUnregister2597;
		public virtual void setDebugUnregister(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver._setDebugUnregister2597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._setDebugUnregister2597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDebugUnregister2598;
		public virtual bool getDebugUnregister() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver._getDebugUnregister2598);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._getDebugUnregister2598);
		}
		internal static global::MonoJavaBridge.MethodId _BroadcastReceiver2599;
		public BroadcastReceiver()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.BroadcastReceiver.staticClass, global::android.content.BroadcastReceiver._BroadcastReceiver2599);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.BroadcastReceiver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/BroadcastReceiver"));
			global::android.content.BroadcastReceiver._onReceive2582 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			global::android.content.BroadcastReceiver._peekService2583 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "peekService", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.content.BroadcastReceiver._setResultCode2584 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResultCode", "(I)V");
			global::android.content.BroadcastReceiver._getResultCode2585 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getResultCode", "()I");
			global::android.content.BroadcastReceiver._setResultData2586 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResultData", "(Ljava/lang/String;)V");
			global::android.content.BroadcastReceiver._getResultData2587 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getResultData", "()Ljava/lang/String;");
			global::android.content.BroadcastReceiver._setResultExtras2588 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResultExtras", "(Landroid/os/Bundle;)V");
			global::android.content.BroadcastReceiver._getResultExtras2589 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getResultExtras", "(Z)Landroid/os/Bundle;");
			global::android.content.BroadcastReceiver._setResult2590 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setResult", "(ILjava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.BroadcastReceiver._getAbortBroadcast2591 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getAbortBroadcast", "()Z");
			global::android.content.BroadcastReceiver._abortBroadcast2592 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "abortBroadcast", "()V");
			global::android.content.BroadcastReceiver._clearAbortBroadcast2593 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "clearAbortBroadcast", "()V");
			global::android.content.BroadcastReceiver._isOrderedBroadcast2594 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "isOrderedBroadcast", "()Z");
			global::android.content.BroadcastReceiver._isInitialStickyBroadcast2595 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "isInitialStickyBroadcast", "()Z");
			global::android.content.BroadcastReceiver._setOrderedHint2596 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setOrderedHint", "(Z)V");
			global::android.content.BroadcastReceiver._setDebugUnregister2597 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "setDebugUnregister", "(Z)V");
			global::android.content.BroadcastReceiver._getDebugUnregister2598 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "getDebugUnregister", "()Z");
			global::android.content.BroadcastReceiver._BroadcastReceiver2599 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.BroadcastReceiver))]
	public sealed partial class BroadcastReceiver_ : android.content.BroadcastReceiver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BroadcastReceiver_()
		{
			InitJNI();
		}
		internal BroadcastReceiver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onReceive2600;
		public override void onReceive(android.content.Context arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver_._onReceive2600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.BroadcastReceiver_.staticClass, global::android.content.BroadcastReceiver_._onReceive2600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.BroadcastReceiver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/BroadcastReceiver"));
			global::android.content.BroadcastReceiver_._onReceive2600 = @__env.GetMethodIDNoThrow(global::android.content.BroadcastReceiver_.staticClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
		}
	}
}

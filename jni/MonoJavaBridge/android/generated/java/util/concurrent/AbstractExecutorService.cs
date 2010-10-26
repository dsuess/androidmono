namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.concurrent.AbstractExecutorService_))]
	public abstract partial class AbstractExecutorService : java.lang.Object, ExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractExecutorService()
		{
			InitJNI();
		}
		protected AbstractExecutorService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27024;
		public abstract void shutdown();
		internal static global::MonoJavaBridge.MethodId _awaitTermination27025;
		public abstract bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1);
		internal static global::MonoJavaBridge.MethodId _shutdownNow27026;
		public abstract global::java.util.List shutdownNow();
		internal static global::MonoJavaBridge.MethodId _isShutdown27027;
		public abstract bool isShutdown();
		internal static global::MonoJavaBridge.MethodId _isTerminated27028;
		public abstract bool isTerminated();
		internal static global::MonoJavaBridge.MethodId _execute27029;
		public abstract void execute(java.lang.Runnable arg0);
		internal static global::MonoJavaBridge.MethodId _submit27030;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService._submit27030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._submit27030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27031;
		public virtual global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService._submit27031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._submit27031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27032;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService._submit27032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._submit27032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny27033;
		public virtual global::java.lang.Object invokeAny(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService._invokeAny27033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._invokeAny27033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny27034;
		public virtual global::java.lang.Object invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService._invokeAny27034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._invokeAny27034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll27035;
		public virtual global::java.util.List invokeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService._invokeAll27035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._invokeAll27035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll27036;
		public virtual global::java.util.List invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService._invokeAll27036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._invokeAll27036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractExecutorService27037;
		public AbstractExecutorService()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.AbstractExecutorService.staticClass, global::java.util.concurrent.AbstractExecutorService._AbstractExecutorService27037);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.AbstractExecutorService.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/AbstractExecutorService"));
			global::java.util.concurrent.AbstractExecutorService._shutdown27024 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "shutdown", "()V");
			global::java.util.concurrent.AbstractExecutorService._awaitTermination27025 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.AbstractExecutorService._shutdownNow27026 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "shutdownNow", "()Ljava/util/List;");
			global::java.util.concurrent.AbstractExecutorService._isShutdown27027 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "isShutdown", "()Z");
			global::java.util.concurrent.AbstractExecutorService._isTerminated27028 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "isTerminated", "()Z");
			global::java.util.concurrent.AbstractExecutorService._execute27029 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "execute", "(Ljava/lang/Runnable;)V");
			global::java.util.concurrent.AbstractExecutorService._submit27030 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.AbstractExecutorService._submit27031 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.AbstractExecutorService._submit27032 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.AbstractExecutorService._invokeAny27033 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.concurrent.AbstractExecutorService._invokeAny27034 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.AbstractExecutorService._invokeAll27035 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;");
			global::java.util.concurrent.AbstractExecutorService._invokeAll27036 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;");
			global::java.util.concurrent.AbstractExecutorService._AbstractExecutorService27037 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.AbstractExecutorService))]
	internal sealed partial class AbstractExecutorService_ : java.util.concurrent.AbstractExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractExecutorService_()
		{
			InitJNI();
		}
		internal AbstractExecutorService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27038;
		public override void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._shutdown27038);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_.staticClass, global::java.util.concurrent.AbstractExecutorService_._shutdown27038);
		}
		internal static global::MonoJavaBridge.MethodId _awaitTermination27039;
		public override bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._awaitTermination27039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_.staticClass, global::java.util.concurrent.AbstractExecutorService_._awaitTermination27039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow27040;
		public override global::java.util.List shutdownNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._shutdownNow27040)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_.staticClass, global::java.util.concurrent.AbstractExecutorService_._shutdownNow27040)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isShutdown27041;
		public override bool isShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._isShutdown27041);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_.staticClass, global::java.util.concurrent.AbstractExecutorService_._isShutdown27041);
		}
		internal static global::MonoJavaBridge.MethodId _isTerminated27042;
		public override bool isTerminated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._isTerminated27042);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_.staticClass, global::java.util.concurrent.AbstractExecutorService_._isTerminated27042);
		}
		internal static global::MonoJavaBridge.MethodId _execute27043;
		public override void execute(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_._execute27043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.AbstractExecutorService_.staticClass, global::java.util.concurrent.AbstractExecutorService_._execute27043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.AbstractExecutorService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/AbstractExecutorService"));
			global::java.util.concurrent.AbstractExecutorService_._shutdown27038 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "shutdown", "()V");
			global::java.util.concurrent.AbstractExecutorService_._awaitTermination27039 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.AbstractExecutorService_._shutdownNow27040 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "shutdownNow", "()Ljava/util/List;");
			global::java.util.concurrent.AbstractExecutorService_._isShutdown27041 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "isShutdown", "()Z");
			global::java.util.concurrent.AbstractExecutorService_._isTerminated27042 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "isTerminated", "()Z");
			global::java.util.concurrent.AbstractExecutorService_._execute27043 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.AbstractExecutorService_.staticClass, "execute", "(Ljava/lang/Runnable;)V");
		}
	}
}

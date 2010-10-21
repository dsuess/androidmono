namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ScheduledFuture_))]
	public interface ScheduledFuture : Delayed, Future
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ScheduledFuture))]
	public sealed partial class ScheduledFuture_ : java.lang.Object, ScheduledFuture
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScheduledFuture_()
		{
			InitJNI();
		}
		internal ScheduledFuture_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDelay27266;
		 long java.util.concurrent.Delayed.getDelay(java.util.concurrent.TimeUnit arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._getDelay27266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._getDelay27266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo27267;
		 int java.lang.Comparable.compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._compareTo27267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._compareTo27267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get27268;
		 global::java.lang.Object java.util.concurrent.Future.get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._get27268)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._get27268)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get27269;
		 global::java.lang.Object java.util.concurrent.Future.get(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._get27269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._get27269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _cancel27270;
		 bool java.util.concurrent.Future.cancel(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._cancel27270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._cancel27270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCancelled27271;
		 bool java.util.concurrent.Future.isCancelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._isCancelled27271);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._isCancelled27271);
		}
		internal static global::MonoJavaBridge.MethodId _isDone27272;
		 bool java.util.concurrent.Future.isDone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._isDone27272);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._isDone27272);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ScheduledFuture_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ScheduledFuture"));
			global::java.util.concurrent.ScheduledFuture_._getDelay27266 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "getDelay", "(Ljava/util/concurrent/TimeUnit;)J");
			global::java.util.concurrent.ScheduledFuture_._compareTo27267 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.ScheduledFuture_._get27268 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "get", "()Ljava/lang/Object;");
			global::java.util.concurrent.ScheduledFuture_._get27269 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.ScheduledFuture_._cancel27270 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "cancel", "(Z)Z");
			global::java.util.concurrent.ScheduledFuture_._isCancelled27271 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "isCancelled", "()Z");
			global::java.util.concurrent.ScheduledFuture_._isDone27272 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "isDone", "()Z");
		}
	}
}

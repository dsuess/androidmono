namespace org.apache.http.impl.conn.tsccm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RefQueueWorker : java.lang.Object, java.lang.Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RefQueueWorker()
		{
			InitJNI();
		}
		protected RefQueueWorker(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run33035;
		public virtual void run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RefQueueWorker._run33035);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, global::org.apache.http.impl.conn.tsccm.RefQueueWorker._run33035);
		}
		internal static global::MonoJavaBridge.MethodId _shutdown33036;
		public virtual void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RefQueueWorker._shutdown33036);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, global::org.apache.http.impl.conn.tsccm.RefQueueWorker._shutdown33036);
		}
		internal static global::MonoJavaBridge.MethodId _toString33037;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RefQueueWorker._toString33037)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, global::org.apache.http.impl.conn.tsccm.RefQueueWorker._toString33037)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _RefQueueWorker33038;
		public RefQueueWorker(java.lang.@ref.ReferenceQueue arg0, org.apache.http.impl.conn.tsccm.RefQueueHandler arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, global::org.apache.http.impl.conn.tsccm.RefQueueWorker._RefQueueWorker33038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/conn/tsccm/RefQueueWorker"));
			global::org.apache.http.impl.conn.tsccm.RefQueueWorker._run33035 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, "run", "()V");
			global::org.apache.http.impl.conn.tsccm.RefQueueWorker._shutdown33036 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, "shutdown", "()V");
			global::org.apache.http.impl.conn.tsccm.RefQueueWorker._toString33037 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.impl.conn.tsccm.RefQueueWorker._RefQueueWorker33038 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.conn.tsccm.RefQueueWorker.staticClass, "<init>", "(Ljava/lang/@ref/ReferenceQueue;Lorg/apache/http/impl/conn/tsccm/RefQueueHandler;)V");
		}
	}
}

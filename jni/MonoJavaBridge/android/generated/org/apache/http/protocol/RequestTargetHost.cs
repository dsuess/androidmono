namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestTargetHost : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RequestTargetHost()
		{
			InitJNI();
		}
		protected RequestTargetHost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33825;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.RequestTargetHost._process33825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.RequestTargetHost.staticClass, global::org.apache.http.protocol.RequestTargetHost._process33825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestTargetHost33826;
		public RequestTargetHost()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.RequestTargetHost.staticClass, global::org.apache.http.protocol.RequestTargetHost._RequestTargetHost33826);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.RequestTargetHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/RequestTargetHost"));
			global::org.apache.http.protocol.RequestTargetHost._process33825 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestTargetHost.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.RequestTargetHost._RequestTargetHost33826 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestTargetHost.staticClass, "<init>", "()V");
		}
	}
}

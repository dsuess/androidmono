namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResponseProcessCookies : java.lang.Object, HttpResponseInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResponseProcessCookies(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.client.protocol.ResponseProcessCookies._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ResponseProcessCookies() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.protocol.ResponseProcessCookies._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.protocol.ResponseProcessCookies._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.ResponseProcessCookies.staticClass, global::org.apache.http.client.protocol.ResponseProcessCookies._m1);
			Init(@__env, handle);
		}
		static ResponseProcessCookies()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/ResponseProcessCookies"));
		}
		internal static void InitJNI()
		{
		}
	}
}
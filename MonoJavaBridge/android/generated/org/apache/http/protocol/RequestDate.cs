namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestDate : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RequestDate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.RequestDate.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.RequestDate._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public RequestDate() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.RequestDate._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.RequestDate._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestDate.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.RequestDate.staticClass, global::org.apache.http.protocol.RequestDate._m1);
			Init(@__env, handle);
		}
		static RequestDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.RequestDate.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/RequestDate"));
		}
		internal static void InitJNI()
		{
		}
	}
}
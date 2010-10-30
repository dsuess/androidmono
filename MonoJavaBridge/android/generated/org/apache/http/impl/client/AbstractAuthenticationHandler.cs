namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.client.AbstractAuthenticationHandler_))]
	public abstract partial class AbstractAuthenticationHandler : java.lang.Object, org.apache.http.client.AuthenticationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractAuthenticationHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract bool isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.util.Map getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.apache.http.auth.AuthScheme selectScheme(java.util.Map arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.AuthScheme>(this, global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "selectScheme", "(Ljava/util/Map;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/auth/AuthScheme;", ref global::org.apache.http.impl.client.AbstractAuthenticationHandler._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.auth.AuthScheme;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual global::java.util.Map parseChallenges(org.apache.http.Header[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "parseChallenges", "([Lorg/apache/http/Header;)Ljava/util/Map;", ref global::org.apache.http.impl.client.AbstractAuthenticationHandler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual global::java.util.List getAuthPreferences()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "getAuthPreferences", "()Ljava/util/List;", ref global::org.apache.http.impl.client.AbstractAuthenticationHandler._m4) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public AbstractAuthenticationHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.AbstractAuthenticationHandler._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.AbstractAuthenticationHandler._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler._m5);
			Init(@__env, handle);
		}
		static AbstractAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractAuthenticationHandler"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.client.AbstractAuthenticationHandler))]
	internal sealed partial class AbstractAuthenticationHandler_ : org.apache.http.impl.client.AbstractAuthenticationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractAuthenticationHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass, "isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", ref global::org.apache.http.impl.client.AbstractAuthenticationHandler_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Map getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass, "getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/Map;", ref global::org.apache.http.impl.client.AbstractAuthenticationHandler_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.Map;
		}
		static AbstractAuthenticationHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractAuthenticationHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
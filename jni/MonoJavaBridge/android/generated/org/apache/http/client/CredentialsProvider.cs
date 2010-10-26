namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.CredentialsProvider_))]
	public partial interface CredentialsProvider  : global::MonoJavaBridge.IJavaObject 
	{
		void clear();
		global::org.apache.http.auth.Credentials getCredentials(org.apache.http.auth.AuthScope arg0);
		void setCredentials(org.apache.http.auth.AuthScope arg0, org.apache.http.auth.Credentials arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.CredentialsProvider))]
	internal sealed partial class CredentialsProvider_ : java.lang.Object, CredentialsProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CredentialsProvider_()
		{
			InitJNI();
		}
		internal CredentialsProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clear31877;
		 void org.apache.http.client.CredentialsProvider.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.CredentialsProvider_._clear31877);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.CredentialsProvider_.staticClass, global::org.apache.http.client.CredentialsProvider_._clear31877);
		}
		internal static global::MonoJavaBridge.MethodId _getCredentials31878;
		 global::org.apache.http.auth.Credentials org.apache.http.client.CredentialsProvider.getCredentials(org.apache.http.auth.AuthScope arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.Credentials>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.CredentialsProvider_._getCredentials31878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.auth.Credentials;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.Credentials>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.CredentialsProvider_.staticClass, global::org.apache.http.client.CredentialsProvider_._getCredentials31878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.auth.Credentials;
		}
		internal static global::MonoJavaBridge.MethodId _setCredentials31879;
		 void org.apache.http.client.CredentialsProvider.setCredentials(org.apache.http.auth.AuthScope arg0, org.apache.http.auth.Credentials arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.CredentialsProvider_._setCredentials31879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.CredentialsProvider_.staticClass, global::org.apache.http.client.CredentialsProvider_._setCredentials31879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.CredentialsProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/CredentialsProvider"));
			global::org.apache.http.client.CredentialsProvider_._clear31877 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CredentialsProvider_.staticClass, "clear", "()V");
			global::org.apache.http.client.CredentialsProvider_._getCredentials31878 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CredentialsProvider_.staticClass, "getCredentials", "(Lorg/apache/http/auth/AuthScope;)Lorg/apache/http/auth/Credentials;");
			global::org.apache.http.client.CredentialsProvider_._setCredentials31879 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.CredentialsProvider_.staticClass, "setCredentials", "(Lorg/apache/http/auth/AuthScope;Lorg/apache/http/auth/Credentials;)V");
		}
	}
}

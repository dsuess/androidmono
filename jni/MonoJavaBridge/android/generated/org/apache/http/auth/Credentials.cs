namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.auth.Credentials_))]
	public interface Credentials  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getPassword();
		global::java.security.Principal getUserPrincipal();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.auth.Credentials))]
	public sealed partial class Credentials_ : java.lang.Object, Credentials
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Credentials_()
		{
			InitJNI();
		}
		internal Credentials_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPassword31707;
		 global::java.lang.String org.apache.http.auth.Credentials.getPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.Credentials_._getPassword31707)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.Credentials_.staticClass, global::org.apache.http.auth.Credentials_._getPassword31707)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getUserPrincipal31708;
		 global::java.security.Principal org.apache.http.auth.Credentials.getUserPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.Credentials_._getUserPrincipal31708)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.Credentials_.staticClass, global::org.apache.http.auth.Credentials_._getUserPrincipal31708)) as java.security.Principal;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.Credentials_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/Credentials"));
			global::org.apache.http.auth.Credentials_._getPassword31707 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.Credentials_.staticClass, "getPassword", "()Ljava/lang/String;");
			global::org.apache.http.auth.Credentials_._getUserPrincipal31708 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.Credentials_.staticClass, "getUserPrincipal", "()Ljava/security/Principal;");
		}
	}
}

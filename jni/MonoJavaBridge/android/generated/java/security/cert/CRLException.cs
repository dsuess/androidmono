namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CRLException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CRLException()
		{
			InitJNI();
		}
		protected CRLException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CRLException23354;
		public CRLException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CRLException.staticClass, global::java.security.cert.CRLException._CRLException23354);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CRLException23355;
		public CRLException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CRLException.staticClass, global::java.security.cert.CRLException._CRLException23355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CRLException23356;
		public CRLException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CRLException.staticClass, global::java.security.cert.CRLException._CRLException23356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CRLException23357;
		public CRLException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CRLException.staticClass, global::java.security.cert.CRLException._CRLException23357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CRLException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CRLException"));
			global::java.security.cert.CRLException._CRLException23354 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRLException.staticClass, "<init>", "()V");
			global::java.security.cert.CRLException._CRLException23355 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRLException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.cert.CRLException._CRLException23356 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRLException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.cert.CRLException._CRLException23357 = @__env.GetMethodIDNoThrow(global::java.security.cert.CRLException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}

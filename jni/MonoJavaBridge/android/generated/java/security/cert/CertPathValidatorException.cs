namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathValidatorException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPathValidatorException()
		{
			InitJNI();
		}
		protected CertPathValidatorException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndex23402;
		public virtual int getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorException._getIndex23402);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._getIndex23402);
		}
		public new global::java.security.cert.CertPath CertPath
		{
			get
			{
				return getCertPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertPath23403;
		public virtual global::java.security.cert.CertPath getCertPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorException._getCertPath23403)) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._getCertPath23403)) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorException23404;
		public CertPathValidatorException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._CertPathValidatorException23404);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorException23405;
		public CertPathValidatorException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._CertPathValidatorException23405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorException23406;
		public CertPathValidatorException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._CertPathValidatorException23406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorException23407;
		public CertPathValidatorException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._CertPathValidatorException23407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorException23408;
		public CertPathValidatorException(java.lang.String arg0, java.lang.Throwable arg1, java.security.cert.CertPath arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._CertPathValidatorException23408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidatorException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidatorException"));
			global::java.security.cert.CertPathValidatorException._getIndex23402 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "getIndex", "()I");
			global::java.security.cert.CertPathValidatorException._getCertPath23403 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "getCertPath", "()Ljava/security/cert/CertPath;");
			global::java.security.cert.CertPathValidatorException._CertPathValidatorException23404 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "()V");
			global::java.security.cert.CertPathValidatorException._CertPathValidatorException23405 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.cert.CertPathValidatorException._CertPathValidatorException23406 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.security.cert.CertPathValidatorException._CertPathValidatorException23407 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.cert.CertPathValidatorException._CertPathValidatorException23408 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/security/cert/CertPath;I)V");
		}
	}
}

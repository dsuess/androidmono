namespace android.net.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SslError : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SslError()
		{
			InitJNI();
		}
		protected SslError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7961;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslError._toString7961)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslError.staticClass, global::android.net.http.SslError._toString7961)) as java.lang.String;
		}
		public new global::android.net.http.SslCertificate Certificate
		{
			get
			{
				return getCertificate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertificate7962;
		public virtual global::android.net.http.SslCertificate getCertificate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.http.SslError._getCertificate7962)) as android.net.http.SslCertificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.http.SslError.staticClass, global::android.net.http.SslError._getCertificate7962)) as android.net.http.SslCertificate;
		}
		internal static global::MonoJavaBridge.MethodId _hasError7963;
		public virtual bool hasError(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.http.SslError._hasError7963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.http.SslError.staticClass, global::android.net.http.SslError._hasError7963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addError7964;
		public virtual bool addError(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.http.SslError._addError7964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.http.SslError.staticClass, global::android.net.http.SslError._addError7964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int PrimaryError
		{
			get
			{
				return getPrimaryError();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrimaryError7965;
		public virtual int getPrimaryError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.http.SslError._getPrimaryError7965);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.http.SslError.staticClass, global::android.net.http.SslError._getPrimaryError7965);
		}
		internal static global::MonoJavaBridge.MethodId _SslError7966;
		public SslError(int arg0, android.net.http.SslCertificate arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslError.staticClass, global::android.net.http.SslError._SslError7966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SslError7967;
		public SslError(int arg0, java.security.cert.X509Certificate arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.http.SslError.staticClass, global::android.net.http.SslError._SslError7967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int SSL_NOTYETVALID
		{
			get
			{
				return 0;
			}
		}
		public static int SSL_EXPIRED
		{
			get
			{
				return 1;
			}
		}
		public static int SSL_IDMISMATCH
		{
			get
			{
				return 2;
			}
		}
		public static int SSL_UNTRUSTED
		{
			get
			{
				return 3;
			}
		}
		public static int SSL_MAX_ERROR
		{
			get
			{
				return 4;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.http.SslError.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/http/SslError"));
			global::android.net.http.SslError._toString7961 = @__env.GetMethodIDNoThrow(global::android.net.http.SslError.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.http.SslError._getCertificate7962 = @__env.GetMethodIDNoThrow(global::android.net.http.SslError.staticClass, "getCertificate", "()Landroid/net/http/SslCertificate;");
			global::android.net.http.SslError._hasError7963 = @__env.GetMethodIDNoThrow(global::android.net.http.SslError.staticClass, "hasError", "(I)Z");
			global::android.net.http.SslError._addError7964 = @__env.GetMethodIDNoThrow(global::android.net.http.SslError.staticClass, "addError", "(I)Z");
			global::android.net.http.SslError._getPrimaryError7965 = @__env.GetMethodIDNoThrow(global::android.net.http.SslError.staticClass, "getPrimaryError", "()I");
			global::android.net.http.SslError._SslError7966 = @__env.GetMethodIDNoThrow(global::android.net.http.SslError.staticClass, "<init>", "(ILandroid/net/http/SslCertificate;)V");
			global::android.net.http.SslError._SslError7967 = @__env.GetMethodIDNoThrow(global::android.net.http.SslError.staticClass, "<init>", "(ILjava/security/cert/X509Certificate;)V");
		}
	}
}

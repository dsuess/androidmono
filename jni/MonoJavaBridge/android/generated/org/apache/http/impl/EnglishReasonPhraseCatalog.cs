namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EnglishReasonPhraseCatalog : java.lang.Object, ReasonPhraseCatalog
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EnglishReasonPhraseCatalog()
		{
			InitJNI();
		}
		protected EnglishReasonPhraseCatalog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getReason32531;
		public virtual global::java.lang.String getReason(int arg0, java.util.Locale arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.EnglishReasonPhraseCatalog._getReason32531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, global::org.apache.http.impl.EnglishReasonPhraseCatalog._getReason32531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _EnglishReasonPhraseCatalog32532;
		protected EnglishReasonPhraseCatalog()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, global::org.apache.http.impl.EnglishReasonPhraseCatalog._EnglishReasonPhraseCatalog32532);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _INSTANCE32533;
		public static global::org.apache.http.impl.EnglishReasonPhraseCatalog INSTANCE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, _INSTANCE32533)) as org.apache.http.impl.EnglishReasonPhraseCatalog;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/EnglishReasonPhraseCatalog"));
			global::org.apache.http.impl.EnglishReasonPhraseCatalog._getReason32531 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, "getReason", "(ILjava/util/Locale;)Ljava/lang/String;");
			global::org.apache.http.impl.EnglishReasonPhraseCatalog._EnglishReasonPhraseCatalog32532 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, "<init>", "()V");
			global::org.apache.http.impl.EnglishReasonPhraseCatalog._INSTANCE32533 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, "INSTANCE", "Lorg/apache/http/impl/EnglishReasonPhraseCatalog;");
		}
	}
}

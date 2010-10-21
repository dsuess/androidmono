namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MissingFormatArgumentException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MissingFormatArgumentException()
		{
			InitJNI();
		}
		protected MissingFormatArgumentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage26397;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.MissingFormatArgumentException._getMessage26397)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.MissingFormatArgumentException.staticClass, global::java.util.MissingFormatArgumentException._getMessage26397)) as java.lang.String;
		}
		public new global::java.lang.String FormatSpecifier
		{
			get
			{
				return getFormatSpecifier();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFormatSpecifier26398;
		public virtual global::java.lang.String getFormatSpecifier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.MissingFormatArgumentException._getFormatSpecifier26398)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.MissingFormatArgumentException.staticClass, global::java.util.MissingFormatArgumentException._getFormatSpecifier26398)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MissingFormatArgumentException26399;
		public MissingFormatArgumentException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.MissingFormatArgumentException.staticClass, global::java.util.MissingFormatArgumentException._MissingFormatArgumentException26399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.MissingFormatArgumentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/MissingFormatArgumentException"));
			global::java.util.MissingFormatArgumentException._getMessage26397 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatArgumentException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.MissingFormatArgumentException._getFormatSpecifier26398 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatArgumentException.staticClass, "getFormatSpecifier", "()Ljava/lang/String;");
			global::java.util.MissingFormatArgumentException._MissingFormatArgumentException26399 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatArgumentException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}

namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DuplicateFormatFlagsException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DuplicateFormatFlagsException()
		{
			InitJNI();
		}
		protected DuplicateFormatFlagsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage26017;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.DuplicateFormatFlagsException._getMessage26017)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.DuplicateFormatFlagsException.staticClass, global::java.util.DuplicateFormatFlagsException._getMessage26017)) as java.lang.String;
		}
		public new global::java.lang.String Flags
		{
			get
			{
				return getFlags();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFlags26018;
		public virtual global::java.lang.String getFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.DuplicateFormatFlagsException._getFlags26018)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.DuplicateFormatFlagsException.staticClass, global::java.util.DuplicateFormatFlagsException._getFlags26018)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _DuplicateFormatFlagsException26019;
		public DuplicateFormatFlagsException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.DuplicateFormatFlagsException.staticClass, global::java.util.DuplicateFormatFlagsException._DuplicateFormatFlagsException26019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.DuplicateFormatFlagsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/DuplicateFormatFlagsException"));
			global::java.util.DuplicateFormatFlagsException._getMessage26017 = @__env.GetMethodIDNoThrow(global::java.util.DuplicateFormatFlagsException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.util.DuplicateFormatFlagsException._getFlags26018 = @__env.GetMethodIDNoThrow(global::java.util.DuplicateFormatFlagsException.staticClass, "getFlags", "()Ljava/lang/String;");
			global::java.util.DuplicateFormatFlagsException._DuplicateFormatFlagsException26019 = @__env.GetMethodIDNoThrow(global::java.util.DuplicateFormatFlagsException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}

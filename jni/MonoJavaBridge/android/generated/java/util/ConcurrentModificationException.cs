namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConcurrentModificationException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConcurrentModificationException()
		{
			InitJNI();
		}
		protected ConcurrentModificationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentModificationException26077;
		public ConcurrentModificationException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ConcurrentModificationException.staticClass, global::java.util.ConcurrentModificationException._ConcurrentModificationException26077);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConcurrentModificationException26078;
		public ConcurrentModificationException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ConcurrentModificationException.staticClass, global::java.util.ConcurrentModificationException._ConcurrentModificationException26078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ConcurrentModificationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ConcurrentModificationException"));
			global::java.util.ConcurrentModificationException._ConcurrentModificationException26077 = @__env.GetMethodIDNoThrow(global::java.util.ConcurrentModificationException.staticClass, "<init>", "()V");
			global::java.util.ConcurrentModificationException._ConcurrentModificationException26078 = @__env.GetMethodIDNoThrow(global::java.util.ConcurrentModificationException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}

namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AbstractMethodError : java.lang.IncompatibleClassChangeError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractMethodError()
		{
			InitJNI();
		}
		protected AbstractMethodError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AbstractMethodError19536;
		public AbstractMethodError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AbstractMethodError.staticClass, global::java.lang.AbstractMethodError._AbstractMethodError19536);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbstractMethodError19537;
		public AbstractMethodError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AbstractMethodError.staticClass, global::java.lang.AbstractMethodError._AbstractMethodError19537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AbstractMethodError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AbstractMethodError"));
			global::java.lang.AbstractMethodError._AbstractMethodError19536 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractMethodError.staticClass, "<init>", "()V");
			global::java.lang.AbstractMethodError._AbstractMethodError19537 = @__env.GetMethodIDNoThrow(global::java.lang.AbstractMethodError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}

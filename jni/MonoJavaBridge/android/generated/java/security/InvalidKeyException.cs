namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidKeyException : java.security.KeyException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidKeyException()
		{
			InitJNI();
		}
		protected InvalidKeyException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeyException22881;
		public InvalidKeyException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidKeyException.staticClass, global::java.security.InvalidKeyException._InvalidKeyException22881);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeyException22882;
		public InvalidKeyException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidKeyException.staticClass, global::java.security.InvalidKeyException._InvalidKeyException22882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeyException22883;
		public InvalidKeyException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidKeyException.staticClass, global::java.security.InvalidKeyException._InvalidKeyException22883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidKeyException22884;
		public InvalidKeyException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.InvalidKeyException.staticClass, global::java.security.InvalidKeyException._InvalidKeyException22884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.InvalidKeyException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/InvalidKeyException"));
			global::java.security.InvalidKeyException._InvalidKeyException22881 = @__env.GetMethodIDNoThrow(global::java.security.InvalidKeyException.staticClass, "<init>", "()V");
			global::java.security.InvalidKeyException._InvalidKeyException22882 = @__env.GetMethodIDNoThrow(global::java.security.InvalidKeyException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.InvalidKeyException._InvalidKeyException22883 = @__env.GetMethodIDNoThrow(global::java.security.InvalidKeyException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.InvalidKeyException._InvalidKeyException22884 = @__env.GetMethodIDNoThrow(global::java.security.InvalidKeyException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}

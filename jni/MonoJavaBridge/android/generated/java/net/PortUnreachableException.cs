namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PortUnreachableException : java.net.SocketException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PortUnreachableException()
		{
			InitJNI();
		}
		protected PortUnreachableException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _PortUnreachableException21654;
		public PortUnreachableException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.PortUnreachableException.staticClass, global::java.net.PortUnreachableException._PortUnreachableException21654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PortUnreachableException21655;
		public PortUnreachableException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.PortUnreachableException.staticClass, global::java.net.PortUnreachableException._PortUnreachableException21655);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.PortUnreachableException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/PortUnreachableException"));
			global::java.net.PortUnreachableException._PortUnreachableException21654 = @__env.GetMethodIDNoThrow(global::java.net.PortUnreachableException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.PortUnreachableException._PortUnreachableException21655 = @__env.GetMethodIDNoThrow(global::java.net.PortUnreachableException.staticClass, "<init>", "()V");
		}
	}
}

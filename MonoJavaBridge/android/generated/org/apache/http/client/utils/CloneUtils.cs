namespace org.apache.http.client.utils
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CloneUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CloneUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.Object clone(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.utils.CloneUtils._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.utils.CloneUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.client.utils.CloneUtils.staticClass, "clone", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.client.utils.CloneUtils.staticClass, global::org.apache.http.client.utils.CloneUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		static CloneUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.utils.CloneUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/utils/CloneUtils"));
		}
		internal static void InitJNI()
		{
		}
	}
}
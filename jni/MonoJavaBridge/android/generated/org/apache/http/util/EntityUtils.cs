namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class EntityUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EntityUtils()
		{
			InitJNI();
		}
		internal EntityUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33891;
		public static global::java.lang.String toString(org.apache.http.HttpEntity arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.EntityUtils.staticClass, global::org.apache.http.util.EntityUtils._toString33891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString33892;
		public static global::java.lang.String toString(org.apache.http.HttpEntity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.EntityUtils.staticClass, global::org.apache.http.util.EntityUtils._toString33892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray33893;
		public static byte[] toByteArray(org.apache.http.HttpEntity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(org.apache.http.util.EntityUtils.staticClass, global::org.apache.http.util.EntityUtils._toByteArray33893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getContentCharSet33894;
		public static global::java.lang.String getContentCharSet(org.apache.http.HttpEntity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.util.EntityUtils.staticClass, global::org.apache.http.util.EntityUtils._getContentCharSet33894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.EntityUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/EntityUtils"));
			global::org.apache.http.util.EntityUtils._toString33891 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EntityUtils.staticClass, "toString", "(Lorg/apache/http/HttpEntity;Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.util.EntityUtils._toString33892 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EntityUtils.staticClass, "toString", "(Lorg/apache/http/HttpEntity;)Ljava/lang/String;");
			global::org.apache.http.util.EntityUtils._toByteArray33893 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EntityUtils.staticClass, "toByteArray", "(Lorg/apache/http/HttpEntity;)[B");
			global::org.apache.http.util.EntityUtils._getContentCharSet33894 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.EntityUtils.staticClass, "getContentCharSet", "(Lorg/apache/http/HttpEntity;)Ljava/lang/String;");
		}
	}
}

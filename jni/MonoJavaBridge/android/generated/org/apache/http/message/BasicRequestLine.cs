namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicRequestLine : java.lang.Object, RequestLine, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicRequestLine()
		{
			InitJNI();
		}
		protected BasicRequestLine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33520;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicRequestLine._toString33520)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._toString33520)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone33521;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicRequestLine._clone33521)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._clone33521)) as java.lang.Object;
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod33522;
		public virtual global::java.lang.String getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicRequestLine._getMethod33522)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._getMethod33522)) as java.lang.String;
		}
		public new global::org.apache.http.ProtocolVersion ProtocolVersion
		{
			get
			{
				return getProtocolVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion33523;
		public virtual global::org.apache.http.ProtocolVersion getProtocolVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicRequestLine._getProtocolVersion33523)) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._getProtocolVersion33523)) as org.apache.http.ProtocolVersion;
		}
		public new global::java.lang.String Uri
		{
			get
			{
				return getUri();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUri33524;
		public virtual global::java.lang.String getUri() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicRequestLine._getUri33524)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._getUri33524)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _BasicRequestLine33525;
		public BasicRequestLine(java.lang.String arg0, java.lang.String arg1, org.apache.http.ProtocolVersion arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicRequestLine.staticClass, global::org.apache.http.message.BasicRequestLine._BasicRequestLine33525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicRequestLine.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicRequestLine"));
			global::org.apache.http.message.BasicRequestLine._toString33520 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicRequestLine._clone33521 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicRequestLine._getMethod33522 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicRequestLine._getProtocolVersion33523 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.BasicRequestLine._getUri33524 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "getUri", "()Ljava/lang/String;");
			global::org.apache.http.message.BasicRequestLine._BasicRequestLine33525 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicRequestLine.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V");
		}
	}
}

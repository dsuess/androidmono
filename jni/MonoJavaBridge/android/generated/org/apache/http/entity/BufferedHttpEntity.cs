namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BufferedHttpEntity : org.apache.http.entity.HttpEntityWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BufferedHttpEntity()
		{
			InitJNI();
		}
		protected BufferedHttpEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32396;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._getContent32396)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._getContent32396)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32397;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._writeTo32397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._writeTo32397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32398;
		public override long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._getContentLength32398);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._getContentLength32398);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32399;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._isRepeatable32399);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._isRepeatable32399);
		}
		internal static global::MonoJavaBridge.MethodId _isChunked32400;
		public override bool isChunked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._isChunked32400);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._isChunked32400);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32401;
		public override bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity._isStreaming32401);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._isStreaming32401);
		}
		internal static global::MonoJavaBridge.MethodId _BufferedHttpEntity32402;
		public BufferedHttpEntity(org.apache.http.HttpEntity arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.BufferedHttpEntity.staticClass, global::org.apache.http.entity.BufferedHttpEntity._BufferedHttpEntity32402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.BufferedHttpEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/BufferedHttpEntity"));
			global::org.apache.http.entity.BufferedHttpEntity._getContent32396 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.BufferedHttpEntity._writeTo32397 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.BufferedHttpEntity._getContentLength32398 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.BufferedHttpEntity._isRepeatable32399 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.BufferedHttpEntity._isChunked32400 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isChunked", "()Z");
			global::org.apache.http.entity.BufferedHttpEntity._isStreaming32401 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.BufferedHttpEntity._BufferedHttpEntity32402 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BufferedHttpEntity.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;)V");
		}
	}
}

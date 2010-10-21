namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpEntity : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHttpEntity()
		{
			InitJNI();
		}
		protected BasicHttpEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
			set
			{
				setContent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32387;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._getContent32387)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._getContent32387)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32388;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._writeTo32388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._writeTo32388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
			set
			{
				setContentLength(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32389;
		public override long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._getContentLength32389);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._getContentLength32389);
		}
		internal static global::MonoJavaBridge.MethodId _setContentLength32390;
		public virtual void setContentLength(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._setContentLength32390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._setContentLength32390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32391;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._isRepeatable32391);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._isRepeatable32391);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32392;
		public override bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._isStreaming32392);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._isStreaming32392);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent32393;
		public override void consumeContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._consumeContent32393);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._consumeContent32393);
		}
		internal static global::MonoJavaBridge.MethodId _setContent32394;
		public virtual void setContent(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._setContent32394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._setContent32394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpEntity32395;
		public BasicHttpEntity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._BasicHttpEntity32395);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.BasicHttpEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/BasicHttpEntity"));
			global::org.apache.http.entity.BasicHttpEntity._getContent32387 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.BasicHttpEntity._writeTo32388 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.BasicHttpEntity._getContentLength32389 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.BasicHttpEntity._setContentLength32390 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "setContentLength", "(J)V");
			global::org.apache.http.entity.BasicHttpEntity._isRepeatable32391 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.BasicHttpEntity._isStreaming32392 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.BasicHttpEntity._consumeContent32393 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.BasicHttpEntity._setContent32394 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "setContent", "(Ljava/io/InputStream;)V");
			global::org.apache.http.entity.BasicHttpEntity._BasicHttpEntity32395 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "<init>", "()V");
		}
	}
}

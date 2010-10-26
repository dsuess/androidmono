namespace javax.xml.transform.stream
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamSource : java.lang.Object, Source
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StreamSource()
		{
			InitJNI();
		}
		protected StreamSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
			set
			{
				setInputStream(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream31162;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource._getInputStream31162)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._getInputStream31162)) as java.io.InputStream;
		}
		public new global::java.lang.String PublicId
		{
			get
			{
				return getPublicId();
			}
			set
			{
				setPublicId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId31163;
		public virtual global::java.lang.String getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource._getPublicId31163)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._getPublicId31163)) as java.lang.String;
		}
		public new global::java.lang.String SystemId
		{
			get
			{
				return getSystemId();
			}
			set
			{
				setSystemId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId31164;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource._getSystemId31164)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._getSystemId31164)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setInputStream31165;
		public virtual void setInputStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource._setInputStream31165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._setInputStream31165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31166;
		public virtual void setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource._setSystemId31166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._setSystemId31166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31167;
		public virtual void setSystemId(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource._setSystemId31167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._setSystemId31167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPublicId31168;
		public virtual void setPublicId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource._setPublicId31168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._setPublicId31168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.Reader Reader
		{
			get
			{
				return getReader();
			}
			set
			{
				setReader(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReader31169;
		public virtual global::java.io.Reader getReader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource._getReader31169)) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._getReader31169)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setReader31170;
		public virtual void setReader(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource._setReader31170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._setReader31170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31171;
		public StreamSource(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31172;
		public StreamSource(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31173;
		public StreamSource(java.io.InputStream arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31174;
		public StreamSource()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31174);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31175;
		public StreamSource(java.io.Reader arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31176;
		public StreamSource(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31177;
		public StreamSource(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.stream.StreamSource/feature";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.stream.StreamSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/stream/StreamSource"));
			global::javax.xml.transform.stream.StreamSource._getInputStream31162 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::javax.xml.transform.stream.StreamSource._getPublicId31163 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::javax.xml.transform.stream.StreamSource._getSystemId31164 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.stream.StreamSource._setInputStream31165 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "setInputStream", "(Ljava/io/InputStream;)V");
			global::javax.xml.transform.stream.StreamSource._setSystemId31166 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.stream.StreamSource._setSystemId31167 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "setSystemId", "(Ljava/io/File;)V");
			global::javax.xml.transform.stream.StreamSource._setPublicId31168 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "setPublicId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.stream.StreamSource._getReader31169 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "getReader", "()Ljava/io/Reader;");
			global::javax.xml.transform.stream.StreamSource._setReader31170 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "setReader", "(Ljava/io/Reader;)V");
			global::javax.xml.transform.stream.StreamSource._StreamSource31171 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::javax.xml.transform.stream.StreamSource._StreamSource31172 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::javax.xml.transform.stream.StreamSource._StreamSource31173 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::javax.xml.transform.stream.StreamSource._StreamSource31174 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "()V");
			global::javax.xml.transform.stream.StreamSource._StreamSource31175 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/Reader;Ljava/lang/String;)V");
			global::javax.xml.transform.stream.StreamSource._StreamSource31176 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.transform.stream.StreamSource._StreamSource31177 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/File;)V");
		}
	}
}

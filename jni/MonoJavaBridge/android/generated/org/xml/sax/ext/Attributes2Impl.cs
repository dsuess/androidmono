namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Attributes2Impl : org.xml.sax.helpers.AttributesImpl, Attributes2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Attributes2Impl()
		{
			InitJNI();
		}
		protected Attributes2Impl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addAttribute35094;
		public override void addAttribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._addAttribute35094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._addAttribute35094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute35095;
		public override void removeAttribute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._removeAttribute35095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._removeAttribute35095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttributes35096;
		public override void setAttributes(org.xml.sax.Attributes arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._setAttributes35096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._setAttributes35096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified35097;
		public virtual bool isSpecified(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isSpecified35097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isSpecified35097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified35098;
		public virtual bool isSpecified(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isSpecified35098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isSpecified35098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpecified35099;
		public virtual bool isSpecified(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isSpecified35099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isSpecified35099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared35100;
		public virtual bool isDeclared(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isDeclared35100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isDeclared35100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared35101;
		public virtual bool isDeclared(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isDeclared35101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isDeclared35101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isDeclared35102;
		public virtual bool isDeclared(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._isDeclared35102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._isDeclared35102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDeclared35103;
		public virtual void setDeclared(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._setDeclared35103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._setDeclared35103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSpecified35104;
		public virtual void setSpecified(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl._setSpecified35104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._setSpecified35104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Attributes2Impl35105;
		public Attributes2Impl(org.xml.sax.Attributes arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl35105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Attributes2Impl35106;
		public Attributes2Impl()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Attributes2Impl.staticClass, global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl35106);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Attributes2Impl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Attributes2Impl"));
			global::org.xml.sax.ext.Attributes2Impl._addAttribute35094 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.Attributes2Impl._removeAttribute35095 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "removeAttribute", "(I)V");
			global::org.xml.sax.ext.Attributes2Impl._setAttributes35096 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "setAttributes", "(Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.ext.Attributes2Impl._isSpecified35097 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isSpecified35098 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(I)Z");
			global::org.xml.sax.ext.Attributes2Impl._isSpecified35099 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isSpecified", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isDeclared35100 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isDeclared35101 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.ext.Attributes2Impl._isDeclared35102 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "isDeclared", "(I)Z");
			global::org.xml.sax.ext.Attributes2Impl._setDeclared35103 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "setDeclared", "(IZ)V");
			global::org.xml.sax.ext.Attributes2Impl._setSpecified35104 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "setSpecified", "(IZ)V");
			global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl35105 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "<init>", "(Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.ext.Attributes2Impl._Attributes2Impl35106 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Attributes2Impl.staticClass, "<init>", "()V");
		}
	}
}

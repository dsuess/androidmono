namespace android.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Element : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Element()
		{
			InitJNI();
		}
		protected Element(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7239;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.sax.Element._toString7239)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.sax.Element.staticClass, global::android.sax.Element._toString7239)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getChild7240;
		public virtual global::android.sax.Element getChild(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.sax.Element._getChild7240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.sax.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.sax.Element.staticClass, global::android.sax.Element._getChild7240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.sax.Element;
		}
		internal static global::MonoJavaBridge.MethodId _getChild7241;
		public virtual global::android.sax.Element getChild(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.sax.Element._getChild7241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.sax.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.sax.Element.staticClass, global::android.sax.Element._getChild7241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.sax.Element;
		}
		internal static global::MonoJavaBridge.MethodId _requireChild7242;
		public virtual global::android.sax.Element requireChild(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.sax.Element._requireChild7242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.sax.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.sax.Element.staticClass, global::android.sax.Element._requireChild7242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.sax.Element;
		}
		internal static global::MonoJavaBridge.MethodId _requireChild7243;
		public virtual global::android.sax.Element requireChild(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.sax.Element._requireChild7243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.sax.Element;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.sax.Element.staticClass, global::android.sax.Element._requireChild7243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.sax.Element;
		}
		internal static global::MonoJavaBridge.MethodId _setElementListener7244;
		public virtual void setElementListener(android.sax.ElementListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.Element._setElementListener7244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.Element.staticClass, global::android.sax.Element._setElementListener7244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTextElementListener7245;
		public virtual void setTextElementListener(android.sax.TextElementListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.Element._setTextElementListener7245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.Element.staticClass, global::android.sax.Element._setTextElementListener7245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStartElementListener7246;
		public virtual void setStartElementListener(android.sax.StartElementListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.Element._setStartElementListener7246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.Element.staticClass, global::android.sax.Element._setStartElementListener7246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEndElementListener7247;
		public virtual void setEndElementListener(android.sax.EndElementListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.Element._setEndElementListener7247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.Element.staticClass, global::android.sax.Element._setEndElementListener7247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEndTextElementListener7248;
		public virtual void setEndTextElementListener(android.sax.EndTextElementListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.sax.Element._setEndTextElementListener7248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.sax.Element.staticClass, global::android.sax.Element._setEndTextElementListener7248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.Element.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/Element"));
			global::android.sax.Element._toString7239 = @__env.GetMethodIDNoThrow(global::android.sax.Element.staticClass, "toString", "()Ljava/lang/String;");
			global::android.sax.Element._getChild7240 = @__env.GetMethodIDNoThrow(global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;");
			global::android.sax.Element._getChild7241 = @__env.GetMethodIDNoThrow(global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;)Landroid/sax/Element;");
			global::android.sax.Element._requireChild7242 = @__env.GetMethodIDNoThrow(global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;)Landroid/sax/Element;");
			global::android.sax.Element._requireChild7243 = @__env.GetMethodIDNoThrow(global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;");
			global::android.sax.Element._setElementListener7244 = @__env.GetMethodIDNoThrow(global::android.sax.Element.staticClass, "setElementListener", "(Landroid/sax/ElementListener;)V");
			global::android.sax.Element._setTextElementListener7245 = @__env.GetMethodIDNoThrow(global::android.sax.Element.staticClass, "setTextElementListener", "(Landroid/sax/TextElementListener;)V");
			global::android.sax.Element._setStartElementListener7246 = @__env.GetMethodIDNoThrow(global::android.sax.Element.staticClass, "setStartElementListener", "(Landroid/sax/StartElementListener;)V");
			global::android.sax.Element._setEndElementListener7247 = @__env.GetMethodIDNoThrow(global::android.sax.Element.staticClass, "setEndElementListener", "(Landroid/sax/EndElementListener;)V");
			global::android.sax.Element._setEndTextElementListener7248 = @__env.GetMethodIDNoThrow(global::android.sax.Element.staticClass, "setEndTextElementListener", "(Landroid/sax/EndTextElementListener;)V");
		}
	}
}

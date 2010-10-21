namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XmlPullParserException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XmlPullParserException()
		{
			InitJNI();
		}
		protected XmlPullParserException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace35246;
		public override void printStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException._printStackTrace35246);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._printStackTrace35246);
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber35247;
		public virtual int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException._getLineNumber35247);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._getLineNumber35247);
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35248;
		public virtual int getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException._getColumnNumber35248);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._getColumnNumber35248);
		}
		public new global::java.lang.Throwable Detail
		{
			get
			{
				return getDetail();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDetail35249;
		public virtual global::java.lang.Throwable getDetail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException._getDetail35249)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._getDetail35249)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _XmlPullParserException35250;
		public XmlPullParserException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._XmlPullParserException35250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XmlPullParserException35251;
		public XmlPullParserException(java.lang.String arg0, org.xmlpull.v1.XmlPullParser arg1, java.lang.Throwable arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.XmlPullParserException.staticClass, global::org.xmlpull.v1.XmlPullParserException._XmlPullParserException35251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.XmlPullParserException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/XmlPullParserException"));
			global::org.xmlpull.v1.XmlPullParserException._printStackTrace35246 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "printStackTrace", "()V");
			global::org.xmlpull.v1.XmlPullParserException._getLineNumber35247 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "getLineNumber", "()I");
			global::org.xmlpull.v1.XmlPullParserException._getColumnNumber35248 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "getColumnNumber", "()I");
			global::org.xmlpull.v1.XmlPullParserException._getDetail35249 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "getDetail", "()Ljava/lang/Throwable;");
			global::org.xmlpull.v1.XmlPullParserException._XmlPullParserException35250 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.XmlPullParserException._XmlPullParserException35251 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.XmlPullParserException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xmlpull/v1/XmlPullParser;Ljava/lang/Throwable;)V");
		}
	}
}

namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BestMatchSpec : java.lang.Object, org.apache.http.cookie.CookieSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BestMatchSpec()
		{
			InitJNI();
		}
		protected BestMatchSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33149;
		public virtual global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec._parse33149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, global::org.apache.http.impl.cookie.BestMatchSpec._parse33149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _match33150;
		public virtual bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec._match33150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, global::org.apache.http.impl.cookie.BestMatchSpec._match33150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion33151;
		public virtual int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec._getVersion33151);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, global::org.apache.http.impl.cookie.BestMatchSpec._getVersion33151);
		}
		internal static global::MonoJavaBridge.MethodId _validate33152;
		public virtual void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec._validate33152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, global::org.apache.http.impl.cookie.BestMatchSpec._validate33152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies33153;
		public virtual global::java.util.List formatCookies(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec._formatCookies33153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, global::org.apache.http.impl.cookie.BestMatchSpec._formatCookies33153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		public new global::org.apache.http.Header VersionHeader
		{
			get
			{
				return getVersionHeader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader33154;
		public virtual global::org.apache.http.Header getVersionHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec._getVersionHeader33154)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, global::org.apache.http.impl.cookie.BestMatchSpec._getVersionHeader33154)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _BestMatchSpec33155;
		public BestMatchSpec(java.lang.String[] arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BestMatchSpec.staticClass, global::org.apache.http.impl.cookie.BestMatchSpec._BestMatchSpec33155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BestMatchSpec33156;
		public BestMatchSpec()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BestMatchSpec.staticClass, global::org.apache.http.impl.cookie.BestMatchSpec._BestMatchSpec33156);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BestMatchSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BestMatchSpec"));
			global::org.apache.http.impl.cookie.BestMatchSpec._parse33149 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.BestMatchSpec._match33150 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.BestMatchSpec._getVersion33151 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, "getVersion", "()I");
			global::org.apache.http.impl.cookie.BestMatchSpec._validate33152 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.BestMatchSpec._formatCookies33153 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.BestMatchSpec._getVersionHeader33154 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.impl.cookie.BestMatchSpec._BestMatchSpec33155 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, "<init>", "([Ljava/lang/String;Z)V");
			global::org.apache.http.impl.cookie.BestMatchSpec._BestMatchSpec33156 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BestMatchSpec.staticClass, "<init>", "()V");
		}
	}
}

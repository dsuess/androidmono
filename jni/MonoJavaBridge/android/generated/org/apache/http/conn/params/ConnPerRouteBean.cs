namespace org.apache.http.conn.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ConnPerRouteBean : java.lang.Object, ConnPerRoute
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConnPerRouteBean()
		{
			InitJNI();
		}
		internal ConnPerRouteBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int DefaultMax
		{
			get
			{
				return getDefaultMax();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultMax32191;
		public int getDefaultMax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRouteBean._getDefaultMax32191);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._getDefaultMax32191);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultMaxPerRoute32192;
		public void setDefaultMaxPerRoute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRouteBean._setDefaultMaxPerRoute32192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._setDefaultMaxPerRoute32192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxForRoute32193;
		public void setMaxForRoute(org.apache.http.conn.routing.HttpRoute arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRouteBean._setMaxForRoute32193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._setMaxForRoute32193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxForRoute32194;
		public int getMaxForRoute(org.apache.http.conn.routing.HttpRoute arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRouteBean._getMaxForRoute32194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._getMaxForRoute32194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxForRoutes32195;
		public void setMaxForRoutes(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRouteBean._setMaxForRoutes32195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._setMaxForRoutes32195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ConnPerRouteBean32196;
		public ConnPerRouteBean(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._ConnPerRouteBean32196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ConnPerRouteBean32197;
		public ConnPerRouteBean()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.@params.ConnPerRouteBean.staticClass, global::org.apache.http.conn.@params.ConnPerRouteBean._ConnPerRouteBean32197);
			Init(@__env, handle);
		}
		public static int DEFAULT_MAX_CONNECTIONS_PER_ROUTE
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/params/ConnPerRouteBean"));
			global::org.apache.http.conn.@params.ConnPerRouteBean._getDefaultMax32191 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "getDefaultMax", "()I");
			global::org.apache.http.conn.@params.ConnPerRouteBean._setDefaultMaxPerRoute32192 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "setDefaultMaxPerRoute", "(I)V");
			global::org.apache.http.conn.@params.ConnPerRouteBean._setMaxForRoute32193 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "setMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;I)V");
			global::org.apache.http.conn.@params.ConnPerRouteBean._getMaxForRoute32194 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "getMaxForRoute", "(Lorg/apache/http/conn/routing/HttpRoute;)I");
			global::org.apache.http.conn.@params.ConnPerRouteBean._setMaxForRoutes32195 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "setMaxForRoutes", "(Ljava/util/Map;)V");
			global::org.apache.http.conn.@params.ConnPerRouteBean._ConnPerRouteBean32196 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "<init>", "(I)V");
			global::org.apache.http.conn.@params.ConnPerRouteBean._ConnPerRouteBean32197 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.@params.ConnPerRouteBean.staticClass, "<init>", "()V");
		}
	}
}

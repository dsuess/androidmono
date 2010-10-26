namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.@params.HttpParams_))]
	public partial interface HttpParams  : global::MonoJavaBridge.IJavaObject 
	{
		global::org.apache.http.@params.HttpParams copy();
		global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getParameter(java.lang.String arg0);
		bool removeParameter(java.lang.String arg0);
		long getLongParameter(java.lang.String arg0, long arg1);
		global::org.apache.http.@params.HttpParams setLongParameter(java.lang.String arg0, long arg1);
		int getIntParameter(java.lang.String arg0, int arg1);
		global::org.apache.http.@params.HttpParams setIntParameter(java.lang.String arg0, int arg1);
		double getDoubleParameter(java.lang.String arg0, double arg1);
		global::org.apache.http.@params.HttpParams setDoubleParameter(java.lang.String arg0, double arg1);
		bool getBooleanParameter(java.lang.String arg0, bool arg1);
		global::org.apache.http.@params.HttpParams setBooleanParameter(java.lang.String arg0, bool arg1);
		bool isParameterTrue(java.lang.String arg0);
		bool isParameterFalse(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.@params.HttpParams))]
	internal sealed partial class HttpParams_ : java.lang.Object, HttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpParams_()
		{
			InitJNI();
		}
		internal HttpParams_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _copy33784;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.copy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._copy33784)) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._copy33784)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParameter33785;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._setParameter33785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._setParameter33785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter33786;
		 global::java.lang.Object org.apache.http.@params.HttpParams.getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._getParameter33786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._getParameter33786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeParameter33787;
		 bool org.apache.http.@params.HttpParams.removeParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._removeParameter33787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._removeParameter33787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLongParameter33788;
		 long org.apache.http.@params.HttpParams.getLongParameter(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._getLongParameter33788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._getLongParameter33788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLongParameter33789;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setLongParameter(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._setLongParameter33789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._setLongParameter33789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getIntParameter33790;
		 int org.apache.http.@params.HttpParams.getIntParameter(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._getIntParameter33790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._getIntParameter33790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIntParameter33791;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setIntParameter(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._setIntParameter33791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._setIntParameter33791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleParameter33792;
		 double org.apache.http.@params.HttpParams.getDoubleParameter(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._getDoubleParameter33792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._getDoubleParameter33792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDoubleParameter33793;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setDoubleParameter(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._setDoubleParameter33793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._setDoubleParameter33793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanParameter33794;
		 bool org.apache.http.@params.HttpParams.getBooleanParameter(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._getBooleanParameter33794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._getBooleanParameter33794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBooleanParameter33795;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setBooleanParameter(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._setBooleanParameter33795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._setBooleanParameter33795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _isParameterTrue33796;
		 bool org.apache.http.@params.HttpParams.isParameterTrue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._isParameterTrue33796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._isParameterTrue33796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isParameterFalse33797;
		 bool org.apache.http.@params.HttpParams.isParameterFalse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_._isParameterFalse33797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.@params.HttpParams_.staticClass, global::org.apache.http.@params.HttpParams_._isParameterFalse33797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpParams_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpParams"));
			global::org.apache.http.@params.HttpParams_._copy33784 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._setParameter33785 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._getParameter33786 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.@params.HttpParams_._removeParameter33787 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "removeParameter", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.HttpParams_._getLongParameter33788 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "getLongParameter", "(Ljava/lang/String;J)J");
			global::org.apache.http.@params.HttpParams_._setLongParameter33789 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._getIntParameter33790 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "getIntParameter", "(Ljava/lang/String;I)I");
			global::org.apache.http.@params.HttpParams_._setIntParameter33791 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._getDoubleParameter33792 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "getDoubleParameter", "(Ljava/lang/String;D)D");
			global::org.apache.http.@params.HttpParams_._setDoubleParameter33793 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._getBooleanParameter33794 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "getBooleanParameter", "(Ljava/lang/String;Z)Z");
			global::org.apache.http.@params.HttpParams_._setBooleanParameter33795 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/params/HttpParams;");
			global::org.apache.http.@params.HttpParams_._isParameterTrue33796 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "isParameterTrue", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.HttpParams_._isParameterFalse33797 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpParams_.staticClass, "isParameterFalse", "(Ljava/lang/String;)Z");
		}
	}
}

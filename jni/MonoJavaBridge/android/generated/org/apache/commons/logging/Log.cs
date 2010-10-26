namespace org.apache.commons.logging
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.commons.logging.Log_))]
	public partial interface Log  : global::MonoJavaBridge.IJavaObject 
	{
		void debug(java.lang.Object arg0);
		void debug(java.lang.Object arg0, java.lang.Throwable arg1);
		void error(java.lang.Object arg0);
		void error(java.lang.Object arg0, java.lang.Throwable arg1);
		void info(java.lang.Object arg0);
		void info(java.lang.Object arg0, java.lang.Throwable arg1);
		void trace(java.lang.Object arg0);
		void trace(java.lang.Object arg0, java.lang.Throwable arg1);
		bool isDebugEnabled();
		bool isErrorEnabled();
		bool isFatalEnabled();
		bool isInfoEnabled();
		bool isTraceEnabled();
		bool isWarnEnabled();
		void warn(java.lang.Object arg0, java.lang.Throwable arg1);
		void warn(java.lang.Object arg0);
		void fatal(java.lang.Object arg0);
		void fatal(java.lang.Object arg0, java.lang.Throwable arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.commons.logging.Log))]
	internal sealed partial class Log_ : java.lang.Object, Log
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Log_()
		{
			InitJNI();
		}
		internal Log_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _debug31471;
		 void org.apache.commons.logging.Log.debug(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._debug31471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._debug31471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _debug31472;
		 void org.apache.commons.logging.Log.debug(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._debug31472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._debug31472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _error31473;
		 void org.apache.commons.logging.Log.error(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._error31473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._error31473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _error31474;
		 void org.apache.commons.logging.Log.error(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._error31474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._error31474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _info31475;
		 void org.apache.commons.logging.Log.info(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._info31475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._info31475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _info31476;
		 void org.apache.commons.logging.Log.info(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._info31476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._info31476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _trace31477;
		 void org.apache.commons.logging.Log.trace(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._trace31477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._trace31477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _trace31478;
		 void org.apache.commons.logging.Log.trace(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._trace31478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._trace31478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isDebugEnabled31479;
		 bool org.apache.commons.logging.Log.isDebugEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isDebugEnabled31479);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isDebugEnabled31479);
		}
		internal static global::MonoJavaBridge.MethodId _isErrorEnabled31480;
		 bool org.apache.commons.logging.Log.isErrorEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isErrorEnabled31480);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isErrorEnabled31480);
		}
		internal static global::MonoJavaBridge.MethodId _isFatalEnabled31481;
		 bool org.apache.commons.logging.Log.isFatalEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isFatalEnabled31481);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isFatalEnabled31481);
		}
		internal static global::MonoJavaBridge.MethodId _isInfoEnabled31482;
		 bool org.apache.commons.logging.Log.isInfoEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isInfoEnabled31482);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isInfoEnabled31482);
		}
		internal static global::MonoJavaBridge.MethodId _isTraceEnabled31483;
		 bool org.apache.commons.logging.Log.isTraceEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isTraceEnabled31483);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isTraceEnabled31483);
		}
		internal static global::MonoJavaBridge.MethodId _isWarnEnabled31484;
		 bool org.apache.commons.logging.Log.isWarnEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._isWarnEnabled31484);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._isWarnEnabled31484);
		}
		internal static global::MonoJavaBridge.MethodId _warn31485;
		 void org.apache.commons.logging.Log.warn(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._warn31485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._warn31485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _warn31486;
		 void org.apache.commons.logging.Log.warn(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._warn31486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._warn31486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fatal31487;
		 void org.apache.commons.logging.Log.fatal(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._fatal31487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._fatal31487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fatal31488;
		 void org.apache.commons.logging.Log.fatal(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_._fatal31488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.commons.logging.Log_.staticClass, global::org.apache.commons.logging.Log_._fatal31488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.commons.logging.Log_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/commons/logging/Log"));
			global::org.apache.commons.logging.Log_._debug31471 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "debug", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._debug31472 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "debug", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._error31473 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "error", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._error31474 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "error", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._info31475 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "info", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._info31476 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "info", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._trace31477 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "trace", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._trace31478 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "trace", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._isDebugEnabled31479 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isDebugEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isErrorEnabled31480 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isErrorEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isFatalEnabled31481 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isFatalEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isInfoEnabled31482 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isInfoEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isTraceEnabled31483 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isTraceEnabled", "()Z");
			global::org.apache.commons.logging.Log_._isWarnEnabled31484 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "isWarnEnabled", "()Z");
			global::org.apache.commons.logging.Log_._warn31485 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "warn", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
			global::org.apache.commons.logging.Log_._warn31486 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "warn", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._fatal31487 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "fatal", "(Ljava/lang/Object;)V");
			global::org.apache.commons.logging.Log_._fatal31488 = @__env.GetMethodIDNoThrow(global::org.apache.commons.logging.Log_.staticClass, "fatal", "(Ljava/lang/Object;Ljava/lang/Throwable;)V");
		}
	}
}

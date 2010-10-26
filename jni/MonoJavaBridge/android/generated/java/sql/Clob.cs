namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Clob_))]
	public partial interface Clob  : global::MonoJavaBridge.IJavaObject 
	{
		long length();
		long position(java.lang.String arg0, long arg1);
		long position(java.sql.Clob arg0, long arg1);
		void truncate(long arg0);
		int setString(long arg0, java.lang.String arg1);
		int setString(long arg0, java.lang.String arg1, int arg2, int arg3);
		void free();
		global::java.io.InputStream getAsciiStream();
		global::java.io.Reader getCharacterStream(long arg0, long arg1);
		global::java.io.Reader getCharacterStream();
		global::java.io.OutputStream setAsciiStream(long arg0);
		global::java.io.Writer setCharacterStream(long arg0);
		global::java.lang.String getSubString(long arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Clob))]
	internal sealed partial class Clob_ : java.lang.Object, Clob
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Clob_()
		{
			InitJNI();
		}
		internal Clob_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _length24306;
		 long java.sql.Clob.length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Clob_._length24306);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._length24306);
		}
		internal static global::MonoJavaBridge.MethodId _position24307;
		 long java.sql.Clob.position(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Clob_._position24307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._position24307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _position24308;
		 long java.sql.Clob.position(java.sql.Clob arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Clob_._position24308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._position24308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _truncate24309;
		 void java.sql.Clob.truncate(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Clob_._truncate24309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._truncate24309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setString24310;
		 int java.sql.Clob.setString(long arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Clob_._setString24310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._setString24310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setString24311;
		 int java.sql.Clob.setString(long arg0, java.lang.String arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Clob_._setString24311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._setString24311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _free24312;
		 void java.sql.Clob.free() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Clob_._free24312);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._free24312);
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream24313;
		 global::java.io.InputStream java.sql.Clob.getAsciiStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getAsciiStream24313)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._getAsciiStream24313)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24314;
		 global::java.io.Reader java.sql.Clob.getCharacterStream(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getCharacterStream24314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._getCharacterStream24314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24315;
		 global::java.io.Reader java.sql.Clob.getCharacterStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getCharacterStream24315)) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._getCharacterStream24315)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24316;
		 global::java.io.OutputStream java.sql.Clob.setAsciiStream(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._setAsciiStream24316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._setAsciiStream24316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24317;
		 global::java.io.Writer java.sql.Clob.setCharacterStream(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._setCharacterStream24317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Writer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._setCharacterStream24317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _getSubString24318;
		 global::java.lang.String java.sql.Clob.getSubString(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getSubString24318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._getSubString24318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Clob_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Clob"));
			global::java.sql.Clob_._length24306 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "length", "()J");
			global::java.sql.Clob_._position24307 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "position", "(Ljava/lang/String;J)J");
			global::java.sql.Clob_._position24308 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "position", "(Ljava/sql/Clob;J)J");
			global::java.sql.Clob_._truncate24309 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "truncate", "(J)V");
			global::java.sql.Clob_._setString24310 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setString", "(JLjava/lang/String;)I");
			global::java.sql.Clob_._setString24311 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setString", "(JLjava/lang/String;II)I");
			global::java.sql.Clob_._free24312 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "free", "()V");
			global::java.sql.Clob_._getAsciiStream24313 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getAsciiStream", "()Ljava/io/InputStream;");
			global::java.sql.Clob_._getCharacterStream24314 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getCharacterStream", "(JJ)Ljava/io/Reader;");
			global::java.sql.Clob_._getCharacterStream24315 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getCharacterStream", "()Ljava/io/Reader;");
			global::java.sql.Clob_._setAsciiStream24316 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setAsciiStream", "(J)Ljava/io/OutputStream;");
			global::java.sql.Clob_._setCharacterStream24317 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setCharacterStream", "(J)Ljava/io/Writer;");
			global::java.sql.Clob_._getSubString24318 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getSubString", "(JI)Ljava/lang/String;");
		}
	}
}

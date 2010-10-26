namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InflaterInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InflaterInputStream()
		{
			InitJNI();
		}
		protected InflaterInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close28420;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._close28420);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._close28420);
		}
		internal static global::MonoJavaBridge.MethodId _mark28421;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._mark28421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._mark28421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset28422;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._reset28422);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._reset28422);
		}
		internal static global::MonoJavaBridge.MethodId _fill28423;
		protected virtual void fill() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._fill28423);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._fill28423);
		}
		internal static global::MonoJavaBridge.MethodId _read28424;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._read28424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._read28424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read28425;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._read28425);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._read28425);
		}
		internal static global::MonoJavaBridge.MethodId _skip28426;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._skip28426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._skip28426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available28427;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._available28427);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._available28427);
		}
		internal static global::MonoJavaBridge.MethodId _markSupported28428;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream._markSupported28428);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._markSupported28428);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream28429;
		public InflaterInputStream(java.io.InputStream arg0, java.util.zip.Inflater arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream28429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream28430;
		public InflaterInputStream(java.io.InputStream arg0, java.util.zip.Inflater arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream28430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InflaterInputStream28431;
		public InflaterInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.InflaterInputStream.staticClass, global::java.util.zip.InflaterInputStream._InflaterInputStream28431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.InflaterInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/InflaterInputStream"));
			global::java.util.zip.InflaterInputStream._close28420 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "close", "()V");
			global::java.util.zip.InflaterInputStream._mark28421 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "mark", "(I)V");
			global::java.util.zip.InflaterInputStream._reset28422 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "reset", "()V");
			global::java.util.zip.InflaterInputStream._fill28423 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "fill", "()V");
			global::java.util.zip.InflaterInputStream._read28424 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "read", "([BII)I");
			global::java.util.zip.InflaterInputStream._read28425 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "read", "()I");
			global::java.util.zip.InflaterInputStream._skip28426 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "skip", "(J)J");
			global::java.util.zip.InflaterInputStream._available28427 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "available", "()I");
			global::java.util.zip.InflaterInputStream._markSupported28428 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "markSupported", "()Z");
			global::java.util.zip.InflaterInputStream._InflaterInputStream28429 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;I)V");
			global::java.util.zip.InflaterInputStream._InflaterInputStream28430 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Inflater;)V");
			global::java.util.zip.InflaterInputStream._InflaterInputStream28431 = @__env.GetMethodIDNoThrow(global::java.util.zip.InflaterInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}

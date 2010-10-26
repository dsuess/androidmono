namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PushbackReader : java.io.FilterReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PushbackReader()
		{
			InitJNI();
		}
		protected PushbackReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close19499;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._close19499);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._close19499);
		}
		internal static global::MonoJavaBridge.MethodId _mark19500;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._mark19500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._mark19500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19501;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._reset19501);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._reset19501);
		}
		internal static global::MonoJavaBridge.MethodId _read19502;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackReader._read19502);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._read19502);
		}
		internal static global::MonoJavaBridge.MethodId _read19503;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackReader._read19503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._read19503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip19504;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.PushbackReader._skip19504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._skip19504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported19505;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PushbackReader._markSupported19505);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._markSupported19505);
		}
		internal static global::MonoJavaBridge.MethodId _ready19506;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PushbackReader._ready19506);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._ready19506);
		}
		internal static global::MonoJavaBridge.MethodId _unread19507;
		public virtual void unread(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._unread19507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._unread19507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unread19508;
		public virtual void unread(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._unread19508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._unread19508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unread19509;
		public virtual void unread(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._unread19509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._unread19509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PushbackReader19510;
		public PushbackReader(java.io.Reader arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackReader.staticClass, global::java.io.PushbackReader._PushbackReader19510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PushbackReader19511;
		public PushbackReader(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackReader.staticClass, global::java.io.PushbackReader._PushbackReader19511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PushbackReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PushbackReader"));
			global::java.io.PushbackReader._close19499 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "close", "()V");
			global::java.io.PushbackReader._mark19500 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "mark", "(I)V");
			global::java.io.PushbackReader._reset19501 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "reset", "()V");
			global::java.io.PushbackReader._read19502 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "read", "()I");
			global::java.io.PushbackReader._read19503 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "read", "([CII)I");
			global::java.io.PushbackReader._skip19504 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "skip", "(J)J");
			global::java.io.PushbackReader._markSupported19505 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "markSupported", "()Z");
			global::java.io.PushbackReader._ready19506 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "ready", "()Z");
			global::java.io.PushbackReader._unread19507 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "unread", "([C)V");
			global::java.io.PushbackReader._unread19508 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "unread", "([CII)V");
			global::java.io.PushbackReader._unread19509 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "unread", "(I)V");
			global::java.io.PushbackReader._PushbackReader19510 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::java.io.PushbackReader._PushbackReader19511 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}
}

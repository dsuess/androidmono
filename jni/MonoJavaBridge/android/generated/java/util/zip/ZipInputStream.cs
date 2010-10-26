namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZipInputStream : java.util.zip.InflaterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ZipInputStream()
		{
			InitJNI();
		}
		protected ZipInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close28469;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._close28469);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._close28469);
		}
		internal static global::MonoJavaBridge.MethodId _read28470;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._read28470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._read28470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip28471;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._skip28471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._skip28471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available28472;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._available28472);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._available28472);
		}
		public new global::java.util.zip.ZipEntry NextEntry
		{
			get
			{
				return getNextEntry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextEntry28473;
		public virtual global::java.util.zip.ZipEntry getNextEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._getNextEntry28473)) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._getNextEntry28473)) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _createZipEntry28474;
		protected virtual global::java.util.zip.ZipEntry createZipEntry(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._createZipEntry28474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._createZipEntry28474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.zip.ZipEntry;
		}
		internal static global::MonoJavaBridge.MethodId _closeEntry28475;
		public virtual void closeEntry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream._closeEntry28475);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._closeEntry28475);
		}
		internal static global::MonoJavaBridge.MethodId _ZipInputStream28476;
		public ZipInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.ZipInputStream.staticClass, global::java.util.zip.ZipInputStream._ZipInputStream28476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.ZipInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/ZipInputStream"));
			global::java.util.zip.ZipInputStream._close28469 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "close", "()V");
			global::java.util.zip.ZipInputStream._read28470 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "read", "([BII)I");
			global::java.util.zip.ZipInputStream._skip28471 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "skip", "(J)J");
			global::java.util.zip.ZipInputStream._available28472 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "available", "()I");
			global::java.util.zip.ZipInputStream._getNextEntry28473 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "getNextEntry", "()Ljava/util/zip/ZipEntry;");
			global::java.util.zip.ZipInputStream._createZipEntry28474 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "createZipEntry", "(Ljava/lang/String;)Ljava/util/zip/ZipEntry;");
			global::java.util.zip.ZipInputStream._closeEntry28475 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "closeEntry", "()V");
			global::java.util.zip.ZipInputStream._ZipInputStream28476 = @__env.GetMethodIDNoThrow(global::java.util.zip.ZipInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}

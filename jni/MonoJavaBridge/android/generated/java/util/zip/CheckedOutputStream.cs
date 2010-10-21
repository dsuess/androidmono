namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckedOutputStream : java.io.FilterOutputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CheckedOutputStream()
		{
			InitJNI();
		}
		protected CheckedOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write28225;
		public override void write(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CheckedOutputStream._write28225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CheckedOutputStream.staticClass, global::java.util.zip.CheckedOutputStream._write28225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write28226;
		public override void write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CheckedOutputStream._write28226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CheckedOutputStream.staticClass, global::java.util.zip.CheckedOutputStream._write28226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.util.zip.Checksum Checksum
		{
			get
			{
				return getChecksum();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChecksum28227;
		public virtual global::java.util.zip.Checksum getChecksum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.zip.Checksum>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.zip.CheckedOutputStream._getChecksum28227)) as java.util.zip.Checksum;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.zip.Checksum>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.zip.CheckedOutputStream.staticClass, global::java.util.zip.CheckedOutputStream._getChecksum28227)) as java.util.zip.Checksum;
		}
		internal static global::MonoJavaBridge.MethodId _CheckedOutputStream28228;
		public CheckedOutputStream(java.io.OutputStream arg0, java.util.zip.Checksum arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.CheckedOutputStream.staticClass, global::java.util.zip.CheckedOutputStream._CheckedOutputStream28228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.CheckedOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/CheckedOutputStream"));
			global::java.util.zip.CheckedOutputStream._write28225 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedOutputStream.staticClass, "write", "(I)V");
			global::java.util.zip.CheckedOutputStream._write28226 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedOutputStream.staticClass, "write", "([BII)V");
			global::java.util.zip.CheckedOutputStream._getChecksum28227 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedOutputStream.staticClass, "getChecksum", "()Ljava/util/zip/Checksum;");
			global::java.util.zip.CheckedOutputStream._CheckedOutputStream28228 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedOutputStream.staticClass, "<init>", "(Ljava/io/OutputStream;Ljava/util/zip/Checksum;)V");
		}
	}
}

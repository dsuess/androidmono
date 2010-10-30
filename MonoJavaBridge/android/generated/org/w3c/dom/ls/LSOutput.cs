namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSOutput_))]
	public partial interface LSOutput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getEncoding();
		void setEncoding(java.lang.String arg0);
		global::java.lang.String getSystemId();
		global::java.io.Writer getCharacterStream();
		void setCharacterStream(java.io.Writer arg0);
		void setSystemId(java.lang.String arg0);
		void setByteStream(java.io.OutputStream arg0);
		global::java.io.OutputStream getByteStream();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.LSOutput))]
	internal sealed partial class LSOutput_ : java.lang.Object, LSOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LSOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.w3c.dom.ls.LSOutput.getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSOutput_.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::org.w3c.dom.ls.LSOutput_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void org.w3c.dom.ls.LSOutput.setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSOutput_.staticClass, "setEncoding", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ls.LSOutput_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.w3c.dom.ls.LSOutput.getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.w3c.dom.ls.LSOutput_.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::org.w3c.dom.ls.LSOutput_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.io.Writer org.w3c.dom.ls.LSOutput.getCharacterStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.ls.LSOutput_.staticClass, "getCharacterStream", "()Ljava/io/Writer;", ref global::org.w3c.dom.ls.LSOutput_._m3) as java.io.Writer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void org.w3c.dom.ls.LSOutput.setCharacterStream(java.io.Writer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSOutput_.staticClass, "setCharacterStream", "(Ljava/io/Writer;)V", ref global::org.w3c.dom.ls.LSOutput_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void org.w3c.dom.ls.LSOutput.setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSOutput_.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::org.w3c.dom.ls.LSOutput_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void org.w3c.dom.ls.LSOutput.setByteStream(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.ls.LSOutput_.staticClass, "setByteStream", "(Ljava/io/OutputStream;)V", ref global::org.w3c.dom.ls.LSOutput_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.io.OutputStream org.w3c.dom.ls.LSOutput.getByteStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.w3c.dom.ls.LSOutput_.staticClass, "getByteStream", "()Ljava/io/OutputStream;", ref global::org.w3c.dom.ls.LSOutput_._m7) as java.io.OutputStream;
		}
		static LSOutput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSOutput"));
		}
		internal static void InitJNI()
		{
		}
	}
}
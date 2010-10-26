namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.MacSpi_))]
	public abstract partial class MacSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MacSpi()
		{
			InitJNI();
		}
		protected MacSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone28689;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi._clone28689)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._clone28689)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28690;
		protected abstract void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28691;
		protected abstract void engineUpdate(byte arg0);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28692;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28693;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi._engineUpdate28693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._engineUpdate28693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset28694;
		protected abstract void engineReset();
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28695;
		protected abstract byte[] engineDoFinal();
		internal static global::MonoJavaBridge.MethodId _engineGetMacLength28696;
		protected abstract int engineGetMacLength();
		internal static global::MonoJavaBridge.MethodId _MacSpi28697;
		public MacSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._MacSpi28697);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.MacSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/MacSpi"));
			global::javax.crypto.MacSpi._clone28689 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.crypto.MacSpi._engineInit28690 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.MacSpi._engineUpdate28691 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "(B)V");
			global::javax.crypto.MacSpi._engineUpdate28692 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "([BII)V");
			global::javax.crypto.MacSpi._engineUpdate28693 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V");
			global::javax.crypto.MacSpi._engineReset28694 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineReset", "()V");
			global::javax.crypto.MacSpi._engineDoFinal28695 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineDoFinal", "()[B");
			global::javax.crypto.MacSpi._engineGetMacLength28696 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineGetMacLength", "()I");
			global::javax.crypto.MacSpi._MacSpi28697 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.MacSpi))]
	internal sealed partial class MacSpi_ : javax.crypto.MacSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MacSpi_()
		{
			InitJNI();
		}
		internal MacSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28698;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineInit28698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineInit28698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate28699;
		protected override void engineUpdate(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineUpdate28699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineUpdate28699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate28700;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineUpdate28700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineUpdate28700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset28701;
		protected override void engineReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineReset28701);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineReset28701);
		}
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28702;
		protected override byte[] engineDoFinal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineDoFinal28702)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineDoFinal28702)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetMacLength28703;
		protected override int engineGetMacLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineGetMacLength28703);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineGetMacLength28703);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.MacSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/MacSpi"));
			global::javax.crypto.MacSpi_._engineInit28698 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.MacSpi_._engineUpdate28699 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineUpdate", "(B)V");
			global::javax.crypto.MacSpi_._engineUpdate28700 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineUpdate", "([BII)V");
			global::javax.crypto.MacSpi_._engineReset28701 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineReset", "()V");
			global::javax.crypto.MacSpi_._engineDoFinal28702 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineDoFinal", "()[B");
			global::javax.crypto.MacSpi_._engineGetMacLength28703 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineGetMacLength", "()I");
		}
	}
}

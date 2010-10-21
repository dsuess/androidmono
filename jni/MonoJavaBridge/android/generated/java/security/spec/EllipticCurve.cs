namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EllipticCurve : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EllipticCurve()
		{
			InitJNI();
		}
		protected EllipticCurve(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23893;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._equals23893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._equals23893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23894;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._hashCode23894);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._hashCode23894);
		}
		public new global::java.security.spec.ECField Field
		{
			get
			{
				return getField();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getField23895;
		public virtual global::java.security.spec.ECField getField() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.ECField>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._getField23895)) as java.security.spec.ECField;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.ECField>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getField23895)) as java.security.spec.ECField;
		}
		public new byte[] Seed
		{
			get
			{
				return getSeed();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSeed23896;
		public virtual byte[] getSeed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._getSeed23896)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getSeed23896)) as byte[];
		}
		public new global::java.math.BigInteger A
		{
			get
			{
				return getA();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getA23897;
		public virtual global::java.math.BigInteger getA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._getA23897)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getA23897)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger B
		{
			get
			{
				return getB();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getB23898;
		public virtual global::java.math.BigInteger getB() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve._getB23898)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._getB23898)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _EllipticCurve23899;
		public EllipticCurve(java.security.spec.ECField arg0, java.math.BigInteger arg1, java.math.BigInteger arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._EllipticCurve23899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _EllipticCurve23900;
		public EllipticCurve(java.security.spec.ECField arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, byte[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.EllipticCurve.staticClass, global::java.security.spec.EllipticCurve._EllipticCurve23900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.EllipticCurve.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/EllipticCurve"));
			global::java.security.spec.EllipticCurve._equals23893 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.spec.EllipticCurve._hashCode23894 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "hashCode", "()I");
			global::java.security.spec.EllipticCurve._getField23895 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getField", "()Ljava/security/spec/ECField;");
			global::java.security.spec.EllipticCurve._getSeed23896 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getSeed", "()[B");
			global::java.security.spec.EllipticCurve._getA23897 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getA", "()Ljava/math/BigInteger;");
			global::java.security.spec.EllipticCurve._getB23898 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "getB", "()Ljava/math/BigInteger;");
			global::java.security.spec.EllipticCurve._EllipticCurve23899 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::java.security.spec.EllipticCurve._EllipticCurve23900 = @__env.GetMethodIDNoThrow(global::java.security.spec.EllipticCurve.staticClass, "<init>", "(Ljava/security/spec/ECField;Ljava/math/BigInteger;Ljava/math/BigInteger;[B)V");
		}
	}
}

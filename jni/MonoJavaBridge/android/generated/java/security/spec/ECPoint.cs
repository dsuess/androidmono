namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECPoint : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ECPoint()
		{
			InitJNI();
		}
		protected ECPoint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23881;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.spec.ECPoint._equals23881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.spec.ECPoint.staticClass, global::java.security.spec.ECPoint._equals23881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23882;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECPoint._hashCode23882);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECPoint.staticClass, global::java.security.spec.ECPoint._hashCode23882);
		}
		public new global::java.math.BigInteger AffineX
		{
			get
			{
				return getAffineX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAffineX23883;
		public virtual global::java.math.BigInteger getAffineX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECPoint._getAffineX23883)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECPoint.staticClass, global::java.security.spec.ECPoint._getAffineX23883)) as java.math.BigInteger;
		}
		public new global::java.math.BigInteger AffineY
		{
			get
			{
				return getAffineY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAffineY23884;
		public virtual global::java.math.BigInteger getAffineY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.ECPoint._getAffineY23884)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.ECPoint.staticClass, global::java.security.spec.ECPoint._getAffineY23884)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _ECPoint23885;
		public ECPoint(java.math.BigInteger arg0, java.math.BigInteger arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECPoint.staticClass, global::java.security.spec.ECPoint._ECPoint23885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _POINT_INFINITY23886;
		public static global::java.security.spec.ECPoint POINT_INFINITY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.ECPoint.staticClass, _POINT_INFINITY23886)) as java.security.spec.ECPoint;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECPoint.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECPoint"));
			global::java.security.spec.ECPoint._equals23881 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPoint.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.spec.ECPoint._hashCode23882 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPoint.staticClass, "hashCode", "()I");
			global::java.security.spec.ECPoint._getAffineX23883 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPoint.staticClass, "getAffineX", "()Ljava/math/BigInteger;");
			global::java.security.spec.ECPoint._getAffineY23884 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPoint.staticClass, "getAffineY", "()Ljava/math/BigInteger;");
			global::java.security.spec.ECPoint._ECPoint23885 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECPoint.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V");
			global::java.security.spec.ECPoint._POINT_INFINITY23886 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.ECPoint.staticClass, "POINT_INFINITY", "Ljava/security/spec/ECPoint;");
		}
	}
}

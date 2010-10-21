namespace dalvik.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::dalvik.annotation.TestTarget_))]
	public interface TestTarget : java.lang.annotation.Annotation
	{
		global::java.lang.String methodName();
		global::java.lang.String conceptName();
		global::java.lang.Class[] methodArgs();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::dalvik.annotation.TestTarget))]
	public sealed partial class TestTarget_ : java.lang.Object, TestTarget
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestTarget_()
		{
			InitJNI();
		}
		internal TestTarget_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _methodName18219;
		 global::java.lang.String dalvik.annotation.TestTarget.methodName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._methodName18219)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_.staticClass, global::dalvik.annotation.TestTarget_._methodName18219)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _conceptName18220;
		 global::java.lang.String dalvik.annotation.TestTarget.conceptName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._conceptName18220)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_.staticClass, global::dalvik.annotation.TestTarget_._conceptName18220)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _methodArgs18221;
		 global::java.lang.Class[] dalvik.annotation.TestTarget.methodArgs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._methodArgs18221)) as java.lang.Class[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_.staticClass, global::dalvik.annotation.TestTarget_._methodArgs18221)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _equals18222;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._equals18222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_.staticClass, global::dalvik.annotation.TestTarget_._equals18222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString18223;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._toString18223)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_.staticClass, global::dalvik.annotation.TestTarget_._toString18223)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18224;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._hashCode18224);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_.staticClass, global::dalvik.annotation.TestTarget_._hashCode18224);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType18225;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._annotationType18225)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_.staticClass, global::dalvik.annotation.TestTarget_._annotationType18225)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.annotation.TestTarget_.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/annotation/TestTarget"));
			global::dalvik.annotation.TestTarget_._methodName18219 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "methodName", "()Ljava/lang/String;");
			global::dalvik.annotation.TestTarget_._conceptName18220 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "conceptName", "()Ljava/lang/String;");
			global::dalvik.annotation.TestTarget_._methodArgs18221 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "methodArgs", "()[Ljava/lang/Class;");
			global::dalvik.annotation.TestTarget_._equals18222 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::dalvik.annotation.TestTarget_._toString18223 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "toString", "()Ljava/lang/String;");
			global::dalvik.annotation.TestTarget_._hashCode18224 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "hashCode", "()I");
			global::dalvik.annotation.TestTarget_._annotationType18225 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}

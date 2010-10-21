namespace android.test
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.UiThreadTest_))]
	public interface UiThreadTest : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.UiThreadTest))]
	public sealed partial class UiThreadTest_ : java.lang.Object, UiThreadTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UiThreadTest_()
		{
			InitJNI();
		}
		internal UiThreadTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12299;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.UiThreadTest_._equals12299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.UiThreadTest_.staticClass, global::android.test.UiThreadTest_._equals12299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12300;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.UiThreadTest_._toString12300)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.UiThreadTest_.staticClass, global::android.test.UiThreadTest_._toString12300)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12301;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.UiThreadTest_._hashCode12301);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.UiThreadTest_.staticClass, global::android.test.UiThreadTest_._hashCode12301);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12302;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.UiThreadTest_._annotationType12302)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.UiThreadTest_.staticClass, global::android.test.UiThreadTest_._annotationType12302)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.UiThreadTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/UiThreadTest"));
			global::android.test.UiThreadTest_._equals12299 = @__env.GetMethodIDNoThrow(global::android.test.UiThreadTest_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.UiThreadTest_._toString12300 = @__env.GetMethodIDNoThrow(global::android.test.UiThreadTest_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.UiThreadTest_._hashCode12301 = @__env.GetMethodIDNoThrow(global::android.test.UiThreadTest_.staticClass, "hashCode", "()I");
			global::android.test.UiThreadTest_._annotationType12302 = @__env.GetMethodIDNoThrow(global::android.test.UiThreadTest_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}

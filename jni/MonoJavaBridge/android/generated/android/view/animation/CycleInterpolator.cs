namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CycleInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CycleInterpolator()
		{
			InitJNI();
		}
		protected CycleInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15596;
		public virtual float getInterpolation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.CycleInterpolator._getInterpolation15596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.CycleInterpolator.staticClass, global::android.view.animation.CycleInterpolator._getInterpolation15596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CycleInterpolator15597;
		public CycleInterpolator(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.CycleInterpolator.staticClass, global::android.view.animation.CycleInterpolator._CycleInterpolator15597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CycleInterpolator15598;
		public CycleInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.CycleInterpolator.staticClass, global::android.view.animation.CycleInterpolator._CycleInterpolator15598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.CycleInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/CycleInterpolator"));
			global::android.view.animation.CycleInterpolator._getInterpolation15596 = @__env.GetMethodIDNoThrow(global::android.view.animation.CycleInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.CycleInterpolator._CycleInterpolator15597 = @__env.GetMethodIDNoThrow(global::android.view.animation.CycleInterpolator.staticClass, "<init>", "(F)V");
			global::android.view.animation.CycleInterpolator._CycleInterpolator15598 = @__env.GetMethodIDNoThrow(global::android.view.animation.CycleInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}

namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccelerateDecelerateInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccelerateDecelerateInterpolator()
		{
			InitJNI();
		}
		protected AccelerateDecelerateInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15483;
		public virtual float getInterpolation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.AccelerateDecelerateInterpolator._getInterpolation15483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, global::android.view.animation.AccelerateDecelerateInterpolator._getInterpolation15483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AccelerateDecelerateInterpolator15484;
		public AccelerateDecelerateInterpolator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateDecelerateInterpolator.staticClass, global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator15484);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccelerateDecelerateInterpolator15485;
		public AccelerateDecelerateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateDecelerateInterpolator.staticClass, global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator15485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AccelerateDecelerateInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AccelerateDecelerateInterpolator"));
			global::android.view.animation.AccelerateDecelerateInterpolator._getInterpolation15483 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator15484 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.AccelerateDecelerateInterpolator._AccelerateDecelerateInterpolator15485 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateDecelerateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}

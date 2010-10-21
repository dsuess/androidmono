namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnimationUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AnimationUtils()
		{
			InitJNI();
		}
		protected AnimationUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _currentAnimationTimeMillis15576;
		public static long currentAnimationTimeMillis() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._currentAnimationTimeMillis15576);
		}
		internal static global::MonoJavaBridge.MethodId _loadAnimation15577;
		public static global::android.view.animation.Animation loadAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._loadAnimation15577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _loadLayoutAnimation15578;
		public static global::android.view.animation.LayoutAnimationController loadLayoutAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._loadLayoutAnimation15578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.LayoutAnimationController;
		}
		internal static global::MonoJavaBridge.MethodId _makeInAnimation15579;
		public static global::android.view.animation.Animation makeInAnimation(android.content.Context arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._makeInAnimation15579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _makeOutAnimation15580;
		public static global::android.view.animation.Animation makeOutAnimation(android.content.Context arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._makeOutAnimation15580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _makeInChildBottomAnimation15581;
		public static global::android.view.animation.Animation makeInChildBottomAnimation(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._makeInChildBottomAnimation15581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _loadInterpolator15582;
		public static global::android.view.animation.Interpolator loadInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallStaticObjectMethod(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._loadInterpolator15582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.animation.Interpolator;
		}
		internal static global::MonoJavaBridge.MethodId _AnimationUtils15583;
		public AnimationUtils()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnimationUtils.staticClass, global::android.view.animation.AnimationUtils._AnimationUtils15583);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnimationUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnimationUtils"));
			global::android.view.animation.AnimationUtils._currentAnimationTimeMillis15576 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "currentAnimationTimeMillis", "()J");
			global::android.view.animation.AnimationUtils._loadAnimation15577 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadAnimation", "(Landroid/content/Context;I)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._loadLayoutAnimation15578 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadLayoutAnimation", "(Landroid/content/Context;I)Landroid/view/animation/LayoutAnimationController;");
			global::android.view.animation.AnimationUtils._makeInAnimation15579 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeInAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._makeOutAnimation15580 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeOutAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._makeInChildBottomAnimation15581 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "makeInChildBottomAnimation", "(Landroid/content/Context;)Landroid/view/animation/Animation;");
			global::android.view.animation.AnimationUtils._loadInterpolator15582 = @__env.GetStaticMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "loadInterpolator", "(Landroid/content/Context;I)Landroid/view/animation/Interpolator;");
			global::android.view.animation.AnimationUtils._AnimationUtils15583 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnimationUtils.staticClass, "<init>", "()V");
		}
	}
}

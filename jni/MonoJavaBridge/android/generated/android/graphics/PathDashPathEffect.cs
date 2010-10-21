namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PathDashPathEffect : android.graphics.PathEffect
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PathDashPathEffect()
		{
			InitJNI();
		}
		protected PathDashPathEffect(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Style : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Style()
			{
				InitJNI();
			}
			internal Style(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5546;
			public static global::android.graphics.PathDashPathEffect.Style[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.PathDashPathEffect.Style>(@__env.CallStaticObjectMethod(android.graphics.PathDashPathEffect.Style.staticClass, global::android.graphics.PathDashPathEffect.Style._values5546)) as android.graphics.PathDashPathEffect.Style[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5547;
			public static global::android.graphics.PathDashPathEffect.Style valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.PathDashPathEffect.Style.staticClass, global::android.graphics.PathDashPathEffect.Style._valueOf5547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.PathDashPathEffect.Style;
			}
			internal static global::MonoJavaBridge.FieldId _MORPH5548;
			public static global::android.graphics.PathDashPathEffect.Style MORPH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PathDashPathEffect.Style.staticClass, _MORPH5548)) as android.graphics.PathDashPathEffect.Style;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ROTATE5549;
			public static global::android.graphics.PathDashPathEffect.Style ROTATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PathDashPathEffect.Style.staticClass, _ROTATE5549)) as android.graphics.PathDashPathEffect.Style;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TRANSLATE5550;
			public static global::android.graphics.PathDashPathEffect.Style TRANSLATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.PathDashPathEffect.Style.staticClass, _TRANSLATE5550)) as android.graphics.PathDashPathEffect.Style;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.PathDashPathEffect.Style.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PathDashPathEffect$Style"));
				global::android.graphics.PathDashPathEffect.Style._values5546 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PathDashPathEffect.Style.staticClass, "values", "()[Landroid/graphics/PathDashPathEffect/Style;");
				global::android.graphics.PathDashPathEffect.Style._valueOf5547 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.PathDashPathEffect.Style.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/PathDashPathEffect$Style;");
				global::android.graphics.PathDashPathEffect.Style._MORPH5548 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PathDashPathEffect.Style.staticClass, "MORPH", "Landroid/graphics/PathDashPathEffect$Style;");
				global::android.graphics.PathDashPathEffect.Style._ROTATE5549 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PathDashPathEffect.Style.staticClass, "ROTATE", "Landroid/graphics/PathDashPathEffect$Style;");
				global::android.graphics.PathDashPathEffect.Style._TRANSLATE5550 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.PathDashPathEffect.Style.staticClass, "TRANSLATE", "Landroid/graphics/PathDashPathEffect$Style;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _PathDashPathEffect5551;
		public PathDashPathEffect(android.graphics.Path arg0, float arg1, float arg2, android.graphics.PathDashPathEffect.Style arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PathDashPathEffect.staticClass, global::android.graphics.PathDashPathEffect._PathDashPathEffect5551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PathDashPathEffect.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PathDashPathEffect"));
			global::android.graphics.PathDashPathEffect._PathDashPathEffect5551 = @__env.GetMethodIDNoThrow(global::android.graphics.PathDashPathEffect.staticClass, "<init>", "(Landroid/graphics/Path;FFLandroid/graphics/PathDashPathEffect$Style;)V");
		}
	}
}

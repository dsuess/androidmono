namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GestureLibraries : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureLibraries()
		{
			InitJNI();
		}
		internal GestureLibraries(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _fromFile4863;
		public static global::android.gesture.GestureLibrary fromFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromFile4863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.gesture.GestureLibrary;
		}
		internal static global::MonoJavaBridge.MethodId _fromFile4864;
		public static global::android.gesture.GestureLibrary fromFile(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromFile4864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.gesture.GestureLibrary;
		}
		internal static global::MonoJavaBridge.MethodId _fromPrivateFile4865;
		public static global::android.gesture.GestureLibrary fromPrivateFile(android.content.Context arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromPrivateFile4865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.gesture.GestureLibrary;
		}
		internal static global::MonoJavaBridge.MethodId _fromRawResource4866;
		public static global::android.gesture.GestureLibrary fromRawResource(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureLibraries.staticClass, global::android.gesture.GestureLibraries._fromRawResource4866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.gesture.GestureLibrary;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureLibraries.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureLibraries"));
			global::android.gesture.GestureLibraries._fromFile4863 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromFile", "(Ljava/lang/String;)Landroid/gesture/GestureLibrary;");
			global::android.gesture.GestureLibraries._fromFile4864 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromFile", "(Ljava/io/File;)Landroid/gesture/GestureLibrary;");
			global::android.gesture.GestureLibraries._fromPrivateFile4865 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromPrivateFile", "(Landroid/content/Context;Ljava/lang/String;)Landroid/gesture/GestureLibrary;");
			global::android.gesture.GestureLibraries._fromRawResource4866 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureLibraries.staticClass, "fromRawResource", "(Landroid/content/Context;I)Landroid/gesture/GestureLibrary;");
		}
	}
}

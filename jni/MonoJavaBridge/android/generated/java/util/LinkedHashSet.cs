namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedHashSet : java.util.HashSet, Set, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinkedHashSet()
		{
			InitJNI();
		}
		protected LinkedHashSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashSet26225;
		public LinkedHashSet(int arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._LinkedHashSet26225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashSet26226;
		public LinkedHashSet(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._LinkedHashSet26226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashSet26227;
		public LinkedHashSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._LinkedHashSet26227);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedHashSet26228;
		public LinkedHashSet(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.LinkedHashSet.staticClass, global::java.util.LinkedHashSet._LinkedHashSet26228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.LinkedHashSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/LinkedHashSet"));
			global::java.util.LinkedHashSet._LinkedHashSet26225 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "(IF)V");
			global::java.util.LinkedHashSet._LinkedHashSet26226 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "(I)V");
			global::java.util.LinkedHashSet._LinkedHashSet26227 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "()V");
			global::java.util.LinkedHashSet._LinkedHashSet26228 = @__env.GetMethodIDNoThrow(global::java.util.LinkedHashSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}

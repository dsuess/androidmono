namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.Observable_))]
	public abstract partial class Observable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Observable()
		{
			InitJNI();
		}
		protected Observable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _registerObserver4696;
		public virtual void registerObserver(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Observable._registerObserver4696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Observable.staticClass, global::android.database.Observable._registerObserver4696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterObserver4697;
		public virtual void unregisterObserver(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Observable._unregisterObserver4697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Observable.staticClass, global::android.database.Observable._unregisterObserver4697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterAll4698;
		public virtual void unregisterAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Observable._unregisterAll4698);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Observable.staticClass, global::android.database.Observable._unregisterAll4698);
		}
		internal static global::MonoJavaBridge.MethodId _Observable4699;
		public Observable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.Observable.staticClass, global::android.database.Observable._Observable4699);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Observable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Observable"));
			global::android.database.Observable._registerObserver4696 = @__env.GetMethodIDNoThrow(global::android.database.Observable.staticClass, "registerObserver", "(Ljava/lang/Object;)V");
			global::android.database.Observable._unregisterObserver4697 = @__env.GetMethodIDNoThrow(global::android.database.Observable.staticClass, "unregisterObserver", "(Ljava/lang/Object;)V");
			global::android.database.Observable._unregisterAll4698 = @__env.GetMethodIDNoThrow(global::android.database.Observable.staticClass, "unregisterAll", "()V");
			global::android.database.Observable._Observable4699 = @__env.GetMethodIDNoThrow(global::android.database.Observable.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.Observable))]
	internal sealed partial class Observable_ : android.database.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Observable_()
		{
			InitJNI();
		}
		internal Observable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Observable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Observable"));
		}
	}
}

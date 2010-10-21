namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataSetObservable : android.database.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DataSetObservable()
		{
			InitJNI();
		}
		protected DataSetObservable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _notifyChanged4581;
		public virtual void notifyChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.DataSetObservable._notifyChanged4581);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._notifyChanged4581);
		}
		internal static global::MonoJavaBridge.MethodId _notifyInvalidated4582;
		public virtual void notifyInvalidated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.DataSetObservable._notifyInvalidated4582);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._notifyInvalidated4582);
		}
		internal static global::MonoJavaBridge.MethodId _DataSetObservable4583;
		public DataSetObservable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._DataSetObservable4583);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DataSetObservable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DataSetObservable"));
			global::android.database.DataSetObservable._notifyChanged4581 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObservable.staticClass, "notifyChanged", "()V");
			global::android.database.DataSetObservable._notifyInvalidated4582 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObservable.staticClass, "notifyInvalidated", "()V");
			global::android.database.DataSetObservable._DataSetObservable4583 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObservable.staticClass, "<init>", "()V");
		}
	}
}

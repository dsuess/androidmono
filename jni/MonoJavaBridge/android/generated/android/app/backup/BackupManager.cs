namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackupManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BackupManager()
		{
			InitJNI();
		}
		protected BackupManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dataChanged2324;
		public virtual void dataChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupManager._dataChanged2324);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupManager.staticClass, global::android.app.backup.BackupManager._dataChanged2324);
		}
		internal static global::MonoJavaBridge.MethodId _dataChanged2325;
		public static void dataChanged(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.app.backup.BackupManager.staticClass, global::android.app.backup.BackupManager._dataChanged2325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestRestore2326;
		public virtual int requestRestore(android.app.backup.RestoreObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.backup.BackupManager._requestRestore2326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.backup.BackupManager.staticClass, global::android.app.backup.BackupManager._requestRestore2326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BackupManager2327;
		public BackupManager(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.backup.BackupManager.staticClass, global::android.app.backup.BackupManager._BackupManager2327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupManager"));
			global::android.app.backup.BackupManager._dataChanged2324 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupManager.staticClass, "dataChanged", "()V");
			global::android.app.backup.BackupManager._dataChanged2325 = @__env.GetStaticMethodIDNoThrow(global::android.app.backup.BackupManager.staticClass, "dataChanged", "(Ljava/lang/String;)V");
			global::android.app.backup.BackupManager._requestRestore2326 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupManager.staticClass, "requestRestore", "(Landroid/app/backup/RestoreObserver;)I");
			global::android.app.backup.BackupManager._BackupManager2327 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupManager.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}

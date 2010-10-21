namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncInfo()
		{
			InitJNI();
		}
		protected SyncInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _account3532;
		public global::android.accounts.Account account
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _account3532)) as android.accounts.Account;
			}
		}
		internal static global::MonoJavaBridge.FieldId _authority3533;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _authority3533)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _startTime3534;
		public long startTime
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _startTime3534);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncInfo"));
			global::android.content.SyncInfo._account3532 = @__env.GetFieldIDNoThrow(global::android.content.SyncInfo.staticClass, "account", "Landroid/accounts/Account;");
			global::android.content.SyncInfo._authority3533 = @__env.GetFieldIDNoThrow(global::android.content.SyncInfo.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.SyncInfo._startTime3534 = @__env.GetFieldIDNoThrow(global::android.content.SyncInfo.staticClass, "startTime", "J");
		}
	}
}

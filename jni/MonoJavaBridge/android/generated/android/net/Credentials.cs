namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Credentials : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Credentials()
		{
			InitJNI();
		}
		protected Credentials(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Uid
		{
			get
			{
				return getUid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUid7605;
		public virtual int getUid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Credentials._getUid7605);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Credentials.staticClass, global::android.net.Credentials._getUid7605);
		}
		public new int Pid
		{
			get
			{
				return getPid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPid7606;
		public virtual int getPid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Credentials._getPid7606);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Credentials.staticClass, global::android.net.Credentials._getPid7606);
		}
		public new int Gid
		{
			get
			{
				return getGid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGid7607;
		public virtual int getGid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.Credentials._getGid7607);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.Credentials.staticClass, global::android.net.Credentials._getGid7607);
		}
		internal static global::MonoJavaBridge.MethodId _Credentials7608;
		public Credentials(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.Credentials.staticClass, global::android.net.Credentials._Credentials7608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Credentials.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Credentials"));
			global::android.net.Credentials._getUid7605 = @__env.GetMethodIDNoThrow(global::android.net.Credentials.staticClass, "getUid", "()I");
			global::android.net.Credentials._getPid7606 = @__env.GetMethodIDNoThrow(global::android.net.Credentials.staticClass, "getPid", "()I");
			global::android.net.Credentials._getGid7607 = @__env.GetMethodIDNoThrow(global::android.net.Credentials.staticClass, "getGid", "()I");
			global::android.net.Credentials._Credentials7608 = @__env.GetMethodIDNoThrow(global::android.net.Credentials.staticClass, "<init>", "(III)V");
		}
	}
}

namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.BasicPermission_))]
	public abstract partial class BasicPermission : java.security.Permission, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicPermission()
		{
			InitJNI();
		}
		protected BasicPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals22786;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.BasicPermission._equals22786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.BasicPermission.staticClass, global::java.security.BasicPermission._equals22786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode22787;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.BasicPermission._hashCode22787);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.BasicPermission.staticClass, global::java.security.BasicPermission._hashCode22787);
		}
		internal static global::MonoJavaBridge.MethodId _implies22788;
		public override bool implies(java.security.Permission arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.BasicPermission._implies22788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.BasicPermission.staticClass, global::java.security.BasicPermission._implies22788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActions22789;
		public override global::java.lang.String getActions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.BasicPermission._getActions22789)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.BasicPermission.staticClass, global::java.security.BasicPermission._getActions22789)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _newPermissionCollection22790;
		public override global::java.security.PermissionCollection newPermissionCollection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.BasicPermission._newPermissionCollection22790)) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.BasicPermission.staticClass, global::java.security.BasicPermission._newPermissionCollection22790)) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _BasicPermission22791;
		public BasicPermission(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.BasicPermission.staticClass, global::java.security.BasicPermission._BasicPermission22791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicPermission22792;
		public BasicPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.BasicPermission.staticClass, global::java.security.BasicPermission._BasicPermission22792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.BasicPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/BasicPermission"));
			global::java.security.BasicPermission._equals22786 = @__env.GetMethodIDNoThrow(global::java.security.BasicPermission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.BasicPermission._hashCode22787 = @__env.GetMethodIDNoThrow(global::java.security.BasicPermission.staticClass, "hashCode", "()I");
			global::java.security.BasicPermission._implies22788 = @__env.GetMethodIDNoThrow(global::java.security.BasicPermission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.BasicPermission._getActions22789 = @__env.GetMethodIDNoThrow(global::java.security.BasicPermission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.security.BasicPermission._newPermissionCollection22790 = @__env.GetMethodIDNoThrow(global::java.security.BasicPermission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.security.BasicPermission._BasicPermission22791 = @__env.GetMethodIDNoThrow(global::java.security.BasicPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.BasicPermission._BasicPermission22792 = @__env.GetMethodIDNoThrow(global::java.security.BasicPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.BasicPermission))]
	public sealed partial class BasicPermission_ : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicPermission_()
		{
			InitJNI();
		}
		internal BasicPermission_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.BasicPermission_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/BasicPermission"));
		}
	}
}

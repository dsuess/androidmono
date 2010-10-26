namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.Group_))]
	public partial interface Group : Principal
	{
		global::java.util.Enumeration members();
		bool addMember(java.security.Principal arg0);
		bool removeMember(java.security.Principal arg0);
		bool isMember(java.security.Principal arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.Group))]
	internal sealed partial class Group_ : java.lang.Object, Group
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Group_()
		{
			InitJNI();
		}
		internal Group_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _members23451;
		 global::java.util.Enumeration java.security.acl.Group.members() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Group_._members23451)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._members23451)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _addMember23452;
		 bool java.security.acl.Group.addMember(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._addMember23452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._addMember23452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeMember23453;
		 bool java.security.acl.Group.removeMember(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._removeMember23453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._removeMember23453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMember23454;
		 bool java.security.acl.Group.isMember(java.security.Principal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._isMember23454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._isMember23454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals23455;
		 bool java.security.Principal.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Group_._equals23455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._equals23455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23456;
		 global::java.lang.String java.security.Principal.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Group_._toString23456)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._toString23456)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23457;
		 int java.security.Principal.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.acl.Group_._hashCode23457);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._hashCode23457);
		}
		internal static global::MonoJavaBridge.MethodId _getName23458;
		 global::java.lang.String java.security.Principal.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Group_._getName23458)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.acl.Group_.staticClass, global::java.security.acl.Group_._getName23458)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Group_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Group"));
			global::java.security.acl.Group_._members23451 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "members", "()Ljava/util/Enumeration;");
			global::java.security.acl.Group_._addMember23452 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "addMember", "(Ljava/security/Principal;)Z");
			global::java.security.acl.Group_._removeMember23453 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "removeMember", "(Ljava/security/Principal;)Z");
			global::java.security.acl.Group_._isMember23454 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "isMember", "(Ljava/security/Principal;)Z");
			global::java.security.acl.Group_._equals23455 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.acl.Group_._toString23456 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.acl.Group_._hashCode23457 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "hashCode", "()I");
			global::java.security.acl.Group_._getName23458 = @__env.GetMethodIDNoThrow(global::java.security.acl.Group_.staticClass, "getName", "()Ljava/lang/String;");
		}
	}
}

namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLEngineResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLEngineResult()
		{
			InitJNI();
		}
		protected SSLEngineResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class HandshakeStatus : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static HandshakeStatus()
			{
				InitJNI();
			}
			internal HandshakeStatus(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values29849;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, global::javax.net.ssl.SSLEngineResult.HandshakeStatus._values29849)) as javax.net.ssl.SSLEngineResult.HandshakeStatus[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf29850;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, global::javax.net.ssl.SSLEngineResult.HandshakeStatus._valueOf29850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
			}
			internal static global::MonoJavaBridge.FieldId _NOT_HANDSHAKING29851;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NOT_HANDSHAKING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NOT_HANDSHAKING29851)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FINISHED29852;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus FINISHED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _FINISHED29852)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_TASK29853;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_TASK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NEED_TASK29853)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_WRAP29854;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_WRAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NEED_WRAP29854)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_UNWRAP29855;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_UNWRAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NEED_UNWRAP29855)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult$HandshakeStatus"));
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._values29849 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "values", "()[Ljavax/net/ssl/SSLEngineResult/HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._valueOf29850 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NOT_HANDSHAKING29851 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NOT_HANDSHAKING", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._FINISHED29852 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "FINISHED", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NEED_TASK29853 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NEED_TASK", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NEED_WRAP29854 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NEED_WRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NEED_UNWRAP29855 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NEED_UNWRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Status : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Status()
			{
				InitJNI();
			}
			internal Status(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values29856;
			public static global::javax.net.ssl.SSLEngineResult.Status[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.SSLEngineResult.Status>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.Status.staticClass, global::javax.net.ssl.SSLEngineResult.Status._values29856)) as javax.net.ssl.SSLEngineResult.Status[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf29857;
			public static global::javax.net.ssl.SSLEngineResult.Status valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.Status.staticClass, global::javax.net.ssl.SSLEngineResult.Status._valueOf29857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLEngineResult.Status;
			}
			internal static global::MonoJavaBridge.FieldId _BUFFER_UNDERFLOW29858;
			public static global::javax.net.ssl.SSLEngineResult.Status BUFFER_UNDERFLOW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _BUFFER_UNDERFLOW29858)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BUFFER_OVERFLOW29859;
			public static global::javax.net.ssl.SSLEngineResult.Status BUFFER_OVERFLOW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _BUFFER_OVERFLOW29859)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OK29860;
			public static global::javax.net.ssl.SSLEngineResult.Status OK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _OK29860)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLOSED29861;
			public static global::javax.net.ssl.SSLEngineResult.Status CLOSED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _CLOSED29861)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.net.ssl.SSLEngineResult.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult$Status"));
				global::javax.net.ssl.SSLEngineResult.Status._values29856 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "values", "()[Ljavax/net/ssl/SSLEngineResult/Status;");
				global::javax.net.ssl.SSLEngineResult.Status._valueOf29857 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._BUFFER_UNDERFLOW29858 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "BUFFER_UNDERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._BUFFER_OVERFLOW29859 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "BUFFER_OVERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._OK29860 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "OK", "Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._CLOSED29861 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "CLOSED", "Ljavax/net/ssl/SSLEngineResult$Status;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString29862;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._toString29862)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._toString29862)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStatus29863;
		public virtual global::javax.net.ssl.SSLEngineResult.Status getStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._getStatus29863)) as javax.net.ssl.SSLEngineResult.Status;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._getStatus29863)) as javax.net.ssl.SSLEngineResult.Status;
		}
		internal static global::MonoJavaBridge.MethodId _getHandshakeStatus29864;
		public virtual global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._getHandshakeStatus29864)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._getHandshakeStatus29864)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
		}
		internal static global::MonoJavaBridge.MethodId _bytesConsumed29865;
		public virtual int bytesConsumed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._bytesConsumed29865);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._bytesConsumed29865);
		}
		internal static global::MonoJavaBridge.MethodId _bytesProduced29866;
		public virtual int bytesProduced() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult._bytesProduced29866);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._bytesProduced29866);
		}
		internal static global::MonoJavaBridge.MethodId _SSLEngineResult29867;
		public SSLEngineResult(javax.net.ssl.SSLEngineResult.Status arg0, javax.net.ssl.SSLEngineResult.HandshakeStatus arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._SSLEngineResult29867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngineResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult"));
			global::javax.net.ssl.SSLEngineResult._toString29862 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.net.ssl.SSLEngineResult._getStatus29863 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "getStatus", "()Ljavax/net/ssl/SSLEngineResult$Status;");
			global::javax.net.ssl.SSLEngineResult._getHandshakeStatus29864 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			global::javax.net.ssl.SSLEngineResult._bytesConsumed29865 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "bytesConsumed", "()I");
			global::javax.net.ssl.SSLEngineResult._bytesProduced29866 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "bytesProduced", "()I");
			global::javax.net.ssl.SSLEngineResult._SSLEngineResult29867 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "<init>", "(Ljavax/net/ssl/SSLEngineResult$Status;Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;II)V");
		}
	}
}

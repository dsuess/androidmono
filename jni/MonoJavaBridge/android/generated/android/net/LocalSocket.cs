namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LocalSocket()
		{
			InitJNI();
		}
		protected LocalSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7665;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._toString7665)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._toString7665)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close7666;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._close7666);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._close7666);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream7667;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getInputStream7667)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getInputStream7667)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _connect7668;
		public virtual void connect(android.net.LocalSocketAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._connect7668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._connect7668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _connect7669;
		public virtual void connect(android.net.LocalSocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._connect7669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._connect7669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed7670;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isClosed7670);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isClosed7670);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream7671;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getOutputStream7671)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getOutputStream7671)) as java.io.OutputStream;
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor7672;
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getFileDescriptor7672)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getFileDescriptor7672)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _bind7673;
		public virtual void bind(android.net.LocalSocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._bind7673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._bind7673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnected7674;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isConnected7674);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isConnected7674);
		}
		public new global::android.net.LocalSocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress7675;
		public virtual global::android.net.LocalSocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getLocalSocketAddress7675)) as android.net.LocalSocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getLocalSocketAddress7675)) as android.net.LocalSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownInput7676;
		public virtual void shutdownInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._shutdownInput7676);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._shutdownInput7676);
		}
		internal static global::MonoJavaBridge.MethodId _shutdownOutput7677;
		public virtual void shutdownOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._shutdownOutput7677);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._shutdownOutput7677);
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize7678;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setReceiveBufferSize7678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setReceiveBufferSize7678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ReceiveBufferSize
		{
			get
			{
				return getReceiveBufferSize();
			}
			set
			{
				setReceiveBufferSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize7679;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.LocalSocket._getReceiveBufferSize7679);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getReceiveBufferSize7679);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout7680;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setSoTimeout7680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setSoTimeout7680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SoTimeout
		{
			get
			{
				return getSoTimeout();
			}
			set
			{
				setSoTimeout(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSoTimeout7681;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.LocalSocket._getSoTimeout7681);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getSoTimeout7681);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize7682;
		public virtual void setSendBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setSendBufferSize7682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setSendBufferSize7682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SendBufferSize
		{
			get
			{
				return getSendBufferSize();
			}
			set
			{
				setSendBufferSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize7683;
		public virtual int getSendBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.LocalSocket._getSendBufferSize7683);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getSendBufferSize7683);
		}
		public new global::android.net.LocalSocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress7684;
		public virtual global::android.net.LocalSocketAddress getRemoteSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getRemoteSocketAddress7684)) as android.net.LocalSocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getRemoteSocketAddress7684)) as android.net.LocalSocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound7685;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isBound7685);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isBound7685);
		}
		internal static global::MonoJavaBridge.MethodId _isOutputShutdown7686;
		public virtual bool isOutputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isOutputShutdown7686);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isOutputShutdown7686);
		}
		internal static global::MonoJavaBridge.MethodId _isInputShutdown7687;
		public virtual bool isInputShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.LocalSocket._isInputShutdown7687);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._isInputShutdown7687);
		}
		internal static global::MonoJavaBridge.MethodId _setFileDescriptorsForSend7688;
		public virtual void setFileDescriptorsForSend(java.io.FileDescriptor[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.LocalSocket._setFileDescriptorsForSend7688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._setFileDescriptorsForSend7688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.FileDescriptor[] AncillaryFileDescriptors
		{
			get
			{
				return getAncillaryFileDescriptors();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAncillaryFileDescriptors7689;
		public virtual global::java.io.FileDescriptor[] getAncillaryFileDescriptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.FileDescriptor>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getAncillaryFileDescriptors7689)) as java.io.FileDescriptor[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.io.FileDescriptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getAncillaryFileDescriptors7689)) as java.io.FileDescriptor[];
		}
		public new global::android.net.Credentials PeerCredentials
		{
			get
			{
				return getPeerCredentials();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPeerCredentials7690;
		public virtual global::android.net.Credentials getPeerCredentials() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocket._getPeerCredentials7690)) as android.net.Credentials;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocket.staticClass, global::android.net.LocalSocket._getPeerCredentials7690)) as android.net.Credentials;
		}
		internal static global::MonoJavaBridge.MethodId _LocalSocket7691;
		public LocalSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalSocket.staticClass, global::android.net.LocalSocket._LocalSocket7691);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.LocalSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalSocket"));
			global::android.net.LocalSocket._toString7665 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.LocalSocket._close7666 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "close", "()V");
			global::android.net.LocalSocket._getInputStream7667 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::android.net.LocalSocket._connect7668 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;I)V");
			global::android.net.LocalSocket._connect7669 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "connect", "(Landroid/net/LocalSocketAddress;)V");
			global::android.net.LocalSocket._isClosed7670 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isClosed", "()Z");
			global::android.net.LocalSocket._getOutputStream7671 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::android.net.LocalSocket._getFileDescriptor7672 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.net.LocalSocket._bind7673 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "bind", "(Landroid/net/LocalSocketAddress;)V");
			global::android.net.LocalSocket._isConnected7674 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isConnected", "()Z");
			global::android.net.LocalSocket._getLocalSocketAddress7675 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;");
			global::android.net.LocalSocket._shutdownInput7676 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "shutdownInput", "()V");
			global::android.net.LocalSocket._shutdownOutput7677 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "shutdownOutput", "()V");
			global::android.net.LocalSocket._setReceiveBufferSize7678 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::android.net.LocalSocket._getReceiveBufferSize7679 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getReceiveBufferSize", "()I");
			global::android.net.LocalSocket._setSoTimeout7680 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setSoTimeout", "(I)V");
			global::android.net.LocalSocket._getSoTimeout7681 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getSoTimeout", "()I");
			global::android.net.LocalSocket._setSendBufferSize7682 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setSendBufferSize", "(I)V");
			global::android.net.LocalSocket._getSendBufferSize7683 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getSendBufferSize", "()I");
			global::android.net.LocalSocket._getRemoteSocketAddress7684 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;");
			global::android.net.LocalSocket._isBound7685 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isBound", "()Z");
			global::android.net.LocalSocket._isOutputShutdown7686 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isOutputShutdown", "()Z");
			global::android.net.LocalSocket._isInputShutdown7687 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "isInputShutdown", "()Z");
			global::android.net.LocalSocket._setFileDescriptorsForSend7688 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "setFileDescriptorsForSend", "([Ljava/io/FileDescriptor;)V");
			global::android.net.LocalSocket._getAncillaryFileDescriptors7689 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;");
			global::android.net.LocalSocket._getPeerCredentials7690 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "getPeerCredentials", "()Landroid/net/Credentials;");
			global::android.net.LocalSocket._LocalSocket7691 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocket.staticClass, "<init>", "()V");
		}
	}
}

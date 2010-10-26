namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatagramSocket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramSocket()
		{
			InitJNI();
		}
		protected DatagramSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close21390;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._close21390);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._close21390);
		}
		internal static global::MonoJavaBridge.MethodId _send21391;
		public virtual void send(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._send21391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._send21391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21392;
		public virtual int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getPort21392);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getPort21392);
		}
		public new global::java.nio.channels.DatagramChannel Channel
		{
			get
			{
				return getChannel();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannel21393;
		public virtual global::java.nio.channels.DatagramChannel getChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getChannel21393)) as java.nio.channels.DatagramChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getChannel21393)) as java.nio.channels.DatagramChannel;
		}
		internal static global::MonoJavaBridge.MethodId _connect21394;
		public virtual void connect(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._connect21394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect21394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _connect21395;
		public virtual void connect(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._connect21395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._connect21395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isClosed21396;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isClosed21396);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isClosed21396);
		}
		public new bool Broadcast
		{
			get
			{
				return getBroadcast();
			}
			set
			{
				setBroadcast(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBroadcast21397;
		public virtual bool getBroadcast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._getBroadcast21397);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getBroadcast21397);
		}
		internal static global::MonoJavaBridge.MethodId _bind21398;
		public virtual void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._bind21398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._bind21398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _disconnect21399;
		public virtual void disconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._disconnect21399);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._disconnect21399);
		}
		internal static global::MonoJavaBridge.MethodId _isConnected21400;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isConnected21400);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isConnected21400);
		}
		public new global::java.net.SocketAddress LocalSocketAddress
		{
			get
			{
				return getLocalSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalSocketAddress21401;
		public virtual global::java.net.SocketAddress getLocalSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalSocketAddress21401)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalSocketAddress21401)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setReceiveBufferSize21402;
		public virtual void setReceiveBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setReceiveBufferSize21402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReceiveBufferSize21402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getReceiveBufferSize21403;
		public virtual int getReceiveBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getReceiveBufferSize21403);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReceiveBufferSize21403);
		}
		internal static global::MonoJavaBridge.MethodId _setSoTimeout21404;
		public virtual void setSoTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setSoTimeout21404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSoTimeout21404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSoTimeout21405;
		public virtual int getSoTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getSoTimeout21405);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSoTimeout21405);
		}
		internal static global::MonoJavaBridge.MethodId _setSendBufferSize21406;
		public virtual void setSendBufferSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setSendBufferSize21406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setSendBufferSize21406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSendBufferSize21407;
		public virtual int getSendBufferSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getSendBufferSize21407);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getSendBufferSize21407);
		}
		public new global::java.net.SocketAddress RemoteSocketAddress
		{
			get
			{
				return getRemoteSocketAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteSocketAddress21408;
		public virtual global::java.net.SocketAddress getRemoteSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getRemoteSocketAddress21408)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getRemoteSocketAddress21408)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _isBound21409;
		public virtual bool isBound() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._isBound21409);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._isBound21409);
		}
		public new global::java.net.InetAddress InetAddress
		{
			get
			{
				return getInetAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInetAddress21410;
		public virtual global::java.net.InetAddress getInetAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getInetAddress21410)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getInetAddress21410)) as java.net.InetAddress;
		}
		public new global::java.net.InetAddress LocalAddress
		{
			get
			{
				return getLocalAddress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalAddress21411;
		public virtual global::java.net.InetAddress getLocalAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalAddress21411)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalAddress21411)) as java.net.InetAddress;
		}
		public new int LocalPort
		{
			get
			{
				return getLocalPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalPort21412;
		public virtual int getLocalPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getLocalPort21412);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getLocalPort21412);
		}
		internal static global::MonoJavaBridge.MethodId _setTrafficClass21413;
		public virtual void setTrafficClass(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setTrafficClass21413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setTrafficClass21413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int TrafficClass
		{
			get
			{
				return getTrafficClass();
			}
			set
			{
				setTrafficClass(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTrafficClass21414;
		public virtual int getTrafficClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramSocket._getTrafficClass21414);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getTrafficClass21414);
		}
		internal static global::MonoJavaBridge.MethodId _setReuseAddress21415;
		public virtual void setReuseAddress(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setReuseAddress21415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setReuseAddress21415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ReuseAddress
		{
			get
			{
				return getReuseAddress();
			}
			set
			{
				setReuseAddress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReuseAddress21416;
		public virtual bool getReuseAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket._getReuseAddress21416);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._getReuseAddress21416);
		}
		internal static global::MonoJavaBridge.MethodId _receive21417;
		public virtual void receive(java.net.DatagramPacket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._receive21417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._receive21417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBroadcast21418;
		public virtual void setBroadcast(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramSocket._setBroadcast21418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setBroadcast21418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDatagramSocketImplFactory21419;
		public static void setDatagramSocketImplFactory(java.net.DatagramSocketImplFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._setDatagramSocketImplFactory21419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21420;
		public DatagramSocket(java.net.SocketAddress arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21421;
		public DatagramSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21421);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21422;
		protected DatagramSocket(java.net.DatagramSocketImpl arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21423;
		public DatagramSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramSocket21424;
		public DatagramSocket(int arg0, java.net.InetAddress arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramSocket.staticClass, global::java.net.DatagramSocket._DatagramSocket21424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramSocket"));
			global::java.net.DatagramSocket._close21390 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "close", "()V");
			global::java.net.DatagramSocket._send21391 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "send", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocket._getPort21392 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getPort", "()I");
			global::java.net.DatagramSocket._getChannel21393 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getChannel", "()Ljava/nio/channels/DatagramChannel;");
			global::java.net.DatagramSocket._connect21394 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._connect21395 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "connect", "(Ljava/net/InetAddress;I)V");
			global::java.net.DatagramSocket._isClosed21396 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isClosed", "()Z");
			global::java.net.DatagramSocket._getBroadcast21397 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getBroadcast", "()Z");
			global::java.net.DatagramSocket._bind21398 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._disconnect21399 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "disconnect", "()V");
			global::java.net.DatagramSocket._isConnected21400 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isConnected", "()Z");
			global::java.net.DatagramSocket._getLocalSocketAddress21401 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramSocket._setReceiveBufferSize21402 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setReceiveBufferSize", "(I)V");
			global::java.net.DatagramSocket._getReceiveBufferSize21403 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getReceiveBufferSize", "()I");
			global::java.net.DatagramSocket._setSoTimeout21404 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setSoTimeout", "(I)V");
			global::java.net.DatagramSocket._getSoTimeout21405 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getSoTimeout", "()I");
			global::java.net.DatagramSocket._setSendBufferSize21406 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setSendBufferSize", "(I)V");
			global::java.net.DatagramSocket._getSendBufferSize21407 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getSendBufferSize", "()I");
			global::java.net.DatagramSocket._getRemoteSocketAddress21408 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getRemoteSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramSocket._isBound21409 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "isBound", "()Z");
			global::java.net.DatagramSocket._getInetAddress21410 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getInetAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramSocket._getLocalAddress21411 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramSocket._getLocalPort21412 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getLocalPort", "()I");
			global::java.net.DatagramSocket._setTrafficClass21413 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setTrafficClass", "(I)V");
			global::java.net.DatagramSocket._getTrafficClass21414 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getTrafficClass", "()I");
			global::java.net.DatagramSocket._setReuseAddress21415 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setReuseAddress", "(Z)V");
			global::java.net.DatagramSocket._getReuseAddress21416 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "getReuseAddress", "()Z");
			global::java.net.DatagramSocket._receive21417 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "receive", "(Ljava/net/DatagramPacket;)V");
			global::java.net.DatagramSocket._setBroadcast21418 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setBroadcast", "(Z)V");
			global::java.net.DatagramSocket._setDatagramSocketImplFactory21419 = @__env.GetStaticMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "setDatagramSocketImplFactory", "(Ljava/net/DatagramSocketImplFactory;)V");
			global::java.net.DatagramSocket._DatagramSocket21420 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramSocket._DatagramSocket21421 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "()V");
			global::java.net.DatagramSocket._DatagramSocket21422 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(Ljava/net/DatagramSocketImpl;)V");
			global::java.net.DatagramSocket._DatagramSocket21423 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(I)V");
			global::java.net.DatagramSocket._DatagramSocket21424 = @__env.GetMethodIDNoThrow(global::java.net.DatagramSocket.staticClass, "<init>", "(ILjava/net/InetAddress;)V");
		}
	}
}

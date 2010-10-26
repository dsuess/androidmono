namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MulticastSocket : java.net.DatagramSocket
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MulticastSocket()
		{
			InitJNI();
		}
		protected MulticastSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _send21609;
		public virtual void send(java.net.DatagramPacket arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._send21609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._send21609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _bind21610;
		public override void bind(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._bind21610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._bind21610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTTL21611;
		public virtual void setTTL(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setTTL21611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setTTL21611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new byte TTL
		{
			get
			{
				return getTTL();
			}
			set
			{
				setTTL(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTTL21612;
		public virtual byte getTTL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.net.MulticastSocket._getTTL21612);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getTTL21612);
		}
		internal static global::MonoJavaBridge.MethodId _setTimeToLive21613;
		public virtual void setTimeToLive(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setTimeToLive21613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setTimeToLive21613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int TimeToLive
		{
			get
			{
				return getTimeToLive();
			}
			set
			{
				setTimeToLive(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimeToLive21614;
		public virtual int getTimeToLive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.MulticastSocket._getTimeToLive21614);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getTimeToLive21614);
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup21615;
		public virtual void joinGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._joinGroup21615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._joinGroup21615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _joinGroup21616;
		public virtual void joinGroup(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._joinGroup21616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._joinGroup21616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup21617;
		public virtual void leaveGroup(java.net.SocketAddress arg0, java.net.NetworkInterface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._leaveGroup21617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._leaveGroup21617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _leaveGroup21618;
		public virtual void leaveGroup(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._leaveGroup21618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._leaveGroup21618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterface21619;
		public virtual void setInterface(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setInterface21619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setInterface21619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.InetAddress Interface
		{
			get
			{
				return getInterface();
			}
			set
			{
				setInterface(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterface21620;
		public virtual global::java.net.InetAddress getInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.MulticastSocket._getInterface21620)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getInterface21620)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setNetworkInterface21621;
		public virtual void setNetworkInterface(java.net.NetworkInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setNetworkInterface21621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setNetworkInterface21621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.NetworkInterface NetworkInterface
		{
			get
			{
				return getNetworkInterface();
			}
			set
			{
				setNetworkInterface(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkInterface21622;
		public virtual global::java.net.NetworkInterface getNetworkInterface() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.MulticastSocket._getNetworkInterface21622)) as java.net.NetworkInterface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.NetworkInterface>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getNetworkInterface21622)) as java.net.NetworkInterface;
		}
		internal static global::MonoJavaBridge.MethodId _setLoopbackMode21623;
		public virtual void setLoopbackMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.MulticastSocket._setLoopbackMode21623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._setLoopbackMode21623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool LoopbackMode
		{
			get
			{
				return getLoopbackMode();
			}
			set
			{
				setLoopbackMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoopbackMode21624;
		public virtual bool getLoopbackMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.MulticastSocket._getLoopbackMode21624);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._getLoopbackMode21624);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket21625;
		public MulticastSocket()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket21625);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket21626;
		public MulticastSocket(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket21626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MulticastSocket21627;
		public MulticastSocket(java.net.SocketAddress arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.MulticastSocket.staticClass, global::java.net.MulticastSocket._MulticastSocket21627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.MulticastSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/MulticastSocket"));
			global::java.net.MulticastSocket._send21609 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "send", "(Ljava/net/DatagramPacket;B)V");
			global::java.net.MulticastSocket._bind21610 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "bind", "(Ljava/net/SocketAddress;)V");
			global::java.net.MulticastSocket._setTTL21611 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setTTL", "(B)V");
			global::java.net.MulticastSocket._getTTL21612 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getTTL", "()B");
			global::java.net.MulticastSocket._setTimeToLive21613 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setTimeToLive", "(I)V");
			global::java.net.MulticastSocket._getTimeToLive21614 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getTimeToLive", "()I");
			global::java.net.MulticastSocket._joinGroup21615 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "joinGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.MulticastSocket._joinGroup21616 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "joinGroup", "(Ljava/net/InetAddress;)V");
			global::java.net.MulticastSocket._leaveGroup21617 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "leaveGroup", "(Ljava/net/SocketAddress;Ljava/net/NetworkInterface;)V");
			global::java.net.MulticastSocket._leaveGroup21618 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "leaveGroup", "(Ljava/net/InetAddress;)V");
			global::java.net.MulticastSocket._setInterface21619 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setInterface", "(Ljava/net/InetAddress;)V");
			global::java.net.MulticastSocket._getInterface21620 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getInterface", "()Ljava/net/InetAddress;");
			global::java.net.MulticastSocket._setNetworkInterface21621 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setNetworkInterface", "(Ljava/net/NetworkInterface;)V");
			global::java.net.MulticastSocket._getNetworkInterface21622 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getNetworkInterface", "()Ljava/net/NetworkInterface;");
			global::java.net.MulticastSocket._setLoopbackMode21623 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "setLoopbackMode", "(Z)V");
			global::java.net.MulticastSocket._getLoopbackMode21624 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "getLoopbackMode", "()Z");
			global::java.net.MulticastSocket._MulticastSocket21625 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "()V");
			global::java.net.MulticastSocket._MulticastSocket21626 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "(I)V");
			global::java.net.MulticastSocket._MulticastSocket21627 = @__env.GetMethodIDNoThrow(global::java.net.MulticastSocket.staticClass, "<init>", "(Ljava/net/SocketAddress;)V");
		}
	}
}

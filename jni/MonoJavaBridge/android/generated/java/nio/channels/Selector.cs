namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.Selector_))]
	public abstract partial class Selector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Selector()
		{
			InitJNI();
		}
		protected Selector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _provider22599;
		public abstract global::java.nio.channels.spi.SelectorProvider provider();
		internal static global::MonoJavaBridge.MethodId _keys22600;
		public abstract global::java.util.Set keys();
		internal static global::MonoJavaBridge.MethodId _close22601;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _open22602;
		public static global::java.nio.channels.Selector open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._open22602)) as java.nio.channels.Selector;
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22603;
		public abstract bool isOpen();
		internal static global::MonoJavaBridge.MethodId _select22604;
		public abstract int select(long arg0);
		internal static global::MonoJavaBridge.MethodId _select22605;
		public abstract int select();
		internal static global::MonoJavaBridge.MethodId _selectedKeys22606;
		public abstract global::java.util.Set selectedKeys();
		internal static global::MonoJavaBridge.MethodId _selectNow22607;
		public abstract int selectNow();
		internal static global::MonoJavaBridge.MethodId _wakeup22608;
		public abstract global::java.nio.channels.Selector wakeup();
		internal static global::MonoJavaBridge.MethodId _Selector22609;
		protected Selector()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._Selector22609);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Selector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Selector"));
			global::java.nio.channels.Selector._provider22599 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.Selector._keys22600 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "keys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector._close22601 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "close", "()V");
			global::java.nio.channels.Selector._open22602 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "open", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.Selector._isOpen22603 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "isOpen", "()Z");
			global::java.nio.channels.Selector._select22604 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "select", "(J)I");
			global::java.nio.channels.Selector._select22605 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "select", "()I");
			global::java.nio.channels.Selector._selectedKeys22606 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "selectedKeys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector._selectNow22607 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "selectNow", "()I");
			global::java.nio.channels.Selector._wakeup22608 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "wakeup", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.Selector._Selector22609 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Selector))]
	internal sealed partial class Selector_ : java.nio.channels.Selector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Selector_()
		{
			InitJNI();
		}
		internal Selector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _provider22610;
		public override global::java.nio.channels.spi.SelectorProvider provider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._provider22610)) as java.nio.channels.spi.SelectorProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._provider22610)) as java.nio.channels.spi.SelectorProvider;
		}
		internal static global::MonoJavaBridge.MethodId _keys22611;
		public override global::java.util.Set keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._keys22611)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._keys22611)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _close22612;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Selector_._close22612);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._close22612);
		}
		internal static global::MonoJavaBridge.MethodId _isOpen22613;
		public override bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.Selector_._isOpen22613);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._isOpen22613);
		}
		internal static global::MonoJavaBridge.MethodId _select22614;
		public override int select(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._select22614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._select22614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _select22615;
		public override int select() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._select22615);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._select22615);
		}
		internal static global::MonoJavaBridge.MethodId _selectedKeys22616;
		public override global::java.util.Set selectedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._selectedKeys22616)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._selectedKeys22616)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _selectNow22617;
		public override int selectNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Selector_._selectNow22617);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._selectNow22617);
		}
		internal static global::MonoJavaBridge.MethodId _wakeup22618;
		public override global::java.nio.channels.Selector wakeup() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_._wakeup22618)) as java.nio.channels.Selector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Selector_.staticClass, global::java.nio.channels.Selector_._wakeup22618)) as java.nio.channels.Selector;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Selector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Selector"));
			global::java.nio.channels.Selector_._provider22610 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.Selector_._keys22611 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "keys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector_._close22612 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "close", "()V");
			global::java.nio.channels.Selector_._isOpen22613 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "isOpen", "()Z");
			global::java.nio.channels.Selector_._select22614 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "select", "(J)I");
			global::java.nio.channels.Selector_._select22615 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "select", "()I");
			global::java.nio.channels.Selector_._selectedKeys22616 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "selectedKeys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector_._selectNow22617 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "selectNow", "()I");
			global::java.nio.channels.Selector_._wakeup22618 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Selector_.staticClass, "wakeup", "()Ljava/nio/channels/Selector;");
		}
	}
}

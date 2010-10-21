namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractSequentialList_))]
	public abstract partial class AbstractSequentialList : java.util.AbstractList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractSequentialList()
		{
			InitJNI();
		}
		protected AbstractSequentialList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add25613;
		public override void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractSequentialList._add25613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._add25613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get25614;
		public override global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList._get25614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._get25614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _addAll25615;
		public override bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractSequentialList._addAll25615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._addAll25615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _iterator25616;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList._iterator25616)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._iterator25616)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove25617;
		public override global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList._remove25617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._remove25617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set25618;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList._set25618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._set25618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator25619;
		public abstract global::java.util.ListIterator listIterator(int arg0);
		internal static global::MonoJavaBridge.MethodId _AbstractSequentialList25620;
		protected AbstractSequentialList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractSequentialList.staticClass, global::java.util.AbstractSequentialList._AbstractSequentialList25620);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSequentialList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSequentialList"));
			global::java.util.AbstractSequentialList._add25613 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.AbstractSequentialList._get25614 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.AbstractSequentialList._addAll25615 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.AbstractSequentialList._iterator25616 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.AbstractSequentialList._remove25617 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.AbstractSequentialList._set25618 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractSequentialList._listIterator25619 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.AbstractSequentialList._AbstractSequentialList25620 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractSequentialList))]
	public sealed partial class AbstractSequentialList_ : java.util.AbstractSequentialList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractSequentialList_()
		{
			InitJNI();
		}
		internal AbstractSequentialList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _listIterator25621;
		public override global::java.util.ListIterator listIterator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList_._listIterator25621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractSequentialList_.staticClass, global::java.util.AbstractSequentialList_._listIterator25621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _size25622;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractSequentialList_._size25622);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractSequentialList_.staticClass, global::java.util.AbstractSequentialList_._size25622);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSequentialList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSequentialList"));
			global::java.util.AbstractSequentialList_._listIterator25621 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList_.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.AbstractSequentialList_._size25622 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSequentialList_.staticClass, "size", "()I");
		}
	}
}

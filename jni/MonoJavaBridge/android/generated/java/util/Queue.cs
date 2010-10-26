namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Queue_))]
	public partial interface Queue : Collection
	{
		bool add(java.lang.Object arg0);
		global::java.lang.Object remove();
		global::java.lang.Object poll();
		global::java.lang.Object peek();
		global::java.lang.Object element();
		bool offer(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Queue))]
	internal sealed partial class Queue_ : java.lang.Object, Queue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Queue_()
		{
			InitJNI();
		}
		internal Queue_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26585;
		 bool java.util.Queue.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._add26585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._add26585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26586;
		 global::java.lang.Object java.util.Queue.remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._remove26586)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._remove26586)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll26587;
		 global::java.lang.Object java.util.Queue.poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._poll26587)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._poll26587)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26588;
		 global::java.lang.Object java.util.Queue.peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._peek26588)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._peek26588)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _element26589;
		 global::java.lang.Object java.util.Queue.element() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._element26589)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._element26589)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26590;
		 bool java.util.Queue.offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._offer26590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._offer26590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26591;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._add26591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._add26591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26592;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._equals26592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._equals26592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26593;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Queue_._hashCode26593);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._hashCode26593);
		}
		internal static global::MonoJavaBridge.MethodId _clear26594;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Queue_._clear26594);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._clear26594);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26595;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._isEmpty26595);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._isEmpty26595);
		}
		internal static global::MonoJavaBridge.MethodId _contains26596;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._contains26596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._contains26596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26597;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._addAll26597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._addAll26597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26598;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Queue_._size26598);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._size26598);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26599;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._toArray26599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._toArray26599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26600;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._toArray26600)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._toArray26600)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26601;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._iterator26601)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._iterator26601)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26602;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._remove26602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._remove26602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26603;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._containsAll26603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._containsAll26603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26604;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._removeAll26604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._removeAll26604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26605;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Queue_._retainAll26605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._retainAll26605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26606;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Queue_._iterator26606)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Queue_.staticClass, global::java.util.Queue_._iterator26606)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Queue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Queue"));
			global::java.util.Queue_._add26585 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._remove26586 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "remove", "()Ljava/lang/Object;");
			global::java.util.Queue_._poll26587 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.Queue_._peek26588 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.Queue_._element26589 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "element", "()Ljava/lang/Object;");
			global::java.util.Queue_._offer26590 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._add26591 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._equals26592 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._hashCode26593 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "hashCode", "()I");
			global::java.util.Queue_._clear26594 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "clear", "()V");
			global::java.util.Queue_._isEmpty26595 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "isEmpty", "()Z");
			global::java.util.Queue_._contains26596 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._addAll26597 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._size26598 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "size", "()I");
			global::java.util.Queue_._toArray26599 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.Queue_._toArray26600 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.Queue_._iterator26601 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.Queue_._remove26602 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.Queue_._containsAll26603 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._removeAll26604 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._retainAll26605 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.Queue_._iterator26606 = @__env.GetMethodIDNoThrow(global::java.util.Queue_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}

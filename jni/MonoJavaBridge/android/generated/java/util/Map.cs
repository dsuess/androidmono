namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Map_))]
	public interface Map  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object get(java.lang.Object arg0);
		global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1);
		bool equals(java.lang.Object arg0);
		global::java.util.Collection values();
		int hashCode();
		void clear();
		bool isEmpty();
		int size();
		global::java.util.Set entrySet();
		void putAll(java.util.Map arg0);
		global::java.lang.Object remove(java.lang.Object arg0);
		global::java.util.Set keySet();
		bool containsValue(java.lang.Object arg0);
		bool containsKey(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Map))]
	public sealed partial class Map_ : java.lang.Object, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Map_()
		{
			InitJNI();
		}
		internal Map_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26383;
		 global::java.lang.Object java.util.Map.get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._get26383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._get26383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26384;
		 global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._put26384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._put26384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26385;
		 bool java.util.Map.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._equals26385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._equals26385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26386;
		 global::java.util.Collection java.util.Map.values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._values26386)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._values26386)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26387;
		 int java.util.Map.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Map_._hashCode26387);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._hashCode26387);
		}
		internal static global::MonoJavaBridge.MethodId _clear26388;
		 void java.util.Map.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Map_._clear26388);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._clear26388);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26389;
		 bool java.util.Map.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._isEmpty26389);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._isEmpty26389);
		}
		internal static global::MonoJavaBridge.MethodId _size26390;
		 int java.util.Map.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Map_._size26390);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._size26390);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26391;
		 global::java.util.Set java.util.Map.entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._entrySet26391)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._entrySet26391)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26392;
		 void java.util.Map.putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Map_._putAll26392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._putAll26392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26393;
		 global::java.lang.Object java.util.Map.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._remove26393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._remove26393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26394;
		 global::java.util.Set java.util.Map.keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._keySet26394)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._keySet26394)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26395;
		 bool java.util.Map.containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._containsValue26395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._containsValue26395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26396;
		 bool java.util.Map.containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._containsKey26396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._containsKey26396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Map_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Map"));
			global::java.util.Map_._get26383 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Map_._put26384 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Map_._equals26385 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Map_._values26386 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.Map_._hashCode26387 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "hashCode", "()I");
			global::java.util.Map_._clear26388 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "clear", "()V");
			global::java.util.Map_._isEmpty26389 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "isEmpty", "()Z");
			global::java.util.Map_._size26390 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "size", "()I");
			global::java.util.Map_._entrySet26391 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.Map_._putAll26392 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.Map_._remove26393 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Map_._keySet26394 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.Map_._containsValue26395 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.Map_._containsKey26396 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
		}
	}
}

namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderIterator : java.lang.Object, HeaderIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHeaderIterator()
		{
			InitJNI();
		}
		protected BasicHeaderIterator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext33410;
		public virtual bool hasNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator._hasNext33410);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator.staticClass, global::org.apache.http.message.BasicHeaderIterator._hasNext33410);
		}
		internal static global::MonoJavaBridge.MethodId _next33411;
		public virtual global::java.lang.Object next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator._next33411)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator.staticClass, global::org.apache.http.message.BasicHeaderIterator._next33411)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove33412;
		public virtual void remove() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator._remove33412);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator.staticClass, global::org.apache.http.message.BasicHeaderIterator._remove33412);
		}
		internal static global::MonoJavaBridge.MethodId _findNext33413;
		protected virtual int findNext(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator._findNext33413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator.staticClass, global::org.apache.http.message.BasicHeaderIterator._findNext33413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextHeader33414;
		public virtual global::org.apache.http.Header nextHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator._nextHeader33414)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator.staticClass, global::org.apache.http.message.BasicHeaderIterator._nextHeader33414)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _filterHeader33415;
		protected virtual bool filterHeader(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator._filterHeader33415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderIterator.staticClass, global::org.apache.http.message.BasicHeaderIterator._filterHeader33415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderIterator33416;
		public BasicHeaderIterator(org.apache.http.Header[] arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderIterator.staticClass, global::org.apache.http.message.BasicHeaderIterator._BasicHeaderIterator33416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderIterator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderIterator"));
			global::org.apache.http.message.BasicHeaderIterator._hasNext33410 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderIterator.staticClass, "hasNext", "()Z");
			global::org.apache.http.message.BasicHeaderIterator._next33411 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderIterator.staticClass, "next", "()Ljava/lang/Object;");
			global::org.apache.http.message.BasicHeaderIterator._remove33412 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderIterator.staticClass, "remove", "()V");
			global::org.apache.http.message.BasicHeaderIterator._findNext33413 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderIterator.staticClass, "findNext", "(I)I");
			global::org.apache.http.message.BasicHeaderIterator._nextHeader33414 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderIterator.staticClass, "nextHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.message.BasicHeaderIterator._filterHeader33415 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderIterator.staticClass, "filterHeader", "(I)Z");
			global::org.apache.http.message.BasicHeaderIterator._BasicHeaderIterator33416 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderIterator.staticClass, "<init>", "([Lorg/apache/http/Header;Ljava/lang/String;)V");
		}
	}
}

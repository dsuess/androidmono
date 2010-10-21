namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.shapes.Shape_))]
	public abstract partial class Shape : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Shape()
		{
			InitJNI();
		}
		protected Shape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone6238;
		public virtual global::android.graphics.drawable.shapes.Shape clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._clone6238)) as android.graphics.drawable.shapes.Shape;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._clone6238)) as android.graphics.drawable.shapes.Shape;
		}
		internal static global::MonoJavaBridge.MethodId _resize6239;
		public virtual void resize(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._resize6239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._resize6239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _draw6240;
		public abstract void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1);
		internal static global::MonoJavaBridge.MethodId _getWidth6241;
		public virtual float getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._getWidth6241);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._getWidth6241);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight6242;
		public virtual float getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._getHeight6242);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._getHeight6242);
		}
		internal static global::MonoJavaBridge.MethodId _hasAlpha6243;
		public virtual bool hasAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._hasAlpha6243);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._hasAlpha6243);
		}
		internal static global::MonoJavaBridge.MethodId _onResize6244;
		protected virtual void onResize(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._onResize6244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._onResize6244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Shape6245;
		public Shape()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._Shape6245);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.Shape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/Shape"));
			global::android.graphics.drawable.shapes.Shape._clone6238 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/Shape;");
			global::android.graphics.drawable.shapes.Shape._resize6239 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "resize", "(FF)V");
			global::android.graphics.drawable.shapes.Shape._draw6240 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.shapes.Shape._getWidth6241 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "getWidth", "()F");
			global::android.graphics.drawable.shapes.Shape._getHeight6242 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "getHeight", "()F");
			global::android.graphics.drawable.shapes.Shape._hasAlpha6243 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "hasAlpha", "()Z");
			global::android.graphics.drawable.shapes.Shape._onResize6244 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "onResize", "(FF)V");
			global::android.graphics.drawable.shapes.Shape._Shape6245 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.shapes.Shape))]
	public sealed partial class Shape_ : android.graphics.drawable.shapes.Shape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Shape_()
		{
			InitJNI();
		}
		internal Shape_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw6246;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape_._draw6246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape_.staticClass, global::android.graphics.drawable.shapes.Shape_._draw6246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.Shape_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/Shape"));
			global::android.graphics.drawable.shapes.Shape_._draw6246 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape_.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
		}
	}
}

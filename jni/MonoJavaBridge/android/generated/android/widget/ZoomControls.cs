namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ZoomControls : android.widget.LinearLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ZoomControls()
		{
			InitJNI();
		}
		protected ZoomControls(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent18325;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls._onTouchEvent18325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._onTouchEvent18325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasFocus18326;
		public override bool hasFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls._hasFocus18326);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._hasFocus18326);
		}
		internal static global::MonoJavaBridge.MethodId _show18327;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._show18327);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._show18327);
		}
		internal static global::MonoJavaBridge.MethodId _hide18328;
		public virtual void hide() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._hide18328);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._hide18328);
		}
		internal static global::MonoJavaBridge.MethodId _setZoomSpeed18329;
		public virtual void setZoomSpeed(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setZoomSpeed18329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setZoomSpeed18329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnZoomInClickListener18330;
		public virtual void setOnZoomInClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setOnZoomInClickListener18330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setOnZoomInClickListener18330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnZoomInClickListener(global::android.view.View.OnClickListenerDelegate arg0)
		{
			setOnZoomInClickListener((global::android.view.View.OnClickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnZoomOutClickListener18331;
		public virtual void setOnZoomOutClickListener(android.view.View.OnClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setOnZoomOutClickListener18331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setOnZoomOutClickListener18331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnZoomOutClickListener(global::android.view.View.OnClickListenerDelegate arg0)
		{
			setOnZoomOutClickListener((global::android.view.View.OnClickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setIsZoomInEnabled18332;
		public virtual void setIsZoomInEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setIsZoomInEnabled18332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setIsZoomInEnabled18332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIsZoomOutEnabled18333;
		public virtual void setIsZoomOutEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ZoomControls._setIsZoomOutEnabled18333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._setIsZoomOutEnabled18333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ZoomControls18334;
		public ZoomControls(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._ZoomControls18334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ZoomControls18335;
		public ZoomControls(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ZoomControls.staticClass, global::android.widget.ZoomControls._ZoomControls18335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ZoomControls.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ZoomControls"));
			global::android.widget.ZoomControls._onTouchEvent18325 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.widget.ZoomControls._hasFocus18326 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "hasFocus", "()Z");
			global::android.widget.ZoomControls._show18327 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "show", "()V");
			global::android.widget.ZoomControls._hide18328 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "hide", "()V");
			global::android.widget.ZoomControls._setZoomSpeed18329 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setZoomSpeed", "(J)V");
			global::android.widget.ZoomControls._setOnZoomInClickListener18330 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setOnZoomInClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.ZoomControls._setOnZoomOutClickListener18331 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setOnZoomOutClickListener", "(Landroid/view/View$OnClickListener;)V");
			global::android.widget.ZoomControls._setIsZoomInEnabled18332 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setIsZoomInEnabled", "(Z)V");
			global::android.widget.ZoomControls._setIsZoomOutEnabled18333 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "setIsZoomOutEnabled", "(Z)V");
			global::android.widget.ZoomControls._ZoomControls18334 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ZoomControls._ZoomControls18335 = @__env.GetMethodIDNoThrow(global::android.widget.ZoomControls.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}

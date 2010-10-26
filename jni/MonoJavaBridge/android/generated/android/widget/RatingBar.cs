namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RatingBar : android.widget.AbsSeekBar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RatingBar()
		{
			InitJNI();
		}
		protected RatingBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.RatingBar.OnRatingBarChangeListener_))]
		public partial interface OnRatingBarChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.RatingBar.OnRatingBarChangeListener))]
		internal sealed partial class OnRatingBarChangeListener_ : java.lang.Object, OnRatingBarChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnRatingBarChangeListener_()
			{
				InitJNI();
			}
			internal OnRatingBarChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onRatingChanged17556;
			 void android.widget.RatingBar.OnRatingBarChangeListener.onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar.OnRatingBarChangeListener_._onRatingChanged17556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass, global::android.widget.RatingBar.OnRatingBarChangeListener_._onRatingChanged17556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar$OnRatingBarChangeListener"));
				global::android.widget.RatingBar.OnRatingBarChangeListener_._onRatingChanged17556 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass, "onRatingChanged", "(Landroid/widget/RatingBar;FZ)V");
			}
		}

		public delegate void OnRatingBarChangeListenerDelegate(android.widget.RatingBar arg0, float arg1, bool arg2);

		internal partial class OnRatingBarChangeListenerDelegateWrapper : java.lang.Object, OnRatingBarChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnRatingBarChangeListenerDelegateWrapper()
			{
				InitJNI();
			}
			protected OnRatingBarChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnRatingBarChangeListenerDelegateWrapper17557;
			public OnRatingBarChangeListenerDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper.staticClass, global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper._OnRatingBarChangeListenerDelegateWrapper17557);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar_OnRatingBarChangeListenerDelegateWrapper"));
				global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper._OnRatingBarChangeListenerDelegateWrapper17557 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class OnRatingBarChangeListenerDelegateWrapper
		{
			private OnRatingBarChangeListenerDelegate myDelegate;
			public void onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnRatingBarChangeListenerDelegateWrapper(OnRatingBarChangeListenerDelegate d)
			{
				global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper ret = new global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _isIndicator17558;
		public virtual bool isIndicator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RatingBar._isIndicator17558);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._isIndicator17558);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17559;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._onMeasure17559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._onMeasure17559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMax17560;
		public override void setMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setMax17560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setMax17560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnRatingBarChangeListener17561;
		public virtual void setOnRatingBarChangeListener(android.widget.RatingBar.OnRatingBarChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setOnRatingBarChangeListener17561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setOnRatingBarChangeListener17561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnRatingBarChangeListener(global::android.widget.RatingBar.OnRatingBarChangeListenerDelegate arg0)
		{
			setOnRatingBarChangeListener((global::android.widget.RatingBar.OnRatingBarChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getOnRatingBarChangeListener17562;
		public virtual global::android.widget.RatingBar.OnRatingBarChangeListener getOnRatingBarChangeListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.RatingBar.OnRatingBarChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RatingBar._getOnRatingBarChangeListener17562)) as android.widget.RatingBar.OnRatingBarChangeListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.RatingBar.OnRatingBarChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getOnRatingBarChangeListener17562)) as android.widget.RatingBar.OnRatingBarChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setIsIndicator17563;
		public virtual void setIsIndicator(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setIsIndicator17563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setIsIndicator17563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNumStars17564;
		public virtual void setNumStars(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setNumStars17564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setNumStars17564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NumStars
		{
			get
			{
				return getNumStars();
			}
			set
			{
				setNumStars(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumStars17565;
		public virtual int getNumStars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RatingBar._getNumStars17565);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getNumStars17565);
		}
		internal static global::MonoJavaBridge.MethodId _setRating17566;
		public virtual void setRating(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setRating17566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setRating17566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Rating
		{
			get
			{
				return getRating();
			}
			set
			{
				setRating(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRating17567;
		public virtual float getRating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.RatingBar._getRating17567);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getRating17567);
		}
		internal static global::MonoJavaBridge.MethodId _setStepSize17568;
		public virtual void setStepSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setStepSize17568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setStepSize17568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float StepSize
		{
			get
			{
				return getStepSize();
			}
			set
			{
				setStepSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStepSize17569;
		public virtual float getStepSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.RatingBar._getStepSize17569);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getStepSize17569);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar17570;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar17570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar17571;
		public RatingBar(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar17571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar17572;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar17572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RatingBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar"));
			global::android.widget.RatingBar._isIndicator17558 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "isIndicator", "()Z");
			global::android.widget.RatingBar._onMeasure17559 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.RatingBar._setMax17560 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setMax", "(I)V");
			global::android.widget.RatingBar._setOnRatingBarChangeListener17561 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setOnRatingBarChangeListener", "(Landroid/widget/RatingBar$OnRatingBarChangeListener;)V");
			global::android.widget.RatingBar._getOnRatingBarChangeListener17562 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getOnRatingBarChangeListener", "()Landroid/widget/RatingBar$OnRatingBarChangeListener;");
			global::android.widget.RatingBar._setIsIndicator17563 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setIsIndicator", "(Z)V");
			global::android.widget.RatingBar._setNumStars17564 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setNumStars", "(I)V");
			global::android.widget.RatingBar._getNumStars17565 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getNumStars", "()I");
			global::android.widget.RatingBar._setRating17566 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setRating", "(F)V");
			global::android.widget.RatingBar._getRating17567 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getRating", "()F");
			global::android.widget.RatingBar._setStepSize17568 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setStepSize", "(F)V");
			global::android.widget.RatingBar._getStepSize17569 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getStepSize", "()F");
			global::android.widget.RatingBar._RatingBar17570 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RatingBar._RatingBar17571 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.RatingBar._RatingBar17572 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}

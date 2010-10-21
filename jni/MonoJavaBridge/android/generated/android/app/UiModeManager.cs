namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UiModeManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UiModeManager()
		{
			InitJNI();
		}
		protected UiModeManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _enableCarMode2174;
		public virtual void enableCarMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.UiModeManager._enableCarMode2174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._enableCarMode2174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _disableCarMode2175;
		public virtual void disableCarMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.UiModeManager._disableCarMode2175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._disableCarMode2175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentModeType
		{
			get
			{
				return getCurrentModeType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentModeType2176;
		public virtual int getCurrentModeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.UiModeManager._getCurrentModeType2176);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._getCurrentModeType2176);
		}
		internal static global::MonoJavaBridge.MethodId _setNightMode2177;
		public virtual void setNightMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.UiModeManager._setNightMode2177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._setNightMode2177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NightMode
		{
			get
			{
				return getNightMode();
			}
			set
			{
				setNightMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNightMode2178;
		public virtual int getNightMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.UiModeManager._getNightMode2178);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._getNightMode2178);
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_ENTER_CAR_MODE2179;
		public static global::java.lang.String ACTION_ENTER_CAR_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_ENTER_CAR_MODE2179)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_EXIT_CAR_MODE2180;
		public static global::java.lang.String ACTION_EXIT_CAR_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_EXIT_CAR_MODE2180)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_ENTER_DESK_MODE2181;
		public static global::java.lang.String ACTION_ENTER_DESK_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_ENTER_DESK_MODE2181)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_EXIT_DESK_MODE2182;
		public static global::java.lang.String ACTION_EXIT_DESK_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_EXIT_DESK_MODE2182)) as java.lang.String;
			}
			set
			{
			}
		}
		public static int MODE_NIGHT_AUTO
		{
			get
			{
				return 0;
			}
		}
		public static int MODE_NIGHT_NO
		{
			get
			{
				return 1;
			}
		}
		public static int MODE_NIGHT_YES
		{
			get
			{
				return 2;
			}
		}
		public static int ENABLE_CAR_MODE_GO_CAR_HOME
		{
			get
			{
				return 1;
			}
		}
		public static int DISABLE_CAR_MODE_GO_HOME
		{
			get
			{
				return 1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.UiModeManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/UiModeManager"));
			global::android.app.UiModeManager._enableCarMode2174 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "enableCarMode", "(I)V");
			global::android.app.UiModeManager._disableCarMode2175 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "disableCarMode", "(I)V");
			global::android.app.UiModeManager._getCurrentModeType2176 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "getCurrentModeType", "()I");
			global::android.app.UiModeManager._setNightMode2177 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "setNightMode", "(I)V");
			global::android.app.UiModeManager._getNightMode2178 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "getNightMode", "()I");
			global::android.app.UiModeManager._ACTION_ENTER_CAR_MODE2179 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_ENTER_CAR_MODE", "Ljava/lang/String;");
			global::android.app.UiModeManager._ACTION_EXIT_CAR_MODE2180 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_EXIT_CAR_MODE", "Ljava/lang/String;");
			global::android.app.UiModeManager._ACTION_ENTER_DESK_MODE2181 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_ENTER_DESK_MODE", "Ljava/lang/String;");
			global::android.app.UiModeManager._ACTION_EXIT_DESK_MODE2182 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_EXIT_DESK_MODE", "Ljava/lang/String;");
		}
	}
}

namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PreferenceCategory : android.preference.PreferenceGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PreferenceCategory()
		{
			InitJNI();
		}
		protected PreferenceCategory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled10360;
		public override bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceCategory._isEnabled10360);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._isEnabled10360);
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareAddPreference10361;
		protected override bool onPrepareAddPreference(android.preference.Preference arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.preference.PreferenceCategory._onPrepareAddPreference10361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._onPrepareAddPreference10361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceCategory10362;
		public PreferenceCategory(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._PreferenceCategory10362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceCategory10363;
		public PreferenceCategory(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._PreferenceCategory10363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceCategory10364;
		public PreferenceCategory(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.preference.PreferenceCategory.staticClass, global::android.preference.PreferenceCategory._PreferenceCategory10364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceCategory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceCategory"));
			global::android.preference.PreferenceCategory._isEnabled10360 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceCategory.staticClass, "isEnabled", "()Z");
			global::android.preference.PreferenceCategory._onPrepareAddPreference10361 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceCategory.staticClass, "onPrepareAddPreference", "(Landroid/preference/Preference;)Z");
			global::android.preference.PreferenceCategory._PreferenceCategory10362 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceCategory.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.preference.PreferenceCategory._PreferenceCategory10363 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceCategory.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.preference.PreferenceCategory._PreferenceCategory10364 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceCategory.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}

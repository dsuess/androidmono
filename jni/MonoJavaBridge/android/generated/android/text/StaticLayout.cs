namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StaticLayout : android.text.Layout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StaticLayout()
		{
			InitJNI();
		}
		protected StaticLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int LineCount
		{
			get
			{
				return getLineCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount12956;
		public override int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getLineCount12956);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineCount12956);
		}
		public new int EllipsizedWidth
		{
			get
			{
				return getEllipsizedWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsizedWidth12957;
		public override int getEllipsizedWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getEllipsizedWidth12957);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getEllipsizedWidth12957);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop12958;
		public override int getLineTop(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getLineTop12958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineTop12958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDescent12959;
		public override int getLineDescent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getLineDescent12959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineDescent12959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineStart12960;
		public override int getLineStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getLineStart12960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineStart12960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection12961;
		public override int getParagraphDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getParagraphDirection12961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getParagraphDirection12961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab12962;
		public override bool getLineContainsTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.StaticLayout._getLineContainsTab12962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineContainsTab12962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDirections12963;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.StaticLayout._getLineDirections12963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineDirections12963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
		}
		public new int TopPadding
		{
			get
			{
				return getTopPadding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPadding12964;
		public override int getTopPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getTopPadding12964);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getTopPadding12964);
		}
		public new int BottomPadding
		{
			get
			{
				return getBottomPadding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPadding12965;
		public override int getBottomPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getBottomPadding12965);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getBottomPadding12965);
		}
		internal static global::MonoJavaBridge.MethodId _getLineForVertical12966;
		public override int getLineForVertical(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getLineForVertical12966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineForVertical12966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart12967;
		public override int getEllipsisStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getEllipsisStart12967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getEllipsisStart12967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount12968;
		public override int getEllipsisCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getEllipsisCount12968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getEllipsisCount12968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StaticLayout12969;
		public StaticLayout(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3, int arg4, android.text.Layout.Alignment arg5, float arg6, float arg7, bool arg8)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._StaticLayout12969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StaticLayout12970;
		public StaticLayout(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3, int arg4, android.text.Layout.Alignment arg5, float arg6, float arg7, bool arg8, android.text.TextUtils.TruncateAt arg9, int arg10)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._StaticLayout12970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StaticLayout12971;
		public StaticLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._StaticLayout12971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.StaticLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/StaticLayout"));
			global::android.text.StaticLayout._getLineCount12956 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineCount", "()I");
			global::android.text.StaticLayout._getEllipsizedWidth12957 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.StaticLayout._getLineTop12958 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineTop", "(I)I");
			global::android.text.StaticLayout._getLineDescent12959 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineDescent", "(I)I");
			global::android.text.StaticLayout._getLineStart12960 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineStart", "(I)I");
			global::android.text.StaticLayout._getParagraphDirection12961 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.StaticLayout._getLineContainsTab12962 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.StaticLayout._getLineDirections12963 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.StaticLayout._getTopPadding12964 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getTopPadding", "()I");
			global::android.text.StaticLayout._getBottomPadding12965 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getBottomPadding", "()I");
			global::android.text.StaticLayout._getLineForVertical12966 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineForVertical", "(I)I");
			global::android.text.StaticLayout._getEllipsisStart12967 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.StaticLayout._getEllipsisCount12968 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.StaticLayout._StaticLayout12969 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.StaticLayout._StaticLayout12970 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V");
			global::android.text.StaticLayout._StaticLayout12971 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
		}
	}
}

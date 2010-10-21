namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LabeledIntent : android.content.Intent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LabeledIntent()
		{
			InitJNI();
		}
		protected LabeledIntent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3723;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._writeToParcel3723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._writeToParcel3723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel3724;
		public override void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._readFromParcel3724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._readFromParcel3724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel3725;
		public virtual global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._loadLabel3725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._loadLabel3725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon3726;
		public virtual global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._loadIcon3726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._loadIcon3726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new int IconResource
		{
			get
			{
				return getIconResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIconResource3727;
		public virtual int getIconResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._getIconResource3727);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getIconResource3727);
		}
		public new global::java.lang.String SourcePackage
		{
			get
			{
				return getSourcePackage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSourcePackage3728;
		public virtual global::java.lang.String getSourcePackage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._getSourcePackage3728)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getSourcePackage3728)) as java.lang.String;
		}
		public new int LabelResource
		{
			get
			{
				return getLabelResource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLabelResource3729;
		public virtual int getLabelResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._getLabelResource3729);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getLabelResource3729);
		}
		public new string NonLocalizedLabel
		{
			get
			{
				return getNonLocalizedLabel().toString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNonLocalizedLabel3730;
		public virtual global::java.lang.CharSequence getNonLocalizedLabel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent._getNonLocalizedLabel3730)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._getNonLocalizedLabel3730)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent3731;
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent3731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent3732;
		public LabeledIntent(android.content.Intent arg0, java.lang.String arg1, java.lang.CharSequence arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent3732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent3733;
		public LabeledIntent(java.lang.String arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent3733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LabeledIntent3734;
		public LabeledIntent(java.lang.String arg0, java.lang.CharSequence arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.LabeledIntent.staticClass, global::android.content.pm.LabeledIntent._LabeledIntent3734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3735;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.LabeledIntent.staticClass, _CREATOR3735)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.LabeledIntent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/LabeledIntent"));
			global::android.content.pm.LabeledIntent._writeToParcel3723 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.LabeledIntent._readFromParcel3724 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.content.pm.LabeledIntent._loadLabel3725 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.LabeledIntent._loadIcon3726 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.content.pm.LabeledIntent._getIconResource3727 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getIconResource", "()I");
			global::android.content.pm.LabeledIntent._getSourcePackage3728 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getSourcePackage", "()Ljava/lang/String;");
			global::android.content.pm.LabeledIntent._getLabelResource3729 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getLabelResource", "()I");
			global::android.content.pm.LabeledIntent._getNonLocalizedLabel3730 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "getNonLocalizedLabel", "()Ljava/lang/CharSequence;");
			global::android.content.pm.LabeledIntent._LabeledIntent3731 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;II)V");
			global::android.content.pm.LabeledIntent._LabeledIntent3732 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Landroid/content/Intent;Ljava/lang/String;Ljava/lang/CharSequence;I)V");
			global::android.content.pm.LabeledIntent._LabeledIntent3733 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;II)V");
			global::android.content.pm.LabeledIntent._LabeledIntent3734 = @__env.GetMethodIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/CharSequence;I)V");
			global::android.content.pm.LabeledIntent._CREATOR3735 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.LabeledIntent.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}

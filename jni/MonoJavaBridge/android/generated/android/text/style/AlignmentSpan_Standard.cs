namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlignmentSpan_Standard : java.lang.Object, AlignmentSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlignmentSpan_Standard()
		{
			InitJNI();
		}
		protected AlignmentSpan_Standard(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13373;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_Standard._writeToParcel13373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._writeToParcel13373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13374;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_Standard._describeContents13374);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._describeContents13374);
		}
		public new global::android.text.Layout.Alignment Alignment
		{
			get
			{
				return getAlignment();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlignment13375;
		public virtual global::android.text.Layout.Alignment getAlignment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_Standard._getAlignment13375)) as android.text.Layout.Alignment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._getAlignment13375)) as android.text.Layout.Alignment;
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13376;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_Standard._getSpanTypeId13376);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._getSpanTypeId13376);
		}
		internal static global::MonoJavaBridge.MethodId _AlignmentSpan_Standard13377;
		public AlignmentSpan_Standard(android.text.Layout.Alignment arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard13377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlignmentSpan_Standard13378;
		public AlignmentSpan_Standard(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard13378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.AlignmentSpan_Standard.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/AlignmentSpan_Standard"));
			global::android.text.style.AlignmentSpan_Standard._writeToParcel13373 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.AlignmentSpan_Standard._describeContents13374 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "describeContents", "()I");
			global::android.text.style.AlignmentSpan_Standard._getAlignment13375 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;");
			global::android.text.style.AlignmentSpan_Standard._getSpanTypeId13376 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard13377 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "<init>", "(Landroid/text/Layout$Alignment;)V");
			global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard13378 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}

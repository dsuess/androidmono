namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class URLSpan : android.text.style.ClickableSpan, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static URLSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.URLSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.URLSpan(@__env); 
			} 
		} 
		protected URLSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getURL7082; 
		public virtual java.lang.String getURL() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.URLSpan)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getURL7082)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.URLSpan.staticClass, _getURL7082)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onClick7083; 
		public override void onClick(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.URLSpan)) 
				@__env.CallVoidMethod(this, _onClick7083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.URLSpan.staticClass, _onClick7083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7084; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.URLSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.URLSpan.staticClass, _writeToParcel7084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7085; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.URLSpan)) 
				return @__env.CallIntMethod(this, _describeContents7085); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.URLSpan.staticClass, _describeContents7085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7086; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.URLSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7086); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.URLSpan.staticClass, _getSpanTypeId7086); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URLSpan7087; 
		public URLSpan(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.URLSpan.staticClass, _URLSpan7087, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URLSpan7088; 
		public URLSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.URLSpan.staticClass, _URLSpan7088, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.URLSpan.staticClass = @__class; 
			global::android.text.style.URLSpan._getURL7082 = @__env.GetMethodID(global::android.text.style.URLSpan.staticClass, "getURL", "()Ljava/lang/String;"); 
			global::android.text.style.URLSpan._onClick7083 = @__env.GetMethodID(global::android.text.style.URLSpan.staticClass, "onClick", "(Landroid/view/View;)V"); 
			global::android.text.style.URLSpan._writeToParcel7084 = @__env.GetMethodID(global::android.text.style.URLSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.URLSpan._describeContents7085 = @__env.GetMethodID(global::android.text.style.URLSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.URLSpan._getSpanTypeId7086 = @__env.GetMethodID(global::android.text.style.URLSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.URLSpan._URLSpan7087 = @__env.GetMethodID(global::android.text.style.URLSpan.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.text.style.URLSpan._URLSpan7088 = @__env.GetMethodID(global::android.text.style.URLSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
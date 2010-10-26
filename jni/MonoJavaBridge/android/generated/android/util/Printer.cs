namespace android.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.util.Printer_))]
	public partial interface Printer  : global::MonoJavaBridge.IJavaObject 
	{
		void println(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.util.Printer))]
	internal sealed partial class Printer_ : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Printer_()
		{
			InitJNI();
		}
		internal Printer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println13834;
		 void android.util.Printer.println(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.util.Printer_._println13834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.util.Printer_.staticClass, global::android.util.Printer_._println13834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Printer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Printer"));
			global::android.util.Printer_._println13834 = @__env.GetMethodIDNoThrow(global::android.util.Printer_.staticClass, "println", "(Ljava/lang/String;)V");
		}
	}

	public delegate void PrinterDelegate(java.lang.String arg0);

	internal partial class PrinterDelegateWrapper : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PrinterDelegateWrapper()
		{
			InitJNI();
		}
		protected PrinterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _PrinterDelegateWrapper13835;
		public PrinterDelegateWrapper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.PrinterDelegateWrapper.staticClass, global::android.util.PrinterDelegateWrapper._PrinterDelegateWrapper13835);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.PrinterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/PrinterDelegateWrapper"));
			global::android.util.PrinterDelegateWrapper._PrinterDelegateWrapper13835 = @__env.GetMethodIDNoThrow(global::android.util.PrinterDelegateWrapper.staticClass, "<init>", "()V");
		}
	}
	internal partial class PrinterDelegateWrapper
	{
		private PrinterDelegate myDelegate;
		public void println(java.lang.String arg0)
		{
			myDelegate(arg0);
		}
		public static implicit operator PrinterDelegateWrapper(PrinterDelegate d)
		{
			global::android.util.PrinterDelegateWrapper ret = new global::android.util.PrinterDelegateWrapper();
			ret.myDelegate = d;
			global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
			return ret;
		}
	}
}

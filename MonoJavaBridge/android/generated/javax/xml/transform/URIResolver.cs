namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.transform.URIResolver_))]
	public partial interface URIResolver  : global::MonoJavaBridge.IJavaObject 
	{
		global::javax.xml.transform.Source resolve(java.lang.String arg0, java.lang.String arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.transform.URIResolver))]
	internal sealed partial class URIResolver_ : java.lang.Object, URIResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal URIResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::javax.xml.transform.Source javax.xml.transform.URIResolver.resolve(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.Source>(this, global::javax.xml.transform.URIResolver_.staticClass, "resolve", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/xml/transform/Source;", ref global::javax.xml.transform.URIResolver_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as javax.xml.transform.Source;
		}
		static URIResolver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.URIResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/URIResolver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
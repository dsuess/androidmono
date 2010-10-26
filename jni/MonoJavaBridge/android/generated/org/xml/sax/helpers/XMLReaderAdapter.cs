namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XMLReaderAdapter : java.lang.Object, Parser, ContentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLReaderAdapter()
		{
			InitJNI();
		}
		protected XMLReaderAdapter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse35288;
		public virtual void parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._parse35288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._parse35288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35289;
		public virtual void parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._parse35289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._parse35289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLocale35290;
		public virtual void setLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setLocale35290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setLocale35290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startElement35291;
		public virtual void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._startElement35291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._startElement35291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters35292;
		public virtual void characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._characters35292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._characters35292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement35293;
		public virtual void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._endElement35293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._endElement35293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument35294;
		public virtual void startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._startDocument35294);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._startDocument35294);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument35295;
		public virtual void endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._endDocument35295);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._endDocument35295);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping35296;
		public virtual void startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._startPrefixMapping35296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._startPrefixMapping35296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace35297;
		public virtual void ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._ignorableWhitespace35297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._ignorableWhitespace35297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction35298;
		public virtual void processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._processingInstruction35298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._processingInstruction35298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator35299;
		public virtual void setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentLocator35299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentLocator35299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity35300;
		public virtual void skippedEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._skippedEntity35300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._skippedEntity35300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping35301;
		public virtual void endPrefixMapping(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._endPrefixMapping35301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._endPrefixMapping35301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver35302;
		public virtual void setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setEntityResolver35302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setEntityResolver35302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler35303;
		public virtual void setDTDHandler(org.xml.sax.DTDHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setDTDHandler35303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setDTDHandler35303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler35304;
		public virtual void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setErrorHandler35304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setErrorHandler35304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentHandler35305;
		public virtual void setDocumentHandler(org.xml.sax.DocumentHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentHandler35305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentHandler35305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _XMLReaderAdapter35306;
		public XMLReaderAdapter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._XMLReaderAdapter35306);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _XMLReaderAdapter35307;
		public XMLReaderAdapter(org.xml.sax.XMLReader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.XMLReaderAdapter.staticClass, global::org.xml.sax.helpers.XMLReaderAdapter._XMLReaderAdapter35307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.XMLReaderAdapter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/XMLReaderAdapter"));
			global::org.xml.sax.helpers.XMLReaderAdapter._parse35288 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._parse35289 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setLocale35290 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._startElement35291 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._characters35292 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "characters", "([CII)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._endElement35293 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._startDocument35294 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "startDocument", "()V");
			global::org.xml.sax.helpers.XMLReaderAdapter._endDocument35295 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "endDocument", "()V");
			global::org.xml.sax.helpers.XMLReaderAdapter._startPrefixMapping35296 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._ignorableWhitespace35297 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._processingInstruction35298 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentLocator35299 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._skippedEntity35300 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._endPrefixMapping35301 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setEntityResolver35302 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setDTDHandler35303 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setErrorHandler35304 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._setDocumentHandler35305 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "setDocumentHandler", "(Lorg/xml/sax/DocumentHandler;)V");
			global::org.xml.sax.helpers.XMLReaderAdapter._XMLReaderAdapter35306 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "<init>", "()V");
			global::org.xml.sax.helpers.XMLReaderAdapter._XMLReaderAdapter35307 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.XMLReaderAdapter.staticClass, "<init>", "(Lorg/xml/sax/XMLReader;)V");
		}
	}
}

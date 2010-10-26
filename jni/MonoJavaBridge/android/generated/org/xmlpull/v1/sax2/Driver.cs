namespace org.xmlpull.v1.sax2
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Driver : java.lang.Object, org.xml.sax.Locator, org.xml.sax.XMLReader, org.xml.sax.Attributes
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Driver()
		{
			InitJNI();
		}
		protected Driver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35407;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setProperty35407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setProperty35407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35408;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getProperty35408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getProperty35408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		public new int Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength35409;
		public virtual int getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getLength35409);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getLength35409);
		}
		internal static global::MonoJavaBridge.MethodId _getValue35410;
		public virtual global::java.lang.String getValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getValue35410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getValue35410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue35411;
		public virtual global::java.lang.String getValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getValue35411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getValue35411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue35412;
		public virtual global::java.lang.String getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getValue35412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getValue35412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35413;
		public virtual global::java.lang.String getType(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getType35413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getType35413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35414;
		public virtual global::java.lang.String getType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getType35414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getType35414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35415;
		public virtual global::java.lang.String getType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getType35415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getType35415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber35416;
		public virtual int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getLineNumber35416);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getLineNumber35416);
		}
		internal static global::MonoJavaBridge.MethodId _parse35417;
		public virtual void parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._parse35417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._parse35417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35418;
		public virtual void parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._parse35418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._parse35418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex35419;
		public virtual int getIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getIndex35419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getIndex35419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex35420;
		public virtual int getIndex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getIndex35420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getIndex35420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.xml.sax.ContentHandler ContentHandler
		{
			get
			{
				return getContentHandler();
			}
			set
			{
				setContentHandler(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler35421;
		public virtual global::org.xml.sax.ContentHandler getContentHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getContentHandler35421)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getContentHandler35421)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _startElement35422;
		protected virtual void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._startElement35422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._startElement35422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String PublicId
		{
			get
			{
				return getPublicId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId35423;
		public virtual global::java.lang.String getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getPublicId35423)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getPublicId35423)) as java.lang.String;
		}
		public new global::java.lang.String SystemId
		{
			get
			{
				return getSystemId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId35424;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getSystemId35424)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getSystemId35424)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQName35425;
		public virtual global::java.lang.String getQName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getQName35425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getQName35425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName35426;
		public virtual global::java.lang.String getLocalName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getLocalName35426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getLocalName35426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI35427;
		public virtual global::java.lang.String getURI(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getURI35427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getURI35427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35428;
		public virtual int getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getColumnNumber35428);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getColumnNumber35428);
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35429;
		public virtual void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setFeature35429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setFeature35429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35430;
		public virtual bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getFeature35430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getFeature35430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver35431;
		public virtual void setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setEntityResolver35431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setEntityResolver35431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.EntityResolver EntityResolver
		{
			get
			{
				return getEntityResolver();
			}
			set
			{
				setEntityResolver(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntityResolver35432;
		public virtual global::org.xml.sax.EntityResolver getEntityResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getEntityResolver35432)) as org.xml.sax.EntityResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getEntityResolver35432)) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler35433;
		public virtual void setDTDHandler(org.xml.sax.DTDHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setDTDHandler35433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setDTDHandler35433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.DTDHandler DTDHandler
		{
			get
			{
				return getDTDHandler();
			}
			set
			{
				setDTDHandler(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDTDHandler35434;
		public virtual global::org.xml.sax.DTDHandler getDTDHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getDTDHandler35434)) as org.xml.sax.DTDHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getDTDHandler35434)) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler35435;
		public virtual void setContentHandler(org.xml.sax.ContentHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setContentHandler35435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setContentHandler35435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler35436;
		public virtual void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setErrorHandler35436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setErrorHandler35436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.ErrorHandler ErrorHandler
		{
			get
			{
				return getErrorHandler();
			}
			set
			{
				setErrorHandler(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler35437;
		public virtual global::org.xml.sax.ErrorHandler getErrorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getErrorHandler35437)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getErrorHandler35437)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _parseSubTree35438;
		public virtual void parseSubTree(org.xmlpull.v1.XmlPullParser arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._parseSubTree35438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._parseSubTree35438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Driver35439;
		public Driver(org.xmlpull.v1.XmlPullParser arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._Driver35439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Driver35440;
		public Driver()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._Driver35440);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.sax2.Driver.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/sax2/Driver"));
			global::org.xmlpull.v1.sax2.Driver._setProperty35407 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xmlpull.v1.sax2.Driver._getProperty35408 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xmlpull.v1.sax2.Driver._getLength35409 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getLength", "()I");
			global::org.xmlpull.v1.sax2.Driver._getValue35410 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getValue35411 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getValue35412 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getType35413 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getType35414 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getType35415 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getLineNumber35416 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getLineNumber", "()I");
			global::org.xmlpull.v1.sax2.Driver._parse35417 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xmlpull.v1.sax2.Driver._parse35418 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.sax2.Driver._getIndex35419 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getIndex", "(Ljava/lang/String;)I");
			global::org.xmlpull.v1.sax2.Driver._getIndex35420 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::org.xmlpull.v1.sax2.Driver._getContentHandler35421 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::org.xmlpull.v1.sax2.Driver._startElement35422 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.sax2.Driver._getPublicId35423 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getSystemId35424 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getQName35425 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getQName", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getLocalName35426 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getLocalName", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getURI35427 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getURI", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getColumnNumber35428 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getColumnNumber", "()I");
			global::org.xmlpull.v1.sax2.Driver._setFeature35429 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xmlpull.v1.sax2.Driver._getFeature35430 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xmlpull.v1.sax2.Driver._setEntityResolver35431 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xmlpull.v1.sax2.Driver._getEntityResolver35432 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
			global::org.xmlpull.v1.sax2.Driver._setDTDHandler35433 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xmlpull.v1.sax2.Driver._getDTDHandler35434 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
			global::org.xmlpull.v1.sax2.Driver._setContentHandler35435 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::org.xmlpull.v1.sax2.Driver._setErrorHandler35436 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xmlpull.v1.sax2.Driver._getErrorHandler35437 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::org.xmlpull.v1.sax2.Driver._parseSubTree35438 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "parseSubTree", "(Lorg/xmlpull/v1/XmlPullParser;)V");
			global::org.xmlpull.v1.sax2.Driver._Driver35439 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "<init>", "(Lorg/xmlpull/v1/XmlPullParser;)V");
			global::org.xmlpull.v1.sax2.Driver._Driver35440 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "<init>", "()V");
		}
	}
}

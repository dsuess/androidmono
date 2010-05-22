namespace android.hardware 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SensorEvent : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SensorEvent() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.hardware.SensorEvent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.hardware.SensorEvent(@__env); 
			} 
		} 
		protected SensorEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _values3726; 
		public float[] values
		{ 
			get 
			{ 
				return default(float[]); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sensor3727; 
		public android.hardware.Sensor sensor
		{ 
			get 
			{ 
				return default(android.hardware.Sensor); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _accuracy3728; 
		public int accuracy
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _timestamp3729; 
		public long timestamp
		{ 
			get 
			{ 
				return default(long); 
			} 
			set 
			{ 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.hardware.SensorEvent.staticClass = @__class; 
		} 
	} 
} 
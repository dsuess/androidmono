namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteQueryBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteQueryBuilder()
		{
			InitJNI();
		}
		protected SQLiteQueryBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _query4824;
		public virtual global::android.database.Cursor query(android.database.sqlite.SQLiteDatabase arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._query4824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._query4824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _query4825;
		public virtual global::android.database.Cursor query(android.database.sqlite.SQLiteDatabase arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._query4825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._query4825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _setDistinct4826;
		public virtual void setDistinct(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._setDistinct4826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._setDistinct4826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Tables
		{
			get
			{
				return getTables();
			}
			set
			{
				setTables(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTables4827;
		public virtual global::java.lang.String getTables() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._getTables4827)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._getTables4827)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTables4828;
		public virtual void setTables(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._setTables4828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._setTables4828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _appendWhere4829;
		public virtual void appendWhere(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._appendWhere4829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._appendWhere4829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void appendWhere(string arg0)
		{
			appendWhere((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _appendWhereEscapeString4830;
		public virtual void appendWhereEscapeString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._appendWhereEscapeString4830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._appendWhereEscapeString4830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProjectionMap4831;
		public virtual void setProjectionMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._setProjectionMap4831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._setProjectionMap4831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorFactory4832;
		public virtual void setCursorFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._setCursorFactory4832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._setCursorFactory4832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _buildQueryString4833;
		public static global::java.lang.String buildQueryString(bool arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._buildQueryString4833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _appendColumns4834;
		public static void appendColumns(java.lang.StringBuilder arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._appendColumns4834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _buildQuery4835;
		public virtual global::java.lang.String buildQuery(java.lang.String[] arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._buildQuery4835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._buildQuery4835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _buildUnionSubQuery4836;
		public virtual global::java.lang.String buildUnionSubQuery(java.lang.String arg0, java.lang.String[] arg1, java.util.Set arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String[] arg6, java.lang.String arg7, java.lang.String arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._buildUnionSubQuery4836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._buildUnionSubQuery4836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _buildUnionQuery4837;
		public virtual global::java.lang.String buildUnionQuery(java.lang.String[] arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder._buildUnionQuery4837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._buildUnionQuery4837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteQueryBuilder4838;
		public SQLiteQueryBuilder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteQueryBuilder.staticClass, global::android.database.sqlite.SQLiteQueryBuilder._SQLiteQueryBuilder4838);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteQueryBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteQueryBuilder"));
			global::android.database.sqlite.SQLiteQueryBuilder._query4824 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "query", "(Landroid/database/sqlite/SQLiteDatabase;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteQueryBuilder._query4825 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "query", "(Landroid/database/sqlite/SQLiteDatabase;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteQueryBuilder._setDistinct4826 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setDistinct", "(Z)V");
			global::android.database.sqlite.SQLiteQueryBuilder._getTables4827 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "getTables", "()Ljava/lang/String;");
			global::android.database.sqlite.SQLiteQueryBuilder._setTables4828 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setTables", "(Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteQueryBuilder._appendWhere4829 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "appendWhere", "(Ljava/lang/CharSequence;)V");
			global::android.database.sqlite.SQLiteQueryBuilder._appendWhereEscapeString4830 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "appendWhereEscapeString", "(Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteQueryBuilder._setProjectionMap4831 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setProjectionMap", "(Ljava/util/Map;)V");
			global::android.database.sqlite.SQLiteQueryBuilder._setCursorFactory4832 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "setCursorFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)V");
			global::android.database.sqlite.SQLiteQueryBuilder._buildQueryString4833 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildQueryString", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.sqlite.SQLiteQueryBuilder._appendColumns4834 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "appendColumns", "(Ljava/lang/StringBuilder;[Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteQueryBuilder._buildQuery4835 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildQuery", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.sqlite.SQLiteQueryBuilder._buildUnionSubQuery4836 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildUnionSubQuery", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Set;ILjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.sqlite.SQLiteQueryBuilder._buildUnionQuery4837 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "buildUnionQuery", "([Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.sqlite.SQLiteQueryBuilder._SQLiteQueryBuilder4838 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteQueryBuilder.staticClass, "<init>", "()V");
		}
	}
}

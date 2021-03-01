using System;
using UnityEngine;

namespace HananokiRuntime {
	/// <summary>
	/// stringに付けて使用します
	/// ObjectFieldで登録してGUIDを保持する文字列フィールドになります
	/// </summary>
	public class GUIDStringAttribute : PropertyAttribute {
		public Type m_type;
		public GUIDStringAttribute( Type t ) {
			m_type = t;
		}
	}


	/// <summary>
	/// intに付けて16進数で表示する
	/// 編集できないので注意
	/// </summary>
	public class HexNumberAttribute : PropertyAttribute {
		public HexNumberAttribute() { }
	}


	[AttributeUsage( AttributeTargets.Method, Inherited = true, AllowMultiple = false )]
	public sealed class InspectorGUIAttribute : Attribute {
		public InspectorGUIAttribute() {
		}
	}


	/// <summary>
	/// 型にIDを割りあてる
	/// SerializeReference向けに使うアトリビュート
	/// </summary>
	[AttributeUsage( AttributeTargets.Class )]
	public class TypeIDAttribute : Attribute {
		public int id;
		public TypeIDAttribute( int id ) { this.id = id; }
		public TypeIDAttribute( Type t ) : this( t.FullName ) { }
		public TypeIDAttribute( string s ) {
			int h = id;
			if( h == 0 && s.Length > 0 ) {
				//	char val[] = s.by;
				for( int i = 0; i < s.Length; i++ ) {
					h = 31 * h + s[ i ];
				}
				id = h;
			}
		}
	}


	[AttributeUsage( AttributeTargets.Class )]
	public class UtilityWindowAttribute : PropertyAttribute {
		public UtilityWindowAttribute() {
		}
	}
}
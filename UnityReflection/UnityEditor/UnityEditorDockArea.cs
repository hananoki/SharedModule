/// UnityEditor.DockArea : 2019.4.5f1

using HananokiEditor;
using System;
using System.Reflection;
using System.Collections.Generic;
using UnityEditor;

namespace UnityReflection {
  public sealed partial class UnityEditorDockArea {

		public static class Cache<T> {
			public static T cache;
		}
		public object m_instance;
    
    public UnityEditorDockArea( object instance ){
			m_instance = instance;
    }
    public UnityEditorDockArea() {
			m_instance = Activator.CreateInstance( UnityTypes.UnityEditor_DockArea, new object[] {} );
    }
    

		public List<EditorWindow> m_Panes {
			get {
				if( __m_Panes == null ) {
					__m_Panes = UnityTypes.UnityEditor_DockArea.GetField( "m_Panes", R.InstanceMembers );
				}
				return (List<EditorWindow>) __m_Panes.GetValue( m_instance );
			}
			set {
				if( __m_Panes == null ) {
					__m_Panes = UnityTypes.UnityEditor_DockArea.GetField( "m_Panes", R.InstanceMembers );
				}
				__m_Panes.SetValue( m_instance, value );
			}
		}

		public UnityEngine.Rect position {
			get {
				if( __getter_position == null ) {
					__getter_position = (Func<UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Func<UnityEngine.Rect> ), m_instance, UnityTypes.UnityEditor_DockArea.GetMethod( "get_position", R.InstanceMembers ) );
				}
				return __getter_position();
			}
			set {
				if( __setter_position == null ) {
					__setter_position = (Action<UnityEngine.Rect>) Delegate.CreateDelegate( typeof( Action<UnityEngine.Rect> ), m_instance, UnityTypes.UnityEditor_DockArea.GetMethod( "set_position", R.InstanceMembers ) );
			  }
				__setter_position( value );
			}
		}

		public object window {
			get {
				if( __getter_window == null ) {
					__getter_window = (Func<object>) Delegate.CreateDelegate( typeof( Func<object> ), m_instance, UnityTypes.UnityEditor_DockArea.GetMethod( "get_window", R.InstanceMembers ) );
				}
				return __getter_window();
			}
		}

		public void AddTab( UnityEditor.EditorWindow pane, bool sendPaneEvents = true ) {
			if( __AddTab_0_2 == null ) {
				__AddTab_0_2 = (Action<UnityEditor.EditorWindow,bool>) Delegate.CreateDelegate( typeof( Action<UnityEditor.EditorWindow,bool> ), m_instance, UnityTypes.UnityEditor_DockArea.GetMethod( "AddTab", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.EditorWindow ), typeof( bool ) }, null ) );
			}
			__AddTab_0_2( pane, sendPaneEvents );
		}
		
		public void AddTab( int idx, UnityEditor.EditorWindow pane, bool sendPaneEvents = true ) {
			if( __AddTab_1_3 == null ) {
				__AddTab_1_3 = (Action<int,UnityEditor.EditorWindow,bool>) Delegate.CreateDelegate( typeof( Action<int,UnityEditor.EditorWindow,bool> ), m_instance, UnityTypes.UnityEditor_DockArea.GetMethod( "AddTab", R.InstanceMembers, null, new Type[]{ typeof( int ), typeof( UnityEditor.EditorWindow ), typeof( bool ) }, null ) );
			}
			__AddTab_1_3( idx, pane, sendPaneEvents );
		}
		
		public void RemoveTab( UnityEditor.EditorWindow pane ) {
			if( __RemoveTab_0_1 == null ) {
				__RemoveTab_0_1 = (Action<UnityEditor.EditorWindow>) Delegate.CreateDelegate( typeof( Action<UnityEditor.EditorWindow> ), m_instance, UnityTypes.UnityEditor_DockArea.GetMethod( "RemoveTab", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.EditorWindow ) }, null ) );
			}
			__RemoveTab_0_1( pane );
		}
		
		public void RemoveTab( UnityEditor.EditorWindow pane, bool killIfEmpty, bool sendEvents = true ) {
			if( __RemoveTab_1_3 == null ) {
				__RemoveTab_1_3 = (Action<UnityEditor.EditorWindow,bool,bool>) Delegate.CreateDelegate( typeof( Action<UnityEditor.EditorWindow,bool,bool> ), m_instance, UnityTypes.UnityEditor_DockArea.GetMethod( "RemoveTab", R.InstanceMembers, null, new Type[]{ typeof( UnityEditor.EditorWindow ), typeof( bool ), typeof( bool ) }, null ) );
			}
			__RemoveTab_1_3( pane, killIfEmpty, sendEvents );
		}
		
		public void MakeVistaDWMHappyDance() {
			if( __MakeVistaDWMHappyDance_0_0 == null ) {
				__MakeVistaDWMHappyDance_0_0 = (Action) Delegate.CreateDelegate( typeof( Action ), m_instance, UnityTypes.UnityEditor_DockArea.GetMethod( "MakeVistaDWMHappyDance", R.InstanceMembers, null, new Type[]{  }, null ) );
			}
			__MakeVistaDWMHappyDance_0_0();
		}
		
		
		
		FieldInfo __m_Panes;
		Func<UnityEngine.Rect> __getter_position;
		Action<UnityEngine.Rect> __setter_position;
		Func<object> __getter_window;
		Action<UnityEditor.EditorWindow,bool> __AddTab_0_2;
		Action<int,UnityEditor.EditorWindow,bool> __AddTab_1_3;
		Action<UnityEditor.EditorWindow> __RemoveTab_0_1;
		Action<UnityEditor.EditorWindow,bool,bool> __RemoveTab_1_3;
		Action __MakeVistaDWMHappyDance_0_0;
	}
}


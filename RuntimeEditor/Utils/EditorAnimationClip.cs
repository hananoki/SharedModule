using HananokiEditor.Extensions;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;


namespace HananokiEditor.Animation {
	public class EditorAnimationClip {
		public AnimationClip m_animationClip;
		public List<AnimationEvent> m_currentEvents;

		public AnimationClip animationClip => m_animationClip;

		public int 最大フレーム数 => m_animationClip.GetFrame( m_animationClip.length );
		public float フレームレート => m_animationClip.frameRate;

		public IEnumerable<AnimationEvent> animationEvent => m_currentEvents;

		public Action m_saveAction;

		/////////////////////////////////////////
		public EditorAnimationClip( AnimationClip animationClip, Action saveAction = null ) {
			m_animationClip = animationClip;
			if( IsEmpty() ) return;
			m_currentEvents = m_animationClip.GetEvents();
			m_saveAction = saveAction;
		}


		/////////////////////////////////////////
		public bool IsEmpty() => m_animationClip == null;



		/////////////////////////////////////////
		public void アニメーションイベントを追加( AnimationEvent ev ) {
			if( m_currentEvents == null ) return;
			m_currentEvents.Add( ev );
		}

		/////////////////////////////////////////
		public void アニメーションイベントを削除( int index ) {
			if( m_currentEvents == null ) return;
			m_currentEvents.RemoveAt( index );
		}

		public void アニメーションイベントを削除( List<AnimationEvent> ev ) {
			アニメーションイベントを削除( ev.ToArray() );
		}

		public void アニメーションイベントを削除( params AnimationEvent[] ev ) {
			if( m_currentEvents == null ) return;
			foreach( var p in ev ) {
				m_currentEvents.Remove( p );
			}
		}

		/////////////////////////////////////////
		public int 時間をフレーム値にする( float time ) {
			Assert.IsNotNull( m_animationClip );
			return m_animationClip.GetFrame( time );
		}

		/////////////////////////////////////////
		public float フレーム値を時間する( int frame ) {
			Assert.IsNotNull( m_animationClip );
			return m_animationClip.GetTime( frame );
		}

		/////////////////////////////////////////
		public void LoadEvents() {
			if( IsEmpty() ) return;
			m_currentEvents = m_animationClip.GetEvents();
		}


		/////////////////////////////////////////
		public void SaveEvents() {
			if( IsEmpty() ) return;
			m_animationClip.SetEvents( m_currentEvents );
			m_saveAction?.Invoke();
		}
	}
}

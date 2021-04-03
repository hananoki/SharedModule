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

		public int �ő�t���[���� => m_animationClip.GetFrame( m_animationClip.length );
		public float �t���[�����[�g => m_animationClip.frameRate;

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
		public void �A�j���[�V�����C�x���g��ǉ�( AnimationEvent ev ) {
			if( m_currentEvents == null ) return;
			m_currentEvents.Add( ev );
		}

		/////////////////////////////////////////
		public void �A�j���[�V�����C�x���g���폜( int index ) {
			if( m_currentEvents == null ) return;
			m_currentEvents.RemoveAt( index );
		}

		public void �A�j���[�V�����C�x���g���폜( List<AnimationEvent> ev ) {
			�A�j���[�V�����C�x���g���폜( ev.ToArray() );
		}

		public void �A�j���[�V�����C�x���g���폜( params AnimationEvent[] ev ) {
			if( m_currentEvents == null ) return;
			foreach( var p in ev ) {
				m_currentEvents.Remove( p );
			}
		}

		/////////////////////////////////////////
		public int ���Ԃ��t���[���l�ɂ���( float time ) {
			Assert.IsNotNull( m_animationClip );
			return m_animationClip.GetFrame( time );
		}

		/////////////////////////////////////////
		public float �t���[���l�����Ԃ���( int frame ) {
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

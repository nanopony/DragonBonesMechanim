using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;


public class StateMachineBehaviourWrapper : StateMachineBehaviour {
	public string AnimationName = "walk";
	public bool Active = false;
	public float TransitionDuration = 0.5f;

	private UnityArmatureComponent _armature;

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		
		if (_armature == null) {
			_armature = animator.gameObject.GetComponent<UnityArmatureComponent> ();
		}

		Active = true;


		if (animator.IsInTransition (layerIndex)) {
			_armature.animation.FadeIn (
				AnimationName,
				TransitionDuration,
				-1
			);
			return;
		}

		// no crossfade - play straight away 
		_armature.animation.Play(AnimationName, -1);


	}

	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Active = false;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;

public class KeyboardController : MonoBehaviour {
	private Animator _animator;
	private UnityArmatureComponent _armature;

	private int _walkingParamHash;
	public float Speed = 0.1f;
	private float _lastDx = 0;


	void Start () {
		_animator = GetComponent<Animator>();
		_armature = GetComponent<UnityArmatureComponent> ();
		_walkingParamHash = Animator.StringToHash ("walking");

	}
	

	void Update () {
		var dx = Input.GetAxisRaw ("Horizontal");

		transform.position += new Vector3 (Speed * dx, 0f, 0f);
		if (_lastDx != dx) {
			_animator.SetBool (_walkingParamHash, dx != 0f);
			if (dx!=0) 
				_armature.armature.flipX = dx<0;
			_lastDx = dx;
		}
	}
}

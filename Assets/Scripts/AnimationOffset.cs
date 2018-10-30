using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOffset : MonoBehaviour {

    [Range(0, 1)]
    public float offset;
    public string animationName;
    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        animator.Play(animationName, -1, offset);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class AudienceAnimationRandomizer : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        //XRSettings.eyeTextureResolutionScale = 1.5f;
        InvokeRepeating("SetAnimator", 3f, 5f);
    }

    private void SetAnimator()
    {
        animator.SetFloat("random", Random.value);
    }
}

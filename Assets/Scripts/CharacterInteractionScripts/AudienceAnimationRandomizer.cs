using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class AudienceAnimationRandomizer : MonoBehaviour
{
    private Animator animator;
    [SerializeField] float Frequency = 5f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        InvokeRepeating("SetAnimator", 0, Frequency);
    }

    private void SetAnimator()
    {
        animator.SetInteger("randomValue", Random.Range(0,3));
    }
}

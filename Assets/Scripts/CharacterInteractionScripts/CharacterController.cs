using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;
    [SerializeField] SpeechToText speechToText;

    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        if (audioSource.isPlaying)
        {
            animator.SetBool("isTalking", true);
            animator.SetBool("isListening", false);
        }
        else
        {
            animator.SetBool("isTalking", false);
            animator.SetBool("isListening", speechToText.Active);

        }
    }
}

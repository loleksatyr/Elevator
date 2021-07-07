using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningDoors : MonoBehaviour
{
    [SerializeField] Animator _DoorsAnimator;
    public static bool _isPlayerNear;
    [SerializeField] AudioClip open;
    [SerializeField] AudioClip close;
    private AudioSource audioSource;
    public static bool isplayedonec;
    [SerializeField] AnimationClip closing;
    [SerializeField] AnimationClip opening;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (_isPlayerNear)
        {
            _DoorsAnimator.SetBool("Open", true);
            if (isplayedonec == false) {
                PlayOnce(open);
            }

            if (_DoorsAnimator.GetCurrentAnimatorStateInfo(0).IsName("OpenDoors"))
            {
                isplayedonec = false;
            }
            else
            {
                isplayedonec = true;
            }
        }
        else
        {
            _DoorsAnimator.SetBool("Open", false);
            if (isplayedonec == false)
            {
                PlayOnce(close);
            }
            if (_DoorsAnimator.GetCurrentAnimatorStateInfo(0).IsName("CloseDoors"))
            {
                isplayedonec = false;
            }
            else
            {
                isplayedonec = true;
            }
           
        }
    }
    void PlayOnce(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
        isplayedonec = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingElevator : MonoBehaviour
{
    public GameObject Elevator;
    public GameObject[] floors;
    public static int ElevatorButton;
    public static int currentfloor;
    private bool _iselevatoronMove = false;
    [SerializeField] AudioClip move;
    private AudioSource audioSource;
    [SerializeField] Animator _DoorsAnimator;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ElevatorButton != currentfloor)
        {
            if (ElevatorButton < currentfloor)
            {
                if (Elevator.transform.position.y < floors[ElevatorButton].transform.position.y)
                {
                    Debug.Log("dol");
                    currentfloor = ElevatorButton;
                    _iselevatoronMove = true;
                }
                else
                {
                    _DoorsAnimator.SetBool("Open", false);
                    transform.Translate(-Vector3.up * Time.deltaTime / 2, Space.World);
                    if (audioSource.isPlaying)
                    {

                    }
                    else
                    {
                        audioSource.PlayOneShot(move);
                    }

                }


            }
            else if (ElevatorButton > currentfloor)
            {
                if (Elevator.transform.position.y > floors[ElevatorButton].transform.position.y)
                {
                    Debug.Log("gora");
                    currentfloor = ElevatorButton;
                    _iselevatoronMove = true;
                }
                else
                {
                    _DoorsAnimator.SetBool("Open", false);
                    transform.Translate(Vector3.up * Time.deltaTime / 2, Space.World);
                    if (audioSource.isPlaying)
                    {

                    }
                    else {
                        audioSource.PlayOneShot(move);
                    }
                    
                }
            }

        }
        else
        {
            if (_iselevatoronMove) {
                OpeningDoors._isPlayerNear = true;
                _iselevatoronMove = false;
            }
           
        }
            
        
    
    }
}

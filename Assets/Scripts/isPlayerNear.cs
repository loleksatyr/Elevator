using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isPlayerNear : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OpeningDoors._isPlayerNear = true;           
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("CloseDoors", 5f);             
            }
           
        }
    private void CloseDoors() {
        OpeningDoors._isPlayerNear = false;
    }
    }


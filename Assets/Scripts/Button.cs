using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject idButton;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            MovingElevator.ElevatorButton = idButton.GetComponent<FloorController>().GetFloorid();
        }
    }
}

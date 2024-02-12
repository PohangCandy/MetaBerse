using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")

        {
            DoorMovement door = transform.GetComponentInChildren<DoorMovement>();

            if (door != null)

            {
                door.playerStay = true; 
            }

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")

        {
            DoorMovement door = transform.GetComponentInChildren<DoorMovement>(); 
            if (door != null)

            {
                door.OpenTheDoor(); 
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Off");
        if (other.tag == "Player")
        {
            DoorMovement door = transform.GetComponentInChildren<DoorMovement>(); 

            if (door != null)

            {
                door.playerStay = false;
            }

        }
    }
}

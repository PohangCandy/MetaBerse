using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    private float DoorXPos;
    private Rigidbody doorRigidbody;
    public float movespeed = 1f;
    public bool playerStay = false;
    // Start is called before the first frame update
    void Start()
    {
        this.DoorXPos = GetComponent<Transform>().position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerStay)
        {
            CloseTheDoor();
        }
    }

    public void OpenTheDoor()
    {
        float ChangedPosX = this.transform.position.x;
        int direction = 1;
        float movement = direction * movespeed * Time.deltaTime;
        if (ChangedPosX - DoorXPos <= 10)
        {
            transform.Translate(movement, 0, 0);
        }
        
    }

    public void CloseTheDoor()
    {
        float ChangedPosX = this.transform.position.x;
        int direction = -1;
        float movement = direction * movespeed * Time.deltaTime;
        if (ChangedPosX >= DoorXPos)
        {
            transform.Translate(movement, 0, 0);
        }
    }
}

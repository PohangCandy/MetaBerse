using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPlatform : MonoBehaviour
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
            PlayerController player = other.transform.GetComponentInChildren<PlayerController>();
            if (player != null)
            {
                player.Boost();
                //player.speed = 1000;
            }

        }
    }
}

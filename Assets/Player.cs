using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Player : MonoBehaviour

{

    private Rigidbody playerRigidbody; //Player게임오브젝트의 리지드바디컴포넌트

    public float speed = 8f; //이동속력

    float turnspeed = 2f;
    Vector3 V3;

    // Start is called before the first frame update

    void Start()

    {

        playerRigidbody = GetComponent<Rigidbody>();


    }



    // Update is called once per frame

    void Update()

    {

        //V3 = new Vector3(0, Input.GetAxis("Mouse X"), 0); 
        //transform.Rotate(V3 * turnspeed);

        float xInput = Input.GetAxis("Horizontal"); //수평축에 대응하는 키를 눌렀을때

        float zInput = Input.GetAxis("Vertical"); //수직축에 대응하는 키를 눌렀을때



        float xSpeed = xInput * speed; //x축 방향으로의 속도

        float zSpeed = zInput * speed; //y축 방향으로의 속도



        playerRigidbody.velocity = new Vector3(xSpeed, 0, zSpeed); //현재속도를 변경

    }



    public void Die()
    {

        gameObject.SetActive(false);

    }

}

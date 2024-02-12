using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Player : MonoBehaviour

{

    private Rigidbody playerRigidbody; //Player���ӿ�����Ʈ�� ������ٵ�������Ʈ

    public float speed = 8f; //�̵��ӷ�

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

        float xInput = Input.GetAxis("Horizontal"); //�����࿡ �����ϴ� Ű�� ��������

        float zInput = Input.GetAxis("Vertical"); //�����࿡ �����ϴ� Ű�� ��������



        float xSpeed = xInput * speed; //x�� ���������� �ӵ�

        float zSpeed = zInput * speed; //y�� ���������� �ӵ�



        playerRigidbody.velocity = new Vector3(xSpeed, 0, zSpeed); //����ӵ��� ����

    }



    public void Die()
    {

        gameObject.SetActive(false);

    }

}

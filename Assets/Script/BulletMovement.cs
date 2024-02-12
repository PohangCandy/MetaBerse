using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 8f; //이동속력

    private Rigidbody bulletRigidbody; // Bullet게임오브젝트의 리지드바디컴포넌트를 할당받을 변수

    void Start()

    {

        bulletRigidbody = GetComponent<Rigidbody>();

        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f); //3초후에 지정한 게임오브젝트가 파괴됨.

    }



    private void OnTriggerEnter(Collider other)

    {

        if (other.tag == "Player")

        {

            Player player = other.GetComponent<Player>(); //충돌한 상대방 게임오브젝트로부터 Player컴포넌트 가져오기

            if (player != null)

            {

                player.Die(); //Player의 Die메서드를 실행한다.

            }

        }

    }
}

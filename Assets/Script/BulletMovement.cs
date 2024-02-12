using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 8f; //�̵��ӷ�

    private Rigidbody bulletRigidbody; // Bullet���ӿ�����Ʈ�� ������ٵ�������Ʈ�� �Ҵ���� ����

    void Start()

    {

        bulletRigidbody = GetComponent<Rigidbody>();

        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f); //3���Ŀ� ������ ���ӿ�����Ʈ�� �ı���.

    }



    private void OnTriggerEnter(Collider other)

    {

        if (other.tag == "Player")

        {

            Player player = other.GetComponent<Player>(); //�浹�� ���� ���ӿ�����Ʈ�κ��� Player������Ʈ ��������

            if (player != null)

            {

                player.Die(); //Player�� Die�޼��带 �����Ѵ�.

            }

        }

    }
}

using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class BulletSpawner : MonoBehaviour

{

    public GameObject bulletPrefab; //ź���� ���� ������

    public float maxRate = 3f; //ź�� ���� �ִ��ֱ�

    public float minRate = 0.5f; //ź�� ���� �ּ��ֱ�



    private float rate; //ź�� ���� �ֱ�

    private Transform target; //�÷��̾��� ��ġ

    private float timeAfterSpawn; //ź�� ���� �� ���� �ð�

    // Start is called before the first frame update

    void Start()

    {

        rate = Random.Range(minRate, maxRate);

        target = FindObjectOfType<PlayerController>().transform;

        timeAfterSpawn = 0f;

    }



    // Update is called once per frame

    void Update()

    {

        //Time.deltaTime�� ������ update()�� ����ǰ� ���� update()�� ����Ǳ������ �ð�����

        //�ð������� ������Ű�� ������� Ư�� �������� �ð��� ��ŭ �귶���� ǥ�� �� �� ����

        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn > rate)

        {

            timeAfterSpawn = 0f;

            rate = Random.Range(minRate, maxRate);



            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            bullet.transform.LookAt(target); // bullet�� ���ʹ���(z�����)�� target�� �ٶ󺸰���

        }

    }

}

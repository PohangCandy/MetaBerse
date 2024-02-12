using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class BulletSpawner : MonoBehaviour

{

    public GameObject bulletPrefab; //탄알의 원본 프리팹

    public float maxRate = 3f; //탄알 생성 최대주기

    public float minRate = 0.5f; //탄알 생성 최소주기



    private float rate; //탄알 생성 주기

    private Transform target; //플레이어의 위치

    private float timeAfterSpawn; //탄알 생성 후 지난 시간

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

        //Time.deltaTime은 직전의 update()가 실행되고 현재 update()가 실행되기까지의 시간간격

        //시간간격을 누적시키는 방법으로 특정 시점에서 시간이 얼만큼 흘렀는지 표현 할 수 있음

        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn > rate)

        {

            timeAfterSpawn = 0f;

            rate = Random.Range(minRate, maxRate);



            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            bullet.transform.LookAt(target); // bullet의 앞쪽방향(z축방향)이 target을 바라보게함

        }

    }

}

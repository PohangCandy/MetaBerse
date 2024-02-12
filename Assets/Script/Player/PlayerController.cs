using System.Collections;

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour

{

    Camera _camera;
    public CharacterController _controller;

    public float speed = 5f; //이동속력
    public float runSpeed = 8f;
    public float BoostSpeed = 1000f;
    public float finalSpeed;
    public bool toggleCameraRotation;
    public bool run;
    public Rigidbody rigid;

    public float smoothness = 10f;

    // Start is called before the first frame update

    void Start()

    {

        _camera = Camera.main;
        _controller = GetComponent<CharacterController>();
        rigid = GetComponent<Rigidbody>();
    }



    // Update is called once per frame

    void Update()

    {
        if(Input.GetKey(KeyCode.LeftAlt))
        {
            toggleCameraRotation = true;
        }
        else
        {
            toggleCameraRotation = false;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }
        else
        {
            run = false;
        }

        InputMovement();
}
    private void LateUpdate()
    {
        if(toggleCameraRotation != true)
        {
            Vector3 playerRotate = Vector3.Scale(_camera.transform.forward, new Vector3(1, 0, 1));
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerRotate), Time.deltaTime * smoothness);
        }
    }



    public void Die()

    {

        gameObject.SetActive(false);

    }

    public void InputMovement() 
    {
        finalSpeed = run  ? runSpeed: speed;

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        Vector3 moveDirection = forward * Input.GetAxisRaw("Vertical") + right * Input.GetAxis("Horizontal");

        _controller.Move(moveDirection.normalized * finalSpeed * Time.deltaTime);
    }

    public void Boost()
    {
        Debug.Log("on!");
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        Vector3 moveDirection = forward * Input.GetAxisRaw("Vertical") + right * Input.GetAxis("Horizontal");

        _controller.Move(moveDirection.normalized * BoostSpeed * Time.deltaTime);
        StartCoroutine(SpeedUp());
        StartCoroutine(SpeedDown());
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(0.2f);

        speed += 10;
    }
    IEnumerator SpeedDown()
    {
        yield return new WaitForSeconds(10.0f);

        speed -= 10;
    }

}

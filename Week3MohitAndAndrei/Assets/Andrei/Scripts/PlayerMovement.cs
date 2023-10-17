using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    Camera mainCam;

    [SerializeField] float movementSpeed;
    Vector3 cameraOffset;

    [SerializeField] GameObject mainModel;
    Animator mainAnim;
    //[SerializeField] float rotationSpeed;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCam = Camera.main;
        cameraOffset= mainCam.transform.position - transform.position;

        mainAnim = mainModel.GetComponent<Animator>();
    }

    private void Update()
    {
        mainAnim.SetFloat("Speed", Mathf.Abs(rb.velocity.magnitude));
    }

    public void StopMoving()
    {
        rb.velocity = Vector3.zero;
        print("stop moving");
    }

    public void SwitchDirection()
    {
        rb.velocity = Vector3.zero;
        Quaternion target = Quaternion.Euler(0, 180f, 0);
        rb.rotation *= target;
    }

    public void MoveForward()
    {
        rb.velocity = transform.forward * movementSpeed;
        print("move");
        
    }
    public void MoveCamera()
    {
        if(transform.position.x > -30f)
        {
            mainCam.transform.position = transform.position + cameraOffset;
        }  
    }

}

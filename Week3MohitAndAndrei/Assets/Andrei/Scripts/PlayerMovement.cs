using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float movementSpeed;
    //[SerializeField] float rotationSpeed;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void StopMoving()
    {
        rb.velocity = Vector3.zero;
        print("stop moving");
    }

    public void SwitchDirection()
    {
        rb.velocity = Vector3.zero;
        //StartCoroutine(TurnOpposite());
        Quaternion target = Quaternion.Euler(0, 180f, 0);
        rb.rotation *= target;
    }

    public void MoveForward()
    {
        rb.velocity = transform.forward * movementSpeed;
        print("move");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float movementSpeed;
    [SerializeField] float rotationSpeed;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void MovementAction(TypeOfInput typeOfInput)
    {
        switch (typeOfInput)
        {
            case TypeOfInput.Release:
                StopMoving();
                    break;
            case TypeOfInput.Press:
                SwitchDirection();
                break;
            case TypeOfInput.Hold:
                MoveForward();
                break;

        }
        print(typeOfInput);
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

    IEnumerator TurnOpposite()
    {
        float startingAngle = transform.rotation.eulerAngles.y;

        while(Mathf.Abs(startingAngle - transform.rotation.eulerAngles.y) < 180f)
        {
            Vector3 angleVelocity = new Vector3(0, rotationSpeed, 0);
            Quaternion deltaRotation = Quaternion.Euler(angleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
            yield return null;
        }
    }
}

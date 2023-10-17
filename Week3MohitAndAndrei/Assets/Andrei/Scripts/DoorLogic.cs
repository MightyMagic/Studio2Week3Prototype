using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DoorLogic : MonoBehaviour
{
    [SerializeField] private DoorPosition currentDoorPosition;
    private GameObject doorUp;
    private GameObject doorDown;

    Vector3 upPosition;
    Vector3 downPosition;

    void Start()
    {
        doorUp = transform.Find("DoorUpPosition").gameObject;
        doorDown = transform.Find("DoorUpPosition").gameObject;

        doorUp = transform.GetChild(0).gameObject;
        doorDown= transform.GetChild(1).gameObject;

        upPosition = doorUp.transform.position;
        downPosition= doorDown.transform.position;

    }

    public void SwitchPosition()
    {
        switch(currentDoorPosition)
        {
            case DoorPosition.up:
                currentDoorPosition = DoorPosition.down;
                transform.position = downPosition;
                break;
            case DoorPosition.down:
                currentDoorPosition = DoorPosition.up;
                transform.position = upPosition;
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("Game is over");
           // Destroy(collision.gameObject);
        }
    }
}

public enum DoorPosition
{
    down,
    up
}

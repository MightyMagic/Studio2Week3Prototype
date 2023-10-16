using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision collision)
    {
        SwitchDoorPositions();
    }

    void SwitchDoorPositions() 
    {
        GameObject[] correspondingDoors = GameObject.FindGameObjectsWithTag(this.gameObject.tag);
        print("Corresponding doors are " + correspondingDoors.Length);

        foreach(GameObject door in correspondingDoors)
        {
            DoorLogic doorLogic = door.GetComponent<DoorLogic>();
            if(doorLogic != null)
                doorLogic.SwitchPosition();
        }

    } 
}

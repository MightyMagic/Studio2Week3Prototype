using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    private bool isPressed = false;

  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            StartCoroutine(SwitchDoorPositions());
    }
    
    private IEnumerator SwitchDoorPositions() 
    {
        GameObject[] correspondingDoors = GameObject.FindGameObjectsWithTag(this.gameObject.tag);
        print("Corresponding doors are " + correspondingDoors.Length);

        print("About to switch doors!!!");

        yield return new WaitForSeconds(2f);

        foreach(GameObject door in correspondingDoors)
        {
            DoorLogic doorLogic = door.GetComponent<DoorLogic>();
            if(doorLogic != null)
                doorLogic.SwitchPosition();
        }
        
        
    } 

   
}

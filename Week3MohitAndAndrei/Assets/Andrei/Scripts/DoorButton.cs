using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    private bool isPressed = false;
    float volumeIncrease;
    Vector3 initialSize;

    private void Start()
    {
        initialSize= transform.localScale;
        volumeIncrease = transform.localScale.x * 0.3f;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(blinkingButton());
            StartCoroutine(SwitchDoorPositions());
        }         
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

        transform.localScale *= 0.67f;
    } 

    private IEnumerator blinkingButton()
    {
        yield return new WaitForSeconds(0.5f);
        transform.localScale += new Vector3(volumeIncrease, volumeIncrease, volumeIncrease);
        yield return new WaitForSeconds(0.5f);
        transform.localScale -= new Vector3(volumeIncrease, volumeIncrease, volumeIncrease);
        yield return new WaitForSeconds(0.5f);
        transform.localScale += new Vector3(volumeIncrease, volumeIncrease, volumeIncrease);
        yield return new WaitForSeconds(0.5f);
        transform.localScale -= new Vector3(volumeIncrease, volumeIncrease, volumeIncrease);
        transform.localScale = initialSize;
    }

   
}

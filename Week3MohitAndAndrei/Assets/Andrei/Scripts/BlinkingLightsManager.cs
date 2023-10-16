using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BlinkingLightsManager : MonoBehaviour
{

    [SerializeField] List<Studio2Week3AndreiMohit.Projector> projectors = new List<Studio2Week3AndreiMohit.Projector>();
    [SerializeField] List<DoorSystem> doorSystems= new List<DoorSystem>();
    

    void Update()
    {
        foreach(Studio2Week3AndreiMohit.Projector projector in projectors)
        {
            projector.Blink();
        }

        for(int k = 0; k < doorSystems.Count; k++)
        {
            AssignTagsToDoorSystems(doorSystems[k], k);
        }
    }

    void AssignTagsToDoorSystems(DoorSystem doorSystem, int i)
    {
        doorSystem.buttonObject.tag = "DoorSystem" + i.ToString();
        foreach(DoorLogic doorLogic in doorSystem.doors)
        {
            doorLogic.gameObject.tag = "DoorSystem" + i.ToString();
        }
    }


}

[System.Serializable]
public class DoorSystem
{
    public List<DoorLogic> doors = new List<DoorLogic>();
    public GameObject buttonObject;
}


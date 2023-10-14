using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BlinkingLightsManager : MonoBehaviour
{

    [SerializeField] List<Studio2Week3AndreiMohit.Projector> projectors = new List<Studio2Week3AndreiMohit.Projector>();


    void Update()
    {
        foreach(Studio2Week3AndreiMohit.Projector projector in projectors)
        {
            projector.Blink();
        }
    }
}


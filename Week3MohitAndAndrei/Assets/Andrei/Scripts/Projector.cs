using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Studio2Week3AndreiMohit
{
    [System.Serializable]
    public class Projector : MonoBehaviour
    {
       [SerializeField] private float blinkingPeriod;
       [SerializeField] private GameObject projectorObject;
       [SerializeField] private GameObject colliderObject;
       private float localTimer = 0f;
    
        public void Blink()
        {
            if (localTimer > blinkingPeriod)
            {
                if(colliderObject != null)
                {
                    if(colliderObject.activeSelf)
                    {
                        colliderObject.SetActive(false);
                    }
                    else
                        colliderObject.SetActive(true);
                }

                print("blink");
                localTimer = 0f;
            }
            else 
            {
                localTimer += Time.deltaTime;
            }

        }
    }
}

 
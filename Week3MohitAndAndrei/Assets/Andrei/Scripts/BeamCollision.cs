using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamCollision : MonoBehaviour
{
    GameObject respawnSystem;
    RespawnSystem _respawnSystem;

    private void Start()
    {
        respawnSystem = GameObject.Find("RespawnSystem");
        _respawnSystem= respawnSystem.GetComponent<RespawnSystem>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(_respawnSystem.RegularGameOver());
            //Destroy(other.gameObject);
            print("Game is over");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalButton : MonoBehaviour
{
    [SerializeField] GameObject monster;
    [SerializeField] GameObject finalTrigger;
    EnemyBehaviour enemyBehaviour;
    // Start is called before the first frame update
    void Start()
    {
        finalTrigger.SetActive(false);
        enemyBehaviour = monster.GetComponent<EnemyBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(enemyBehaviour.WakeUp());
        }

        finalTrigger.SetActive(true);
    }
}

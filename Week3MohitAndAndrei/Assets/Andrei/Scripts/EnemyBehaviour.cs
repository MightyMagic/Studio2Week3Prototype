using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Animator anim;
    bool wakeUp = false;
    [SerializeField] GameObject player;

    GameObject respawnSystem;
    RespawnSystem _respawnSystem;

    void Start()
    {
        anim= GetComponent<Animator>();

        respawnSystem = GameObject.Find("RespawnSystem");
        _respawnSystem = respawnSystem.GetComponent<RespawnSystem>();
    }

    void Update()
    {
        if(wakeUp)
        {
            transform.LookAt(player.transform.position);
        }
        
    }

    public IEnumerator WakeUp()
    {       
        yield return new WaitForSeconds(3f);
        anim.SetBool("startCrawling", true);
        yield return new WaitForSeconds(1.5f);
        wakeUp= true;


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(_respawnSystem.BrutalGameOver());
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTrigger : MonoBehaviour
{
    [SerializeField] Canvas victoryCanvas;
    // Start is called before the first frame update
    void Start()
    {
        victoryCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            victoryCanvas.gameObject.SetActive(true);
            //Proceed to next scene
        }
    }
}

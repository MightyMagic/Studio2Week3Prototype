using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnSystem : MonoBehaviour
{
    [SerializeField] private List<GameObject> checkPoints = new List<GameObject>();
    [SerializeField] GameObject player;
    [SerializeField] Canvas brutalCanvas;
    Camera mainCam;


    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Checkpoint"))
            PlayerPrefs.SetInt("Checkpoint", 0);
    }

    void Start()
    {
        mainCam = Camera.main;
        brutalCanvas.gameObject.SetActive(false);
        mainCam.enabled = false;
        player.transform.position = checkPoints[PlayerPrefs.GetInt("Checkpoint")].transform.position;
        mainCam.enabled = true;
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) { Reset();  }
    }

    public IEnumerator BrutalGameOver()
    {
        if(brutalCanvas.gameObject !=null)
            brutalCanvas.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("Mohit");
    }

    public IEnumerator RegularGameOver()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Mohit");
    }

    public void Reset()
    {
        if (PlayerPrefs.HasKey("Checkpoint"))
            PlayerPrefs.SetInt("Checkpoint", 0);
        SceneManager.LoadScene("Mohit");
    }
}

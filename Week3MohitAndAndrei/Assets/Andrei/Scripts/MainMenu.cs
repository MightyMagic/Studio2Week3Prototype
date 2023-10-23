using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public IEnumerator RegularGameOver()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Mohit");
    }

    public void StartFromCheckpoint()
    {
        StartCoroutine(RegularGameOver());
    }

    public void Reset()
    {
        if (PlayerPrefs.HasKey("Checkpoint"))
            PlayerPrefs.SetInt("Checkpoint", 0);
        SceneManager.LoadScene("Mohit");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

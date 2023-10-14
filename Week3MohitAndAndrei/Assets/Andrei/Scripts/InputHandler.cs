using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] KeyCode gameButton;
    Time timeOnPress;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(gameButton))
        {

        }
    }

    private bool IsDoubleClick()
    {
        return false;
    }
}

public enum TypeOfPress
{
    Press,
    Hold
}

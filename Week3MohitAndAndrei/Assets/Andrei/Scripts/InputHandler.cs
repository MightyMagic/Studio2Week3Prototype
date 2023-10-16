using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] KeyCode gameButton;
    [SerializeField] GameObject player;

    [SerializeField] float buttonHoldTime;

    PlayerMovement playerMovement;

    float timeOnPress;
    private bool startedInput = false;
    private bool startedWalking = false;

    void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    void Update()
    {
       CheckForMovementInput();
    }

    private void CheckForMovementInput()
    {
        if(Input.GetKeyDown(gameButton))
        {
            if (!startedInput)
            {
                timeOnPress = Time.time;
                startedInput = true;
            }
        }

        else if (Input.GetKey(gameButton))
        {
            if (Time.time - timeOnPress > buttonHoldTime && !startedWalking)
            {
                startedWalking= true;
                playerMovement.MoveForward();
            }
        }

        else if(Input.GetKeyUp(gameButton))
        {
            if (Time.time - timeOnPress < buttonHoldTime)
            {
                playerMovement.SwitchDirection();
            }

            startedInput= false;
            startedWalking= false;
            playerMovement.StopMoving();
        }
    }

}

public enum TypeOfInput
{
    Release,
    Press,
    Hold
}

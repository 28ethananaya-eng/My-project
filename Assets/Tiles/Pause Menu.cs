using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        GetComponent<Canvas>().enabled = true;
    }
    //RESUME unfreeze the game, makes the pause menue invisible
    public void Resume ()
    {
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       //if we press the escape key, run the pause function
       if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            PauseGame();
        }
    }
}

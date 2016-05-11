using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseMenuScript : MonoBehaviour
{

    public GameObject pausePanel;
    public bool isPaused;

    // Use this for initialization
    void Start()
    {
        isPaused = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            PauseGame(true);
        }
        else
        {
            PauseGame(false);
        }
        if (Input.GetButtonDown("Cancel"))
        {
            SwitchPause();
        }

    }
    void PauseGame(bool state)
    {
        if (state)
        {
            Time.timeScale = 0.0f; //Paused
        }
        else
        {
            Time.timeScale = 1.0f; //Unpaused
        }
        pausePanel.SetActive(state);
    }
    public void SwitchPause()
    {
        if (isPaused)
        {
            isPaused = false; //Change the value
        }
        else
        {
            isPaused = true;
        }
    }
}


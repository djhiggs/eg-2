using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuscript : MonoBehaviour {


    public Canvas optionMenu;
    public Button optionButton;
    public Button optionBackground;
    public Button startButton;
    public Button startBackground;
    public Button exitButton;
    public Button exitBackground;
    public Button loadButton;
    public Button loadBackground;
    public Canvas loadMenu;
    
    

	// Use this for initialization
	void Start ()
    {

        optionMenu = optionMenu.GetComponent<Canvas>();
        optionButton = optionButton.GetComponent<Button>();
        optionBackground = optionBackground.GetComponent<Button>();
        startButton = startButton.GetComponent<Button>();
        startBackground = startBackground.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
        exitBackground = exitBackground.GetComponent<Button>();
        loadButton = loadButton.GetComponent<Button>();
        loadBackground = loadBackground.GetComponent<Button>();
        loadMenu = loadMenu.GetComponent<Canvas>();
       
        optionMenu.enabled = false;
        loadMenu.enabled = false;

	}

    public void OptionPress()
    {
        optionMenu.enabled = true;
        startButton.enabled = false;
        startBackground.enabled = false;
        exitButton.enabled = false;
        exitBackground.enabled = false;
        loadButton.enabled = false;
        loadBackground.enabled = false;
        loadMenu.enabled = false;
        optionButton.enabled = false;
        optionBackground.enabled = false;


        
    }
    public void LoadPress()
    {
        optionMenu.enabled = false;
        startButton.enabled = false;
        startBackground.enabled = false; 
        exitButton.enabled = false;
        exitBackground.enabled = false;
        loadButton.enabled = false;
        loadBackground.enabled = false;
        loadMenu.enabled = true;
        optionButton.enabled = false;
        optionBackground.enabled = false;

    }

    public void NoPress()
    {
        optionMenu.enabled = false;
        startButton.enabled = true;
        startBackground.enabled = true;
        exitButton.enabled = true;
        exitBackground.enabled = true;
        loadButton.enabled = true;
        loadBackground.enabled = true;
        loadMenu.enabled = false;
        optionButton.enabled = true;
        optionBackground.enabled = true;

    }

    //public void StartLevel()
    //{
    //    Application.LoadLevel(1);
    //}
    public void ExitGame()
    {
        Application.Quit();
    }
	
	
}

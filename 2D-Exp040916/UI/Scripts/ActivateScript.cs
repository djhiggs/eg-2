using UnityEngine;
using System.Collections;

public class ActivateScript : MonoBehaviour { // THIS IS FOR BUTTONS!!!
    public GameObject targetObject;
    private bool flyoutOn = false;   //  start w/ all targets deactivated

	
	void Start () {
	
	}
	
	
	void Update () {
      
    }


    public void onClick()
    {
        if (flyoutOn)
        {
            flyoutOn = false;
            targetObject.SetActive(false);
        }
        else
        {
            flyoutOn = true;
            targetObject.SetActive(true);
        }
    }
}

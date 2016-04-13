using UnityEngine;
using System.Collections;

public class FlyoutControl : MonoBehaviour {

    public GameObject targetObject;
    private bool flyoutOn = false;   //  start w/ all targets deactivated

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnMouseDown()
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

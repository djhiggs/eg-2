using UnityEngine;
using System.Collections;

public class ChangeSceen : MonoBehaviour {

	public void ChangeToSceen (string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
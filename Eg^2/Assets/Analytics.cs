using UnityEngine;
using System.Collections;

// Adding System reference for Serializable
using System;

[Serializable]
public class Analytics : MonoBehaviour {

    public int NumberOfBoltsCollected { get; set; }
    public int NumberOfNutsCollected { get; set; }
    public bool FoundJetPack { get; set; }

    public float TimeLevelStarted { get; set; }
    public float TimeElapsed { get; set; }
    public string NameOfCurrentLevel { get; set; }
    public Transform PlayerCurrentPosition { get; set; }

    void Awake()
    {
        DontDestroyOnLoad(this);
        TimeLevelStarted = Time.realtimeSinceStartup;
        TimeElapsed = 0f;
        NameOfCurrentLevel = "This should be changed by the level (scene) loaded.";
        PlayerCurrentPosition = this.transform;     // This should be a reference to the player transform and kept 
                                                    // up-to-date by the player GameObject.
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        TimeElapsed += Time.deltaTime;
	}
}

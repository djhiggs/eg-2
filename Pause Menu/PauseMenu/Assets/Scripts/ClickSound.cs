using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]//can only be put on buttons

public class ClickSound : MonoBehaviour {


    public AudioClip sound;//object called "sound".

    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }//grabs the audio source from Unity.

	// Use this for initialization.
	void Start () {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;//sound object is equal to audio clip
        source.playOnAwake = false;//doesnt play the audio on awake 
        button.onClick.AddListener(() => PlaySound());
	
	}
	
	void PlaySound()
    {
        source.PlayOneShot(sound);//plays audio thats being passed thru
    }
}

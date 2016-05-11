using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectBolt : MonoBehaviour {
    public int boltValue;
    public int nutValue;
    public Text boltScoreText;//Text that will show the count of the bolts on screen
    public Text nutScoreText;//Text that will show the count of the bolts on screen

	// Use this for initialization
	void Start () {
        boltValue = 0;//sets a value for the object.
        nutValue = 0;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        boltScoreText.text = boltValue.ToString(); //converts number value to a string
        nutScoreText.text = nutValue.ToString();

	
	}
    void OnTriggerEnter(Collider other)//player will cause a trigger event
    {
        if (other.gameObject.tag == "Bolt")
        {
            boltValue = boltValue + 1;//adds a value of 1 to itself
           // Destroy(other.gameObject); //This Will get rid of the Bolt item that was just picked up 
        }
        if (other.gameObject.tag=="Nut")
        {
            nutValue = nutValue + 1;
            // Destroy(other.gameObject); //This Will get rid of the NUT item that was just picked up 
        }
    }
}

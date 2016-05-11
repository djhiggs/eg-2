using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
        moveObject();
	
	}
    void moveObject()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}

using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
    // Just a comment.
	GameObject mainCam;
	private float zval;
	private float xval;
	private float jval;
	public float camDistance;
 	Vector3 home;
	public float camHeight;
	Vector3 mainCamMove;
	public float speed;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		mainCam = GameObject.Find ("mainCamera");
		home = new Vector3 (camDistance, camHeight, 0);
		mainCamMove = new Vector3 ();
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		zval = Input.GetAxis ("zHorizontal");
		xval = Input.GetAxis ("xHorizontal");
		mainCamMove.Set (camDistance, camHeight, -20 * zval); 

		if (zval > 0) {
			transform.Translate (0, 0, speed*zval);
			mainCam.transform.localPosition = mainCamMove;

			//rb.velocity = new Vector3(7, 1, 0);
		}

		if (zval < 0) {
			transform.Translate (0, 0, speed*zval);
			mainCam.transform.localPosition = mainCamMove;

			//rb.velocity = new Vector3(-7, 1, 0);
		}

		if (zval == 0 && mainCam.transform.localPosition.z != 0) {
			mainCam.transform.localPosition = home;
		}

		if (xval > 0) {
			transform.Translate (speed*xval, 0, 0);
			//rb.velocity = new Vector3(0, 1, 7);
		}

		if (xval < 0) {
			transform.Translate (speed*xval, 0, 0);
			//rb.velocity = new Vector3(0, 1, -7);
		}
			
			
		if (Input.GetButtonDown("Jump")) {
			
			rb.velocity = new Vector3(0, 5, 0);
		}

		if (Input.GetButtonDown("Fire1")) {

			transform.rotation = Quaternion.Euler(0 , -90 , 0);
		}
	}
}

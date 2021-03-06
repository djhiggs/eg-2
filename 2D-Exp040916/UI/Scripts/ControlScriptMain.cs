using UnityEngine;
using System.Collections;

public class ControlScriptMain : MonoBehaviour {
// VAR
	public float moveSpeed = 5f;
	public float xRotateSpeed = 4f;
	public float yRotateSpeed = 4f;
	public float keyRotateSpeed = 1f;

	// float cubeSize = 1f;
	// float scaleSpeed = 1f;
	float temp = 0f;

	// The following Vector3 objects will store the calculated rotation and translation
	Vector3 storedRotation;
	Vector3 storedTranslation;

	// The translaion increment amount
	// float translationIncrement = .1f;

	// The rotation increments
	float rotationYIncrement = 0f;
	float rotationXIncrement = 0f;

	// Rotation to multiply by
	float rotationFactor = 4f;

	void Start () {
		storedRotation = new Vector3 ();
		storedTranslation = new Vector3 ();
		}

	void Update () {
		
		// Set the stored rotation and translation objects to 0,0,0
		storedRotation.Set (0f, 0f, 0f);
		storedTranslation.Set (0f, 0f, 0f);

		///// MOVEMENT /////
		if (Input.GetMouseButton (2)) { // move up on middle mouse
			this.transform.Translate (new Vector3 (0f, moveSpeed * Time.deltaTime, 0f));
		}

		if (Input.GetMouseButton (1)) {  // pan view if right mouse
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {  // check for arrow or asdw
				if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) { // if both opposing buttons - do nothing
				} else {
					this.transform.Translate (new Vector3 (-moveSpeed * Time.deltaTime, 0f, 0f));  // move
				}
			}
			if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {  // check for arrow or asdw
				if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) { // if both opposing buttons - do nothing
				} else {				
					this.transform.Translate (new Vector3 (moveSpeed * Time.deltaTime, 0f, 0f));  // move
				}
			}
		}
		if (Input.GetMouseButton (1)) {  // pan view with button if no mouse
		} else {
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {  // check for arrow or asdw
				if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) { // if both opposing buttons - do nothing
				} else {
					this.transform.Translate (new Vector3 (-moveSpeed * Time.deltaTime, 0f, 0f));  // move
				}
			}
			if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {  // check for arrow or asdw
				if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) { // if both opposing buttons - do nothing
				} else {				
					this.transform.Translate (new Vector3 (moveSpeed * Time.deltaTime, 0f, 0f));  // move
				}
			}
		}

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {  // check for arrow or asdw
			if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) { // if both opposing buttons - do nothing
			} else {				
				this.transform.Translate (new Vector3 (0f, 0f, moveSpeed * Time.deltaTime));  // move
			}
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {  // check for arrow or asdw
			if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) { // if both opposing buttons - do nothing
			} else {				
				this.transform.Translate (new Vector3 (0f, 0f, -moveSpeed * Time.deltaTime));  // move
			}
		}

		///// ROTATION /////
		if (Input.GetMouseButton (1)) { 
			if (Input.GetAxis ("Mouse X") != 0 || Input.GetAxis ("Mouse Y") != 0) {
				rotationXIncrement += Input.GetAxis ("Mouse X") * rotationFactor;
				rotationYIncrement -= Input.GetAxis ("Mouse Y") * rotationFactor;
			}

			// Apply the rotation calculations to the storedRotation Vector3 object
			storedRotation.Set (rotationYIncrement, rotationXIncrement, 0);
			// Apply a constrained z-axis rotation to the actual GameObject
			this.transform.rotation = Quaternion.Euler (storedRotation);
			// Apply  storedTranslation Vector3 object to the actual GameObject
			this.transform.Translate (storedTranslation);
		}

		if (Input.GetAxis ("Mouse ScrollWheel") != 0f) { // check for scale on mousewheel
			temp = Input.GetAxis ("Mouse ScrollWheel")*30; // adjust size

			this.transform.Translate (new Vector3 (0f, 0f, temp));
		}
	}
}
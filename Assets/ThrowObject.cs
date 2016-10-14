using UnityEngine;
using System.Collections;

public class ThrowObject :MonoBehaviour {
	public Transform Ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Debug.Log ("click");
			Transform newObject = (Transform) Instantiate (Ball, transform.position, Quaternion.identity);
			newObject.GetComponent<Rigidbody>().AddForce (transform.forward * 2000);
		}
	}
}
using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {
	public Transform Ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0)) {
			GameObject newObject = (GameObject) Instantiate (Ball, transform.position, Quaternion.identity);
			newObject.GetComponent<Rigidbody>().AddForce (transform.forward * 2000);
		}
	}
}

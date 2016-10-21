using UnityEngine;
using System.Collections;

public class LookFloor : MonoBehaviour, IGvrGazeResponder {
	public GameObject mainCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region IGvrGazeResponder implementation

	/// Called when the user is looking on a GameObject with this script,
	/// as long as it is set to an appropriate layer (see GvrGaze).
	public void OnGazeEnter() {
		//Debug.Log ("OnGazeEnter of LookFloor");
		//mainCamera.GetComponent<RectTransform> ().position += new Vector3 (0f, 0f, 0.1f);
	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit() {
	
	}

	/// Called when the viewer's trigger is used, between OnGazeEnter and OnGazeExit.
	public void OnGazeTrigger() {

	}

	#endregion
}

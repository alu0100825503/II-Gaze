using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class EventTriggerVR : EventTrigger {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void OnPointerClick (PointerEventData eventData)
	{
		gameObject.transform.position += new Vector3 (0f, 3f, 0f);
	}
}

using UnityEngine;
using System.Collections;

public class CellPhone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown() {
		if (SelectionManager.HasSelection()) {
			Debug.Log("You've been attacked");
		} else {
			Debug.Log ("You have not been attacked");
		}
	}		
}

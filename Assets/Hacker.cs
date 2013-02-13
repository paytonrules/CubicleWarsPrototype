using UnityEngine;
using System.Collections;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start() {
	
	}
	
	void OnMouseDown() {
		SelectionManager.Select(gameObject);
	}
	
	void Update() {
		Debug.Log("IS Selected: " + SelectionManager.HasSelection());
	}
}

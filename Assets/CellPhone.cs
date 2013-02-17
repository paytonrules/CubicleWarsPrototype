using UnityEngine;
using System.Collections;
using CubicleWarsLibrary;

public class CellPhone : MonoBehaviour, Unit {
	CellPhoneUnit unit;

	// Use this for initialization
	void Start () {
		unit = new CellPhoneUnit();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown() {
		StateMachineLoader.stateMachine.SelectObject(this);
	}
	
	public void AttackWith(Unit enemy) {
		unit.AttackWith(enemy);
	}
}

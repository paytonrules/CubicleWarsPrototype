using UnityEngine;
using System.Collections;
using CubicleWarsLibrary;

public class Hacker : MonoBehaviour, UnityObject, Unit {
	HackerUnit unit;

	void Start() {
		unit = new HackerUnit(this);
	}
	
	void OnMouseDown() {
		StateMachineLoader.stateMachine.Attack(this);
	}

	public void Attacked() 
	{
		Debug.Log("ATTACKED");
	}
	
	public void AttackWith(Unit enemy) {
		unit.AttackWith(enemy);
	}
}

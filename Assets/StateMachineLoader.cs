using UnityEngine;
using System.Collections;
using System.Linq;
using CubicleWarsLibrary;

public class StateMachineLoader : MonoBehaviour {
	public static CubicleWarsStateMachine stateMachine;

	// Use this for initialization
	void Start () {
		
		stateMachine = new CubicleWarsStateMachine(
			new HumanPlayer(new Unit[] { 
				GameObject.Find("Telephone").GetComponent<CellPhone>()
			}),
			new HumanPlayer(new Unit[] {}));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

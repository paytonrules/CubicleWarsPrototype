using UnityEngine;
using System.Collections;

public delegate void TurnEnded(TurnInfo tI);

public class StateManager : MonoBehaviour
{
/*	public event TurnEnded enemyTurnEnded;
    public event TurnEnded playerTurnEnded;
	
	void Start()
	{
		StartCoroutine(UpdateState());
	}
	
	IEnumerator UpdateState()
	{
		while(true)
		{
			yield return StartCoroutine(PlayerTurn());
			
			yield return StartCoroutine(EnemyTurn());
		}
	}
	
	IEnumerable PlayerTurn()
	{
		Transform target = null;
		
		bool objectSelected = false;
		
		TurnInfo t1 = new TurnInfo();
		
		yield return StartCoroutine(SelectObject(target));
		
		if (target != null) 
			yield return StartCoroutine(Attack(target));
		
		Debug.Log ("Enemy Attacked");
		
		if (playerTurnEnded != null)
			playerTurnEnded(t1);
	}
	
	IEnumerator EnemyTurn()
	{
		Transform target = null;
		
		bool objectSelected = false;

		TurnInfo t1 = new TurnInfo();
		
		yield return StartCoroutine(SelectObject(target));
		
		if (target != null) 
			yield return StartCoroutine(Attack(target));
		
		Debug.Log ("Player Attacked");
		
		if (enemyTurnEnded != null)
			enemyTurnEnded(t1);
	}
	
	IEnumerator SelectObject(Transform target)
	{
		bool objectSelected = false;
		
		while(!objectSelected)
		{
			target = SomeMethodForFindingATarget();
			
			if (target != null)
			{
				objectSelected = true;
				
				Debug.Log ("object selected");
			}
			
			yield return null;
		}
	}
	
	Transform SomeMethodForFindingATarget()
	{
		return null;
	}
	
	IEnumerator Attack(Transform target)
	{
		bool attacked = false;
		
		while (!attacked)
		{
			target.SendMessage("Attacked", SendMessageOptions.DontRequireReceiver);
			
			attacked = true;
			
			yield return null;
		}
	}*/
}

public struct TurnInfo
{
	public float DamageDone { get; set; }
}	
using System;
using UnityEngine;

public class SelectionManager
{
	private static GameObject SelectedObject { get; set; }
	
	public static void Select(GameObject selected)
	{
		SelectedObject = selected;
	}
	
	public static bool HasSelection()
	{
		return SelectedObject != null;
	}
}


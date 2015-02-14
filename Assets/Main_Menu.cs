using UnityEngine;
using System.Collections;

public class Main_Menu : MonoBehaviour 
{
	
	public bool isQuit = false;
	
	void OnMouseEnter()
	{
		gameObject.GetComponent<TextMesh>().color = Color.black;    
	}
	
	void OnMouseExit()
	{
		gameObject.GetComponent<TextMesh>().color = Color.white;
	}
	
	void OnMouseDown()
	{
			Application.Quit();    
		
	}
}
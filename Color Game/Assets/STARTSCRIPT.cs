using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {
	
	public GUISkin skin = null;
	
	public float widthPercent = 0.3f;
	public float heightPercent = 0.3f;
	
	void OnGUI() {
		GUI.skin = skin;    
		Rect r = new Rect(Screen.width * (1 - widthPercent) / 2,
		                  Screen.height * (1 - heightPercent) / 2,
		                  Screen.width * widthPercent,
		                  Screen.height * heightPercent); 
		
		// draw the menu
		GUILayout.BeginArea(r);
		GUILayout.BeginVertical("box");   
		
		if (GUILayout.Button("Play"))
			Application.LoadLevel("thegame");        
		if (GUILayout.Button("Quit"))
			Application.Quit();
		
		GUILayout.EndVertical();        
		GUILayout.EndArea();       
	}
}

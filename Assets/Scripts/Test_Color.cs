using UnityEngine;
using System.Collections;

public class Test_Color : MonoBehaviour {

	public int randomColor;
	/*public int red = 1;
	public int blue = 2;
	public int green = 3;
	public int yellow = 4;
	public int magenta = 5;
	public int black =6;*/
	public float min = 1f;
	public float max = 6.9f;
	//public Color pinkColor = new Color(1,0,1);

	void Update () {

		randomColor = (int) Random.Range (min,max);

		if (Input.GetKeyDown(KeyCode.Space))
			colorTest ();

	}

	void colorTest()
	{
		if (randomColor == 1) {
						Debug.Log ("Red");
						gameObject.renderer.material.color = Color.red;			
				} else if (randomColor == 2) {
						Debug.Log ("Blue");
						gameObject.renderer.material.color = Color.blue;
				} else if (randomColor == 3) {
						Debug.Log ("Green");
						gameObject.renderer.material.color = Color.green;
				} else if (randomColor == 4) {
						Debug.Log ("Yellow");
						gameObject.renderer.material.color = Color.yellow;
				} else if (randomColor == 5){
						Debug.Log("Magenta");
						gameObject.renderer.material.color = Color.magenta;
				} else if (randomColor == 6){
						Debug.Log("White");
						gameObject.renderer.material.color = Color.white;
				}
	}
}

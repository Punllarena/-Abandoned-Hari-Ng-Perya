using UnityEngine;
using System.Collections;

public class Test_Color : MonoBehaviour {

	public int randomColor;
	public int red = 1;
	public int blue = 2;
	public int green = 3;
	public int yellow = 4;
	public int pink = 5;
	public int white =6;
	public float min = 1f;
	public float max = 6f;


	void Update () {

		if (Input.GetKeyDown(KeyCode.Space))
			colorTest ();

		randomColor = (int) Random.Range (min,max);

	}

	void colorTest()
	{
		if (randomColor == 1)
			Debug.Log("Red");
		else if (randomColor == 2)
			Debug.Log("Blue");
		else if (randomColor == 3)
			Debug.Log("Green");
		else if (randomColor == 4)
			Debug.Log("Yellow");
		else if (randomColor == 5)
			Debug.Log("Pink");
		else if (randomColor == 6)
			Debug.Log("White");
		/* Debug.Log("Red"); break;
		Debug.Log("Blue"); break;
		case 3: Debug.Log("Green"); break;
		case 4: Debug.Log("Yellow"); break;
		case 5: Debug.Log("Pink"); break;
		case 6:	Debug.Log("White"); break;
		}*/
	
	}
}

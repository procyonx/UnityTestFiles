using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour {

	public bool boolean1=false;	// [!] public allows other scripst to access this information if needed. (accessibility)
		// will appear as a field in the inspector within Unity when script is dragged onto a game object**.
	private bool boolean2=true;	// private vars can only be used inside this file. (accessibility)
		// bool is a TRUE/FALSE (1/0) value

	// **bools show up as a check box within the inspector.
	/* NOTE: When changing global variables like this, they will not update within the Inspector until you click on the little gear icon in
	 * the far top right of the script area and click on "refresh". Watch out for that.
	 * NOTE: Any value you manually enter into the inspector (works for public variables only because those are the only variables that you can
	 * see within the Unity engine's inspector), will override whatever global value that parameter was set to here. In other words:
	 		Think of creating public int x=20; If I go into the inspector and change x to 30, it is the same as if I had coded x=30; in here. 
	 		x will now be 30 forever, until it is overridden in some way after that change was made (or you reset the script) */

	public int integer1 = 1;
	public float floatingPoint1 = 1.1f; // decimals must have the f after them

	// Use this for initialization
	void Start () {

		// boolean1 = true;
		integer1 = 10;
		floatingPoint1 = 5.4f;

		if (boolean1)
			{	Debug.Log ("Awesome");	}
	}
	
	// Update is called once per frame
	void Update () {
		integer1 += 1;
	}
}

// cool resource: http://zingweb.com/blog/2013/02/05/unity-coroutine-wrapper/
// http://stackoverflow.com/questions/26570226/c-sharp-creating-new-vector3-with-variables-not-numbers
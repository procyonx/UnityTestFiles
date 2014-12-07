using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public GameObject Wall; // then just drag the game object Wall into the Wall parameter of the inspector.

	public bool touchingGround; // going to check if the ball is checking the ground and we'll save the state to a new variable
	public float sphereRadius = 0.5f; // we are going to dynamically check the radius of the sphere
		// remember that the public assignment allows Unity (and other scripts) to references the above variables

	// Use this for initialization
	void Start () {
		Function1();

		bool test = true; // remember that this test variable is local so it will be destroyed once this function (Start()) is done.
		test = !test; // works! w00t! Basically, this says test equals the opposite (!) value of its current value; only works with bools.
		Debug.Log (test);
	}

	// Update is called once per frame
	void Update () {

		touchingGround = isTouching ();

		float tempVar = 1.1f; // local variable (note lack of public/private accessability)
		// once this particular function ends, the local var TempVar is destroyed.

		// ChangeWallColor();


		if (touchingGround)
			{	Bounce(new Vector3(0, 5, 0));	}
				// would you forward a new float parameter as (new float 4.4f)?
				// PrintNewFloat (new float 4.4f); // Doesn't work. WTF?! Why new Vector3 but not new float?
				/* 	Vector3 is a special object (class or struct) so we have to use the new keyword to create a new instance of it.
					new GameObject("gameObjectName") is another example. int, string, bool, all of these are pretty standard so 
		 			you do not need to use the new keyword to invoke a new instance of it. New is a reserved word for certain situations. */
	}

	void Function1 () { // when naming functions, void has to come first. What is void? void just means the function will return nothing.
		Debug.Log ("This is a function");
	}

	void Bounce(Vector3 bounceVelocity) {
		rigidbody.velocity=bounceVelocity;
		// Debug.Log (tempVar);
			/*	If you uncomment the above line, you'll see that we can't acces tempVar within this Bounce() function even
			 * though we declared that local variable before calling Bounce(). This proves that local variables can only
			 * be used by the functions from within which they are created, unless forwarded as a parameter. */
	}

	void PrintNewFloat(float newFloat)
	{
		Debug.Log ("new Float");
	}

	void ChangeWallColor()
	{
		Wall.renderer.material.color = new Color(0, 0, 0, 1);

		// renderer, material, and color are lowercase because they are referencing an instance of a class/structs, not creating a new one.
		// Structs have to have all their variables change on iniatlization, whereas classes are way more dynamic, albeit slower to create/spawn.
		// more color examples: http://answers.unity3d.com/questions/314737/how-to-randomly-change-a-color-on-an-object-in-c.html
	}

	bool isTouching() // bool states that isTouching() is going to return a value, in this case a bool value
	{
		// we know that the ball is 1 unit and has a radius of 0.5, so we want to fire a ray at the end of it.
		return Physics.Raycast (transform.position, Vector3.down, sphereRadius);
		// return is the keyword that returns some value, in this case a Raycast hit (or no hit)
	}
}
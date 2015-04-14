using UnityEngine;
using System.Collections;

public class Controller: MonoBehaviour
{
			
	public void Controlling (float speed, float move_x, float move_y)
	{
		Rigidbody2D myRigidBody = GetComponent<Rigidbody2D>();
		//GetComponent<Rigidbody2D>().velocity = new Vector2 (move_x * speed, move_y * speed);	
		myRigidBody.velocity = new Vector2 (move_x * speed, move_y * speed);
	}
}
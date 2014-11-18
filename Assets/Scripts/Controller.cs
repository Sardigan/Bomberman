using UnityEngine;
using System.Collections;

public class Controller: MonoBehaviour
{
			
	public void Controlling (int speed, int move_x, int move_y)
	{
		rigidbody2D.velocity = new Vector2 (move_x * speed, move_y * speed);
	
	}

}
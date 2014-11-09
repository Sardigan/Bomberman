using UnityEngine;
using System.Collections;

public class Controller: MonoBehaviour
{
			
	public void Controlling (int speed, float move_x, float move_z)
	{
		rigidbody.velocity = new Vector3 (move_x * speed, 0, move_z * speed);
	
	}

}
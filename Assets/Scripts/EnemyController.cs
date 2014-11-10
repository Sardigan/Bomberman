using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public Controller enemy;  
	private float move_x;
	// Use this for initialization
	void Start () {
	
	}
	void Star () {
		move_x = 2;
		
	}

	// Update is called once per frame
	void Update () {
		this.Star ();
		enemy.Controlling(1, move_x, 2);
	}
}

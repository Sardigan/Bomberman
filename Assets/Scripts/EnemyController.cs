using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public Controller enemy;    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		enemy.Controlling(3, Random.Range(-1,1), Random.Range(-1,1));
	}
}

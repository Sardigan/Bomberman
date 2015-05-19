using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Data : MonoBehaviour
{

		public int power = 0;
		public int speedPlayer = 0;
		public int speedEnemy = 0;
		public Slider Power;
		public Slider SpeedPlayer;
		public Slider SpeedEnemy;
		public Text textPower;
		public Text textSpeedPlayer;
		public Text textSpeedEnemy;
		// Use this for initialization
		void Start ()
		{
		 
		}

		// Update is called once per frame
		void Update ()
		{	
				power = (int)Power.value;
				textPower.text = "Power:" + power.ToString ();
				PlayerPrefs.SetInt ("power", power);

				speedPlayer = (int)SpeedPlayer.value;
				textSpeedPlayer.text = "SpeedPlayer:" + speedPlayer.ToString ();
				PlayerPrefs.SetFloat ("speedPlayer", (float) speedPlayer);

				speedEnemy = (int)SpeedEnemy.value;
				textSpeedEnemy.text = "SpeedEnemy:" + speedEnemy.ToString ();
				PlayerPrefs.SetFloat ("speedEnemy", (float) speedEnemy);
		}
}

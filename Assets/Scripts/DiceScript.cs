using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour {

	public GameObject Plane;
	public GameObject TextGB;

	private GameObject Dice1;
	private GameObject Dice2;
	private GameObject Dice3;
	private GameObject Dice4;
	private GameObject Dice5;
	private GameObject Dice6;

	private bool isStill;
	private Rigidbody rb;
	private Text text;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		text = TextGB.GetComponent<Text>();
		Dice1 = GameObject.Find ("Dice1");
		Dice2 = GameObject.Find ("Dice2");
		Dice3 = GameObject.Find ("Dice3");
		Dice4 = GameObject.Find ("Dice4");
		Dice5 = GameObject.Find ("Dice5");
		Dice6 = GameObject.Find ("Dice6");

		// Random rotation on start
		this.transform.rotation = Random.rotation;
		isStill = false;
	}

	// Update is called once per frame
	void Update () {
		string diceValue = "";
		if (!isStill && rb.velocity.x == 0 && rb.velocity.y == 0 && rb.velocity.z == 0) {
			if (Dice1.transform.eulerAngles.x == Plane.transform.eulerAngles.x + 90) {
				diceValue = "1";
			}
			if (Dice2.transform.eulerAngles.x == Plane.transform.eulerAngles.x + 90) {
				diceValue = "2";
			}
			if (Dice3.transform.eulerAngles.x == Plane.transform.eulerAngles.x + 90) {
				diceValue = "3";
			}
			if (Dice4.transform.eulerAngles.x == Plane.transform.eulerAngles.x + 90) {
				diceValue = "4";
			}
			if (Dice5.transform.eulerAngles.x == Plane.transform.eulerAngles.x + 90) {
				diceValue = "5";
			}
			if (Dice6.transform.eulerAngles.x == Plane.transform.eulerAngles.x + 90) {
				diceValue = "6";
			}
			if (diceValue != "") {
				isStill = true;
			}

			Debug.Log ("Dice " +diceValue);
			text.text = "You got a " +diceValue +"!";
		}
	}
}

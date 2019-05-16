using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftEnemy : MonoBehaviour {

	public Text Left;

	// Use this for initialization
	void Start () {
		Left.text = PNum.PlayerNum.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		Left.text = PNum.PlayerNum.ToString ();
	}
}

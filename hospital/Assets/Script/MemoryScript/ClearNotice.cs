using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearNotice : MonoBehaviour {

	public GameObject Notice;
	public float clearTime;
	public float clearTime2;

	// Use this for initialization
	void Start () {
		clearTime = 0f;
		clearTime2 = 8f;
		Notice.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
		clearTime += Time.deltaTime;
		if (clearTime > clearTime2) 
		{
			Notice.SetActive (false);
		}
	}
}

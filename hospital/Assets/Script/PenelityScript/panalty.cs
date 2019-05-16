using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panalty : MonoBehaviour {
	public TimerManager timeManager;
	float timeSpan;
	float checkTime;
	float minusTime;

	// Use this for initialization
	void Start () {
		timeManager = GameObject.Find ("Time").GetComponent<TimerManager> ();
		float minusTime = 2f;
		timeSpan = 0.0f;
		checkTime = 20.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("item").Length == 2)
		{
			minusTime = 2f;
			timeSpan = 0;
		}
		else if (GameObject.FindGameObjectsWithTag ("item").Length == 1)
		{
			timeSpan += Time.deltaTime;
			if (timeSpan < checkTime)
			{
				minusTime = 0f;
			}
			else
			{
				minusTime = 2f;
			}
		}
	}

	void OnMouseUp()
	{
		PanaltySound.instance.PlaySound ();
		timeManager.TimeCost = timeManager.TimeCost - minusTime;
		Debug.Log ("penalty:" + timeManager.TimeCost);
	}
}

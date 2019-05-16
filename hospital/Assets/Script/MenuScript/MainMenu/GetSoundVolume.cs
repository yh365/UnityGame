using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSoundVolume : MonoBehaviour {

	public AudioSource soundVolume;

	// Use this for initialization
	void Start () {
		soundVolume.volume = BVolume.bVolume;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

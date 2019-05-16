using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class BVolume
{
	public static float bVolume = 1;
}

public class SetSoundVolume : MonoBehaviour {

	public Slider SoundVolume;
	public AudioSource audio;

	// Use this for initialization
	void Start () {
		SoundVolume.value = BVolume.bVolume;
	}

	// Update is called once per frame
	void Update () {
		audio.volume = SoundVolume.value;
		BVolume.bVolume = audio.volume;
	}
}

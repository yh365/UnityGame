using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanaltySound : MonoBehaviour {

	public AudioClip SoundPanalty;
	AudioSource myAudio;

	public static PanaltySound instance;

	private void Awake() // start 함수보다 먼저 호출됨
	{
		if(PanaltySound.instance == null)
		{
            PanaltySound.instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource>();
	}

	public void PlaySound()
	{
		myAudio.PlayOneShot(SoundPanalty); // soundExplosion 안에 있는 사운드가 재생
	}

	// Update is called once per frame
	void Update () {

	}
}

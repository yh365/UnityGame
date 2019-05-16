using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSound : MonoBehaviour {

	public AudioClip SoundItem;
	AudioSource myAudio;

	public static ItemSound instance;

	private void Awake() // start 함수보다 먼저 호출됨
	{
		if(ItemSound.instance == null)
		{
			ItemSound.instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource>();
	}

	public void PlaySound()
	{
		myAudio.PlayOneShot(SoundItem); // soundExplosion 안에 있는 사운드가 재생
	}

	// Update is called once per frame
	void Update () {

	}
}

using UnityEngine;
using System.Collections;
using System.Linq;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource _audioSource;

	void Awake () {
		DontDestroyOnLoad(gameObject);
	}

	void Start() {
		_audioSource = GetComponent<AudioSource>();
	}

	void OnLevelWasLoaded(int level) {
		var audioClip = levelMusicChangeArray.ElementAtOrDefault(level);
		if (audioClip != null) {
			if (_audioSource.clip == audioClip) {
				return;
			}
			_audioSource.clip = audioClip;
			_audioSource.Play();
		}
	}

}

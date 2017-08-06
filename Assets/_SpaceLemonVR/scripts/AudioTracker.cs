using UnityEngine;

public class AudioTracker : MonoBehaviour
{
	public AudioSource track1;
	public AudioSource track2;
	public NewtonVR.NVRLever lever;

	public float fadeTime1;
	public float fadeTime2;

	private bool isPlayingTrack2;
	private float track2StartTime;

	private void Update()
	{
		if (lever.LeverEngaged)
			playTrack2();

		float currentTime = Time.time;

		track1.volume = Mathf.Min(currentTime / fadeTime1, 1);

		if(isPlayingTrack2)
			track2.volume = Mathf.Min((currentTime - track2StartTime) / fadeTime2, 1);
	}

	public void playTrack2()
	{
		track2StartTime = Time.time;
		isPlayingTrack2 = true;
	}
}
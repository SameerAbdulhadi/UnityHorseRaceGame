using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    public AudioClip billStart;
    public AudioClip Crowd;
    private AudioSource audioSource;
    public GameObject Horse;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Set the first track as the initial background music
        audioSource.clip = billStart;
        audioSource.Play();
    }

    void Update()
    {
        // Check if the first track has ended
        if (!audioSource.isPlaying)
        {
            // Start playing the second track
            PlaySecondTrack();
        }
        if (Horse.transform.position.x > 203 && Horse.transform.position.x < 238 && Horse.transform.position.z > 553)
        {
            audioSource.enabled = false;
        }
    }

    void PlaySecondTrack()
    {
        // Set the second track and play it
        audioSource.clip = Crowd;
        audioSource.Play();
    }
}

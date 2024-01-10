using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playButton : MonoBehaviour
{
    public AudioSource audio;

    public void ButtonClicked()
    {
        audio.Play();
        StartCoroutine(LoadNextSceneAfterSound());
    }

    private IEnumerator LoadNextSceneAfterSound()
    {
       
        yield return new WaitForSeconds(audio.clip.length);
        SceneManager.LoadScene("SelectLevel");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_1 : MonoBehaviour
{
    public AudioSource audio;
    
    public void ButtonClicked()
    {
        audio.Play();
        //StartCoroutine(LoadNextSceneAfterSound());
        SceneManager.LoadScene("HorseSelection");
    }

    //private IEnumerator LoadNextSceneAfterSound()
    //{

      //  yield return new WaitForSeconds(audio.clip.length);
        //SceneManager.LoadScene("HorseSelection");
    //}
}

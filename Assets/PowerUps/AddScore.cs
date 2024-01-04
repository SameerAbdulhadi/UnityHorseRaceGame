using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    // Start is called before the first frame update

    public int amount;
    public AudioSource audio;


    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Horse"))
        {
            ScoreManager scoreManager = other.GetComponent<ScoreManager>();
            ScoreManager.instance.score += amount;
            audio.enabled = true;
            audio.Play();
            StartCoroutine(DestroyObj());
        }

    }
    private IEnumerator DestroyObj()
    {

        yield return new WaitForSeconds(audio.clip.length);
        Destroy(gameObject);
    }

    }



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

        if (other.CompareTag("BrownHorse"))
        {

            scoreToBoard.instance.brownScore += amount;

            audio.enabled = true;
            audio.Play();
            StartCoroutine(DestroyObj());

        }


        else if (other.CompareTag("BlackHorse"))
            {
                score2ToBoard.instance.blackScore += amount;

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



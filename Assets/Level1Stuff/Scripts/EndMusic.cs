using UnityEngine;

public class RaceGameManager : MonoBehaviour
{
    public GameObject Horse;
    public AudioSource winSound;
    private void Update()
    {
        if (Horse.transform.position.x > 203 && Horse.transform.position.x < 238 && Horse.transform.position.z > 553 )
        {
            winSound.enabled = true;

        }
        else
        {
            winSound.enabled = false;
 
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class LoadCharacter : MonoBehaviour
{
	public GameObject[] characterPrefabs;
	public Transform PlayerspawnPoint;
    public Transform EnemyspawnPoint;
    public TMP_Text label;
	GameObject PlayerHorse;
	GameObject EnemyHorse;

	GameObject playerprefab;
    GameObject Enemyprefab;


    void Start()
	{
		int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        playerprefab = characterPrefabs[selectedCharacter];
		 PlayerHorse = Instantiate(playerprefab, PlayerspawnPoint.position, Quaternion.identity);
        //label.text = prefab.name;
        if (selectedCharacter == 0)
            Enemyprefab = characterPrefabs[1];
        else if(selectedCharacter == 1)
            Enemyprefab = characterPrefabs[0];
        EnemyHorse = Instantiate(Enemyprefab, EnemyspawnPoint.position, Quaternion.identity);


    }
}

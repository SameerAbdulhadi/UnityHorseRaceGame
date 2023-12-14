using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HanyObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab1;
    public GameObject obstaclePrefab2;
    public GameObject obstaclePrefab3;


    public GameObject[] references = new GameObject[10]; 
    public GameObject arr0 ,arr1 , arr2 , arr3 ,arr4 , arr5 ,arr6 , arr7 ,arr8 , arr9;

    private void Awake()
    {
        // fill the references array with the references points. 
        references[0] = arr0;
        references[1] = arr1;
        references[2] = arr2;
        references[3] = arr3;
        references[4] = arr4;
        references[5] = arr5;
        references[6] = arr6;
        references[7] = arr7;
        references[8] = arr8;
        references[9] = arr9;
        ChooseObstacles(references);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChooseObstacles(GameObject[] array)
    {
        // Generate a random number
        int obstaclePosition1 = Random.Range(0, 4);
        int obstaclePosition2;

        // Make sure obstaclePosition2 is different from obstaclePosition1
        do
        {
            obstaclePosition2 = Random.Range(0, 4);
        } while (obstaclePosition2 == obstaclePosition1);

        int obstaclePosition3;

        // Make sure obstaclePosition3 is different from obstaclePosition1 and obstaclePosition2
        do
        {
            obstaclePosition3 = Random.Range(0, 4);
        } while (obstaclePosition3 == obstaclePosition1 || obstaclePosition3 == obstaclePosition2);

        // Make the spawn point is equal to the children of the reference
        for (int i = 0; i < array.Length; i++)
        {
            Transform spawnPoint1 = array[i].transform.GetChild(obstaclePosition1).transform;
            Transform spawnPoint2 = array[i].transform.GetChild(obstaclePosition2).transform;
            Transform spawnPoint3 = array[i].transform.GetChild(obstaclePosition3).transform;

            Instantiate(obstaclePrefab1, spawnPoint1.position, spawnPoint1.rotation);
            Instantiate(obstaclePrefab2, spawnPoint2.position, Quaternion.identity);
            Instantiate(obstaclePrefab3, spawnPoint3.position, spawnPoint3.rotation);
        }
    }

}

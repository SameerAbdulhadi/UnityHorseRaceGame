using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseSelectionScript : MonoBehaviour
{
    private int CurrentCar;
    private void SelectCar(int _index)
    {
        for(int i = 0;i<transform.childCount;i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }
    public void ChangeCar(int _change)
    {
        CurrentCar += _change;
        SelectCar(CurrentCar);
    }
}

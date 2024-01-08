using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public GameObject lvl2RespawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject.transform);
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

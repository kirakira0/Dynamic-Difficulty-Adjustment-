using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HailSpawner : MonoBehaviour
{
    public GameObject hail; 
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(hail, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }   
    }

    // Update is called once per frame
    void Update()
    {

    }
}

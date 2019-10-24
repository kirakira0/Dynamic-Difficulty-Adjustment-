using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeRoom : MonoBehaviour
{
    public string targetRoom; 
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(targetRoom);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

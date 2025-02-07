using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Redemarrer : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RedemarrerScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}

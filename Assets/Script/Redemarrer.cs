using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Redemarrer : MonoBehaviour
{ 
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ResetBox"))  // Ensure your box is tagged "ResetBox"
        {
            Debug.Log("Reset triggered! Restarting in 5 seconds...");
            Invoke("RestartScene", 5f); // Calls RestartScene after 5 seconds
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

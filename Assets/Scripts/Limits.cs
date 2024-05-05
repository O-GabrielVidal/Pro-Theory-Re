using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Limits : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            SceneManager.LoadScene(5, LoadSceneMode.Single);//Go to the screen of victory
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestroyPlatform : MonoBehaviour
{
    public void BeginGame()
    {
        GameObject platform = GameObject.FindGameObjectWithTag("platform");

        Destroy(platform);
  
    }
    public void OnCollisionEnter(Collision collision) 
    {        
        int secondes = 5f * Time.deltaTime;

        if(collision.gameObject.CompareTag("Fin")){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JeuBille : MonoBehaviour
{
    public void BeginGame()
    {
        GameObject platform = GameObject.FindGameObjectWithTag("platform");

        Destroy(platform);
  
    }

    public void OnCollisionEnter(Collision collision) 
    {        
        float secondes = 220 * Time.deltaTime;

        if(collision.gameObject.CompareTag("Fin")){
            Invoke("RestartGame", secondes);
        

        }
        
    }

    public void RestartGame()
    {        

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
}


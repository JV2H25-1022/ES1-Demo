using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public void BeginGame()
    {
        GameObject platform = GameObject.FindGameObjectWithTag("platform");

        Destroy(platform);
  
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPass : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BackgroundMusic");

        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }

        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}

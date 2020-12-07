using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isOrbShattered = false;
    public GameObject levelGeometry;

    public void Start()
    {
    }

    public void FixedUpdate()
    {
        if (isOrbShattered)
        {
            
            levelGeometry.SetActive(false); //not working? - Destroy() also doesn't work
        }
    }

}

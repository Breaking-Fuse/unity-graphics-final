using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isOrbShattered = false;
    public GameObject levelGeometry;

    public void Update()
    {
        if (isOrbShattered)
        {
            ChangeEnvironment();
        }

    }


    private void ChangeEnvironment()
    {
        RenderSettings.fogEndDistance = 10f;
        //Shaders on LevelGeometry - Need to research Replacement Shaders!
        Destroy(levelGeometry);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ScreenFlasher : MonoBehaviour
{
    public CanvasGroup cg;

    private bool isEffectPlaying = false;
    private bool hasEffectPlayed = false;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isOrbShattered && !hasEffectPlayed) FlashScreen();
        if (isEffectPlaying)
        {
            Time.timeScale = .5f;
            cg.alpha -= Time.deltaTime * 2;

            if (cg.alpha <= 0)
            {
                cg.alpha = 0;
                Time.timeScale = 1;
                isEffectPlaying = false;
            }
        }
    }
    
    private void FlashScreen()
    {
        cg.alpha = 1;
        isEffectPlaying = true;
        hasEffectPlayed = true;
    }
}

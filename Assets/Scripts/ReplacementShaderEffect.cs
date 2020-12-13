using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ReplacementShaderEffect : MonoBehaviour
{
    /* Unused at the moment - This was meant to apply a replacement shader (glitch-out/dissolve entire level geometry for example)*/
    public Shader replacementShader;

    // Start is called before the first frame update
    private void OnEnable()
    {
        if (replacementShader != null)
        {
            GetComponent<Camera>().SetReplacementShader(replacementShader, "");
        }
    }

    private void OnDisable()
    {
        GetComponent<Camera>().ResetReplacementShader();
    }
}

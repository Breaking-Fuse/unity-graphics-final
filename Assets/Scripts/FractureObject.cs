using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FractureObject : MonoBehaviour
{
    public GameObject fractured;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            //HACK put into a child class ("FractureOrb:FractureObject")!
            GameManager.isOrbShattered = true;
            Instantiate(fractured, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }

}

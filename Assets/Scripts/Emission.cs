using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Emission : MonoBehaviour
{
    public ParticleSystem change;
    float multi = 0.01f;
    float x = 0.004f;


   


    [System.Obsolete]
   
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            functionOne();

        }
        else if(other.tag != "Player")
        {
            functionTwo();
        }
    }

    [System.Obsolete]
    private void functionOne()
    {
        change.gameObject.GetComponent<ParticleSystem>().startLifetime -= multi;
        if(change.gameObject.GetComponent<ParticleSystem>().startLifetime < 0.001f)
        {
            x = 0f;
            change.gameObject.GetComponent<ParticleSystem>().Stop();
        }
    }

    [System.Obsolete]
    private void functionTwo()
    {
        if(change.gameObject.GetComponent<ParticleSystem>().startLifetime < 2)
        change.gameObject.GetComponent<ParticleSystem>().startLifetime += x;
    }

}

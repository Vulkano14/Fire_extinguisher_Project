using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionToFire : MonoBehaviour
{
    public ParticleSystem changeToFire;
    float multi = 0.005f;
    float x = 0.004f;





    [System.Obsolete]

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            functionOne();

        }
        else if (other.tag != "Player")
        {
            functionTwo();
        }
    }

    [System.Obsolete]
    private void functionOne()
    {
        changeToFire.gameObject.GetComponent<ParticleSystem>().startLifetime -= multi;
        if (changeToFire.gameObject.GetComponent<ParticleSystem>().startLifetime < 0.001f)
        {
            x = 0f;
            changeToFire.gameObject.GetComponent<ParticleSystem>().Stop();
        }
    }

    [System.Obsolete]
    private void functionTwo()
    {
        if (changeToFire.gameObject.GetComponent<ParticleSystem>().startLifetime < 2)
            changeToFire.gameObject.GetComponent<ParticleSystem>().startLifetime += x;
    }

}

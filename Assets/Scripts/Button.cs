using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour
{
    public bool buttonPressed;
    public ParticleSystem particle;
    public GameObject box;
    public Text text;
    private float time = 10;


    public void Start()
    {
        text.text = "10,0 s";
        if (box.activeInHierarchy == true)
            box.SetActive(false);
    }

    [System.Obsolete]
    private void Update()
    {
        

        if (buttonPressed)
        {
            particle.gameObject.GetComponent<ParticleSystem>().startLifetime = 2.64f;
            box.SetActive(true);
            time -= Time.deltaTime;
            text.text = time.ToString("F1") + " s";
            if (time <= 0)
            {
                text.text = "Time Out";
                particle.gameObject.GetComponent<ParticleSystem>().startLifetime = 0f;
                box.SetActive(false);
            }
                
        }
        else
        {
            particle.gameObject.GetComponent<ParticleSystem>().startLifetime = 0f;
            box.SetActive(false);
        }
            
    }

    public void OnMouseDrag()
    {
        buttonPressed = true;
   
    }

    public void OnMouseUp()
    {
        buttonPressed = false;
    }

}

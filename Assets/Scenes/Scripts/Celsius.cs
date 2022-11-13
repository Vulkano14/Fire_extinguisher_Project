using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Celsius : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public short numberCelsius;
    public GameObject other;

    private void Start()
    {
        numberCelsius = 0;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "red")
            {
            changeNumber();
        }
        else if(other.tag == "blue")
        {
            changeNumberBlue();
        }
            
    }

    private void changeNumberBlue()
    {
        textMesh.text = numberCelsius.ToString() + " *C";
        if (numberCelsius > -100)
            numberCelsius--;
    }

    private void changeNumber()
    {
        textMesh.text = numberCelsius.ToString() + " *C";
        if (numberCelsius < 1000)
            numberCelsius++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{  
    public Dropdown ColorDropdown;
    public GameObject Player;
    // Start is called before the first frame update
    public void ChangeColor ()
    {
        switch(ColorDropdown.value)
        {
            case 1:
                Player.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                Player.GetComponent<Renderer>().material.color = Color.black;
                break;
            default:
                Player.GetComponent<Renderer>().material.color = Color.blue;
                break;
        }
    }   
}

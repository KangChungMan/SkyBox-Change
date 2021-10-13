using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMode : MonoBehaviour
{
    public GameObject sun;
    public GameObject night;
    public void sunSwitch()
    {
        sun.gameObject.SetActive(true);
        night.gameObject.SetActive(false);        
    }
    public void nightSwitch()
    {
        sun.gameObject.SetActive(false);
        night.gameObject.SetActive(true);        
    }

}

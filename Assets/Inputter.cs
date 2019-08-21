using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Inputter : MonoBehaviour{

    public Text testi,quali;
    int i = 0;
    public VolumeButton Volumes;
    float volume0, volume1;
    private void Start()
    {
        volume0 = Volumes.GetVolume();
    }
    void Update ()
    {
        volume1 = Volumes.GetVolume();

        if (volume1 > volume0)
        {
            i++;
            testi.text = i.ToString();
            quali.text = "AUMENTOU";
            volume0 = Volumes.GetVolume();
            Time.timeScale = volume0 + 0.5f ;
        }
        else if(volume0 > volume1)
        {
            i--;
            testi.text = i.ToString();
            quali.text = "DIMINUIU";
            volume0 = Volumes.GetVolume();
            Time.timeScale = volume0 + 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (transform.GetComponent<Camera>().backgroundColor == Color.black)
            {
                transform.GetComponent<Camera>().backgroundColor = Color.white;
                testi.color = Color.black;
                quali.color = Color.black;
            }
            else
            {
                transform.GetComponent<Camera>().backgroundColor = Color.black;
                testi.color = Color.white; 
                quali.color = Color.white;
                
            }
        }

        
	}
}

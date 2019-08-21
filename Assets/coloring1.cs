#region Bibliotecas
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
#endregion
public class coloring1 : MonoBehaviour
{
                                                /*Mudar para apenas cores virantes*/
    Color nova;
    Color R, G, B;


    public float velocidade;
    private void Start()
    {
        /*R = randomizer.Next(255);
        G = randomizer.Next(255);
        B = randomizer.Next(255);-*/

        nova = Mudacolor();
        StartCoroutine("CorAleatoria");
    }
    private void Update()
    {
        //gameObject.GetComponent<Image>().color = Color.Lerp(gameObject.GetComponent<Image>().color, nova, Time.deltaTime*velocidade);
        gameObject.GetComponent<MeshRenderer>().material.color = Color.Lerp(gameObject.GetComponent<MeshRenderer>().material.color, nova, Time.deltaTime * velocidade);
    }
    IEnumerator CorAleatoria()
    {
        
        yield return new WaitForSeconds(velocidade);
        nova = Mudacolor();
        StartCoroutine("CorAleatoria");
    }

    Color Mudacolor()
    {
        switch(Random.Range(0, 7))
        {
            case 1:
                return new Color(0, 0, 1);
            case 2:
                return new Color(0, 1, 0);
            case 3:
                return new Color(1, 0, 0);
            case 4:
                return new Color(0, 1, 1);
            case 5:
                return new Color(1, 0, 1);
            case 6:
                return new Color(1, 1, 0);
            case 7:
                return new Color(1, 1, 0.5f);
        }
        return new Color(Random.Range(0.3f, 0.7f), Random.Range(0.3f, 0.7f), Random.Range(0.3f, 0.7f)); ;
    }

}
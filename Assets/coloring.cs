#region Bibliotecas
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
#endregion
public class coloring : MonoBehaviour
{
                                                /*Mudar para apenas cores virantes*/
    Color nova;
    public float velocidade;
    private void Start()
    {
        nova = new Color(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));
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
        nova = new Color(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));
        StartCoroutine("CorAleatoria");
    }
}
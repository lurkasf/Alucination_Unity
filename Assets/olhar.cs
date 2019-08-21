using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olhar : MonoBehaviour {

    public Transform Qual;
    // Update is called once per frame
    void Update () {
        transform.LookAt(Qual);
	}
}

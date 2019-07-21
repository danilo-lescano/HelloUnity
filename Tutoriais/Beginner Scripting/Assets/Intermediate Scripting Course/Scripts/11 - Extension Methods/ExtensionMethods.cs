using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods{
    public static IEnumerator Girar(this GiraGira g){
        while(true){
            g.GetComponent<Transform>().Rotate(Random.Range(0f, 360.0f), Random.Range(0f, 360.0f), Random.Range(0f, 360.0f), Space.World);
            yield return new WaitForSeconds(1);
        }
    }
}
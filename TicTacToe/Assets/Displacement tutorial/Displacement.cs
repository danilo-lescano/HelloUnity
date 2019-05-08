using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displacement : MonoBehaviour{
    float displacementAmount;
    MeshRenderer mesh;
    void Start(){
        mesh = GetComponent<MeshRenderer>();
    }

    void Update(){
        displacementAmount = Mathf.Lerp(displacementAmount, 0, Time.deltaTime);
        mesh.material.SetFloat("_Amount", displacementAmount);
        if(Input.GetButtonDown("Jump"))
            displacementAmount += 1f;
    }
}

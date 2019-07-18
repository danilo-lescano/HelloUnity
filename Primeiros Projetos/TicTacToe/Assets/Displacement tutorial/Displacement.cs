using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Displacement : MonoBehaviour{
    float displacementAmount;
    float tempoVar = 100f;
    bool controlTime;
    MeshRenderer mesh;
    void Start(){
        mesh = GetComponent<MeshRenderer>();
    }

    void Update(){
        displacementAmount = Mathf.Lerp(displacementAmount, 0, Time.deltaTime);
        mesh.material.SetFloat("_Amount", displacementAmount);
        mesh.material.SetFloat("_tempoVar", tempoVar + 500f);
        if(tempoVar > 100f)
            controlTime = true;
        if(tempoVar < 0f)
            controlTime = false;
        tempoVar = tempoVar + (controlTime ? -1 : 1) * Time.deltaTime;
        if(Input.GetButtonDown("Jump"))
            displacementAmount += 1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S_AlinhamentoTexto : MonoBehaviour{
    float initialY;
    void Start(){
        initialY = transform.position.y;
    }

    void Update(){
        if(Input.GetMouseButtonDown(0))
            StartCoroutine(x((Camera.main.ScreenToWorldPoint(Input.mousePosition)).y, transform.position));
        if(!Input.GetButton("Fire1") && initialY > transform.position.y){
            Vector3 pos = transform.position;
            pos.y = Mathf.Lerp(pos.y, initialY, 0.2f);
            transform.position = pos;
        }
        print(GetComponent<TextMeshProUGUI>().bounds.extents.y);
        print(GetComponent<TextMeshProUGUI>().textBounds.extents.y);
        print(GetComponent<TextMeshProUGUI>().textInfo.lineCount);
    }
    IEnumerator x(float yInicialDoClick, Vector3 posicaoInicial){
        Vector3 pos = posicaoInicial;
        while(Input.GetButton("Fire1")){
            pos.y = posicaoInicial.y + (Camera.main.ScreenToWorldPoint(Input.mousePosition)).y - yInicialDoClick;
            transform.position = pos;
            yield return null;
        }
    }
}
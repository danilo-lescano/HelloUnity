using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlinhamentoDeTesto : MonoBehaviour{
    public TextMeshProUGUI text;
    void Start(){
        text = GetComponent<TextMeshProUGUI>();
    }
    void Update(){
        print(text.text.Length);
    }
}
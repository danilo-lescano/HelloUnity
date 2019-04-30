using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerGuilherme : MonoBehaviour{
    public TextMeshProUGUI nome, hp, mana;
    public SampleSO guilhermeSO;
    void Start(){
        guilhermeSO.Load();
    }

    void Update(){
        nome.text = guilhermeSO.npcName;
        hp.text = guilhermeSO.hp.ToString();
        mana.text = guilhermeSO.mana.ToString();
    }

    public void Save(){
        print("Save");
        guilhermeSO.Save();
    }
    public void Load(){
        print("Load");
        guilhermeSO.Load();
    }
    
    public void dano(){
        print("dano");
        guilhermeSO.hp--;
    }
    public void cura(){
        print("cura");
        guilhermeSO.hp++;
    }
    public void magia(){
        print("magia");
        guilhermeSO.mana--;
    }
    public void pocao(){
        print("pocao");
        guilhermeSO.mana++;
    }
}

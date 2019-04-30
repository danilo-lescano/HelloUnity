using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Teste/sampleSo")]
public class SampleSO : BaseScriptable{
    //os objetos aqui dentro NÃO são salvos sozinhos
    public string npcName;
    public int hp;
    public int mana;
    
    
    public string stringtype;
    public int inttype;
    public float floattype;
    public bool booltype;
    public Vector2 v2;
    public Vector3 v3;
    public string[] stringtypearr;
    public int[] inttypearr;
    public float[] floattypearr;
    public bool[] booltypearr;
    public Vector2[] v2arr;
    public Vector3[] v3arr;

/*    SampleModel sampleModel; //Esse modelo é implementado pelo programador e não é automatico
    public override void Load(){
        sampleModel = StorageData.LoadData<SampleModel>(ID);
        if(sampleModel != default(SampleModel)){
            npcName = sampleModel.npcName;
            hp = sampleModel.hp;
            mana = sampleModel.mana;
        }
        else{
            sampleModel = new SampleModel();
            sampleModel.ID = ID;
            sampleModel.npcName = npcName;
            sampleModel.hp = hp;
            sampleModel.mana = mana;
        }
    }
    public override void Save(){
        if(sampleModel != default(SampleModel)){
            sampleModel = new SampleModel();
            sampleModel.ID = ID;
            sampleModel.npcName = npcName;
            sampleModel.hp = hp;
            sampleModel.mana = mana;
        }
        sampleModel.Save<SampleModel>();
    }*/
}

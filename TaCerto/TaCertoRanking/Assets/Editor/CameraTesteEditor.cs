using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

[CustomEditor(typeof(CameraTeste), true)]
public class CameraTesteEditor : Editor {
    private CameraTeste myTarget;

    void OnEnable(){
        myTarget = (CameraTeste) target;
    }

    public override void OnInspectorGUI(){
        base.OnInspectorGUI();

        if(GUILayout.Button("jump camera")){
            myTarget.x = !myTarget.x;
            Vector3 p = myTarget.gameObject.transform.position;
            if(myTarget.x)
                p.y = 10.67f;
            else
                p.y = 0;
            myTarget.gameObject.transform.position = p;
        }
    }
}
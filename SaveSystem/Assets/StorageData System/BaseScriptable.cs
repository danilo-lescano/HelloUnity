using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BaseScriptable : ScriptableObject{
    public string ID;

    public BaseModel ListValue { get; set; }
    public void Save(){
        StringVariable sv = new StringVariable();
        sv.value = "thais é maravilhosa";
        ListValue.ListValue.Add(sv);
        StorageData.SaveData(ListValue, ID);
    }
    public void Load(){
        // Get the type of FieldsClass.
        Type fieldsType = this.GetType();

        // Get an array of FieldInfo objects.
        FieldInfo[] fields = fieldsType.GetFields(BindingFlags.Public 
            | BindingFlags.Instance);
        // Display the values of the fields.
        Debug.Log("Displaying the values of the fields of :" + fieldsType);
        for(int i = 0; i < fields.Length; i++)
        {
            Debug.Log(fields[i].Name + " : " + fields[i].GetValue(this) + " : " + fields[i].ReflectedType + " : " + fields[i].FieldType);
        }
        ListValue = StorageData.LoadData(ID);
    }

    private void AddValueToList(FieldInfo f){
        if(f.FieldType.ToString() == "System.String"){

        }
        else if(f.FieldType.ToString() == "System.Int32"){

        }
        else if(f.FieldType.ToString() == "System.Single"){

        }
        else if(f.FieldType.ToString() == "System.Boolean"){

        }
        else if(f.FieldType.ToString() == "System.String[]"){

        }
        else if(f.FieldType.ToString() == "System.Int32[]"){

        }
        else if(f.FieldType.ToString() == "System.Single[]"){

        }
        else if(f.FieldType.ToString() == "System.Boolean[]"){

        }
        else if(f.FieldType.ToString() == "UnityEngine.Vector2"){

        }
        else if(f.FieldType.ToString() == "UnityEngine.Vector3"){

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class salida : MonoBehaviour
{
	void Update(){
    	if(Input.GetKeyDown(KeyCode.K)){
    		Cambio();
    	}
    }
    void Cambio(){
    	Application.Quit();
    }
}

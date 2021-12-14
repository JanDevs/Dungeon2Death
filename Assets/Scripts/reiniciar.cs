using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class reiniciar : MonoBehaviour
{

    // Start is called before the first frame update
    void Update(){
    	if(Input.GetKeyDown(KeyCode.J)){
    		Cambio();
    	}
    	
    }
    void Cambio(){
    	SceneManager.LoadScene("SampleScene");
    }
}

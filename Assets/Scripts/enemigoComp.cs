using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigoComp : MonoBehaviour
{
  public Camera cam1;
  public Camera cam2;
	
	private void OnCollisionEnter2D(Collision2D other){	    
       	print("Asndasd");
       	if(this.name == "Slime" ){
       		Destroy(this.gameObject);
          	SceneManager.LoadScene("Combate", LoadSceneMode.Additive);
       	}else if(this.name == "Slime2"){
       		Destroy(this.gameObject);
          	SceneManager.LoadScene("Combate", LoadSceneMode.Additive);
       	}else if(this.name == "SlimeMuerte"){
          Destroy(this.gameObject);
          SceneManager.LoadScene("Combate2", LoadSceneMode.Additive);
        }
       //SceneManager.LoadScene("otro"); 
       
    }    


}


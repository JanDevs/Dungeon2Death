using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemigoComp : MonoBehaviour
{
	
	private void OnCollisionEnter2D(Collision2D other){	    
       	print("Asndasd");
       	if(this.name == "Slime" || this.name == "SlimeMuerte"){
       		Destroy(this.gameObject);
       	}else if(this.name == "Slime2"){
       		Destroy(GameObject.Find("Cuadro"));
       		Destroy(this.gameObject);
       	}
       //SceneManager.LoadScene("otro"); 
       
    }    

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compObjeto : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;
	public Sprite nimagen; 

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other){	    
       print("Cofre");
      	if(this.name == "Cofre"){
       		spriteRenderer.sprite = nimagen;
       	}else if(this.name == "Cofre2"){
       		spriteRenderer.sprite = nimagen;
       		Destroy(GameObject.Find("Cuadro"));
       	}
       //SceneManager.LoadScene("otro"); 
       
    }
    
}

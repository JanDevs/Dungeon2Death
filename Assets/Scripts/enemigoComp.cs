using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemigoComp : MonoBehaviour
{

	private void OnCollisionEnter2D(Collision2D other){
        
       print("Asndasd");
       //SceneManager.LoadScene("otro"); 
       Destroy(this.gameObject);
    }    

}


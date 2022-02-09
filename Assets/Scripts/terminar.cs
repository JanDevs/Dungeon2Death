using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class terminar : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other){	    
       SceneManager.LoadScene("Pantalla de Victoria");
       //SceneManager.LoadScene("otro"); 
       
    }
}

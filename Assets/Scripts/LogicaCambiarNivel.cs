using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaCambiarNivel : MonoBehaviour
{
    // Start is called before the first frame update
    public bool pasarNivel;
    public int indiceNivel;
    public AudioSource Enter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) || pasarNivel)
            CambiarNivel(indiceNivel);
    }

    public void CambiarNivel(int indice)
    {
        //GetComponent<AudioSource>().Play();
        Enter.Play();
        SceneManager.LoadScene(indice);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Boton : MonoBehaviour
{
    public Color[] colors;
    public Image buttonImage;
    public bool select=false;
    public int position2;
    public static Boton Instance;
    public UnityEvent testEvent;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        buttonImage = GetComponent<Image>();
        buttonImage.color = colors[0];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(select){
            buttonImage.color = colors[1];
        }else{
            buttonImage.color = colors[0];
        }

        if(Input.GetKeyDown(KeyCode.J) && select){
            StartCoroutine (TestEventDemo() );
        }
    }

    IEnumerator TestEventDemo(){
        yield return new WaitForSeconds(0f);
        testEvent.Invoke ();
    }
}


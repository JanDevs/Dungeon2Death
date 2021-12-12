using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsM : MonoBehaviour
{
    public Boton[] buttons;
    public int position=0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)){
            buttons[position].select = false;
            position++;

            if(position<0){
                position = buttons.Length -1;
                buttons[position].select = true;
                buttons[position].position2=position;
                return;
            }

            if(position > buttons.Length-1){
                position = 0;
                buttons[position].select = true;
                buttons[position].position2=position;
                return;
            }

            buttons[position].select = true;
        }

        if(Input.GetKeyDown(KeyCode.A)){
            buttons[position].select = false;
            position--;

            if(position<0){
                position = buttons.Length -1;
                buttons[position].select = true;
                buttons[position].position2=position;
                return;
            }

            if(position >= buttons.Length-1){
                position = 0;
                buttons[position].select = true;
                buttons[position].position2=position;
                return;
            }

            buttons[position].select = true;
            buttons[position].position2=position;
        }

    }
}

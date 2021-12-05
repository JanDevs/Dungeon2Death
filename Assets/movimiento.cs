using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    // Start is called before the first frame update
 	public float vel = 0.3f;

 	public Rigidbody2D rb;

 	Vector2 mov;


    // Update is called once per frame
    void Update()
    {
        //Input
        mov.x = Input.GetAxisRaw("Horizontal");
        mov.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate(){

    	//Movimiento
    	rb.MovePosition(rb.position + mov * vel * Time.fixedDeltaTime);

    }
}

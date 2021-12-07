using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movimiento : MonoBehaviour
{
    // Start is called before the first frame update
 	public float vel = 2f;

 	public Rigidbody2D rb;

 	Vector2 mov;

 	public Animator animator;
    // Update is called once per frame
    void Update()
    {
    	Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
    	animator.SetFloat("Horizontal", movement.x);
    	animator.SetFloat("Vertical", movement.y);
    	animator.SetFloat("Magnitud", movement.magnitude);
        //Input
        mov.x = Input.GetAxisRaw("Horizontal");
        mov.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate(){

    	//Movimiento
    	rb.MovePosition(rb.position + mov * vel * Time.fixedDeltaTime);

    }

      

}

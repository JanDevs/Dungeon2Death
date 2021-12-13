using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimate : MonoBehaviour
{
    
    void Start()
    {
        startJumping();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startJumping()
    {
        transform.LeanMoveLocal(new Vector2(273,40),2).setEaseOutQuart().setLoopPingPong();
    }
}

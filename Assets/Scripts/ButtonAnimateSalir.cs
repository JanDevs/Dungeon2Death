using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimateSalir : MonoBehaviour
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
        transform.LeanMoveLocal(new Vector2(240, -20), 2).setEaseOutQuart().setLoopPingPong();
    }
}

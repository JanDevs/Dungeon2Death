using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [Range(1f, 20F)]
    public float ScrollSpeed = 1;
    public float scrollOfset;
    Vector2 StartPos;
    float NawPos;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        NawPos = Mathf.Repeat(Time.time * -ScrollSpeed, scrollOfset);
        transform.position = StartPos + Vector2.right * NawPos;
    }
}

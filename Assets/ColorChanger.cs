using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public TrailRenderer trail;
    public SpriteRenderer rend;
    public Color color;
    public float forward;
    public float reverse;
    public float turnleft;
    public float turnright;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        basics();
        turbo();
    }
    void basics()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-forward * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(reverse * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, turnleft * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -turnright * Time.deltaTime);
        }
    }
    void turbo()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            forward = 10;
            trail.endColor = new Color(1, 0, 1);
            trail.startColor = new Color(0, 1, 1);
            trail.emitting = true;
            rend.color = new Color(0, 1, 1);
        }
        else
        {
            forward = 5;
            trail.emitting = false;
            rend.color = new Color(1, 1, 1);
        }
    }
}

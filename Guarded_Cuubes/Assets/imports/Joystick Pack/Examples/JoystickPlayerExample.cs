using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour {
    public float speed;
    public FloatingJoystick floatingJoystick;
    public Rigidbody rb;
    private CharacterController controller;
    private Vector3 playerVelocity;

    void Start() {
        rb.GetComponent<Rigidbody>();
    }


    public void FixedUpdate() {
        Vector3 direction = Vector3.forward * floatingJoystick.Vertical + Vector3.right * floatingJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    void Update() {
        float hoz = floatingJoystick.Horizontal;
        float ver = floatingJoystick.Vertical;

        Vector3 direction = new Vector3(hoz, 0, ver);
        rb.transform.Translate(direction * 0.02f, Space.Self);

        //Vector3 ldir = new Vector3(ver, hoz, 0);
        //rb.transform.Rotate(ldir * 1f, Space.World);
    }
}
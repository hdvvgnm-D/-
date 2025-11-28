using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void FixedUpdate()
    {
        HandleTranslate();
        HandleRotate();
    }
    public float speed = 10;
    void HandleTranslate()
    {
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed,Space.Self);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.back * Time.fixedDeltaTime * speed, Space.Self);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.left * Time.fixedDeltaTime * speed, Space.Self);
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.right * Time.fixedDeltaTime * speed, Space.Self);
        if (Input.GetKey(KeyCode.Space)) transform.Translate(Vector3.up * Time.fixedDeltaTime * speed, Space.Self);
    }
    void HandleRotate()
    {
        if (Input.GetKey(KeyCode.Q))transform.Rotate(Vector3.down);
        if (Input.GetKey(KeyCode.E))transform.Rotate(Vector3.up);
    }
}

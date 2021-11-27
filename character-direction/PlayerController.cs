using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float thrust = 1.0f;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.localScale = new Vector3(1, 1, 1);
            rb2D.AddForce(transform.right * thrust);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.localScale = new Vector3(-1, 1, 1);
            rb2D.AddForce(-transform.right * thrust);
        }

    }
}

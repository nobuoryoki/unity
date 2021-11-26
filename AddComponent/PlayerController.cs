using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            if (GetComponent<Rigidbody2D>() != null) {
                Destroy(GetComponent<Rigidbody2D>());
            }
        };

        if (Input.GetKey(KeyCode.DownArrow)) {
            if (GetComponent<Rigidbody2D>() == null) {
                rb2D = gameObject.AddComponent<Rigidbody2D>();
            }
        };
    }
}

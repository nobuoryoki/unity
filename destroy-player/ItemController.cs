using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = transform.position - this.player.transform.position;
        if (v.magnitude < 0.5f) {
            Destroy(gameObject);
        }
    }
}

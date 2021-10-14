using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballPrefab;

    void Start()
    {
        for (int i = 0; i < 5; i++) {
            Instantiate (
                ballPrefab, 
                new Vector3(i, 0, 0), 
                Quaternion.identity
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

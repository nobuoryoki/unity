using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGenerator : MonoBehaviour
{
    public GameObject boxPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++) {
            Instantiate(
                boxPrefab, 
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

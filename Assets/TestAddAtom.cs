using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMol.API;


public class TestAddAtom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            APIPython.AddAtom("H");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_HitBox : MonoBehaviour
{

    public OpenCVForUnityExample.Script_spell unScript; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        unScript.booValid1 = true; 
    }
}

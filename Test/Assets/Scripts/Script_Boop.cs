using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.UnityUtils.Helper;
using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnityExample
{
    public class Script_Boop : MonoBehaviour
    {
        public GameObject gameObj;
        RectTransform rectForm;
        Point monpoint;

        Vector3 vec;
        public Script_MainScene unScript;
        int nbdoigts;  
        Slider unslide; 
        // Start is called before the first frame update
        void Start()
        {
            rectForm = GetComponent<RectTransform>();
            unslide = unScript.threasholdSlider;
            unslide.value = 14600; 
            Debug.Log(unslide.value);
            
        } 

        // Update is called once per frame
        void Update()
        {
                nbdoigts = unScript.nbFinger;
                
                if(nbdoigts < 3){
                    monpoint = new Point();
                    
                }
                else{
                    monpoint = unScript.monPoint;
                    monpoint.y = (unScript.monPoint.y);
                }
                
                vec = transform.position;
                vec.x = (float)monpoint.x;
                vec.y = (float)monpoint.y;
                transform.position = vec;
                Debug.Log(monpoint);
            }
    }
}
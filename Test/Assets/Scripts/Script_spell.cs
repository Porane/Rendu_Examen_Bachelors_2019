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

namespace OpenCVForUnityExample{
    public class Script_spell : MonoBehaviour
{
    public GameObject camera;
    
    Point unPoint; 

    public bool booValid1;
    public bool booValid2;

    bool quit; 

    public Sprite sucess;
    public Sprite fail; 

    public GameObject spell; 

    // Start is called before the first frame update
    void Start()
    {
        booValid1 = false;
        booValid2 = false; 
        quit = false;

        int choixPersoSpells = PlayerPrefs.GetInt("temp");
    }

    bool isValid(Point lePoint){

        float x = (float)unPoint.x;

        if(x < 200 && !booValid1 && !booValid2) {
            booValid1 = true; 
            GameObject.Find("Trace_spell_sucess").GetComponent<SpriteRenderer>().sprite = this.sucess;  
        }
        if(x > 500 && booValid1 && !booValid2)
        {
            booValid2 = true;
            GameObject.Find("Trace_spell_sucess").GetComponent<SpriteRenderer>().sprite = this.sucess;  
        }
        if(booValid1 && booValid2){
            quit = true;
            return true;
        }

        Debug.Log("Le preshot : 200 ");
        Debug.Log("Le x " +  x);
        Debug.Log("Le bool 1 : " + booValid1);
        Debug.Log("Le preshot 2  450: ");
        Debug.Log("Le x 2 " +  x);
        Debug.Log("Le bool 2 : " + booValid2);  
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        unPoint = camera.GetComponent<Script_MainScene>().monPoint;
        
        if(isValid(unPoint) && quit){
            Camera.main.orthographicSize = 5;
            camera.SetActive(false);
            Camera.main.orthographicSize = 5;
            GameObject.Find("BarreVieEnnemi").SetActive(true);
            GameObject.Find("BarreVie").SetActive(true);
            GameObject.Find("Trace_spell_sucess").SetActive(false);

            if(choixPersoSpells == 1)
            {
                GetComponent<Animator>().SetFloat("choixPersos", choixPersoSpells);
            }
            else if(choixPersoSpells == 2)
            {
                GetComponent<Animator>().SetFloat("choixPersos", choixPersoSpells);
            }
            else{
                GetComponent<Animator>().SetFloat("choixPersos", choixPersoSpells);
            }
            quit = false; 
        }
    }

    }
}
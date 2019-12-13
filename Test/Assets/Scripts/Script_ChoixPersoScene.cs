using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_ChoixPersoScene : MonoBehaviour
{
    public int choix;
    public int temp;

    public void OnPushReturnButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void OnPushWarriorButton()
    {
        Debug.Log("Choix : Guerrier");
        choix = 1;
    }

    public void OnPushThiefButton()
    {
        Debug.Log("Choix : Voleur");
        choix = 2;
    }

    public void OnPushWizardButton()
    {
        Debug.Log("Choix : Mage");
        choix = 3;
    }

    public void OnPushFightButton()
    {
        if(choix != 0)
        {
            Debug.Log("Début du combat en tant que : ");
            
            if(choix == 1)
            {
                Debug.Log("Guerrier");
            }
            else if(choix == 2)
            {
                Debug.Log("Voleur");
            }
            else if(choix == 3)
            {
                Debug.Log("Mage");
            }
            else
            {
                Debug.Log("ERREUR");
            }
            PlayerPrefs.SetInt("temp", choix);
            SceneManager.LoadScene("FightScene");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        choix = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_FightScene : MonoBehaviour
{
    public int choixPerso;
    public GameObject Selection;
    public GameObject Victoire;

    // Start is called before the first frame update
    void Start()
    {
        Victoire = GameObject.Find("enemy");
        choixPerso = PlayerPrefs.GetInt("temp");
        if(choixPerso == 1)
        {
            GameObject.Find("PlayerCharacter").GetComponent<SpriteRenderer>().sprite = GameObject.Find("Chara_31").GetComponent<SpriteRenderer>().sprite;
        }
        else if(choixPerso == 2)
        {
            GameObject.Find("PlayerCharacter").GetComponent<SpriteRenderer>().sprite = GameObject.Find("Charb_31").GetComponent<SpriteRenderer>().sprite;
        }
        else if(choixPerso == 3)
        {
            GameObject.Find("PlayerCharacter").GetComponent<SpriteRenderer>().sprite = GameObject.Find("Charc_31").GetComponent<SpriteRenderer>().sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Victoire.GetComponent<Script_Enemy>().PV <= 0)
        {
            Debug.Log("test");
            SceneManager.LoadScene("FinScene");
        }
    }
}

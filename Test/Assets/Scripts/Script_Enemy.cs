using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_Enemy : MonoBehaviour
{
    public int PV = 3;
    public int PV_Max = 3;
    public int Largeur_Barre = 300;
    public GameObject Barre;

    // Start is called before the first frame update
    void Start()
    {
        Barre = GameObject.Find("Vie");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Modif_Hauteur = Barre.GetComponent<RectTransform>().sizeDelta;
        Modif_Hauteur.x = ((float)PV / (float)PV_Max) * Largeur_Barre;
        Barre.GetComponent<RectTransform>().sizeDelta = Modif_Hauteur;

        Vector2 Position = Barre.GetComponent<RectTransform>().anchoredPosition;
        Position.x = Modif_Hauteur.x / 2.0f - 150;
        Barre.GetComponent<RectTransform>().anchoredPosition = Position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Script_DragAndDrop : MonoBehaviour
{
    public bool selected = false;
    public bool dragbox = false;

    public GameObject gameObject; 

    public GameObject Imgspell;

    public GameObject Vie_Ennemi;

    private void OnMouseDrag()
    {
        selected = true;
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DragDrop"))
        {
            dragbox = true;
        }
    }

    public void OnMouseUp()
    {
        if (selected == true && dragbox == true)
        {
            Vie_Ennemi.GetComponent<Script_Enemy>().PV -= 1;
        }
        selected = false;
        dragbox = false;
        transform.position = new Vector2(0, -3.5f);
        gameObject.SetActive(true);
        Imgspell.SetActive(true);

        GameObject.Find("BarreVieEnnemi").SetActive(false);
        GameObject.Find("BarreVie").SetActive(false);

    }

    // Start is called before the first frame update
    void Start()
    {
        Vie_Ennemi = GameObject.Find("enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

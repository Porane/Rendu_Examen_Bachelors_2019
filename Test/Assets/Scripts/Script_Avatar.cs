using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Script_Avatar : MonoBehaviour
{
    public bool isJumping;
    void Jump()
    {
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Z)) && !isJumping)
        {
            isJumping = true;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sol"))
        {
            isJumping = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;

        position.x = position.x + 1.5f * horizontal;
        Jump();
        transform.position = position;  
    }
}

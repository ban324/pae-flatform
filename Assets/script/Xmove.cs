using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xmove : MonoBehaviour
{
    public float speed = 10;
    public float jumpforce = 10;
    public Rigidbody2D rigid2;
    public bool ong = true;
    // Start is called before the first frame update
    void Start()
    {
        rigid2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&ong == true)
        {
            rigid2.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }

        float x = Input.GetAxisRaw("Horizontal");
    
        rigid2.velocity = new Vector2(x * speed, rigid2.velocity.y); 
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ong = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        ong = false;
    }
}

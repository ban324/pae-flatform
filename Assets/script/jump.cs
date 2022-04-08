using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float speed = 5f;
    public int Tch = 1;
    public float jumpforce = 100000000;
    public Rigidbody2D rigid2;
    // Start is called before the first frame update
    void Start()
    {
        rigid2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

}

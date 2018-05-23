using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    //速度
    public float speed = 7;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = -1;

        //移動
        Vector2 Cuthrhu = new Vector2(x,y).normalized;

        GetComponent<Rigidbody2D>().velocity = Cuthrhu * speed;
    }
}

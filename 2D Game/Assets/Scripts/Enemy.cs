using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public bool is_moveing_right = true;
    public Transform Grounddetect;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D hit = Physics2D.Raycast(Grounddetect.position, Vector2.down, 1.0f);
        if (hit.collider == false)
        {
            if (is_moveing_right == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                is_moveing_right = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                is_moveing_right = true;
            }
        }
    }

}

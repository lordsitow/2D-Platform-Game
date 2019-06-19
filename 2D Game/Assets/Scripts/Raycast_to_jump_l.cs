using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_to_jump_l : MonoBehaviour
{
    public LayerMask groundLayer;

    static public bool is_on_ground_l;
    public bool on_ground;

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }

    private void Start()
    {
        is_on_ground_l = false;
    }
    // Update is called once per frame
    void Update()
    {
        is_on_ground_l = IsGrounded();
        on_ground = is_on_ground_l;
    }
}

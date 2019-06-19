using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Raycast_to_jump_r;
using static Raycast_to_jump_l;

public class Move : MonoBehaviour
{
    public bool on_ground;
    public float move_speed;
    public float jump_height;
    

    public void back_to_menu()
    {
        SceneManager.LoadScene(0);
    }

    private Rigidbody2D rg2d;
    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (is_on_ground_l || is_on_ground_r))
        {
            rg2d.velocity = new Vector2(0, jump_height);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rg2d.velocity = new Vector2(-1 * move_speed, rg2d.velocity.y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rg2d.velocity = new Vector2(move_speed, rg2d.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetInt("last_scene", SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(9);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mover : MonoBehaviour{
    [SerializeField] float movment_speed = 10f;
    [SerializeField] float jump_velocity = 10f;
    [SerializeField] float midAir_scaler = 0.2f;
    [SerializeField] LayerMask platformLayerMask;
    [Tooltip("Time to wait before restart on death")]
    [SerializeField] public int restartWaitTime = 0;
    [Tooltip("Game horizontal limit, sets the games horizontal border that when reached will kill the player")]
    [SerializeField] public int horizontalGameBorder = -1;
    private float zero = 0f;
    private float one =1f;
    private Rigidbody2D rb2d;
    private BoxCollider2D cc2d;
    private float minSpeedForFriction = 1f;
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();
        cc2d = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        if (transform.position.y < horizontalGameBorder)
        {
            Kill();
        }
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded()){
            rb2d.velocity += new Vector2(rb2d.velocity.x,rb2d.velocity.y +jump_velocity);
        }
        if( Input.GetKey(KeyCode.A)){
            if(IsGrounded()){
                rb2d.velocity = new Vector2(-movment_speed,rb2d.velocity.y);
            }else{
                rb2d.velocity =  new Vector2(-movment_speed*midAir_scaler,rb2d.velocity.y);
            }
        }     
        if( Input.GetKey(KeyCode.D)){
            if(IsGrounded()){
                rb2d.velocity =  new Vector2(+movment_speed,rb2d.velocity.y);
            }else{
                rb2d.velocity =  new Vector2(+movment_speed*midAir_scaler,rb2d.velocity.y);
            }
        }else{
            if(IsGrounded()){
                if(rb2d.velocity.x>0){
                    rb2d.velocity =  new Vector2(rb2d.velocity.x-minSpeedForFriction,rb2d.velocity.y);
                }else rb2d.velocity =  new Vector2(rb2d.velocity.x+minSpeedForFriction,rb2d.velocity.y);
            }
        }
    }

    private bool IsGrounded(){
        RaycastHit2D ray = Physics2D.BoxCast(cc2d.bounds.center,cc2d.bounds.size,zero,Vector2.down,one,platformLayerMask);
        return ray.collider != null;
    }

    public void Kill()
    {
        Invoke("Restart", restartWaitTime);
    }

    /*
     * Restarts the game by restarting the current game scene
     */
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

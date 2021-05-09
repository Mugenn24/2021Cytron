using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class scanPlayer : MonoBehaviour
{

    public float range, speed, atk_range, atk_speed;
    public GameObject player, bulletobj;
    public Transform fp;
    public Rigidbody2D enemy;
    private float cd;
    private Rigidbody2D projectile;

    
    void Start()
    {

    }


    void FixedUpdate()
    {
        float dist = Vector2.Distance(player.transform.position, transform.position);
        if(dist < range){
            if(dist < atk_range){
                if(cd > atk_speed){
                    Debug.Log("attacking target");
                    GameObject bullet = Instantiate(bulletobj, fp.position, fp.rotation);
                    projectile = bullet.GetComponent<Rigidbody2D>();
                    projectile.AddForce(fp.up * 10f, ForceMode2D.Impulse);
                    cd = 0;
                }
                
            }
            else{
                Debug.Log("target in range");
                Vector2 targetPos = player.transform.position;
                Vector2 enemyPos = enemy.transform.position;
                enemy.position = Vector2.MoveTowards(enemy.position, targetPos, speed * Time.fixedDeltaTime);
            }


        }
        
        cd += Time.deltaTime;
        
    }

    



    // void Shoot(){
    //     GameObject bullet = Instantiate(bulletobj, firepoint.position, firepoint.rotation);
    //     Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    //     rb.AddForce(firepoint.up*bulletforce, ForceMode2D.Impulse);
    // }
}

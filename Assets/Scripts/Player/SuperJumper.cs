using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperJumper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        Debug.Log("picked up green key");
        try{
            collision.GetComponent<PlayerController>().allowedJumps=4;
        }
        catch{
            
        }
        
        GameObject.Find("GameDialog").GetComponent<GameDialog>().setDialog("SUPER JUMPER!", 3);

    }
}

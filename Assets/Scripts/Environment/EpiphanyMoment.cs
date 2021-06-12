using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpiphanyMoment : MonoBehaviour
{
    PlayerDialog playerDialog;
    public string dialogText;
    public int duration;
    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(!collider2D.gameObject.GetComponent<PlayerController>()){
            return;
        }
        playerDialog=collider2D.gameObject.GetComponent<PlayerDialog>();

        Debug.Log("epeph");
        playerDialog.setDialog(dialogText, duration);
        Destroy(gameObject);
        
    }
    
}

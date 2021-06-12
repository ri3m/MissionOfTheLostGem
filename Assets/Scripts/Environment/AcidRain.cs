using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidRain : MonoBehaviour
{
    private static int hitCount=0;
    PlayerDialog playerDialog;
    [SerializeField] public int waitCount=3;

    private void Start() {
        StartCoroutine(WaitThenDestroy());
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        
        if(collision.gameObject.GetComponent<PlayerController>()){
            playerDialog=collision.gameObject.GetComponent<PlayerDialog>();
            
            Debug.Log("hit player "+hitCount); 
            
            /* if(hitCount==1)
                playerDialog.setDialog("acid rain?!", 5); */
            if(hitCount==1)
                playerDialog.setDialog("ok now that hurt!", 5);
            else if(hitCount==2)
                playerDialog.setDialog("how do I stop this rain!", 10);
            else if(hitCount==5)
                playerDialog.setDialog("there's got to be a way to stop this rain!", 10);
            else
                playerDialog.setDialog("ouch!", 3);
            
            hitCount+=1;
        }
    }
    private IEnumerator WaitThenDestroy()
    {
        
            yield return new WaitForSeconds(waitCount);
            Destroy(gameObject);
        
        
    }
        
    
}

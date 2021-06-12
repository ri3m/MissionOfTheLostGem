using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyScore : MonoBehaviour
{
    public int amount=5;
    private void OnDestroy() {
        
        GameManager.AddScore(amount);
        try{
            GameObject.Find("GameDialog").GetComponent<GameDialog>().setDialog("+"+amount, 6);
        }catch{
            
        }
        
      
    }
}

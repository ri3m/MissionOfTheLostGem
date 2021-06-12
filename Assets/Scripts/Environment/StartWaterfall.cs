using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWaterfall : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collider2D){
        
        GameObject.Find("AcidWaterfallSpawner").GetComponent<EnemySpawner>().enabled=true;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWaterfall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        Debug.Log("picked up blue key");
        Destroy(GameObject.Find("AcidWaterfallSpawner"));
        Debug.Log("destroyed!");
        GameObject.Find("Player").GetComponent<PlayerDialog>().setDialog("now let's see if this worked!!", 6);
    }
}

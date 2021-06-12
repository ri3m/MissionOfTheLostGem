using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopAcidRain : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        Debug.Log("picked up white key");
        Destroy(GameObject.Find("AcidRainSpawner"));
        Debug.Log("destroyed!");
        /* GameObject.Find("GameDialog").GetComponent<GameDialog>().setDialog("That'll do it, thanks!", 10); */
        GameObject.Find("Player").GetComponent<PlayerDialog>().setDialog("the rain seems to have stopped, thanks!", 10);
    }
}

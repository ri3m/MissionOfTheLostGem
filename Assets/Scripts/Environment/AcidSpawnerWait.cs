using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidSpawnerWait : MonoBehaviour
{
   [SerializeField] public GameObject AcidRainSpawner;
    void Start()
    {
        AcidRainSpawner.SetActive(false);
        StartCoroutine(WaitThenStart());
    }
    private IEnumerator WaitThenStart()
    {
        
            yield return new WaitForSeconds(2);
            AcidRainSpawner.SetActive(true);
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDialog>().setDialog("where did that rain come from?", 10);
            Debug.Log("start acid rain");
        
        
    }

}

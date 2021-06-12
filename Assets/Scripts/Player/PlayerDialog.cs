using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDialog : MonoBehaviour
{
    private Text playerDialog;
    public string startDialog;
    void Start()
    {
        playerDialog=gameObject.GetComponentInChildren<Text>();
        playerDialog.text=startDialog;
        StartCoroutine(WaitThenDestroy(5));
    }
    public void setDialog(string dialog, float destryAmount){
        playerDialog.text=dialog;
        playerDialog.enabled=true;
        StartCoroutine(WaitThenDestroy(destryAmount));
    }

    private IEnumerator WaitThenDestroy(float amount)
    {
        
        yield return new WaitForSeconds(amount);
        playerDialog.enabled=false;
        
        
    }

}

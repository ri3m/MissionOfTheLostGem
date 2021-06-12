using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDialog : MonoBehaviour
{
    [SerializeField] private Text gameDialog;

    private void Start() {
        gameDialog.enabled=false;
    }
    public void setDialog(string dialog, float destryAmount){
        gameDialog.text=dialog;
        gameDialog.enabled=true;
        StartCoroutine(WaitThenDestroy(destryAmount));
    }
    private IEnumerator WaitThenDestroy(float amount)
    {
        
            yield return new WaitForSeconds(amount);
            gameDialog.enabled=false;
        
        
    }
}

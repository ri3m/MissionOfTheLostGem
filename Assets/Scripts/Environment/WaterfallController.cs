using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterfallController : MonoBehaviour
{
    static int size=1;
    private void Start() {
        StartCoroutine(WaitThenStart());
    }


    private IEnumerator WaitThenStart()
    {
        while(true){
            
            waterfallScaller();
            yield return new WaitForSeconds(1f);
            if(gameObject.transform.name!="waterfallDrop")
                Destroy(gameObject);
        }
        
    }

    private void waterfallScaller(){
        
        transform.localScale= new Vector3(size, transform.localScale.y, transform.localScale.z);
        
        if(size==5){
            size=1;
            return;
        } 
        size++;
        
    }

}

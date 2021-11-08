using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class ForEnemyDestroyOnTrigger2D : MonoBehaviour {

    
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
  
    [SerializeField] int maxTypeEnemy;


 private void OnTriggerEnter2D(Collider2D other) {
        for(int i=maxTypeEnemy;i>0;i--){
        if ((other.tag==i.ToString()||other.tag=="points")&& enabled) {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            
        }
        }
        
        
    }



    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}

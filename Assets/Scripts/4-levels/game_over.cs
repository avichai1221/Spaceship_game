using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_over : MonoBehaviour
{
        [SerializeField] int maxTypeEnemy;

   private void OnTriggerEnter2D(Collider2D other) {

        for(int i=maxTypeEnemy;i>0;i--){
        if ((other.tag==i.ToString()||other.tag=="points")&& enabled) {
            Debug.Log("Game over!");
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
        }
    }
}


 

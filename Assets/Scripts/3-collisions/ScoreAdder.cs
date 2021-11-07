using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger adding score to the score field.")]
    
    [SerializeField] NumberField scoreField;
    [SerializeField] int maxTypeEnemy;
    

    private void OnTriggerEnter2D(Collider2D other) {
        for(int i=1;i<=maxTypeEnemy;i++){
        if (other.tag == i.ToString()) {
            scoreField.AddNumber(i);
        }
        
        }
    }

    public void SetScoreField(NumberField newTextField) {
        this.scoreField = newTextField;
    }
}

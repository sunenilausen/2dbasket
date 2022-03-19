
using UnityEngine;
using UnityEngine.UI;

public class HoopScore : MonoBehaviour
{
   public GameObject ParticleEffectPrefab;
   public Text scoreText;
   public int score = 0;

   void OnTriggerEnter2D(Collider2D collider)
   {
       if (collider.gameObject.name == "Basketball")
       {
           var effect = Instantiate(ParticleEffectPrefab, this.transform);
           score = score + 1;
           scoreText.text = $"Score: {score.ToString()}";
           Destroy(effect, 2);
       }
   }
}

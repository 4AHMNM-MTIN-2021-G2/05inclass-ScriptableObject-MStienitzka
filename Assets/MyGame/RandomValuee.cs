using UnityEngine;
using UnityEngine.UI;

public class RandomValuee : MonoBehaviour
{
    public float number;
    public Text value;
    

   public void ValueButton()
   {
        number = UnityEngine.Random.value;
        value.text = number.ToString();
    }
}
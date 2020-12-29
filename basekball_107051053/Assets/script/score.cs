using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [Header("txet")]
    public Text text;
    [Header("score")]
    public int i;
    [Header("ball in")]
    public int iin;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ball")
        {
            addi();
        }

        if(other.transform.root.name == "Player")
        {
            iin = 3;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.transform.root.name == "Player")
        {
            iin = 2;
        }
    }

    private void addi()
    {
        i += iin;
        text.text = "SCORE : " + i;
    }       
}

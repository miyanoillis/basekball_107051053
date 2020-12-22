using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [Header("txet")]
    public Text text;
    [Header("score")]
    public int i;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
    }
}

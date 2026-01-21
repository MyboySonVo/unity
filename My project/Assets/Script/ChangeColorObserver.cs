using UnityEngine;

public class ChangeColorObserver : MonoBehaviour
{
    public void ChangeColor()
    {
        GetComponent<SpriteRenderer>().color = new Color(Random.value, Random.value, Random.value);
        Debug.Log(gameObject.name + " changed color!");
    }
}

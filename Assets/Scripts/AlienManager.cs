using UnityEngine;

public class AlienManager : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 2f);
    }

    private void OnMouseDown()
    {
        Debug.Log("HIT");
        Destroy(gameObject);
    }

    private void OnMouseOver()
    {
        Debug.Log("Mouse Over " + gameObject.name);
    }
}

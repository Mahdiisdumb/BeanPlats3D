using UnityEngine;
public class RandomColliderHighlight : MonoBehaviour
{
    public GameObject[] objects;
    public Color highlightColor = Color.green;
    private Color defaultColor = Color.black;
    void Start()
    {
        if (objects == null || objects.Length == 0) return;
        int randomIndex = Random.Range(0, objects.Length);
        for (int i = 0; i < objects.Length; i++)
        {
            GameObject obj = objects[i];
            BoxCollider box = obj.GetComponent<BoxCollider>();
            Renderer rend = obj.GetComponent<Renderer>();
            if (box == null || rend == null) continue;
            if (i == randomIndex)
            {
                box.enabled = true;
                if (rend.material != null)
                    rend.material.color = highlightColor;
            }
            else
            {
                box.enabled = false;
                if (rend.material != null)
                    rend.material.color = defaultColor;
            }
        }
    }
}

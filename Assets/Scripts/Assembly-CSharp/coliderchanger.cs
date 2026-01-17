using UnityEngine;
public class RandomColliderHighlight : MonoBehaviour
{
    public GameObject[] objects;
    public Color highlightColor = Color.green;
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
                Material unlitMat = new Material(Shader.Find("Unlit/Color"));
                unlitMat.color = highlightColor;
                rend.material = unlitMat;
            }
            else
            {
                box.enabled = false;
                Material darkMat = new Material(Shader.Find("Unlit/Color"));
                darkMat.color = Color.black;
                rend.material = darkMat;
            }
        }
    }
}
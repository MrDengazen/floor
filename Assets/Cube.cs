using UnityEngine;

public class Cube : MonoBehaviour
{
    private Quaternion originalposition;
    private Vector3 originalscale;
    private float i;
    private int a;
    void Awake()
    {
        Debug.Log("Awake!!!!!!!");
        originalposition = this.transform.rotation;
        originalscale = this.transform.localScale;
    }
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Euler(originalposition.x += 0.2f, originalposition.y += 0.2f, originalposition.z += 0.2f);
        if (a == 1)
        {
            i += 0.03f;
        }
        if (i > 3f)
        {
            a = 0;
        }
        if (a == 0)
        {
            i -= 0.01f;
        }
        if (i < 0f)
        {
            a = 1;
        }
        this.transform.localScale = new Vector3(originalscale.x + i, originalscale.x + i, originalscale.x + i);
    }
}

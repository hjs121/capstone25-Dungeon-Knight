using UnityEngine;

public class AttackCol : MonoBehaviour
{
    CapsuleCollider2D col;
    Vector2[] offset = {new Vector2(0.48f, 1.18f), new Vector2() };
    Vector2[] size = {new Vector2(2.6f, 1.5f), new Vector2()};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        col = GetComponent<CapsuleCollider2D>();
        col.enabled = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ColSet(int n)
    {
        col.enabled = true;
        col.offset = offset[n];
        col.size = size[n];
    }

    public void ColOff()
    {
        col.enabled = false;
    }
}


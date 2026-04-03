using UnityEngine;

public class Dropper : MonoBehaviour
{
    // reference catching
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float TimeToWait = 5f;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (Time.time > TimeToWait)
       {
          renderer.enabled = true;
        rigidbody.useGravity = true;
       }
    }
}

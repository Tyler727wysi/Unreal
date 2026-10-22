using UnityEngine;
using UnityEngine.EventSystems;

public class enemysSpiderMovement : MonoBehaviour
{
    public float spooderSpeed = 1;
    Transform spooderTransfrom;
    Vector3 spooderPosition;

    void Start()
    {
        spooderTransfrom = this.gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 spooderPosition = transform.right;
        spooderTransfrom.Translate(spooderPosition * spooderSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        spooderPosition = Vector3.Reflect(spooderPosition, other.GetContact(0).normal);
    }
}   
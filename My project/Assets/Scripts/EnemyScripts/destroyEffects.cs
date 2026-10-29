using UnityEngine;

public class destroyEffects : MonoBehaviour
{
    [SerializeField] private float delay = 1;
    
    void Start()
    {
        Destroy(this.gameObject, delay);
    }

}

using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    PowerUpData speedboost = new PowerUpData("speedboost", 20f);
    PowerUpData invincibility = new PowerUpData("invincibility", 10f);
    private void Start()
    {
        Debug.Log(speedboost.powerName + ": " + speedboost.duration);
        Debug.Log(invincibility.powerName + ": " + invincibility.duration);
    }

}

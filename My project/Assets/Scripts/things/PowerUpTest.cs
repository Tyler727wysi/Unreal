using Unity.VisualScripting;

public class PowerUpData
{
    public string powerName;
    public float duration;

    public PowerUpData(string newPower, float setDuration)
    {
        powerName = newPower;
        duration = setDuration;
    }
}


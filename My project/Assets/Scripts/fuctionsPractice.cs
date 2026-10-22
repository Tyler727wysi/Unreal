using UnityEngine;

public class fuctionsPractice : MonoBehaviour
{
    int coins = 0;
    void Start()
    {
        TakeDamage(3, 5);
        CollectCoin(0, 0);
        
    }

    void TakeDamage(int damage1, int damage2)
    {
        int damage = damage1 * damage2;
        Debug.Log("Player took" + damage + "damage");
    }

    int CollectCoin(int coinCount, int coinTotal)
    {
        int coins = coinCount + coinTotal;
        return coins;
    }
}

using UnityEngine;

public class whileLoopPractice : MonoBehaviour

{
    int enemyHP = 100;
    int playerDamage = 0;
    
    void Start()
    {
        while(enemyHP > 0)
        {
            playerDamage = Random.Range(1, 6);
            enemyHP -= playerDamage;
            Debug.Log("Player dealt" + playerDamage + "damage");
            Debug.Log("Enemy has" + enemyHP + "HP left");
        }

        if (enemyHP <= 0)
        {
            Debug.Log("YIPPIE!!!");
        }
    }
}

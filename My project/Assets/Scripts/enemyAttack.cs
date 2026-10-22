using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    Transform player;
    Transform enemy;
    float playerDistance;
    healthManager health;
    [SerializeField] private GameObject combust;

    void Start()
    {
        health = FindAnyObjectByType<healthManager>();
        player = GameObject.Find("Player").GetComponent<Transform>();
        enemy = this.gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        playerDistance = Vector3.Distance(player.position, enemy.position);

        if (playerDistance <= 0.95f)
        {
            combust.transform.parent = null;
            combust.SetActive(true);
            Destroy(this.gameObject);
            health.health -= 2;
            Debug.Log(health.health);
        }
    }
}

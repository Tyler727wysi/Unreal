using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Collectable : MonoBehaviour

{
    Transform playerTransform;
    Transform collectableTransform;
    float distanceToPlayer;
    scoreManager scoreManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = FindAnyObjectByType<scoreManager>();
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        collectableTransform = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(playerTransform.position, collectableTransform.position);

        if (distanceToPlayer <= 0.5f)
        {
            Destroy(this.gameObject);
            scoreManager.score += 1;
            Debug.Log(scoreManager.score);
        }
    }
}
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    LifeManager lifeManager;
    public float lifeGain;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lifeManager = FindAnyObjectByType<LifeManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Yes");
        if(lifeManager.currentLife < lifeManager.maxLife)
        {
            Destroy(gameObject);
            lifeManager.currentLife += lifeGain;
        }
    }
}

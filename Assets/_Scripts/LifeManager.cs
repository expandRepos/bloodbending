using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifeManager : MonoBehaviour
{
    public float currentLife;
    public float maxLife;
    public float drain;
    public Image filledImage;
    public TMP_Text currentLifeText; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLife();
    }

    public void UpdateLife() 
    {
        filledImage.fillAmount = Mathf.Clamp(currentLife/maxLife,0,1);

        currentLife -= drain * Time.deltaTime;
        currentLifeText.SetText(Mathf.Round(currentLife) + " / " + maxLife); 
    }


}

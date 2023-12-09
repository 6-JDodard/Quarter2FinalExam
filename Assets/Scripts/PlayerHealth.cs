using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    private float health;
    private float lerpTimer;
    public float maxHealth = 100;
    public float chipSpeed = 2f;
    public Image FrontofHealthBar;
    public Image BackofHealthBar;
    // Start is called before the first frame update
    void Start()
    {
       health = maxHealth; 
    }

    // Update is called once per frame
    void Update()
    {
      health = Mathf.Clamp(health, 0, maxHealth);
      UpdateHealthUI();
   
    }
    public void UpdateHealthUI()
    {
        Debug.Log(health);
        float fillF = FrontofHealthBar.fillAmount;
        float fillB = BackofHealthBar.fillAmount;
        float hFraction = health / maxHealth;
        if(fillB > hFraction)
        {
            FrontofHealthBar.fillAmount = hFraction;
            BackofHealthBar.color = Color.red;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer/chipSpeed;
            BackofHealthBar.fillAmount = Mathf.Lerp(fillB, hFraction, percentComplete);
        }
    }

    public void TakeDamage(float damage) 
    {
     health -= damage;
     lerpTimer = 0f;
    }

}

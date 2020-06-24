using UnityEngine;
using UnityEngine.UI;

public class FoxHealth : MonoBehaviour 
{
	public float CurrentHealth {get; set;}
	public float TotalHealth {get; set;}

	public Slider healthBar;

	void Start()
	{
		TotalHealth = 100f;
		CurrentHealth = TotalHealth;

		healthBar.value = CalculateHealth();
	}

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Z))
		{
			DealDamage(6);
		}
//		Debug.Log(CurrentHealth);
	}

	void DealDamage(float dmgValue)
	{
		CurrentHealth -= dmgValue;
		healthBar.value = CalculateHealth();
		
		if (CurrentHealth <= 0)
		{
			Die();
		}
	}

	float CalculateHealth()
	{
		return CurrentHealth / TotalHealth;
	}
	
	void Die()
	{
		CurrentHealth = 0;
		Debug.Log("You failed.");
	}
}

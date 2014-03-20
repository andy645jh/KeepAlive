using UnityEngine;
using System.Collections;

public class Pistol : Weapon{

	private const int MAXIMUM_MAGAZINE_CAPACITY = 10;
	private const int INITIAL_AMMO = 30;
	private const float SPEED_RELOAD = 3.0f;
	private const float RATE_OF_FIRE = 0.5f;

	public Pistol()
	{
		magazineCapacity = MAXIMUM_MAGAZINE_CAPACITY;
		ammo = INITIAL_AMMO;
		speedReload = SPEED_RELOAD;
		rateOfFire = RATE_OF_FIRE;
	}


}

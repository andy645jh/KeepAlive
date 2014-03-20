using UnityEngine;
using System.Collections;

public class BossEnemy : Enemy {

	private const float MAXIMUM_HIT_POINTS = 20;
	private const float MAXIMUM_SPEED_MOVEMENT = 5;
	private const float MAXIMUM_DAMAGE = 15;
	private const float	MAXIMUN_SPEED_ATTACK = 5;
	
	
	public BossEnemy()
	{
		hitPoints = MAXIMUM_HIT_POINTS;
		speedMovement = MAXIMUM_SPEED_MOVEMENT;
		damage = MAXIMUM_DAMAGE;
		speedAttack = MAXIMUN_SPEED_ATTACK;
	}

}

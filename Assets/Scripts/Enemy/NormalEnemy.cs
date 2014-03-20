using UnityEngine;
using System.Collections;

public class NormalEnemy : Enemy {

	private const float MAXIMUM_HIT_POINTS = 3;
	private const float MAXIMUM_SPEED_MOVEMENT = 5;
	private const float MAXIMUM_DAMAGE = 3;
	private const float	MAXIMUN_SPEED_ATTACK = 3;
	
	
	public NormalEnemy()
	{
		hitPoints = MAXIMUM_HIT_POINTS;
		speedMovement = MAXIMUM_SPEED_MOVEMENT;
		damage = MAXIMUM_DAMAGE;
		speedAttack = MAXIMUN_SPEED_ATTACK;
	}

}

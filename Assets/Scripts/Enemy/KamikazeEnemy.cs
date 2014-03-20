using UnityEngine;
using System.Collections;

public class KamikazeEnemy : Enemy {

	private const float MAXIMUM_HIT_POINTS = 1;
	private const float MAXIMUM_SPEED_MOVEMENT = 10;
	private const float MAXIMUM_DAMAGE = 8;
	private const float	MAXIMUN_SPEED_ATTACK = 0.5f;
	
	
	public KamikazeEnemy()
	{
		hitPoints = MAXIMUM_HIT_POINTS;
		speedMovement = MAXIMUM_SPEED_MOVEMENT;
		damage = MAXIMUM_DAMAGE;
		speedAttack = MAXIMUN_SPEED_ATTACK;
	}
}

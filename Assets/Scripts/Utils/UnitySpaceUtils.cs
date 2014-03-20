using UnityEngine;
using System.Collections;


     /*! @class UnitySpaceUtils
	  *  @brief Manages of the game size, ratio and screen adaptations
	  */
public class UnitySpaceUtils
{
	public const float DESIGN_WIDTH = 2048; //Max game Width
	public const float DESIGN_HEIGTH = 1536; //Max game Height
	public const float DESIGN_ASPECT_RATIO = 4.0f / 3.0f; // The game is designed in an 4/3 ratios (the same as actual Ipads)


	 /*! @fn float UnitySpaceUtils:getWidthRatio
	      *  @brief Calculates the ratio between the design width and the screen width of the device the game is running on
	      *  @return a float: Width ratio
	      */
	public static float getWidthRatio ()
	{
	    return Screen.width / DESIGN_WIDTH;
	}


	 /*! @fn float UnitySpaceUtils:getUseableHeigth
	      *  @brief Calculates the game vertical visible size of the Unity Space in the current device screen 
	      *  @return a float: Usable (visible) vertical space
	      */
	public static float getUseableHeigth ()
	{
	 
	    return (DESIGN_WIDTH / Camera.main.aspect);
	}


		 /*! @fn float UnitySpaceUtils:getUseableHeigthHalf
	      *  @brief Calculates the game vertical visible half size of the Unity Space in the current device screen 
	      *  @return a float: Usable (visible) vertical space half
	      */
	public static float getUseableHeigthHalf ()
	{
	 
	    return (DESIGN_WIDTH / Camera.main.aspect / 2);
	}


	 /*! @fn float UnitySpaceUtils:getHeigthLost
	      *  @brief Calculates the game vertical NON visible size of the Unity Space in the current device screen
	      *  there is a space lost due to the adjust from the original game ratio to the device ratio
	      *  @return a float: Vertical lost space
	      */
	public static float getHeigthLost ()
	{
	 
	    return (DESIGN_HEIGTH - getUseableHeigth ());
	}


		 /*! @fn float UnitySpaceUtils:getHeigthLostHalf
	      *  @brief Calculates the game vertical NON visible half size of the Unity Space in the current device screen
	      *  there is a space lost due to the adjust from the original game ratio to the device ratio
	      *  @return a float: Vertical lost half space
	      */
	public static float getHeigthLostHalf ()
	{         
	    return (DESIGN_HEIGTH - getUseableHeigth ()) / 2;
	}
}

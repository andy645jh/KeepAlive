using UnityEngine;
using System.Collections;


    /*! @class MainCamera extends MonoBehaviourBTG
  *  @brief Class that adjusts the size and type of the camera according to the aspect ratio of each device.
  */
public class MainCamera : MonoBehaviour
{    
	private float _ratioWidth;
	private float _sizeCamara;   

	/*! fn void MainCamera.Start()
	* 
	* Calculates the proper size and aspect ratio for the camera
	* */
	void Start ()
	{
	    camera.orthographic = true;
	 
	    // Calculates Aspect Ratio       
	    _ratioWidth = UnitySpaceUtils.getWidthRatio ();                  
	    _sizeCamara = (Screen.height / 2) / _ratioWidth;     
	 
	    Camera.main.orthographicSize = _sizeCamara;
	}
}

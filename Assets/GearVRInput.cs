using UnityEngine;
using System.Collections;

public class GearVRInput : MonoBehaviour 
{
	static public float GetAxisX;
	static public float GetAxisY;

	bool mouseDown = false;
	Vector3 mousePosition;
	bool MovingDirectionLockedToX;
	bool MovingDirectionLockedToY;


	void Update()
	{
		if (Input.GetMouseButtonDown(0) && mouseDown == false)
		{
			// Initial Press
			GetAxisX = GetAxisY = 0f;
			MovingDirectionLockedToX = false;
			MovingDirectionLockedToY = false;
			mousePosition = Input.mousePosition;
			mouseDown = true;
		}
		else if (Input.GetMouseButtonUp(0) && mouseDown)
		{
			// Released
			GetAxisX = GetAxisY = 0f;
			MovingDirectionLockedToX = false;
			MovingDirectionLockedToY = false;
			mouseDown = false;
		}
		else if (mouseDown)
		{
			// Detect Axis Movement
			Vector3 newMousePosition = Input.mousePosition;
			Vector3 deltaMousePosition = mousePosition - newMousePosition;

			float x = deltaMousePosition.x > 5 ? 1f : (deltaMousePosition.x < -5 ? -1f : 0);
			float y = deltaMousePosition.y > 5 ? 1f : (deltaMousePosition.y < -5 ? -1f : 0);

			// which direction do we care about ?
			if (MovingDirectionLockedToX == false && MovingDirectionLockedToY == false && (Mathf.Abs (x) > 0 || Mathf.Abs (y) >  0))
			{
				if (Mathf.Abs ( deltaMousePosition.x) > Mathf.Abs( deltaMousePosition.y))
			    {
					MovingDirectionLockedToX= true;
				}
				else
				{
					MovingDirectionLockedToY= true;
				}
			}

			if (MovingDirectionLockedToX && Mathf.Abs (x) > 0)
			{
				GetAxisX = x;
			}
			if (MovingDirectionLockedToY && Mathf.Abs (y) > 0)
			{
				GetAxisY = y;
			}
			mousePosition = newMousePosition;
		}
	}
}

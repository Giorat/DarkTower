using System;
using UnityEngine;

public class VReyecaster : MonoBehaviour {


			private Vector3 cordHit;
	
	        [SerializeField] private Transform m_Camera;
	        [SerializeField] private LayerMask m_ExclusionLayers;           // Layers to exclude from the raycast.
	        [SerializeField] private bool m_ShowDebugRay = true;                   // Optionally show the debug ray.
	         private float m_DebugRayLength = 5f;           // Debug ray length.
	         private float m_DebugRayDuration = 1f;         // How long the Debug ray will remain visible.
	         private float m_RayLength = 500f;              // How far into the scene the ray is cast.

	        private void Update()
	        {
	            EyeRaycast(); 
	        }

	public Vector3 hitPoint()
	{
		Debug.Log("H:"+cordHit);
		return cordHit;
	}
	
	
	        private void EyeRaycast()
	        {
	            // Show the debug ray if required
	            if (m_ShowDebugRay)
	            {
	                Debug.DrawRay(m_Camera.position, m_Camera.forward * m_DebugRayLength, Color.blue, m_DebugRayDuration);
	            }

	            // Create a ray that points forwards from the camera.
	            Ray ray = new Ray(m_Camera.position, m_Camera.forward);
	            RaycastHit hit;

	            // Do the raycast forweards to see if we hit an interactive item
	            if (Physics.Raycast(ray, out hit, m_RayLength, ~m_ExclusionLayers))
	            {
				cordHit = hit.point;
				Debug.Log("VH:"+cordHit);
	            }
	        }


	      
	    }
	
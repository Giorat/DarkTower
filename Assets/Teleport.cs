// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

using System.Collections;
using UnityEngine.EventSystems;


[RequireComponent(typeof(Collider))]
public class Teleport : MonoBehaviour {
  

  public GameObject camera;
  private VReyecaster cameraEyeCast;
  

  void Start()
  {
    cameraEyeCast = camera.GetComponent<VReyecaster>();
  }

  public void Recenter() {
#if !UNITY_EDITOR
    GvrCardboardHelpers.Recenter();
#else
    GvrEditorEmulator emulator = FindObjectOfType<GvrEditorEmulator>();
    if (emulator == null) {
      return;
    }
    emulator.Recenter();
#endif  // !UNITY_EDITOR
  }

  public void TeleportRandomly()
  {
    Debug.Log("click");
    transform.position = cameraEyeCast.hitPoint();
    transform.position = new Vector3 (transform.position.x, transform.position.y + 1.4f, transform.position.z);
    
  }
}

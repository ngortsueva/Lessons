using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    [SerializeField] private GameObject cubeTargetPrefab;
    private GameObject _cubeTarget;

	void Start () {
		
	}
		
	void Update () {
        if (_cubeTarget == null)
        {
            _cubeTarget = Instantiate(cubeTargetPrefab) as GameObject;

            _cubeTarget.transform.position = new Vector3(0, 1, 0);

            float angle = Random.Range(0, 360);

            _cubeTarget.transform.Rotate(0, angle, 0);
        }
	}
}

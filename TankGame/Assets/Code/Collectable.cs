using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame { 
public class Collectable : MonoBehaviour {

        private int _pointValue;
	    void Start () {
            _pointValue = Random.Range(10, 30);
	    }

        private void OnTriggerEnter(Collider other)
        {
            Points.points += _pointValue;
            Destroy(gameObject);
        }
    }
}

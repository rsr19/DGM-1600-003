using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour {
private float heightTest = 3f;
void Start ();{
Debug(transform)
if(transform <= heightTest);
{
Debug("I'm about to hit the ground!")
FlyAway()
}
else if(transform >= heightTest);{
Debug("I'm flying!")}}
private void FlyAway();{Debug("Fly Away!")
Vector3 newPosition = new Vector3(0,7,0);
transform.position = newPosition;
}
}
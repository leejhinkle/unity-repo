#pragma strict
public var cameraObj : GameObject;
public var specificVector : Vector3;
public var smoothSpeed : float;

function Start () { 
//just turn camera in Inspector, for example
}

function Update () {
	if(cameraObj.transform.position.y < transform.position.y - 2){
		specificVector = Vector3(transform.position.x, transform.position.y - 2, cameraObj.transform.position.z);
		cameraObj.transform.position = Vector3.Lerp(cameraObj.transform.position, specificVector, smoothSpeed * Time.deltaTime);
	}
	else if (cameraObj.transform.position.y > transform.position.y + 2){
		specificVector = Vector3(transform.position.x, transform.position.y + 2, cameraObj.transform.position.z);
		cameraObj.transform.position = Vector3.Lerp(cameraObj.transform.position, specificVector, smoothSpeed * Time.deltaTime);
	}
	else {
		specificVector = Vector3(transform.position.x, cameraObj.transform.position.y, cameraObj.transform.position.z);
		cameraObj.transform.position = Vector3.Lerp(cameraObj.transform.position, specificVector, smoothSpeed * Time.deltaTime);
	}
}
 
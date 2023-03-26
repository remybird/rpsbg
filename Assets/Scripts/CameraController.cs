using UnityEngine;

public class CameraController : MonoBehaviour {

  public GameObject player;

  private void LateUpdate () {
    this.transform.position = new Vector3(
      player.transform.position.x, player.transform.position.y, transform.position.z);
  }
}

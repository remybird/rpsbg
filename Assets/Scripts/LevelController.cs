using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelController : MonoBehaviour {

  public Tile grass;
  public Tilemap floor;
  public Tilemap walls;

  private void Start () {
    GenerateLevel();
  }

  private void GenerateLevel () {
    floor.ClearAllTiles();
    for (var yy = -20; yy < 20; yy += 1) for (var xx = -20; xx < 20; xx += 1) {
      floor.SetTile(new Vector3Int(xx, yy, 0), grass);
    }
  }
}

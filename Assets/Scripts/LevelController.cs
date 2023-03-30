using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelController : MonoBehaviour {

  public Tile grass;
  public Tile barrier;
  public Tile[] mountainB;
  public Tile[] mountainS;
  public Tilemap floor;
  public Tilemap walls;

  private void Start () {
    GenerateLevel();
  }

  private void GenerateLevel () {
    floor.ClearAllTiles();
    for (var yy = -21; yy < 20; yy += 1) for (var xx = -21; xx < 21; xx += 1) {
      floor.SetTile(new Vector3Int(xx, yy, 0), grass);
    }
    for (var yy = -30; yy < 30; yy += 1) for (var xx = -30; xx < 30; xx += 1) {
      if (yy >= -21 && yy < 20 && xx >= -21 && xx < 21) continue;
      floor.SetTile(new Vector3Int(xx, yy, 0), barrier);
    }
    walls.ClearAllTiles();
    for (var xx = -20; xx < 20; xx += 3) {
      SetMountainB(xx, 21);
      SetMountainB(xx, -20);
    }
    for (var yy = -19; yy < 20; yy += 2) {
      SetMountainS(-22, yy);
      SetMountainS(20, yy);
    }
  }

  private void SetMountainB (int xx, int yy) {
    walls.SetTile(new Vector3Int(xx, yy, 0), mountainB[0]);
    walls.SetTile(new Vector3Int(xx + 1, yy, 0), mountainB[1]);
    walls.SetTile(new Vector3Int(xx + 2, yy, 0), mountainB[2]);
    walls.SetTile(new Vector3Int(xx, yy - 1, 0), mountainB[3]);
    walls.SetTile(new Vector3Int(xx + 1, yy - 1, 0), mountainB[4]);
    walls.SetTile(new Vector3Int(xx + 2, yy - 1, 0), mountainB[5]);
  }

  private void SetMountainS (int xx, int yy) {
    walls.SetTile(new Vector3Int(xx, yy, 0), mountainS[0]);
    walls.SetTile(new Vector3Int(xx + 1, yy, 0), mountainS[1]);
    walls.SetTile(new Vector3Int(xx, yy - 1, 0), mountainS[2]);
    walls.SetTile(new Vector3Int(xx + 1, yy - 1, 0), mountainS[3]);
  }
}

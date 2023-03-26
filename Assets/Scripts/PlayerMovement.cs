using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
// [RequireComponent(typeof(AudioSource))]
public class PlayerMovement : MonoBehaviour {
  private Rigidbody2D rb2d;
  // private AudioSource audioSrc;

  public Animator animator;

  [SerializeField]
  private float speedMultiplier;

  void Awake () {
    rb2d = GetComponent<Rigidbody2D>();
    // audioSrc = GetComponent<AudioSource>();
  }

  void FixedUpdate () {
    var horiz = Input.GetAxis("Horizontal");
    var vert = Input.GetAxis("Vertical");
    rb2d.velocity = new Vector2(horiz * speedMultiplier * 0.8f,
                                vert * speedMultiplier * 0.8f);
  }

  void Update () {
    var vx = Input.GetAxis("Horizontal");
    var vy = Input.GetAxis("Vertical");
    animator.SetFloat("VX", vx);
    animator.SetFloat("VY", vy);
    if (vx != 0 || vy != 0) animator.Play("Walk");
    else animator.Play("Idle");
    // if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
    //   if (!audioSrc.isPlaying) {
    //     audioSrc.Play();
    //   }
    // }
  }
}

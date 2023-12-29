using UnityEngine;

[RequireComponent(typeof(Ghosts))]
public abstract class GhostBehavior : MonoBehaviour
{
    public Ghosts ghost { get; private set; }
    [SerializeField] private float duration;

    private void Awake()
    {
        this.ghost = GetComponent<Ghosts>();

    }

    public void Enable()
    {
        Enable(this.duration);
    }

    public virtual void Enable(float duration)
    {
        this.enabled = true;
        CancelInvoke();
        Invoke(nameof(Disable), duration);
    }

    public virtual void Disable()
    {
        this.enabled = false;
        CancelInvoke();
    }
}

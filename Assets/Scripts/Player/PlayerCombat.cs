using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public WeaponData equippedWeapon;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (equippedWeapon == null) return;

        switch (equippedWeapon.type)
        {
            case WeaponType.Knife:
                if (Input.GetKeyDown(KeyCode.F))
                    animator.SetBool("AttackKnife", true);
                if (Input.GetKeyUp(KeyCode.F))
                    animator.SetBool("AttackKnife", false);
                break;

            case WeaponType.Gun:
                if (Input.GetKeyDown(KeyCode.G))
                    animator.SetBool("AttackGun", true);
                if (Input.GetKeyUp(KeyCode.G))
                    animator.SetBool("AttackGun", false);
                break;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShardsOfCourage.Character
{
    public class BoogieAbility
    {
        public Ability dash;
        public Ability dive;
        public Ability doubleJump;
        public Ability wallJump;
        
        public BoogieAbility()
        {
            dash = new Ability("dash");
            dive = new Ability("dive");
            doubleJump = new Ability("doubleJump");
            wallJump = new Ability("wallJump");
        }
        
        public void Reset()
        {
            dash.obtained = false;
            dive.obtained = false;
            doubleJump.obtained = false;
            wallJump.obtained = false;
        }
    }
    
    
    public class PBoogieController : MonoBehaviour
    {
        public enum BoogieStates
        {
            None,
            Preparing,
            Hidden,
            Normal,
            Dashing,
            GettingHit,
            Dead,
            HitSpike,
            Paused,
            MoveTo
        }

        public enum DamageT
        {
            Unknown,
            Obstacle,
            Enemy,
            Fall
        }

        [Serializable]
        struct InputState
        {
            public Vector2 axis;
            public bool jumpPressed;
            public bool jumpReleased;
            public bool dash;
            public bool attack;
        }

        [Serializable]
        public struct BoogieMovementStatus
        {
            public bool dead;
            public bool vulnerable;
            public bool facingRight;
            public bool canMove;
            public bool canDash;
            public bool isDashing;
            public bool canDoubleJump;
            public bool isWallJumping;
            public bool isAttacking;
            public Vector2 moveInput;
        }

        [Serializable]
        public class BoogieProperties
        {
            public int health = 3;
            public bool fishMode = false;

            public void Reset()
            {
                health = 3;
                fishMode = false;
            }
        }
        
        [Header("Boogie Properties")]
        public float movingspeed;
        public float gravity;
        public float maxVelocityDown;
        public float jumpForce;
        public float velDownMultiplier;
        public float groundMoveResponse;
        public float airMoveResponse;
        public float attackRate;
        public float attackBufferTime;
        public LayerMask attackLayer;
        public float coyoteTime;
        public float jumpBufferTime;
        public float wallJumpBuffer;
        [Header("Ability Properties")]
        public float dashForce;
        public float dashDuration;
        
    }
}


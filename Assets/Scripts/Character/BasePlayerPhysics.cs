using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShardsOfCourage.Interface;

namespace ShardsOfCourage.Character
{
    public class BasePlayerPhysics : MonoBehaviour, IPhysicsInfluence
    {

        public enum PlayerPhysicsState
        {
            IsNormal,
            IsWater
        }

        public struct Collisions
        {
            public bool isGrounded;
            public bool isGroundedPrev;
            public bool isLeftBlocked;
            public bool isRightBlocked;
            public bool isTouchLeft;
            public bool isTouchRight;
            public bool isTouchWall;
            public bool isTouchWallPrev;
            public bool isOnSlope;
            public bool isOnMaxSlope;
            public bool isInsidePlatform;
            public bool isInWater;
            public float slopeAngle;
            public float errorAngle;
            public float coyoteTime;
            public float jumpPressedTime;
            public float groundedTime;
            
            public void Reset()
            {
                //set all bools to false and all floats to 0
                isGrounded = false;
                isGroundedPrev = false;
                isLeftBlocked = false;
                isRightBlocked = false;
                isTouchLeft = false;
                isTouchRight = false;
                isTouchWall = false;
                isTouchWallPrev = false;
                isOnSlope = false;
                isOnMaxSlope = false;
                isInsidePlatform = false;
                isInWater = false;
                slopeAngle = 0;
                errorAngle = 0;
                coyoteTime = 0;
                jumpPressedTime = 0;
                groundedTime = 0;
            }
        }

        

        [Header("properties")] [SerializeField]
        private Vector2 charSize;
        [SerializeField] private Vector2 sensorSize;
        [SerializeField] private float widthOfSkin;
        [SerializeField] private int sensorCount;
        [SerializeField] private float minSensorLength;
        [SerializeField] private float lengthSeonsorSize;
        [SerializeField] private LayerMask physicsInteractionMask;
        
        [Header("slope properties")] [SerializeField]
        private float maxSlopeAngle;

        [Header("Physics info")] 
        public Collisions collisions;
        public Vector2 velocity;
        public Vector2 influenceVelocity;
        
        [SerializeField]private float gravity;
        public float gravityDownMultiplier;
        [SerializeField] private  float maxGravity;
        
        private RaycastHit2D[] verticalCastHits;
        private RaycastHit2D[] horizontalCastHits;
        private RaycastHit2D hitSide;

        private Transform body;
        private float offsetAngle;
        private float lengthCharSize;
        private Vector2 charSensorSize;
        
        private Vector2 halfCharSize => charSize * .5f;
        private Vector2 halfSensorSize => charSensorSize * .5f;
        
        private Vector2 halfCharSizeDir => halfCharSize * ExtensionMethods.DegreesToVector2(-Mathf.Abs(collisions.slopeAngle)) +
                                           halfCharSize * ExtensionMethods.DegreesToVector2(-Mathf.Abs(collisions.slopeAngle)+90);
        
        

        public void Init(Transform body)
        { 
            this.body = body;
            offsetAngle = ExtensionMethods.Vector2ToDegrees(halfCharSize);
            lengthCharSize = halfCharSize.magnitude - widthOfSkin;
            lengthSeonsorSize = halfSensorSize.magnitude - widthOfSkin;
            
            horizontalCastHits = new RaycastHit2D[sensorCount];
            verticalCastHits = new RaycastHit2D[sensorCount];
            
            collisions.isInsidePlatform = false;
            
            
        }

        public void PreUpdate()
        {
            //Pre Sensor Functionalities
            //Sersor Detection 
            //Sersor Validation 
        }

        public void OnUpdate()
        {
            //Post Sensor Functionalities
            //Coyote validation and sensor
            //Move
            //Late Sensor dectection and functions
        }

        public void Move()
        { 
            //Check the Sqeezing 
            //Find the Direction for movement 
            //Predict the fall angle and position 
        }

        bool CheckingSqeeze()
        {
            return false;
        }

        void VerticalSensor()
        { 
            //Check the collisions vertically 
        }

        void HorizontalSensor()
        {
            //Check the collisions vertically 
        }

        void EdgeSensor()
        { 
        
        }

        void GroundSensor()
        { 
        
        }
        void SlopeSensor()
        { 
        
        }
        void CoyoteSensor()
        { 
        
        }

        public void OnGravityUpdate(PlayerPhysicsState state)
        {
            switch (state)
            {
                case PlayerPhysicsState.IsNormal:
                    UpdateGravityOnNormal();
                    break;
                case PlayerPhysicsState.IsWater:
                    UpdateGravityOnWater();
                    break;
            }
        }

        private void UpdateGravityOnWater()
        {
            
        }

        private void UpdateGravityOnNormal()
        {
            
        }

        public void ForceMovePoint(Vector2 dirOfMovement)
        {
            body.position = body.position.ToVector2() + dirOfMovement;
        }

        public void GiveMomentumVelocity(Vector2 velocity)
        {
            influenceVelocity = velocity;
        }

        
    }
}



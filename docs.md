# World Defender<a id="world-defender"></a>

Egy egyszeru shoot em up jatek, ahol van egy urhajo ami a feleje jovo ellensegekre lo.


### Ellensegek tipusai<a id="ellensegek-tipusai"></a>

- Urhajo 5 pont 3 hp

- Bomba -5 pont 1 hp sebzese: - 1hp ha kilovik

- Meteor 3 pont 2 hp


### Powerup-ok<a id="powerup-ok"></a>

- Magic box

  - Gyorssabban lo 2x sebesseggel

  - Ket csikban lo ugyanolyan sebessegel

  - +1 elet


### Player<a id="player"></a>

-  Loves 

  - Space gombbal

  - 1 / 2 tick

- 10 hp

- Ha a atmegy az also hataron (a player mozgasi vektoran), akkor minden ellenseg 1 hp-t sebez


## Class high level overview<a id="class-high-level-overview"></a>

- World

- Data

- CollisionBox

- InteractableManagement

- CollisionEventHandler

- CollisionEventArgs

* Entity

  - Bullet

  - Player

  - Interactable

    - Powerup

    - Enemy

      - SpaceShip

      - Bomb

      - Meteor

**Class World**

- Params

  - Tick (egy tick = 0.1 sec KONSTANS, 0-60 kozott lehet csak)

- Methods

  - MainLoop

  - AdvanceTick

  - UpdateWorld

  - IncreaseSpawnChance

  - ResetTick

**Class Entity**

- Params

  - Id

  - PosX

  - PosY

  - AbsoluteSpeed (A sebessseg amivel megy, csak egy int)

  - SpeedVector (0,0 a bal also sarok)

  - Data (ures array, amiben key-value pair-ek)

  - IsAlive

  - Heath

  - WorldBorderUpper

  - WorldBorderLower

- Methods

  - calcSpeedVec()

  - checkCollision()

**Class Interactable**

- Params

  - SpawnChance

- Methods

  - increaseSpawnChance(Tick)

  - CheckCollision()

**Class Enemy**

- Params

  - Points

  - Health

  - DamageValue

- Methods

**Class Bullet**

- Params

  - PosX

  - PosY

  - CollisionBox()

\
\


**Class CollisionBox**

- Params

  - OffsetY

  - Size

* MinX

* MaxX

* CenterPosX

* CenterPosY

- Methods

  - UpdateCollisionBox(CenterPosX, CenterPosY)

  - Constructor(OffsetY, Size)

**Class InteractableManagement**

- Params

  - InteractableList

- Methods

  - RemoveCollidedItem()

**Class CollisionEventHandler\<CollisionEventArgs>**

- Params

  -

- Metholds

  -

**Class CollisionEventArgs : EventArgs**

- Params

  - Sender

  - PosY

  - MinX

  - MaxX

`1.4.6`

- Updated RU TL

`1.4.5`

- SMASH
	- Added config option to disable forward lunge. (Can be changed in-game with Risk of Options)

`1.4.4`

- Added Japanese translation (Thanks punch!)

`1.4.2` - `1.4.3`

- Updated BR TL.

`1.4.1`

- Fixed Gummy Clone and Ghost HAN-Ds leaving behind interactables if "Allow Player Repair" is enabled.

`1.4.0`

- Added Hopoo's HAN-D skin.
- Added Grandmastery.  

	*Thanks FORCED_REASSEMBLY!*
	
- toned down edge wear on default textures
- Learned how to do speculars
- Fixed animations breaking at high attack speed

	*Thanks Timesweeper!*

`1.3.1`

- Tweaked DRONE - SPEED icon.
- Updated the localization files.

`1.3.0`

- Added DRONE - SPEED
	- Grants +10% attack speed for 10 seconds on hit.
	- New stacks reset the buff duration.
	- Cooldown is 2x the cooldown of DRONE - HEAL
	
	*Thanks to Thingw for the icon!*
	
- Fixed a nullref with M2 squashing.

`1.2.4` to `1.2.7`

- Added Brazilian Portuguese translation (Thanks Kauzok!)

`1.2.3`

- Added Spanish translation (Thanks Juhnter!)

`1.2.2`

- Lowered HURT/FORCED_REASSEMBLY screenshake by 80%
- Added screenshake scale config option.

`1.2.1`

- Added Korean translation (Thanks CaffeinePain!)

`1.2.0`

- Assetbundle/Soundbank are no longer embedded. This will reduce RAM usage.
- Updated CN localization.

`1.1.13`

- Fixed some code related to DRONE replacements on skins. (Thanks RandomlyAwesome!)

`1.1.12`

- Updated Ukrainian translation.

`1.1.11`

- Added Ukrainian translation (Thanks Damglador!)

`1.1.10`

- Added French translation (Thanks FyreBW!)

`1.1.9`

- SWARM_ARMOR now supports DroneMeld.

`1.1.8`

- Remembered to mark KingKombatArena as a softdependency so that it will always load before HAN-D.

`1.1.7`

- Updated SMASH to check InputBank instead of CharacterMotor.

`1.1.6`

- Minor tweak to HURT's self-force code.
	- HURT doesn't apply self-force if you are standing still. Before, this was checked via the CharacterMotor's move vector. Now it uses the actual Input move vector to check this.

`1.1.5`

- Fixed Scepter M2 anim not playing online.

`1.1.4`

- Fixed Mastery skin not being unlockable when using the Force Unlock config option.

`1.1.3`

- Fixed game not booting up with the Russian translation.

`1.1.2`

- Added Russian translation (Thanks MoonsugarCrusader!)

`1.1.1`

- Renamed Mastery skin. (Credits to Commando Gaming for the suggestion!)

`1.1.0`

- Added Mastery skin. (Thanks dotflare!)
	- Also thanks to TimeSweeper for getting it working in-game, and improving the mod's skin support!

- Updated portrait icon.
	- Old icon was from an older version of the mod when the textures were different.
	
- Fixed neck becoming tiny when looking backwards.

- SMASH
	- Replaced screenshake with subtle recoil.
	- Now only lunges forward if the forward movement button is pressed.
		- On gamepad, checks if movement input is within 50 degrees of the forward direction on either side.
	- Each enemy hit reduces lunge speed by 50%.
	
	*Adding extra control to this skill's movement. You can now easily choose whether you want to lunge or stay in place.*
	
- FORCED_REASSEMBLY
	- Increased fully charged hit OVERCLOCK extension time from 1.6s -> 2s

- FOCUS
	- Added a -30% speed penalty and +50 armor bonus.
	
	*Trying to make this feel more distinct from OVERCLOCK. Now has better crowdtanking potential, but worse mobility for chasing down enemies to keep your buff active.*
	
- DRONE
	- Healing allies with DRONE will now heal a minimum of 10% of their max HP.
		- Does not apply to your self-heal.
	- Fixed Spare Drone Parts and Illegal Drone Coolant interaction not working
		- DRONES are affected by the attack speed and on-hit effects of both items.
		- DRONES do NOT get the Spare Drone Parts minigun.
	
	*This should fix DRONES not being effective at healing NPCs that use AmbientLevel scaling (ex. Beetle Guards).*

`1.0.2`

- Added Simplified Chinese translation (Thanks WockyTheWolf and JunJun_w!)
- Added Spare Drone Parts item displays.
- Head can now rotate 360 degrees.
- Fixed DRONE not proccing on-impact effects like Behemoth.

`1.0.1`

- Changed default sort position from Before Rex to After MUL-T

`1.0.0`

- Rewrote the mod.
- Added new model + anims (made by dotflare)
- Added alt Primary and alt Utility.
- Added unlock condition.
	- Can be bypassed with Force Unlock config option.
- SWARM_ARMOR now gives damage reduction instead of armor.
- Added EmoteAPI support.
- Added ItemDisplays
- Added 3 built-in emotes.

*Special thanks to Jaysian for commissioning dotflare for the new HAN-D Model/Anims!*
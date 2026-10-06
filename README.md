# Super Mario Maker 2 Calculator

**English** | [中文](README.zh.md) | [한국어](README.kr.md)

![1](https://github.com/user-attachments/assets/fd75c089-cdea-49de-874b-27bf8324537c)

> [!IMPORTANT]
> 
> Available commands: [CommandTexts](https://github.com/user-attachments/files/19239102/CommandTexts.txt)


> [!WARNING]
> 
> A few special commands cannot be combined.
>
> Ground commands cannot be used after a jump.
>
> Landing after a jump has special rules that are not finished yet, so calculate the jump and the landing separately.
>
> Combining crouching, standing, walking and running on the ground has special rules that are not finished yet.

> [!IMPORTANT]
> 
> The program uses [Ark Pixel Font / 方舟像素字体](https://github.com/TakWolf/fusion-pixel-font)

## Languages

- The interface comes in Chinese, English, Spanish and Korean; pick one in the language box. English and Korean use the official names from the game.
- Commands can be typed in English, Chinese or Korean whatever the interface language, and the command buttons show them in the interface language. Example: `RightWalk1 BackCrouch1 RightDash51 FrontCrouch1 AccRightJump16`. The old English names (`RightRun`, `FrontDuck`, `RightWallKick`...) still work. The English and Korean names are listed in the `[COMMANDS]` section of `Languages/English.ini` and `Languages/Korean.ini`.

## Grinder

Grinders are in the obstacle list. A Grinder takes 3x3 blocks, and its damage hitbox is a circle around its centre. Set its radius in `Grinder r` under `Crouch` (default 18.6 px). There is no official value; 18.6 is the largest radius that the clear of J18-0TG-33G still survives, since its crouch-jump hitbox passes 18.6 px from a Grinder's centre. The distance is measured from the Grinder's centre to the nearest edge of the character's hitbox.

## Importing a map

Type a course ID (`J18-0TG-33G`) or an mm2list URL into `Course ID` and press `Import map`.

- The course file is downloaded from TheGreatRambler's server (`tgrcode.com`), which gets courses from Nintendo, and read exactly.
- If that server does not answer within 10 seconds, the map picture from mm2list (`https://mm2list.cyzon.us/cached-view/<course ID>`, drawn by toost) is used instead. The importer compares it pixel by pixel with the game textures to find ground, blocks, pipes, Spike Traps, Piranha Plants, Munchers and Grinders.
- With the box empty, the button opens a course file from a save (`course_data_XXX.bcd`, still encrypted) or a map PNG instead.
- `Map X`/`Map Y` set the block at the bottom left of the canvas. Check `Sub Area` to import the sub area.
- The calculator's ground (`Ground W`/`Ground H`) is set from the height of the leftmost column of the canvas. Terrain is only drawn as a background; hits are checked against obstacles only.
- Terrain is drawn with SMB1, SMB3 and SMW textures only; there are none for NSMBU and 3D World. Courses in those two styles can only be imported from course files, and their terrain is drawn in the selected style.

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

Grinders are in the obstacle list. A Grinder takes 3x3 blocks, and its damage hitbox is a circle of radius 16 px around its centre. There is no official value, so this is an estimate: in a clear video of J18-0TG-33G the crouch-jump hitbox passes about 18.3 px from a Grinder's centre, so the real radius is smaller than that.

## Importing a map

Type a course ID (`J18-0TG-33G`) or an mm2list URL into `Course ID` and press `Import map`.

- mm2list (`https://mm2list.cyzon.us/cached-view/<course ID>`) has no course data, only maps drawn by toost. The importer compares those images pixel by pixel with the game textures to find ground, blocks, pipes, Spike Traps, Piranha Plants, Munchers and Grinders.
- With the box empty, the button opens a course file from a save (`course_data_XXX.bcd`, still encrypted) or a map PNG instead.
- `Map X`/`Map Y` set the block at the bottom left of the canvas. Check `Sub Area` to import the sub area.
- The calculator's ground (`Ground W`/`Ground H`) is set from the height of the leftmost column of the canvas. Terrain is only drawn as a background; hits are checked against obstacles only.
- Only SMB1, SMB3 and SMW courses can be imported; there are no textures for NSMBU and 3D World.

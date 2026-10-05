# 超级马里奥制造2计算器 Super Mario Maker 2 Calculator

[English](README.md) | **中文** | [한국어](README.kr.md)

![1](https://github.com/user-attachments/assets/fd75c089-cdea-49de-874b-27bf8324537c)

> [!IMPORTANT]
> 
> 可以使用的操作指令：[CommandTexts](https://github.com/user-attachments/files/19239102/CommandTexts.txt)


> [!WARNING]
> 
> [注意]少数几个特殊指令不能复合使用
>
> [注意]起跳后不能使用地面指令
>
> [注意]起跳后落地时会有特殊判定，此部分未完善，需要分段计算
>
> [注意]地面走位的蹲下/站立/走跑动作复合有特殊判定，未完善

> [!IMPORTANT]
> 
> 程序内使用了[方舟像素字体 / Ark Pixel Font](https://github.com/TakWolf/fusion-pixel-font)

## 语言

- 界面支持中文、English、Español 和 한국어，在语言框中选择。英文和韩文使用游戏中的官方名称。
- 无论界面是哪种语言，指令都可以用中文、英文或韩文输入，指令按钮会显示为界面语言。例：`右走1 反蹲1 右跑51 正蹲1 加速右跳16`。以前的英文指令名（`RightRun`、`FrontDuck`、`RightWallKick`……）仍然可用。英文和韩文指令名分别列在 `Languages/English.ini` 和 `Languages/Korean.ini` 的 `[COMMANDS]` 部分。

## 圆锯

障碍物列表中新增了圆锯。圆锯占 3x3 格，伤害判定是以中心为圆心的圆，半径可在 `下蹲` 下方的 `圆锯半径` 中修改（默认 18.6px）。没有官方数据：J18-0TG-33G 的通关路线中，下蹲跳的判定距离圆锯中心 18.6px，所以 18.6 是这条路线仍能通过的最大半径。距离是从圆锯中心量到角色判定框最近的边。

## 导入地图

在 `关卡ID` 中输入关卡ID（`J18-0TG-33G`）或 mm2list 网址，然后点击 `导入地图`。

- mm2list（`https://mm2list.cyzon.us/cached-view/<关卡ID>`）没有关卡数据，只有 toost 绘制的地图图片。程序把图片和游戏贴图逐像素比较，识别地面、砖块、管道以及刺、绿花、黑花和圆锯。
- 输入框留空时点击按钮，可以打开存档里的关卡文件（`course_data_XXX.bcd`，加密的原文件即可）或地图 PNG。
- `地图X`/`地图Y` 是画布左下角的格子坐标。勾选 `副区域` 可导入副区域。
- 计算器的地面（`起点X`/`起点Y`）会按画布最左边一列的高度自动设置。地形只作为背景显示，碰撞判定只对障碍物有效。
- 只支持 SMB1、SMB3 和 SMW 风格。NSMBU 和 3D World 没有贴图，无法导入。

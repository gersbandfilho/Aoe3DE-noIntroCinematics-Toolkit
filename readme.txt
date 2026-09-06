|||||||||||||||||||||||||||||||||||||||||||||||
|||                                         |||
|||     Aoe3DE-noIntroCinematics-Toolkit    |||
|||                                         |||
|||||||||||||||||||||||||||||||||||||||||||||||

|||||||||||||||||||||||||||||||||||||||||||||||
||| Simple tools to fix glitches when using |||
|||    the '+noIntroCinematics' string at   |||
|||  Age of Empires 3: Definitive Edition.  |||
|||||||||||||||||||||||||||||||||||||||||||||||

- You can skip the cinematic intros at AoE3:DE by adding the string `+noIntroCinematics` to the game's launch options in Steam.

- However, after making this change, the game might launch in a _different X/Y position_ that is misaligned with your display, even though it starts up faster.

- To fix this, simply change the resolution to something else and then switch back to your original setting; the glitch will disappear.

- To save you the trouble of opening Windows settings every time this happens, I've created a simples .bat that generates an executable to handle you in this process.

########################
## Displays supported ##
########################
##
###  Currently, only the version to 2560 x 1080 px (Ultrawide) monitors is available. 
###  I am creating versions to other monitors.
##
#
##
################
## Bonus tool ##
################
##
###  You can also find my "ForceAoe" tool at the directory; 
###  it is designed to force the termination of processes related to 
###  the "Aoe3DE.exe" executable and then relaunch it after a few seconds. 
##
###  It can be useful when you can't open the game due to a glitched process, 
###  or when you lose and—in a fit of anger—need to leave the match/game immediately.
##
#

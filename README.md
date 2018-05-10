NOTE: I removed Zen Mode and added an Interval setting in this fork.

mousejiggler
============

Mouse Jiggler is a very simple piece of software whose sole function is to "fake" mouse input to Windows, and 
jiggle the mouse pointer back and forth.

Useful for avoiding screensavers or other things triggered by idle detection that, for whatever reason, you 
can't turn off any other way; or as a quick way to stop a screensaver activating during an installation or 
when monitoring a long operation without actually having to muck about with the screensaver settings.

Operation
=========

Simply run the MouseJiggle.exe included in the release .zip file. Check the "Enable jiggle?" checkbox to start
jiggling the mouse pointer; uncheck it to stop. The jiggle is slight enough that you should be able to use the
computer normally even with jiggling enabled.

To minimize Mouse Jiggler to the system tray, click the button marked with a green, down-pointing arrow.

Command Line Switches
=====================

 * --jiggle | -j ... start jiggling on load
 * --interval [min] | -i [min] ... set minutes between jiggles
 * --minimized | -m ... start minimized
 * --screen | -s ... start with screen on enabled

Features That Will Not Be Implemented
=====================================

This is a list of feature requests which I've decided won't be implemented in Mouse Jiggler for one reason or another, along with what those reasons are, just for reference:

 * Autorun on startup (because that's what the Startup group, Task Scheduler, etc. are for; it's inelegant to duplicate system facilities in a minimal app).
 * Timed startup/shutdown (again, Task Scheduler is for this).
 * Reducing the jiggle speed to just under a minute (yes, the Windows idle detection time can only be reduced to one minute through the interface; various home-rolled idle detectors, on the other hand, do not have this limitation; besides, it makes it harder to see at a glance if jiggle is enabled)

Support
=======

Mouse Jiggler is a free product provided without warranty or support.

SafeConnect "Bypass"
====================

This repository contains two folders: one for the Windows client, one for the
linux client.  Until I can reliably hook into the network connection handler on
both OSes in the same language, these will remain as separate code bases.

Why?
----

The idea here is to not have to install a daemon just to connect to the network.
On linux, this is simple, and goes a step farther.  Since linux, by default,
requires no daemon, the linux script simply automates the login process.

Windows, on the other hand, bypasses the daemon installation with a small C#.NET
utility.  This utility will save your username and password (_in plain text_),
and log you into SafeConnect. This is done by running a web session with a linux
user agent. Additionally, there are features to check if the login is needed,
and make sure SafeConnect isn't redirecting you to a default page once logged
in.
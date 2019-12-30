Setup:
1. Implement view locking and each of the toggles or button events (step 3 below)

2. Done!

================================================================================================================================================================================================

To create a new cheat:
1. Drag the appropriate prefab (toggle or button) to the proper section in the UI (either "Cheats(Buttons)" or "Cheats(Toggles)"). Then append "-(30*n)" where n is the number of cheats of that type already in the column to "Pos Y" on the Rect Transform component.

2. (optional) You can rename the root object (which you just dragged and dropped onto the existing UI) to a relevant name

3. Expand the prefab instance and navigate to "Add Events" - add any methods you want to the button reaction. They must be attached to an object in the scene as a monobehaviour and be public.

4. On the child object labeled "(Toggle/Button)Label", change the Text object to a relevant name for the cheat.

5. You're done! Just hit F10 when you are in the game and the UI will come up :)

================================================================================================================================================================================================

Liscense:
Made by VoidVenom (Void, Captain Void, VoidVenom777, Void Venom) for User335 - feel free to copy and use for free!
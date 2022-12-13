# mznft-unity
Mozart NFT Unity SDK client code

# Setup
Clone this repo to a directory on your disk
Install Unity hub from unity.com
**BE SURE TO USE Unity 2019.4.40f1 LTS** so that you do not change any version related things in the project

Open Unity Hub and click Open Project and navigate to the base directory of the repo
The project should load



# Usage
This system was architected to be as easy as possible for drag and drop usage.
The MozartSDK folder contains a Demo scene to view an example of how things work together.
The Components folder contains a list of Mozart Widgets ready to be dragged into Unity GUI.

**Everything requires the MozartManager component added to the scene to work**, and the system is designed in such a way that no additional set up is required.

You simply drag a MozartManager onto the scene, and then drag as many additional components as you want.  They will automatically bind to one another when enabled.  

It is important that you **only create one MozartManager - it is a singleton**, and it will persist across scenes with DoNotDestroy.

# Login
**Inventory, Store, and Purchase will not work unless you are logged in**.  Drag a MozartLoginWidget and MozartManager into your scene and after you click Login you will be able to freely use these other components.

If you want to detect when Login is complete you can use code to monitor the IsLoggedIn boolean on MozartManager, or you can add a hook into the onLoginCompleteEvent delegate on MozartManager.

 ![Configure Settings](/Assets/MozartSDK/docs/img/components.png)
 ![Configure Settings](/Assets/MozartSDK/docs/img/step0_configure_mozart_settings.png)
 ![Configure Settings](/Assets/MozartSDK/docs/img/step1_add_canvas.png)
 ![Configure Settings](/Assets/MozartSDK/docs/img/step2_add_manager.png)
 ![Configure Settings](/Assets/MozartSDK/docs/img/step3_add_login_widget.png)
 ![Configure Settings](/Assets/MozartSDK/docs/img/step4_add_funds_widget.png)
 ![Configure Settings](/Assets/MozartSDK/docs/img/step5_add_locked_item_selector.png)
 ![Configure Settings](/Assets/MozartSDK/docs/img/step6_add_instant_buy_button.png)
 ![Configure Settings](/Assets/MozartSDK/docs/img/step7_configure_buy_button.png)
 ![Configure Settings](/Assets/MozartSDK/docs/img/step8_configure_buy_button.png)

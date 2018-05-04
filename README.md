# Hazard Recognition Challenge Website
The Hazard Recognition Challenge allows you to perform a virtual workplace examination. Your goal is to find as many hazards as possible at a work location.

Panorama scenes are created and viewed with the [krpano Panorama Viewer](https://krpano.com/). A paid license is required, although a free trial is available.

## To create a panorama for the Hazard Recognition Challenge

1. In your krpano tools folder (downloaded separately) drag your original pano image on to "MAKE PANO (NORMAL) droplet.bat"
2. Select cylindiral projection and 360 degrees. (Images <360 degrees are not tested but should work)
3. Copy output into a new folder in /Content/krpano/{id}
4. Edit the xml file and add this line inside the root element: `<events onclick="js(HazRecKR.Mouse_Clicked();)"></events>`
5. Change maxpixelzoom to 10 if appropriate.
6. Change `<include url="skin/defaultskin.xml" />` to `<include url="../skin/defaultskin.xml" />`
7. Define a new challenge in [HazardChallenges.cs](HazardRecognitionWebsite/Models/HazardChallenges.cs)

### To define hazard hotspots
1. Copy the same outputted files into /Content/krpano/editor
2. Edit that xml file to enable the editor plugin by adding this line inside the root element: `<plugin name="editor" url="plugins/editor.swf" keep="true" />`
3. Visit the html page to view the panorama. Append ?html5=never to the URL to make sure the Flash version is used.
4. Click the "editor" button and follow directions to define a polygon hotspot.
5. When the hotspot is complete, click back and view the xml it generated.
6. Note the coords for the hotspot in the bottom of the xml and use them to define a new hazard in HazardChallenges.cs.

## Terms of Use

NIOSH github projects follow the [CDC privacy policy](https://www.cdc.gov/Other/privacy.html) and [other policies](https://www.cdc.gov/Other/policies.html) where applicable.

## Disclaimer

This NIOSH-developed software is provided "AS IS" without warranty of any kind including express or implied warranties of merchantability or fitness for a particular purpose. By acceptance and use of this software, which is conveyed to the user without consideration by NIOSH, the user expressly waives any and all claims for damage and/or suits for personal injury or property damage resulting from any direct, indirect, incidental, special or consequential damages, or damages for loss of profits, revenue, data or property use, incurred by you or any third party, whether in an action in contract or tort, arising from your access to, or use of, this software in whole or in part.

No further development or upgrades for this software is planned. Any questions concerning this product can be directed to the NIOSH Mining Program via email at mining@cdc.gov.